using CustodianPlc.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CustodianPlc.Controllers
{
	public class HomeController : Controller
	{

		private readonly IDataProtectionProvider _dataProtectionProvider;
		private readonly ILogger<HomeController> _logger;

		public HomeController(ILogger<HomeController> logger, IDataProtectionProvider dataProtectionProvider)
		{
			_logger = logger;
			_dataProtectionProvider = dataProtectionProvider;
		}


		public IActionResult Index()
		{
			return View();
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[HttpPost]
		[Route("/cookies/accept")]
		public IActionResult AcceptCookies(string redirectUrl)
		{

			// Generate a unique identifier for the user
			var userId = Guid.NewGuid().ToString();

			// Create a data protector
			var protector = _dataProtectionProvider.CreateProtector("MyCookieConsent");

			// Encrypt the consent value with the user ID
			var encryptedValue = protector.Protect(userId + ":accepted");

			// Set the cookie value to the encrypted value
			HttpContext.Response.Cookies.Append($"Custodian-{redirectUrl}-Consent", encryptedValue, new CookieOptions
			{
				Expires = DateTimeOffset.UtcNow.AddYears(5),
				HttpOnly = true,
				SameSite = SameSiteMode.Strict,
				Secure = true
			});

			// Redirect user back to original page
			return RedirectToAction("Index", redirectUrl);
		}
	}

	//[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
	//public IActionResult Error()
	//{
	//return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
	//}
	//}
}