using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wildcat.App.SHCA.ViewModels.Accounting;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Entities.SHCA.ShultzPro;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.SHCA.Accounting
{
    [Area("SHCA")]
    public class ChecksController : Controller
    {
        #region Private Fields

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly WildcatContext _wildcatContext;
        private readonly ShultzProContext _shultzProContext;

        private readonly IViewRenderService _viewRenderService;

        private const int LOGON32_PROVIDER_DEFAULT = 0;
        private const int LOGON32_LOGON_INTERACTIVE = 2;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public ChecksController(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, ShultzProContext shultzProContext)
        {
            this._httpContextAccessor = httpContextAccessor;
            this._wildcatContext = wildcatContext;
            _shultzProContext = shultzProContext;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Pages     

        public IActionResult Index()
        {
            ChecksIndexViewModel vm = new ChecksIndexViewModel(_httpContextAccessor, _viewRenderService, _shultzProContext, "SELECT_DATE");
            return View(vm);
        }

        #endregion Pages



        #region Api

        [HttpPost]
        public ActionResult AjaxGetJsonProductionData(int draw, int start, int length)
        {
            int TOTAL_ROWS = 0;
            DateTime from = Convert.ToDateTime(_httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "from").FirstOrDefault().Value);
            DateTime to = Convert.ToDateTime(_httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "to").FirstOrDefault().Value);
            string search = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "search[value]").FirstOrDefault().Value;
            string checktype = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "search[value]").FirstOrDefault().Value;
            int sortColumn = Convert.ToInt32(_httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][column]").FirstOrDefault().Value);
            string sortDirection = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][dir]").FirstOrDefault().Value;
            if (length == -1)
            {
                length = TOTAL_ROWS;
            }

            CheckRunsDataTableData dataTableData = new CheckRunsDataTableData(_httpContextAccessor, _viewRenderService, _shultzProContext, draw, start, length, search, sortColumn, sortDirection, from, to, checktype);

            return Json(dataTableData.set);
        }

        #endregion Api

    }
}