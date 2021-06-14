using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wildcat.App.Classes;
using Wildcat.App.Models;
using Wildcat.App.Utilities;
using Wildcat.App.ViewModels;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Logic.Administration.NavMenu;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.Administration
{
    //TODO renamespace
    [Area("Administration")]
    public class MenuController : Controller
    {
        #region Private Fields

        private readonly IOptions<AppSettings.LoupeUser> config;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private WildcatContext _wildcatContext;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields

        #region Constructors

        public MenuController(IOptions<AppSettings.LoupeUser> config, IHttpContextAccessor httpContextAccessor, WildcatContext wildcatContext, IViewRenderService viewRenderService)
        {
            this.config = config;
            this._httpContextAccessor = httpContextAccessor;
            this._wildcatContext = wildcatContext;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors

        #region Pages

        public IActionResult Index()
        {
            MenuSettingsViewModel vm = new MenuSettingsViewModel();
            return View(vm);
        }

        public IActionResult Add()
        {
            AddNavigationMenuViewModel vm = new AddNavigationMenuViewModel(_httpContextAccessor, _viewRenderService, _wildcatContext);
            return View(vm);
        }

        public IActionResult Edit(Guid ID)
        {
            EditNavigationMenuViewModel vm = new EditNavigationMenuViewModel(_httpContextAccessor, _viewRenderService, _wildcatContext, ID);
            return View(vm);
        }

        public JsonResult MenuLocationsPartial(Guid ID)
        {
            LocationsMenuPartialResponse vm = new LocationsMenuPartialResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID);
            return Json(vm);
        }

        public JsonResult MenuGroupsPartial(Guid ID)
        {
            GroupsMenuPartialResponse vm = new GroupsMenuPartialResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID);
            return Json(vm);
        }

        [HttpPost]
        public JsonResult MenuOrderPartial(Guid ID, string MenuID)
        {
            MenuOrderPartialResponse vm = new MenuOrderPartialResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID, MenuID);
            return Json(vm);
        }

        public IActionResult EditLocations()
        {
            EditNavigationLocationsViewModel vm = new EditNavigationLocationsViewModel();
            vm.LocationsAll = _wildcatContext.Location.ToList();
            vm.MenuItems = new List<NavMenuLocations>();

            //foreach (var item in _wildcatContext.NavigationMenu.ToList())
            //{
            //    NavMenuLocations navMenu = new NavMenuLocations
            //    {
            //        Menu = item,
            //        Locations = new List<Location>()
            //    };

            // var locs = _wildcatContext.NavigationMenuToLocation.Where(x => x.NavigationMenuId == item.Id).ToList();

            // foreach(var loc in locs) { navMenu.Locations.Add(_wildcatContext.Location.Where(x =>
            // x.LocationCode == loc.LocationCode).FirstOrDefault()); }

            //    vm.MenuItems.Add(navMenu);
            //}

            //vm.Locations = _wildcatContext.Location.ToList();
            //vm.Locations = _wildcatContext.
            return View(vm);
        }

        public IActionResult EditTeams()
        {
            EditNavigationGroupsViewModel vm = new EditNavigationGroupsViewModel();
            vm.SecurityGroupsAll = _wildcatContext.SecurityGroup.ToList();
            vm.MenuItems = new List<NavMenuTeams>();

            foreach (var item in _wildcatContext.NavigationMenu.ToList())
            {
                NavMenuTeams navMenu = new NavMenuTeams
                {
                    Menu = item,
                    SecurityGroups = new List<SecurityGroup>()
                };

                var teams = _wildcatContext.NavigationMenuToSecurityGroup.Where(x => x.NavigationMenu == item.Id).ToList();

                foreach (var team in teams)
                {
                    navMenu.SecurityGroups.Add(_wildcatContext.SecurityGroup.Where(x => x.SecurityName == team.SecurityName).FirstOrDefault());
                }

                vm.MenuItems.Add(navMenu);
            }

            //vm.Locations = _wildcatContext.Location.ToList();
            //vm.Locations = _wildcatContext.
            return View(vm);
        }

        [HttpGet]
        public IActionResult LocationsMenuTreeClick(Guid ID)
        {
            LocationsTreeClickViewModel vm = new LocationsTreeClickViewModel();
            EndUser user = new WildcatUser(_wildcatContext).GetUserByName(User.Identity.Name);
            vm.selectedLocation = new WildcatUser(_wildcatContext).GetSelectedLocation(HttpContext);

            //vm.selectedLocation = WildcatUser.GetCurrentLocation(_httpContextAccessor.HttpContext);


            vm.locations = new List<Location>(); vm.locations = _wildcatContext.Location.ToList();
            vm.navmenu = _wildcatContext.NavigationMenu.Where(x => x.Id == ID).FirstOrDefault();
            vm.menuLocations = new MenuLocations();
            vm.menuLocations.menuLocations = new List<Location>();
            var menulocations = _wildcatContext.NavigationMenuToLocation.Where(x => x.NavigationMenu == ID && x.Active == true).ToList();
            foreach (var m in menulocations)
            {
                var l = _wildcatContext.Location.Where(x => x.LocationCode == m.LocationCode).FirstOrDefault();
                vm.menuLocations.navigationMenu = _wildcatContext.NavigationMenu.Where(x => x.Id == ID).FirstOrDefault();
                vm.menuLocations.menuLocations.Add(l);
            }

            if (string.Equals(ID, "#"))
            {
                return PartialView(vm);
            }
            else
            {
                return PartialView(vm);
            }
        }

        [HttpGet]
        public IActionResult TeamMenuTreeClick(Guid ID)
        {
            TeamTreeClickViewModel vm = new TeamTreeClickViewModel();
            EndUser user = new WildcatUser(_wildcatContext).GetUserByName(User.Identity.Name);
            vm.selectedLocation = new WildcatUser(_wildcatContext).GetSelectedLocation(HttpContext);
            vm.securityGroups = new List<SecurityGroup>(); vm.securityGroups = _wildcatContext.SecurityGroup.ToList();
            vm.navmenu = _wildcatContext.NavigationMenu.Where(x => x.Id == ID).FirstOrDefault();
            vm.menuteams = new MenuTeams();
            vm.menuteams.menuSecurityGroups = new List<SecurityGroup>();
            var menuteams = _wildcatContext.NavigationMenuToSecurityGroup.Where(x => x.NavigationMenu == ID && x.Active == true).ToList();
            foreach (var m in menuteams)
            {
                var l = _wildcatContext.SecurityGroup.Where(x => x.SecurityName == m.SecurityName).FirstOrDefault();
                vm.menuteams.navigationMenu = _wildcatContext.NavigationMenu.Where(x => x.Id == ID).FirstOrDefault();
                vm.menuteams.menuSecurityGroups.Add(l);
            }

            if (string.Equals(ID, "#"))
            {
                return PartialView(vm);
            }
            else
            {
                return PartialView(vm);
            }
        }

        #endregion Pages

        #region Api

        public JsonResult AddResponse(Guid Id, Guid? ParentId, string AppName, string DisplayName, string ToolTip, string ControllerName, string ActionName, string Link, string IconCss, string CssClass, bool Active, List<string> list)
        {
            AddMenuResponse response = new AddMenuResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, Id, ParentId, AppName, DisplayName, ToolTip, ControllerName, ActionName, Link, IconCss, CssClass, Active, list);
            return new JsonResult(response);
        }

        [HttpPost]
        public JsonResult EditResponse(Guid Id, Guid? ParentId, string AppName, string DisplayName, string ToolTip, string ControllerName, string ActionName, string Link, string IconCss, string CssClass, bool Active, List<string> list)
        {
            EditMenuResponse response = new EditMenuResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, Id, ParentId, AppName, DisplayName, ToolTip, ControllerName, ActionName, Link, IconCss, CssClass, Active, list);
            return new JsonResult(response);
        }

        public JsonResult EditLocationResult(Guid ID, string Location, bool Check)
        {
            EditMenuLocationsResponse response = new EditMenuLocationsResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID, Location, Check);
            return Json(response);
        }
        public JsonResult EditSecurityGroupsResult(Guid ID, string Group, bool Check)
        {
            EditMenuSecurityGroupsResponse response = new EditMenuSecurityGroupsResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID, Group, Check);
            return Json(response);
        }

        [HttpGet]
        public JsonResult MenuTree(string ID)
        {
            EndUser user = new WildcatUser(_wildcatContext).GetUserByName(User.Identity.Name);
            var selectedLocation = new WildcatUser(_wildcatContext).GetSelectedLocation(HttpContext);
            List<TreeviewModel> items = new List<TreeviewModel>();

            if (string.Equals(ID, "#"))
            {
                return GetMenuRoots(selectedLocation);
            }
            else
            {
                return GetMenuChildren(selectedLocation, ID, true);
            }
        }

        [HttpPost]
        public ActionResult AjaxGetJsonData(int draw, int start, int length)
        {
            int TOTAL_ROWS = 0;
            string search = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "search[value]").FirstOrDefault().Value;
            int sortColumn = Convert.ToInt32(_httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][column]").FirstOrDefault().Value);
            string sortDirection = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][dir]").FirstOrDefault().Value;
            if (length == -1)
            {
                length = TOTAL_ROWS;
            }

            NavMenuDataTableData dataTableData = new NavMenuDataTableData(_wildcatContext, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
        }

        #endregion Api

        #region Private Json

        public JsonResult GetMenuRoots(string selectedLocation)
        {
            List<TreeviewModel> items = new List<TreeviewModel>();

            //var locationCodeParameter = new SqlParameter("LocationID", selectedLocation);
            //List<Ldirectory> directoryList = _context.Ldirectory.Where("dbo.GetRootBrowserByLocation @LocationID", locationCodeParameter).ToList();
            List<NavigationMenu> navList = _wildcatContext.NavigationMenu.Where(x => x.ParentId == null && x.Active == true).OrderBy(x => x.SortOrder).ToList();
            foreach (var i in navList)
            {
                var count = _wildcatContext.NavigationMenu.Where(x => x.ParentId == i.Id).Count();

                treeviewdata d = new treeviewdata();
                d.id = i.Id.ToString();
                items.Add(new TreeviewModel
                {
                    id = i.Id.ToString(),
                    parent = "#",
                    text = i.DisplayName,
                    data = d,
                    children = count > 0 ? true : false
                });
            }

            return new JsonResult(items);
        }

        public JsonResult GetMenuChildren(string selectedLocation, string ID, bool Active)
        {
            var g = Guid.Parse(ID);
            List<TreeviewModel> items = new List<TreeviewModel>();
            List<NavigationMenu> navList = _wildcatContext.NavigationMenu.Where(x => x.ParentId == g && x.Active == true).OrderBy(x => x.SortOrder).ToList();
            foreach (var i in navList)
            {
                var p = i.ParentId == null ? "#" : i.ParentId.ToString();

                var count = _wildcatContext.NavigationMenu.Where(x => x.ParentId == i.Id).Count();
                treeviewdata d = new treeviewdata();
                d.id = i.Id.ToString();
                items.Add(new TreeviewModel
                {
                    id = i.Id.ToString(),
                    parent = p,
                    text = i.DisplayName,
                    data = d,
                    children = count > 0 ? true : false
                });
            }

            return new JsonResult(items);
        }

        #endregion Private Json
    }
}