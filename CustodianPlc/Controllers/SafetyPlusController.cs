using CustodianPlc.FilterAttributes;
using CustodianPlc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CustodianPlc.Controllers
{
	[Route("Sales/[controller]/[action]")]
public class SafetyPlusController : Controller
  {
		[ServiceFilter(typeof(GetPersonalInformationFilter))]
    public IActionResult PersonalInformation()
    {
      return View();
    }
		[HttpPost]
		[ValidateAntiForgeryToken]
		[ServiceFilter(typeof(PersonalInformationFilter))]
		public IActionResult PersonalInformation(PersonalInformationViewModel personal)
		{
			if (!ModelState.IsValid)
			{
				return View(personal);
			}
			var beneficiaryInformation = HttpContext.Session.GetString("beneficiaryInformation");
			if (beneficiaryInformation != null)
			{
				var beneficiarySession = JsonConvert.DeserializeObject<VehicleViewModel>(beneficiaryInformation);
				return RedirectToAction("BeneficiaryInformation", beneficiarySession);
			}
			return RedirectToAction("beneficiarySession");
		}
		public IActionResult BeneficiaryInformation()
    {
      return View();
    }
  }
}
