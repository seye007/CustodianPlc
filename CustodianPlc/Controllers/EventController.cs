using Microsoft.AspNetCore.Mvc;

namespace CustodianPlc.Controllers
{
	[Route("Sales/[controller]/[action]")]
  public class EventController : Controller
  {
    public IActionResult Index()
    {
      return View();
    }
  }
}
