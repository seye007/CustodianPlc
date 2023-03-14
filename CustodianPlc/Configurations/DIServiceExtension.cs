using CustodianProduct.Application.Implementations;
using CustodianProduct.Application.Interfaces;
using CustodianProduct.Infrastructure.Repositories.Implementations;
using CustodianProduct.Infrastructure.Repositories.Interface;

namespace CustodianPlc.Configurations
{
  public static class DIServiceExtension
  {
    public static void AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
    {
      services.AddScoped<ISafetyPlusPlanService, SafetyPlusPlanService>();
      services.AddScoped<ICookieService, CookieService>();
      services.AddScoped<IEventInsuranceService, EventInsuranceService>();
      services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
      services.AddHttpContextAccessor();
    }
  }
}