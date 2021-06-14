using Aspose.Cells;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Security.Principal;
using System.Threading.Tasks;
using Wildcat.App.Classes;
using Wildcat.App.Models;
using Wildcat.App.Utilities;
using Wildcat.App.ViewModels;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Logic.Administration.Users;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.Administration
{
    //TODO renamespace
    [Area("Administration")]
    public class UsersController : Controller
    {
        private readonly IOptions<AppSettings.LoupeUser> config;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private WildcatContext _wildcatContext;
        private IViewRenderService _viewRenderService;

        public UsersController(IOptions<AppSettings.LoupeUser> config, IHttpContextAccessor httpContextAccessor, WildcatContext wildcatContext, IViewRenderService viewRenderService)
        {
            this.config = config;
            this._httpContextAccessor = httpContextAccessor;
            this._wildcatContext = wildcatContext;
            _viewRenderService = viewRenderService;
        }



        #region - Pages

        public IActionResult Index()
        {
            UserSettingsViewModel vm = new UserSettingsViewModel(_httpContextAccessor, _wildcatContext);
            return View(vm);
        }

        public JsonResult EditUserPartial(string ID)
        {
            EditUserPartialResponse response = new EditUserPartialResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID);
            return Json(response);
        }

        public JsonResult EditLocationsPartial(string ID)
        {
            EditLocationsPartialResponse response = new EditLocationsPartialResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID);
            return Json(response);
        }

        public JsonResult EditGroupsPartial(string ID)
        {
            EditGroupsPartialResponse response = new EditGroupsPartialResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID);
            return Json(response);
        }

        #endregion - Pages



        #region - Api

        [HttpPost]
        public JsonResult ImportUsersResult(string SheetAddress)
        {
            ImportUsersResponse response = new ImportUsersResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, SheetAddress);
            return Json(response);
        }

        [HttpPost]
        public JsonResult AddUserResult(string ID, string DisplayName, string Domain, string Email)
        {
            AddUserResponse response = new AddUserResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID, DisplayName, Domain, Email);
            return Json(response);
        }

        [HttpPost]
        public JsonResult EditUserResult(string ID, string DisplayName, string Domain, string Email, bool Active, bool Locked)
        {
            EndUser requestor = new WildcatUser(_wildcatContext).GetUserByName(User.Identity.Name);

            EditUserResponse response = new EditUserResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID, DisplayName, Domain, Email, Active, Locked);
            return Json(response);
        }

        public JsonResult DeleteUser(string ID)
        {
            DeleteUserResponse response = new DeleteUserResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID);
            return Json(response);
        }

        [HttpGet]
        public JsonResult EditLocationResult(string ID, string Location, bool Check)
        {
            EditUserLocationsResponse response = new EditUserLocationsResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID, Location, Check);
            return Json(response);
        }

        [HttpGet]
        public JsonResult EditSecurityGroupsResult(string ID, string Group, bool Check)
        {
            EditUserSecurityGroupsResponse response = new EditUserSecurityGroupsResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID, Group, Check);
            return Json(response);
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

            UserDataTableData dataTableData = new UserDataTableData(_wildcatContext, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
        }

        #endregion - Api
    }
}