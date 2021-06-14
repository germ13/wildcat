using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System;
using System.Linq;
using Wildcat.App.Classes;
using Wildcat.App.Models;
using Wildcat.App.ViewModels;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.Administration
{
    //TODO renamespace
    [Area("Administration")]
    public class SecurityGroupController : Controller
    {
        #region Private Fields

        private readonly IOptions<AppSettings.LoupeUser> config;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private WildcatContext _wildcatContext;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Constructors

        public SecurityGroupController(IOptions<AppSettings.LoupeUser> config, IHttpContextAccessor httpContextAccessor, WildcatContext wildcatContext, IViewRenderService viewRenderService)
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
            SecurityGroupViewModel vm = new SecurityGroupViewModel();
            return View(vm);
        }

        public JsonResult EditGroupPartial(string ID)
        {
            EditGroupPartialResponse response = new EditGroupPartialResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID);
            return Json(response);
        }

        #endregion Pages

        #region Api

        public JsonResult AddGroupResult(string ID)
        {
            AddGroupResponse response = new AddGroupResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID);
            return Json(response);
        }

        public JsonResult EditGroupResult(string ID, bool Active)
        {
            EditGroupResponse response = new EditGroupResponse(_httpContextAccessor, _viewRenderService, _wildcatContext, ID, Active);
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

            SecurityGroupDataTableData dataTableData = new SecurityGroupDataTableData(_wildcatContext, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
        }

        #endregion Api
    }
}