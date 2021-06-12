using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.IISIntegration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wildcat.Entities.PCC.Wildcat;

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
            services.AddControllersWithViews();
            services.AddDbContext<WildcatContext>(
                options => options.UseSqlServer(
                    Configuration.GetConnectionString("Wildcat")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
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

            app.UseEndpoints(endpoints =>
            {


                //endpoints.MapControllerRoute(
                //    name: "engineering",
                //    pattern: "SHCA/Engineering/{controller=Home}/{action=Index}/{id?}");


                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
                //endpoints.MapAreaControllerRoute(
                //    name: "CCTV",
                //    areaName: "CCTV",
                //    pattern: "~/CCTV/{controller=Home}/{action=Index}/{id?}");

                endpoints.MapAreaControllerRoute(
                    name: "engineering2",
                    areaName: "SHCA",
                    pattern: "{area}/Engineering/{controller=Workers}/{action=Index}/{id?}"
                    );


                //    //routes.MapAreaRoute(
                //    //    name: "saws",
                //    //    areaName: "Saws",
                //    //    template: "~/Saws/{controller=Saws}/{action=Index}/{id?}");


            });
        }
    }
}
