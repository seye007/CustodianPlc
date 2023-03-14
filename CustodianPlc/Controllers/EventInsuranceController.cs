using CustodianPlc.Constants;
using CustodianPlc.Models;
using CustodianProduct.Application.Interfaces;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
namespace CustodianPlc.Controllers
{
	public class EventInsuranceController : Controller
	{
		private readonly ICookieService _cookieService;
		private readonly IEventInsuranceService _eventInsuranceService;
		public EventInsuranceController(ICookieService cookieService, IEventInsuranceService eventInsuranceService)
		{
			_cookieService = cookieService;
			_eventInsuranceService = eventInsuranceService;
		}


		[Route("Sales/Event-Insurance")]
		public IActionResult Index()
		{
			ViewBag.IsSuccessful = false;
			ViewBag.Url = UrlLinks.EventInsurance;
			ViewBag.IsCookieConsent = _cookieService.CheckEncryptedCookie(UrlLinks.EventInsurance);
			return View();
		}



		[HttpPost]
		[Route("Sales/Event-Insurance")]
		[ValidateAntiForgeryToken]
		public async Task<IActionResult> Index(EventInsuranceVm eventInsurance)
		{

			ViewBag.IsCookieConsent = _cookieService.CheckEncryptedCookie(UrlLinks.EventInsurance);
			if (!ModelState.IsValid)
			{
				return View(eventInsurance);
			}

			var key = _cookieService.GetConsentCookie(UrlLinks.SafetyPlusUrl);
			var response = await _eventInsuranceService.CreateEventInsuranceAsync(eventInsurance, key);
			if (response)
			{
				ViewBag.IsSuccessful = true;
				return View();
			}
			else
			{
				ViewBag.IsSuccessful = false;
				// return to the form page with an error message
				ModelState.AddModelError("", "An error occurred while saving your information. Please try again.");
				return View(eventInsurance);
			}

		}
	}
}