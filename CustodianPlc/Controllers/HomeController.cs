using Microsoft.AspNetCore.Mvc;

namespace CustodianPlc.Controllers
{
	public class HomeController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
