/*using CustodianPlc.Constants;
using CustodianPlc.Models;
using CustodianProduct.Application.Interfaces;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;

namespace CustodianPlc.Controllers
{
	public class AutoInsuranceController : Controller
	{
		private readonly ICookieService _privacyService;

		public AutoInsuranceController(ICookieService privacyService)
		{
			_privacyService = privacyService;
		}
		[Route("Sales/Auto-Insurance")]
		public IActionResult Index()
		{
			ViewBag.IsSuccessful = false;
			ViewBag.Url = UrlLinks.AutoInsurance;
			ViewBag.IsCookieConsent = _privacyService.CheckEncryptedCookie(UrlLinks.AutoInsurance);
			return View();
		}
		[HttpPost]
		[ValidateAntiForgeryToken]
		[Route("Sales/Auto-Insurance")]
		public IActionResult Index(EventInsuranceVm eventInsurance)
		{
			if (!ModelState.IsValid)
			{
				return View(eventInsurance);
			}
			return View(eventInsurance);
		}
	}
}*/