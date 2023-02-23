using CustodianPlc.FilterAttributes;
using CustodianPlc.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;

namespace CustodianPlc.Controllers
{
	[Route("Sales/[controller]/[action]")]
	public class AutoInsuranceController : Controller
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
			var carDetails = HttpContext.Session.GetString("carDetails");
			if (carDetails != null)
			{
				var carSession = JsonConvert.DeserializeObject<VehicleViewModel>(carDetails);
				return RedirectToAction("VehicleDetails", carSession);
			}
			return RedirectToAction("VehicleDetails");
		}

		public IActionResult VehicleDetails()
		{
			var personal = HttpContext.Session.GetString("personalInformation");
			if(personal is null)
			{
				return RedirectToAction("PersonalInformation");
			}
			return View();
		}


		[HttpPost]
		public IActionResult VehicleDetails(VehicleViewModel vehicleDetails)
		{
			if (!ModelState.IsValid)
			{
				return View(vehicleDetails);
			}
			return RedirectToAction("Summary");
		}

		public IActionResult Summary()
		{
			return View();
		}


		[HttpPost]
		public IActionResult Summary(VehicleViewModel vehicleDetails)
		{
			if (!ModelState.IsValid)
			{
				return View(vehicleDetails);
			}
			return View(vehicleDetails);
		}

		[HttpGet]
		public IActionResult GetCarModels(string carName)
		{
			// set the content type of the response to JSON
			Response.ContentType = "application/json";
			if (string.IsNullOrEmpty(carName))
			{
				return Json(null);
			}

			var carDictionary = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase)
			{
				["toyota"] = new List<string> { "Brevis", "Camry", "Runner" },
				["nissan"] = new List<string> { "Sunny", "200SX", "240SX" },
				["buick"] = new List<string> { "8Series", "X5 M", "X8 M" }
			};

			if (!carDictionary.TryGetValue(carName.ToLower(), out var carModels))
			{
				return Json(null);
			}

			return Json(carModels);
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}