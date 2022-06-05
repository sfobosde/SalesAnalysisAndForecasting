using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace WebAPIService
{
	public class Program
	{
		public static void Main(string[] args)
		{
			CreateHostBuilder(args).Build().Run();
		}

		/// <summary>
		/// UseWebRoot("Views") - use files from ~/Views. Delete to use wwwroot and index.chtml.
		/// </summary>
		/// <param name="args"></param>
		/// <returns></returns>
		public static IHostBuilder CreateHostBuilder(string[] args) =>
			Host.CreateDefaultBuilder(args)
				.ConfigureWebHostDefaults(webBuilder =>
				{
					webBuilder.UseStartup<Startup>()
					.UseWebRoot("Views");
				});
	}
}
