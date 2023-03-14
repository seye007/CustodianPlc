using CustodianProduct.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace CustodianProduct.Infrastructure.Extensions
{
	public static class DbContextExt
	{
		public static void RegisterDbContext(this IServiceCollection services, IConfiguration config)
		{
			services.AddDbContext<AppDbContext>(options =>
			options.UseSqlServer(config["ConnectionStrings:DefaultConnection"],
			getAssembly => getAssembly.MigrationsAssembly(typeof(AppDbContext).Assembly.FullName)
			));
		}
		}
}
