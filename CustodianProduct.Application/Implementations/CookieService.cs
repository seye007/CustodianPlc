using CustodianProduct.Application.Interfaces;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Http;

namespace CustodianProduct.Application.Implementations
{
	public class CookieService : ICookieService
	{
    private readonly IHttpContextAccessor _httpContextAccessor;
    private readonly IDataProtectionProvider _dataProtectionProvider;

    public CookieService(IHttpContextAccessor httpContextAccessor, IDataProtectionProvider dataProtectionProvider)
    {
      _httpContextAccessor = httpContextAccessor;
      _dataProtectionProvider = dataProtectionProvider;
    }
    public bool CheckEncryptedCookie(string productName)
    {
      var cookieResponse = false;
      var protector = _dataProtectionProvider.CreateProtector("MyCookieConsent");
      var consentCookie = _httpContextAccessor.HttpContext.Request.Cookies[$"Custodian-{productName}-Consent"];

      if (!string.IsNullOrEmpty(consentCookie))
      {
        var decryptedValue = protector.Unprotect(consentCookie);
        var arr = decryptedValue.Split(':');
        if(arr[1] == "accepted")
        {
          cookieResponse = true;
        }
      }
      return cookieResponse;
    }

    public string GetConsentCookie(string productName)
    {
      var protector = _dataProtectionProvider.CreateProtector("MyCookieConsent");
      var consentCookie = _httpContextAccessor.HttpContext.Request.Cookies[$"Custodian-{productName}-Consent"];

      if (!string.IsNullOrEmpty(consentCookie))
      {
        return consentCookie;
      }
      return string.Empty;
    }
  }
}
