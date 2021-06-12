using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wildcat.App.Utilities;
using Wildcat.Entities.PCC.Wildcat;


namespace Wildcat.App.Views.Shared.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        private readonly string houstonServer = @"HTTP://WGFC-IIS01{0}";

        //Each location that wants to interact with the industrial
        // network would have it's own distinct base url.
        private readonly string southGateServer = @"HTTP://SHCA-IIS01{0}";

        private readonly WildcatContext db;

        public NavigationMenuViewComponent(WildcatContext context)
        {
            db = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(HttpContext context)
        {
            var menus = await GetMenus(context);
            var f = menus.ToList();

            //ModifyPathForIndustrialNetworking(ref f);

            if (menus == null) return View();
            return View(menus.Where(m => m.Active == true));
        }

        public void ModifyPathForIndustrialNetworking(ref List<SideMenu> sideMenuItems)
        {
            //No industrial shennanigens if running on developer pc
            if (Environment.MachineName.ToUpper() == "SHCA-CDJXZ12")
                return;

            foreach (SideMenu sideMenuItem in sideMenuItems)
            {
                //Make path to leave site
                if (sideMenuItem.ControllerName == "/Engineering/GasMeter" && Environment.MachineName.ToUpper() != "SHCA-IIS01")
                    sideMenuItem.Link = sideMenuItem.ControllerName = string.Format(southGateServer, sideMenuItem.ControllerName, sideMenuItem.ActionName);

                //After Gas Meter action, make paths to get back to the main site
                if (sideMenuItem.ControllerName != "/Engineering/GasMeter" && Environment.MachineName.ToUpper() == "SHCA-IIS01")
                    sideMenuItem.Link = sideMenuItem.ControllerName = string.Format(houstonServer, sideMenuItem.ControllerName, sideMenuItem.ActionName);
            }
        }

        private Task<List<SideMenu>> GetMenus(HttpContext context)
        {
            EndUser user = new WildcatUser(db).GetUserByName(User.Identity.Name);
            var location = new WildcatUser(db).GetSelectedLocation(HttpContext);

            var endUserIdParameter = new SqlParameter("AppLoginName", user.AppLoginName);
            var locationCodeParameter = new SqlParameter("LocationCode", location);
            return db.SideMenu
                .FromSqlRaw("EXECUTE GetNavigationMenu @AppLoginName, @LocationCode",
                             endUserIdParameter, locationCodeParameter)
                .ToListAsync();
        }
    }
}