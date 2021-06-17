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
using Wildcat.Entities.PCC.PCC03Integration;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Entities.SHCA.EngineeringData;
using Wildcat.Entities.SHCA.Grinders.FGA;
using Wildcat.Entities.SHCA.Grinders.FGD;
using Wildcat.Entities.SHCA.Grinders.FGQ;
using Wildcat.Entities.SHCA.Grinders.FGX;
using Wildcat.Entities.SHCA.Grinders.Wildcat;
using Wildcat.Entities.SHCA.ShultzPro;
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

            //TODO This appears to be a bad pattern. 
            //Appears to hijack the entire rendering engine
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
                endpoints.MapAreaControllerRoute(
                    name: "SHCA_ACCOUNTING",
                    areaName: "SHCA",
                    pattern: "{area}/Accounting/{controller=Workers}/{action=Index}/{id?}"
                );


                // :: CFCA :: //
                endpoints.MapAreaControllerRoute(
                   name: "CFCA_SAWS",
                   areaName: "CFCA",
                   pattern: "{area}/Saws/{controller=Workers}/{action=Index}/{id?}"
                );
                //endpoints.MapAreaControllerRoute(
                //   name: "CFCA_PLANNING",
                //   areaName: "CFCA",
                //   pattern: "{area}/Planning/{controller=Workers}/{action=Index}/{id?}"
                //);


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
                endpoints.MapAreaControllerRoute(
                   name: "MCNJ_HEATTREATBATCHRECORDS",
                   areaName: "MCNJ",
                   pattern: "{area}/HeatTreatBatchRecords/{controller=Workers}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                   name: "MCNJ",
                   areaName: "MCNJ",
                   pattern: "{area}/HeatTreatMaterials/{controller=Workers}/{action=Index}/{id?}"
                );
                endpoints.MapAreaControllerRoute(
                   name: "MCNJ_HEATCARDS",
                   areaName: "MCNJ",
                   pattern: "{area}/IDR/{controller=Workers}/{action=Index}/{id?}"
                );

                // :: Administration :: //
                endpoints.MapAreaControllerRoute(
                    name: "Administration",
                    areaName: "Administration",
                    pattern: "{area}/Security/{controller=Workers}/{action=Index}/{id?}"
                );

                // :: SMCA :: //
                endpoints.MapAreaControllerRoute(
                    name: "SMCA_PCC03",
                    areaName: "SMCA",
                    pattern: "{area}/PCC03/{controller=Workers}/{action=Index}/{id?}"
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

                // :: SHCA :: //
                options.AreaViewLocationFormats.Add("Areas/{2}/Views/Engineering/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("Areas/{2}/Views/Kepware/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("Areas/{2}/Views/Accounting/{1}/{0}.cshtml");

                // :: MCNJ :: //
                options.AreaViewLocationFormats.Add("Areas/{2}/Views/DCR/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("Areas/{2}/Views/HeatCards/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("Areas/{2}/Views/HeatTreatBatchRecords/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("Areas/{2}/Views/HeatTreatMaterials/{1}/{0}.cshtml");
                options.AreaViewLocationFormats.Add("Areas/{2}/Views/IDR/{1}/{0}.cshtml");
  
                // :: CFCA :: //
                options.AreaViewLocationFormats.Add("Areas/{2}/Views/Saws/{1}/{0}.cshtml");
                //options.AreaViewLocationFormats.Add("Areas/{2}/Views/Planning/{1}/{0}.cshtml");

                // :: Administration :: //
                options.AreaViewLocationFormats.Add("Areas/{2}/Views/Security/{1}/{0}.cshtml");

                // :: SMCA :: //
                options.AreaViewLocationFormats.Add("Areas/{2}/Views/PCC03/{1}/{0}.cshtml");
                //options.AreaViewLocationFormats.Add("Areas/{2}/Views/Planning/{1}/{0}.cshtml");

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
            //TODO rename with SHCA prefix
            services.AddDbContext<EngineeringDataContext>(
                options => options.UseSqlServer(
                Configuration.GetConnectionString("EngineeringData")));
            services.AddDbContext<ShultzProContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("ShultzPro")));
            services.AddDbContext<FGAContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("FGAGrinder")));
            services.AddDbContext<FGDContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("FGDGrinder")));
            services.AddDbContext<FGQContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("FGQGrinder")));
            services.AddDbContext<FGXContext>(options =>
                options.UseSqlServer(
                    Configuration.GetConnectionString("FGXGrinder")));





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

            // :: SMCA :: //
            services.AddDbContext<PCC03_IntegrationContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("PCC03Integration")));
        }

    }
}
