using Aspose.Cells;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Wildcat.App.Models;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Logic.Administration.Users;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels
{
    public class UserSettingsViewModel
    {
        public string UserID { get; set; }
        public string Sheetaddress { get; set; }
        public List<EndUser> Users { get; set; }
        public EndUser AddUser { get; set; }
        public EndUser EditUser { get; set; }
        public List<UserGroupAccess> GroupAccess { get; set; }
        public List<UserLocationAccess> LocationAccess { get; set; }
        public UserSettingsViewModel(IHttpContextAccessor httpContextAccessor, WildcatContext wildcatContext)
        {
            UserID = "";
            Sheetaddress = "";
            Users = new List<EndUser>();
            AddUser = new EndUser();
            EditUser = new EndUser();
            GroupAccess = new List<UserGroupAccess>();
            LocationAccess = new List<UserLocationAccess>();
        }
    }

    public class AddUserViewModel
    {
        public EndUser User { get; set; }
    }

    public class EditUserViewModel
    {
        public EndUser User { get; set; }
    }

    public class UserLocations
    {
        public EndUser User { get; set; }
        public List<Location> Locations { get; set; }
    }

    public class UserTeams
    {
        public EndUser User { get; set; }
        public List<SecurityGroup> SecurityGroups { get; set; }
    }


    #region - ViewModels
    #endregion - ViewModels



    #region - Models

    public class UserLocationAccess
    {
        public bool UserAccess { get; set; }
        public string User { get; set; }
        public string Location { get; set; }
    }

    public class UserGroupAccess
    {
        public bool UserAccess { get; set; }
        public string User { get; set; }
        public string Group { get; set; }
    }

    public class ImportUsersResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public ImportUsersResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string Sheetaddress)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                //Open your template file.
                Workbook wb = new Workbook(Sheetaddress);
                //Get the first worksheet.
                Worksheet worksheet = wb.Worksheets[0];
                //Get the cells collection.
                Cells cells = worksheet.Cells;

                //Get the AA column index. (Since "Status" is always @ AA column.
                int colA = CellsHelper.ColumnNameToIndex("A");
                int colB = CellsHelper.ColumnNameToIndex("B");
                int colC = CellsHelper.ColumnNameToIndex("C");

                //Get the last row index in AA column.
                int last_row = worksheet.Cells.GetLastDataRow(colA);

                //Loop through the "Status" column while start collecting values from row 9
                //to save each value to List
                for (int i = 0; i <= last_row; i++)
                {
                    try
                    {
                        var username = cells[i, colA].Value.ToString();

                        //depending on your environment, you may need to specify a container along with the domain
                        //ex: new PrincipalContext(ContextType.Domain, "yourdomain", "OU=abc,DC=xyz")
                        using (var context = new PrincipalContext(ContextType.Domain, username.Split('\\')[0]))
                        {
                            var user = UserPrincipal.FindByIdentity(context, username);
                            if (user != null && CheckUser(username))
                            {
                                var enduser = _wildcatContext.EndUser.Where(x => x.AppLoginName == username).FirstOrDefault();
                                if (enduser == null)
                                {
                                    enduser = new EndUser
                                    {
                                        DisplayName = username.Split('\\')[1],
                                        AppLoginName = username,
                                        Domain = username.Split('\\')[0].ToLower(),
                                        Email = user.EmailAddress,
                                        Locked = false,
                                        Active = true,
                                        Added = DateTime.Now,
                                        AddedBy = _httpContextAccessor.HttpContext.User.Identity.Name
                                    };
                                    _wildcatContext.Add(enduser);
                                }
                                else
                                {
                                    enduser.Active = true;
                                    enduser.Updated = DateTime.Now;
                                    enduser.UpdatedBy = _httpContextAccessor.HttpContext.User.Identity.Name;
                                }
                                _wildcatContext.SaveChanges();

                                enduser = _wildcatContext.EndUser.Where(x => x.AppLoginName == username).FirstOrDefault();

                                //if plant column value is not null
                                if (cells[i, colB].Value != null && user != null)
                                {
                                    var eulocation = cells[i, colB].Value.ToString();
                                    Location location = _wildcatContext.Location.Where(x => x.LocationCode == eulocation).FirstOrDefault();
                                    if (location != null)
                                    {
                                        EndUserToLocation eul = _wildcatContext.EndUserToLocation.Where(x => x.AppLoginName == enduser.AppLoginName && x.LocationCode == eulocation).FirstOrDefault();

                                        if (eul == null)
                                        {
                                            _wildcatContext.EndUserToLocation.Add(new EndUserToLocation
                                            {
                                                AppLoginName = enduser.AppLoginName,
                                                LocationCode = location.LocationCode,
                                                Active = true,
                                                Added = DateTime.Now,
                                                Updated = DateTime.Now,
                                                AddedBy = _httpContextAccessor.HttpContext.User.Identity.Name,
                                                UpdatedBy = _httpContextAccessor.HttpContext.User.Identity.Name
                                            });
                                        }
                                        else
                                        {
                                            eul.Active = true;
                                            eul.Updated = DateTime.Now;
                                            eul.UpdatedBy = _httpContextAccessor.HttpContext.User.Identity.Name;
                                        }

                                        _wildcatContext.SaveChanges();
                                    }
                                }

                                //if group value is not null
                                if (cells[i, colC].Value != null && user != null)
                                {
                                    var euteam = cells[i, colC].Value.ToString();

                                    SecurityGroup team = _wildcatContext.SecurityGroup.Where(x => x.SecurityName == euteam).FirstOrDefault();
                                    if (team != null)
                                    {
                                        EndUserToSecurityGroup eut = _wildcatContext.EndUserToSecurityGroup.Where(x => x.EndUserAppLoginName == enduser.AppLoginName
                                        && x.SecurityName == team.SecurityName).FirstOrDefault();

                                        if (eut == null)
                                        {
                                            _wildcatContext.EndUserToSecurityGroup.Add(new EndUserToSecurityGroup
                                            {
                                                EndUserAppLoginName = enduser.AppLoginName,
                                                SecurityName = team.SecurityName,
                                                Active = true,
                                                Added = DateTime.Now,
                                                Updated = DateTime.Now,
                                                AddedBy = _httpContextAccessor.HttpContext.User.Identity.Name,
                                                UpdatedBy = _httpContextAccessor.HttpContext.User.Identity.Name
                                            });
                                        }
                                        else
                                        {
                                            eut.Active = true;
                                            eut.Updated = DateTime.Now;
                                            eut.UpdatedBy = _httpContextAccessor.HttpContext.User.Identity.Name;
                                        }

                                        _wildcatContext.SaveChanges();
                                    }
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                    }
                }

                success = true;
                message = "Import successful.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message;
            }
        }
        private bool CheckUser(string user)
        {
            bool res = false;
            SecurityIdentifier sid;
            IdentityReference name;

            try
            {
                sid = new SecurityIdentifier(SecurityID.GetSid(user));
                name = sid.Translate(typeof(NTAccount));

                res = true;
            }
            catch (Exception e)
            {
                res = false;

                //log as missing or bad policy
            }

            return res;
        }
    }

    public class AddUserResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public AddUserResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string ID, string DisplayName, string Domain, string Email)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                //depending on your environment, you may need to specify a container along with the domain
                //ex: new PrincipalContext(ContextType.Domain, "yourdomain", "OU=abc,DC=xyz")
                using (var context = new PrincipalContext(ContextType.Domain, ID.Split('\\')[0]))
                {
                    var user = UserPrincipal.FindByIdentity(context, ID);
                    if (user != null && CheckUser(ID))
                    {
                        var enduser = _wildcatContext.EndUser.Where(x => x.AppLoginName == ID).FirstOrDefault();
                        if (enduser == null)
                        {
                            enduser = new EndUser
                            {
                                DisplayName = ID.Split('\\')[1],
                                AppLoginName = ID,
                                Domain = ID.Split('\\')[0],
                                Email = user.EmailAddress,
                                Locked = false,
                                Active = true,
                                Added = DateTime.Now,
                                AddedBy = _httpContextAccessor.HttpContext.User.Identity.Name
                            };
                            _wildcatContext.Add(enduser);

                            success = true;
                            message = "New user added.";
                        }
                        else
                        {
                            enduser.Active = true;
                            enduser.Updated = DateTime.Now;
                            enduser.UpdatedBy = enduser.AppLoginName;

                            success = true;
                            message = "user active.";
                        }
                        _wildcatContext.SaveChanges();
                    }
                    else
                    {
                        success = false;
                        message = "Please check username is correct and user has been added to active directory.";
                    }
                }
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message;
            }
        }

        private bool CheckUser(string user)
        {
            bool res = false;
            SecurityIdentifier sid;
            IdentityReference name;

            try
            {
                sid = new SecurityIdentifier(SecurityID.GetSid(user));
                name = sid.Translate(typeof(NTAccount));

                res = true;
            }
            catch (Exception e)
            {
                res = false;

                //log as missing or bad policy
            }

            return res;
        }
    }

    public class EditUserResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public EditUserResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string ID, string DisplayName, string Domain, string Email, bool Active, bool Locked)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                var endUser = _wildcatContext.EndUser.Where(x => x.AppLoginName == ID).FirstOrDefault();

                if (endUser == null)
                {
                    success = false;
                    message = "Could not find user. Please contact administrator.";
                }
                else
                {
                    endUser.DisplayName = DisplayName;
                    endUser.Active = Active;
                    endUser.Locked = Locked;
                    endUser.Updated = DateTime.Now;
                    endUser.UpdatedBy = _httpContextAccessor.HttpContext.User.Identity.Name;

                    success = true;
                    message = "User: " + ID + " edited.";

                    _wildcatContext.SaveChanges();
                }
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message;
            }
        }
    }

    public class DeleteUserResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public DeleteUserResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                var locations = _wildcatContext.EndUserToLocation.Where(x => x.AppLoginName == ID).ToList();
                _wildcatContext.RemoveRange(locations);

                var groups = _wildcatContext.EndUserToSecurityGroup.Where(x => x.EndUserAppLoginName == ID).ToList();
                _wildcatContext.RemoveRange(groups);

                var user = _wildcatContext.EndUser.Where(x => x.AppLoginName == ID).ToList();
                _wildcatContext.RemoveRange(user);

                success = true;
                message = ID + " removed from wildcat.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }

        }
    }

    public class EditUserPartialResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;
        public Task<string> Form { get; set; }
        public EndUser User { get; set; }
        public EditUserPartialResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                User = _wildcatContext.EndUser.Where(x => x.AppLoginName == ID).FirstOrDefault();

                Form = _viewRenderService.RenderToStringAsync("Administration/Users/EditUserPartial", User);
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

    public class EditLocationsPartialResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;
        public Task<string> Form { get; set; }
        public List<UserLocationAccess> LocationAccess { get; set; }
        public EditLocationsPartialResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                LocationAccess = new List<UserLocationAccess>();
                foreach (var loc in _wildcatContext.Location)
                {
                    LocationAccess.Add(new UserLocationAccess
                    {
                        UserAccess = false,
                        User = ID,
                        Location = loc.LocationCode
                    });
                }

                foreach (var access in _wildcatContext.EndUserToLocation.Where(x => x.AppLoginName == ID))
                {
                    var loc = LocationAccess.Where(x => x.Location == access.LocationCode).FirstOrDefault();
                    loc.UserAccess = true;
                }

                Form = _viewRenderService.RenderToStringAsync("Administration/Users/EditLocationsPartial", LocationAccess);
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

    public class EditGroupsPartialResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;
        public Task<string> Form { get; set; }
        public List<UserGroupAccess> GroupAccess { get; set; }
        public EditGroupsPartialResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                GroupAccess = new List<UserGroupAccess>();
                foreach (var group in _wildcatContext.SecurityGroup)
                {
                    GroupAccess.Add(new UserGroupAccess
                    {
                        UserAccess = false,
                        User = ID,
                        Group = group.SecurityName
                    });
                }

                foreach (var access in _wildcatContext.EndUserToSecurityGroup.Where(x => x.EndUserAppLoginName == ID))
                {
                    var loc = GroupAccess.Where(x => x.Group == access.SecurityName).FirstOrDefault();
                    loc.UserAccess = true;
                }

                Form = _viewRenderService.RenderToStringAsync("Administration/Users/EditGroupsPartial", GroupAccess);
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

    public class EditUserLocationsResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public EditUserLocationsResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string iD, string location, bool check)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                EndUserToLocation eul = _wildcatContext.EndUserToLocation.Where(x => x.AppLoginName == iD && x.LocationCode == location).FirstOrDefault();

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
                        var k = new EndUserToLocation()
                        {
                            AppLoginName = iD,
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

    public class EditUserSecurityGroupsResponse : Response
    {
        private IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private WildcatContext _wildcatContext;

        public EditUserSecurityGroupsResponse(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, string iD, string group, bool check)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;

            try
            {
                EndUserToSecurityGroup eusg = _wildcatContext.EndUserToSecurityGroup.Where(x => x.EndUserAppLoginName == iD && x.SecurityName == group).FirstOrDefault();

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
                        var k = new EndUserToSecurityGroup()
                        {
                            EndUserAppLoginName = iD,
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

    public class UserDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<EndUser> data { get; set; }

        public UserDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<EndUser>();
        }

    }

    public class UserDataTableData
    {
        public UserDataSet set;
        public UserDataTableData(WildcatContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new UserDataSet();

            UserAdministration adminClass = new UserAdministration(context, viewRenderService);

            set.draw = draw;
            set.data = adminClass.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Models
}