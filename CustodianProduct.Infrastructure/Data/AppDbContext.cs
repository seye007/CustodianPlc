using CustodianProduct.Domain;
using Microsoft.EntityFrameworkCore;

namespace CustodianProduct.Infrastructure.Data
{
	public class AppDbContext : DbContext
	{
		public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
		{

		}

		public DbSet<SafetyPlusPlan> SafetyPlusPlans { get; set; }
		public DbSet<EventInsurance> EventInsurance { get; set; }
	}
}
