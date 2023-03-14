using CustodianPlc.Models;

namespace CustodianProduct.Application.Interfaces
{
	public interface IEventInsuranceService
	{
		Task<bool> CreateEventInsuranceAsync(EventInsuranceVm eventInsuranceVm, string cookieConsent);
	}
}