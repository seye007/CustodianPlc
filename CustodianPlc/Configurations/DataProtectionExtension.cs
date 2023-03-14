using Microsoft.AspNetCore.DataProtection;

namespace CustodianPlc.Configurations
{
	public static class DataProtectionExtension
	{
		public static void AddDataProtection(this IServiceCollection services, IConfiguration configuration)
		{
			var dir = Directory.GetCurrentDirectory();
			string keysFolder = configuration.GetValue<string>("DataProtection:KeysFolder");
			string appName = configuration.GetValue<string>("DataProtection:ApplicationName");
			string absoluteKeysFolder = dir + keysFolder;

			if (!Directory.Exists(absoluteKeysFolder))
			{
				Directory.CreateDirectory(absoluteKeysFolder);
			}
			var see = Path.GetFullPath(absoluteKeysFolder);
			services.AddDataProtection()
			.PersistKeysToFileSystem(new DirectoryInfo(absoluteKeysFolder))
			.SetApplicationName(appName);
		}
	}
}
