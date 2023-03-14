namespace CustodianProduct.Application.Interfaces
{
	public interface ICookieService
	{
		bool CheckEncryptedCookie(string productName);
		string GetConsentCookie(string productName);
	}
}