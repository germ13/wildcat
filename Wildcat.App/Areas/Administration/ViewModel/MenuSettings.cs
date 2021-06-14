using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wildcat.App.Models;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Logic.Administration.NavMenu;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels
{
    #region - ViewModels

    public class MenuSettingsViewModel
    {
        public List<NavigationMenu> MenuItems { get; set; }
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;
        public List<MenuGroupAccess> GroupAccess { get; set; }
        public List<MenuLocationAccess> LocationAccess { get; set; }

        public MenuSettingsViewModel()
        {
            MenuItems = new List<NavigationMenu>();
            GroupAccess = new List<MenuGroupAccess>();
            LocationAccess = new List<MenuLocationAccess>();
        }
    }

    public class AddNavigationMenuViewModel
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public NavigationMenu MenuItem { get; set; }
        public string NodeDisplay { get; set; }
        public bool AddToRoot { get; set; }
        public string ListOrder { get; set; }
        public List<NavigationMenu> MenuOrderItems { get; set; }
        public List<Location> Locations { get; set; }
        public List<SecurityGroup> SecurityGroups { get; set; }

        public AddNavigationMenuViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            MenuItem = new NavigationMenu(); 
            MenuItem.Id = Guid.Parse("00000000-0000-0000-0000-000000000000");
            MenuItem.Parent = null;
            MenuItem.DisplayName = "New Menu Item";

            AddToRoot = true;
            NodeDisplay = "Added to root node.";

            MenuOrderItems = new List<NavigationMenu>();
            MenuOrderItems = _wildcatContext.NavigationMenu.Where(x => x.ParentId == null).OrderBy(x => x.SortOrder).ToList();
            MenuOrderItems.Add(MenuItem);
        }
    }

    public class EditNavigationMenuViewModel
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public NavigationMenu MenuItem { get; set; }
        public string NodeDisplay { get; set; }
        public bool AddToRoot { get; set; }
        public string ListOrder { get; set; }
        public List<NavigationMenu> MenuOrderItems { get; set; }
        public List<Location> Locations { get; set; }
        public List<SecurityGroup> SecurityGroups { get; set; }

        public EditNavigationMenuViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, Guid ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            MenuItem = _wildcatContext.NavigationMenu.Where(x => x.Id == ID).FirstOrDefault();
            AddToRoot = MenuItem.ParentId == null ? true : false;

            if (MenuItem.ParentId == null)
            {
                NodeDisplay = "Added to root node.";
            }
            else
            {
                NodeDisplay = "Parent node: " + _wildcatContext.NavigationMenu.Where(x => x.Id == MenuItem.ParentId).FirstOrDefault().DisplayName;
            }

            MenuOrderItems = new List<NavigationMenu>();
            MenuOrderItems = _wildcatContext.NavigationMenu.Where(x => x.ParentId == MenuItem.ParentId).OrderBy(x => x.SortOrder).ToList();
        }
    }

    public class MenuOrderViewModel
    {
        public string ListOrder { get; set; }
        public List<NavigationMenu> MenuOrderItems { get; set; }

    }

    #endregion - ViewModels



    #region - Models

    public class MenuGroupAccess
    {
        public bool MenuAccess { get; set; }
        public Guid Menu { get; set; }
        public string Group { get; set; }
    }
    public class MenuLocationAccess
    {
        public bool MenuAccess { get; set; }
        public Guid Menu { get; set; }
        public string Location { get; set; }
    }

    #endregion - Models



    #region - Api

    public class LocationsMenuPartialResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;
        public Task<string> Form { get; set; }
        public List<MenuLocationAccess> LocationAccess { get; set; }
        public LocationsMenuPartialResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, Guid ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;


            try
            {
                LocationAccess = new List<MenuLocationAccess>();
                foreach (var location in _wildcatContext.Location)
                {
                    LocationAccess.Add(new MenuLocationAccess
                    {
                        MenuAccess = false,
                        Menu = ID,
                        Location = location.LocationCode
                    });
                }

                foreach (var access in _wildcatContext.NavigationMenuToLocation.Where(x => x.NavigationMenu == ID))
                {
                    var loc = LocationAccess.Where(x => x.Location == access.LocationCode).FirstOrDefault();
                    loc.MenuAccess = true;
                }

                Form = _viewRenderService.RenderToStringAsync("Administration/Menu/EditLocationsPartial", LocationAccess);
                success = true;
                message = "";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class GroupsMenuPartialResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;
        public Task<string> Form { get; set; }
        public List<MenuGroupAccess> GroupAccess { get; set; }
        public GroupsMenuPartialResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, Guid ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                GroupAccess = new List<MenuGroupAccess>();
                foreach (var group in _wildcatContext.SecurityGroup)
                {
                    GroupAccess.Add(new MenuGroupAccess
                    {
                        MenuAccess = false,
                        Menu = ID,
                        Group = group.SecurityName
                    });
                }

                foreach (var access in _wildcatContext.NavigationMenuToSecurityGroup.Where(x => x.NavigationMenu == ID))
                {
                    var groupaccess = GroupAccess.Where(x => x.Group == access.SecurityName).FirstOrDefault();
                    groupaccess.MenuAccess = true;
                }

                Form = _viewRenderService.RenderToStringAsync("Administration/Menu/EditGroupsPartial", GroupAccess);
                success = true;
                message = "";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class MenuOrderPartialResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;
        public Task<string> Form { get; set; }
        public List<MenuGroupAccess> GroupAccess { get; set; }
        public MenuOrderPartialResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, Guid ID, string MenuID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {

                MenuOrderViewModel vm = new MenuOrderViewModel();
                vm.ListOrder = "";
                vm.MenuOrderItems = _wildcatContext.NavigationMenu.Where(x => x.ParentId == ID).OrderBy(x => x.SortOrder).ToList();
                if(MenuID != "00000000-0000-0000-0000-000000000000")
                {
                    var g = Guid.Parse(MenuID);
                    vm.MenuOrderItems.Add(_wildcatContext.NavigationMenu.Where(x => x.Id == g).FirstOrDefault());
                }
                else
                {
                    vm.MenuOrderItems.Add(new NavigationMenu { Id = Guid.Parse("00000000-0000-0000-0000-000000000000"), ParentId = ID, DisplayName = "New Menu Item" });
                }

                Form = _viewRenderService.RenderToStringAsync("Administration/Menu/EditOrderPartial", vm);
                success = true;
                message = "";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    #endregion - Api

    public class EditNavigationLocationsViewModel
    {
        public List<NavMenuLocations> MenuItems { get; set; }
        public List<Location> LocationsAll { get; set; }
    }

    public class NavMenuLocations
    {
        public NavigationMenu Menu { get; set; }
        public List<Location> Locations { get; set; }
    }

    public class EditNavigationGroupsViewModel
    {
        public List<NavMenuTeams> MenuItems { get; set; }
        public List<SecurityGroup> SecurityGroupsAll { get; set; }
    }

    public class NavMenuTeams
    {
        public NavigationMenu Menu { get; set; }
        public List<SecurityGroup> SecurityGroups { get; set; }
    }

    public class AddMenuResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public AddMenuResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, Guid Id, Guid? ParentId, string AppName, string DisplayName, string ToolTip, string ControllerName, string ActionName, string Link, string IconCss, string CssClass, bool Active, List<string> list)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                var menuItem = _wildcatContext.NavigationMenu.Where(x => x.Id == Id && x.ActionName == ActionName && x.ControllerName == ControllerName).FirstOrDefault();
                if (menuItem == null)
                {
                    var nm = new NavigationMenu { Id = Id, ParentId = ParentId, AppName = AppName, DisplayName = DisplayName, ToolTip = ToolTip, ControllerName = ControllerName, ActionName = ActionName, Link = Link, IconCss = IconCss, CssClass = CssClass, Active = Active, Added = DateTime.UtcNow, AddedBy = _httpContextAccessor.HttpContext.User.Identity.Name };

                    _wildcatContext.Add(nm);
                    _wildcatContext.SaveChanges();

                    int order = 1;
                    foreach (var i in list)
                    {
                        var id = i;
                        if (id == "00000000-0000-0000-0000-000000000000")
                        {
                            id = nm.Id.ToString();
                        }

                        var mi = _wildcatContext.NavigationMenu.Where(x => x.Id == Guid.Parse(id)).FirstOrDefault();
                        mi.SortOrder = order;
                        mi.Updated = DateTime.Now;
                        mi.UpdatedBy = _httpContextAccessor.HttpContext.User.Identity.Name;
                        _wildcatContext.SaveChanges();

                        order++;
                    }


                    success = true;
                    message = "Menu Item Added";
                }
                else
                {
                    success = false;
                    message = "Menu Item Already Exists";
                }
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }

    }

    public class EditMenuResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public EditMenuResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, Guid Id, Guid? ParentId, string AppName, string DisplayName, string ToolTip, string ControllerName, string ActionName, string Link, string IconCss, string CssClass, bool Active, List<string> list)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                //EndUser user = new WildcatUser(_wildcatContext).GetUserByName(User.Identity.Name);
                var menuItem = _wildcatContext.NavigationMenu.Where(x => x.Id == Id).FirstOrDefault();
                if (menuItem == null)
                {
                    success = false;
                    message = "Menu Item Does not exist";
                }
                else
                {
                    //if (ParentId == null)
                    //{
                    //    menuItem.ParentId = null;
                    //}
                    //else
                    //{

                    //}
                    menuItem.ParentId = ParentId;
                    menuItem.ActionName = ActionName;
                    menuItem.Active = Active;
                    menuItem.AppName = AppName;
                    menuItem.ControllerName = ControllerName;
                    menuItem.Link = Link;
                    menuItem.CssClass = CssClass;
                    menuItem.DisplayName = DisplayName;
                    menuItem.IconCss = IconCss;
                    //menuItem.SortOrder = SortOrder;
                    menuItem.ToolTip = ToolTip;
                    menuItem.Updated = DateTime.Now;
                    menuItem.UpdatedBy = _httpContextAccessor.HttpContext.User.Identity.Name;

                    _wildcatContext.SaveChanges();

                    int order = 1;
                    foreach (var i in list)
                    {
                        var mi = _wildcatContext.NavigationMenu.Where(x => x.Id == Guid.Parse(i)).FirstOrDefault();
                        mi.SortOrder = order;
                        mi.Updated = DateTime.Now;
                        mi.UpdatedBy = _httpContextAccessor.HttpContext.User.Identity.Name;
                        _wildcatContext.SaveChanges();

                        order++;
                    }


                    success = true;
                    message = "Menu Item Changed";
                }
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message;
            }
        }
    }

    public class EditMenuLocationsResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public EditMenuLocationsResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, Guid iD, string location, bool check)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                NavigationMenuToLocation eul = _wildcatContext.NavigationMenuToLocation.Where(x => x.NavigationMenu == iD && x.LocationCode == location).FirstOrDefault();

                if (check == false)
                {
                    if (eul != null)
                    {
                        wildcatContext.Remove(eul);
                        _wildcatContext.SaveChanges();
                        message = iD + " removed from " + location;
                    }
                }
                else
                {
                    if (eul != null)
                    {
                        eul.Active = true;
                    }
                    else
                    {
                        var k = new NavigationMenuToLocation()
                        {
                            NavigationMenu = iD,
                            LocationCode = location,
                            Active = true,
                            Added = DateTime.Now,
                            Updated = DateTime.Now,
                            AddedBy = _httpContextAccessor.HttpContext.User.Identity.Name,
                            UpdatedBy = _httpContextAccessor.HttpContext.User.Identity.Name
                        };

                        _wildcatContext.Add(k);
                    }

                    _wildcatContext.SaveChanges();
                    message = iD + " added to " + location;
                }

                success = true;
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditMenuSecurityGroupsResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public EditMenuSecurityGroupsResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, Guid iD, string group, bool check)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                NavigationMenuToSecurityGroup eusg = _wildcatContext.NavigationMenuToSecurityGroup.Where(x => x.NavigationMenu == iD && x.SecurityName == group).FirstOrDefault();

                if (check == false)
                {
                    if (eusg != null)
                    {
                        wildcatContext.Remove(eusg);
                        _wildcatContext.SaveChanges();
                        message = iD + " removed from " + group;
                    }
                }
                else
                {
                    if (eusg != null)
                    {
                        eusg.Active = true;
                    }
                    else
                    {
                        var k = new NavigationMenuToSecurityGroup()
                        {
                            NavigationMenu = iD,
                            SecurityName = group,
                            Active = true,
                            Added = DateTime.Now,
                            Updated = DateTime.Now,
                            AddedBy = _httpContextAccessor.HttpContext.User.Identity.Name,
                            UpdatedBy = _httpContextAccessor.HttpContext.User.Identity.Name
                        };

                        _wildcatContext.Add(k);
                    }

                    _wildcatContext.SaveChanges();
                    message = iD + " added to " + group;
                }

                success = true;
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }

        }
    }

    public class NavMenuDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<NavigationMenu> data { get; set; }

        public NavMenuDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<NavigationMenu>();
        }

    }

    public class NavMenuDataTableData
    {
        public NavMenuDataSet set;
        public NavMenuDataTableData(WildcatContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new NavMenuDataSet();

            NavMenuAdministration adminClass = new NavMenuAdministration(context, viewRenderService);

            set.draw = draw;
            set.data = adminClass.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

}