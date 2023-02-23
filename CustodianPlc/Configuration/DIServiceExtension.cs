using CustodianPlc.FilterAttributes;

namespace CustodianPlc.Configuration
{
	public static class DIServiceExtension
	{
		public static void AddDependencyInjection(this IServiceCollection services, IConfiguration config)
		{
			services.AddControllersWithViews();
			services.AddHttpContextAccessor();
			services.AddScoped<PersonalInformationFilter>();
			services.AddScoped<GetPersonalInformationFilter>();
			services.AddSession();
		}
	}
}
