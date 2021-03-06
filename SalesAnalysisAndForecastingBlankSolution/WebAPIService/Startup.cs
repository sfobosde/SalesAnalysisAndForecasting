using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using LinqToDB.AspNet;
using LinqToDB.Configuration;
using DataBaseLayerLib;
using LinqToDB.AspNet.Logging;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using JWTAuthorizationLib;

namespace WebAPIService
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		/// <summary>
		/// This method gets called by the runtime. Use this method to add services to the container.
		/// </summary>
		
		public void ConfigureServices(IServiceCollection services)
		{
			/// Configure Authorization.
			services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
				.AddJwtBearer(options =>
				{
					options.RequireHttpsMetadata = false;
					options.TokenValidationParameters = new TokenValidationParameters
					{
						ValidateIssuer = true,
						ValidIssuer = AuthOptions.ISSUER,

						ValidateAudience = true,
						ValidAudience = AuthOptions.AUDIENCE,

						ValidateLifetime = true,

						IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
						ValidateIssuerSigningKey = true,
					};
				});

			services.AddControllersWithViews();

			services.AddLinqToDBContext<DBContext>((provider, options) => {
				options
				.UseSqlServer(Configuration.GetConnectionString("Default"))
				.UseDefaultLogging(provider);
			});
		}

		/// <summary>
		/// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		/// </summary>
		
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				app.UseExceptionHandler("/Home/Error");
				app.UseHsts();
			}

			/// To change default file names.
			//DefaultFilesOptions defaultFilesOptions = new DefaultFilesOptions();
			//defaultFilesOptions.DefaultFileNames.Clear();
			//defaultFilesOptions.DefaultFileNames.Add("Filename.html");
			//app.UseDefaultFiles(defaultFilesOptions);

			/// To Use default files as index.html.
			app.UseDefaultFiles();

			app.UseHttpsRedirection();

			app.UseStaticFiles();

			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.UseEndpoints(endpoints =>
			{
				//endpoints.MapControllerRoute(
				//	name: "default",
				//	pattern: "{controller=Home}/{action=Index}/{id?}");
				endpoints.MapDefaultControllerRoute();
			});

			using (var scope = app.ApplicationServices.CreateScope())
			{
				var dbContext = scope.ServiceProvider.GetService<DBContext>();
			}
		}
	}
}
