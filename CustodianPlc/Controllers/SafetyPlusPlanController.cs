using CustodianPlc.Constants;
using CustodianPlc.Models;
using CustodianProduct.Application.Interfaces;
using System.Net.Http;
using Microsoft.AspNetCore.Mvc;

namespace CustodianPlc.Controllers
{
  public class SafetyPlusPlanController : Controller
  {
		private readonly ICookieService _privacyService;
    private readonly ISafetyPlusPlanService _safetyPlusService;

    public SafetyPlusPlanController(ICookieService privacyService,
      ISafetyPlusPlanService safetyPlusService)
    {
			_privacyService = privacyService;
      _safetyPlusService = safetyPlusService;
		}

    [Route("Sales/Safety-Plus-Plan")]
    public IActionResult Index()
    {
      ViewBag.IsSuccessful = false;
      ViewBag.Url = UrlLinks.SafetyPlusUrl;
      ViewBag.IsCookieConsent =  _privacyService.CheckEncryptedCookie(UrlLinks.SafetyPlusUrl);
      return View();
    }

    

    [HttpPost]
    [Route("Sales/Safety-Plus-Plan")]
    public async Task<IActionResult> Index(SafetyPlusVm safetyPlusPlanVm)
    {
      ViewBag.IsCookieConsent = _privacyService.CheckEncryptedCookie(UrlLinks.SafetyPlusUrl);
      if (!ModelState.IsValid)
      {
        return View(safetyPlusPlanVm);
      }

      var key = _privacyService.GetConsentCookie(UrlLinks.SafetyPlusUrl);
      var response = await _safetyPlusService.CreateSafetyPlusPlanAync(safetyPlusPlanVm, key);
			if (response)
			{
        ViewBag.IsSuccessful = true;
        // redirect to a success page
        return View();
      }
			else
			{
        ViewBag.IsSuccessful = false;
        // return to the form page with an error message
        ModelState.AddModelError("", "An error occurred while saving your information. Please try again.");
        return View(safetyPlusPlanVm);
      }
    }

    [HttpGet]
    [Route("Sales/Safety-Plus-Plan/CalculatePremium")]
    public IActionResult CalculatePremium(int unit)
    {
      if (unit > 0 && unit <= 5)
      {
        var premium = unit * 10000;
        return Json(new { premium });
      }

      return BadRequest("Error calculating premium, make sure to input a valid unit");
    }

    public async Task<IActionResult> DownloadPdf()
    {
      var client = new HttpClient();

      // Replace "api-url" with the actual URL of the API endpoint that generates the PDF file
      var response = await client.GetAsync("api-url");

      if (response.IsSuccessStatusCode)
      {
        var content = await response.Content.ReadAsByteArrayAsync();

        // Replace "filename" with the desired file name for the downloaded PDF file
        return File(content, "application/pdf", "filename.pdf");
      }

      // Handle the case where the API call fails
      return View("Error");
    }

  }
}