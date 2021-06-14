using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wildcat.App.ViewModels.MCNJ.HeatTreatBatchRecords;
using Wildcat.Entities.MCNJ.SecureHeatTreatBatchBook;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.MCNJ.HeatTreatBatchRecords
{
    [Area("MCNJ")]
    public class DieCardsController : Controller
    {

        #region Private Fields

        private readonly IHttpContextAccessor _httpContextAccessor;
        private SecureHeatTreatBatchBookContext _context;
        private IViewRenderService _viewRenderService;

        private const int LOGON32_PROVIDER_DEFAULT = 0;

        //This parameter causes LogonUser to create a primary token.
        private const int LOGON32_LOGON_INTERACTIVE = 2;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public DieCardsController(IHttpContextAccessor httpContextAccessor, SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Pages        

        public IActionResult Index()
        {
            DieCardsViewModel vm = new DieCardsViewModel();
            return View(vm.DieCards);
        }

        public IActionResult Add()
        {
            AddDieCardsViewModel vm = new AddDieCardsViewModel(_context, _viewRenderService);
            return View(vm);
        }

        public IActionResult Edit(string id)
        {
            EditDieCardsViewModel vm = new EditDieCardsViewModel(_context, _viewRenderService, id);
            return View(vm);
        }


        #endregion Pages



        #region Api

        public JsonResult EditHeatPartial(string ID)
        {
            SelectEditDieCardHeatResponse response = new SelectEditDieCardHeatResponse(_context, _viewRenderService, ID);
            return Json(response);
        }

        [HttpPost]
        public JsonResult AddDieResult(string DieNo, string SectionSize, string MatL, int? ForgingsPerTray, string Remarks, string Bhn, string Weight)
        {
            AddDieResponse response = new AddDieResponse(_context, _viewRenderService, DieNo, SectionSize, MatL, ForgingsPerTray, Remarks, Bhn, Weight, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult EditDieResult(string DieNo, string SectionSize, string MatL, int? ForgingsPerTray, string Remarks, string Bhn, string Weight)
        {
            EditDieResponse response = new EditDieResponse(_context, _viewRenderService, DieNo, SectionSize, MatL, ForgingsPerTray, Remarks, Bhn, Weight, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult AddHeatResult(int OpKey, string DieNo, string Operation, string Furnace, string Zone, int? Temperature, string PushTime, string HoldTime, string Quench)
        {
            AddDieHeatResponse response = new AddDieHeatResponse(_context, _viewRenderService, OpKey, DieNo, Operation, Furnace, Zone, Temperature, PushTime, HoldTime, Quench, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult EditHeatResult(int OpKey, string DieNo, string Operation, string Furnace, string Zone, int? Temperature, string PushTime, string HoldTime, string Quench)
        {
            EditDieHeatResponse response = new EditDieHeatResponse(_context, _viewRenderService, OpKey, DieNo, Operation, Furnace, Zone, Temperature, PushTime, HoldTime, Quench, _httpContextAccessor.HttpContext.User.Identity.Name);
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

            DataTableData dataTableData = new DataTableData(_context, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
        }

        #endregion Api    
    }
}