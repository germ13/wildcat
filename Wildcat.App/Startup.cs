using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using Wildcat.Entities.MCNJ.DCR;
using Wildcat.Entities.MCNJ.HeatsSecured;
using Wildcat.Entities.MCNJ.IDR;
using Wildcat.Entities.MCNJ.SecureHeatCards;
using Wildcat.Entities.MCNJ.SecureHeatTreatBatchBook;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Entities.SHCA.EngineeringData;
using Wildcat.Entities.SHCA.Grinders.Wildcat;
using Wildcat.Utilities;

namespace Wildcat.App
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddAuthentication(IISDefaults.AuthenticationScheme);
            services.TryAddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddControllersWithViews();

            ConfigureAreas(services);
            ConfigureDbContexts(services);

            //TODO This appears to be a really bad pattern.  Appears to hijack the entire rendering engine
            services.AddScoped<IViewRenderService, ViewRenderService>();
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            MapEndpoints(app);
        }

        private void MapEndpoints(IApplicationBuilder app)
        {
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                
                //endpoints.MapAreaControllerRoute(
                //    name: "CCTV",
                //    areaName: "CCTV",
                //    pattern: "~/CCTV/{controller=Home}/{action=Index}/{id?}");

                // :: SHCA :: //
                endpoints.MapAreaControllerRoute(
                    name: "SHCA_ENGINEERING",
                    areaName: "SHCA",
                    pattern: "{area}/Engineering/{controller=Workers}/{action=Index}/{id?}"
                );

                endpoints.MapAreaControllerRoute(
                    name: "SHCA_KEPWARE",
                    areaName: "SHCA",
                    pattern: "{area}/Kepware/{controller=Workers}/{action=Index}/{id?}"
                );

                // :: MCNJ :: //
                endpoints.MapAreaControllerRoute(
                   name: "MCNJ_DCR",
                   areaName: "MCNJ",
                   pattern: "{area}/DCR/{controller=Workers}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                   name: "MCNJ_HEATCARDS",
                   areaName: "MCNJ",
                   pattern: "{area}/HeatCards/{controller=Workers}/{action=Index}/{id?}"
                );

                //endpoints.MapControllerRoute(
                //    name: "engineering",
                //    pattern: "SHCA/Engineering/{controller=Home}/{action=Index}/{id?}");


                //    //routes.MapAreaRoute(
                //    //    name: "saws",
                //    //    areaName: "Saws",
                //    //    template: "~/Saws/{controller=Saws}/{action=Index}/{id?}");

            });
        }

        private void ConfigureAreas(IServiceCollection services)
        {
            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.AreaViewLocationFormats.Clear();
                options.AreaViewLocationFormats.Add("Areas/{2}/Views/Engineering/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("Areas/{2}/Views/Kepware/{1}/{0}.cshtml");


                options.AreaViewLocationFormats.Add("Areas/{2}/Views/DCR/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("Areas/{2}/Views/HeatCards/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("/Views/Shared/{0}.cshtml");
            });
        }

        private void ConfigureDbContexts(IServiceCollection services)
        {
            services.AddDbContext<WildcatContext>(
               options => options.UseSqlServer(
                   Configuration.GetConnectionString("Wildcat")));


            // :: SHCA :: //
            services.AddDbContext<SHCAEngineeringContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("SHCAEngineering")));
            services.AddDbContext<EngineeringDataContext>(
                options => options.UseSqlServer(
                Configuration.GetConnectionString("EngineeringData")));


            // :: MCJN :: //
            services.AddDbContext<HeatsSecuredContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("HeatsSecured")));
            services.AddDbContext<SecureHeatCardsContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("SecureHeatCards")));
            services.AddDbContext<SecureHeatTreatBatchBookContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("SecureHeatTreatBatchBook")));
            services.AddDbContext<DCRContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("DCR")));
            services.AddDbContext<IDRContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("IDR")));
        }

    }
}
