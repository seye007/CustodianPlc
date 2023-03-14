using CustodianPlc.Models;

namespace CustodianProduct.Application.Interfaces
{
	public interface ISafetyPlusPlanService
	{
		Task<bool> CreateSafetyPlusPlanAync(SafetyPlusVm safetyPlusProduct, string id);
	}
}