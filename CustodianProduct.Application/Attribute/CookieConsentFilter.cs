/*using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

public class CookieConsentFilter : ActionFilterAttribute
{
  private readonly IDataProtector _dataProtector;
  public CookieConsentFilter(IDataProtector dataProtector)
  {
    _dataProtector = dataProtector;
  }

  public override void OnActionExecuting(ActionExecutingContext context)
  {
    var protector = _dataProtector;
    var consentCookie = context.HttpContext.Request.Cookies["consent"];

    // Cast Controller property to your specific controller type and access its ViewBag property
    var controller = context.Controller as Controller;
    var viewBag = controller?.ViewBag;

    if (string.IsNullOrEmpty(consentCookie))
    {
      // Set a value in ViewBag
      viewBag.MyValue = "Cookie consent not given";
    }
    else
    {
      var decryptedValue = protector.Unprotect(consentCookie);

      if (decryptedValue != "accepted")
      {
        // Set a value in ViewBag
        viewBag.MyValue = "Cookie consent not accepted";
      }
      else
      {
        // Set a value in ViewBag
        viewBag.MyValue = "Cookie consent accepted";
      }
    }

    base.OnActionExecuting(context);
  }
}*/