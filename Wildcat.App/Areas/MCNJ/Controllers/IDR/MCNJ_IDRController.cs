using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wildcat.App.ViewModels.MCNJ.IDR;
using Wildcat.Entities.MCNJ.IDR;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.MCNJ.IDR
{
    public class MCNJ_IDRController : Controller
    {
        #region Private Fields

        private readonly IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private IDRContext _context;

        private const int LOGON32_PROVIDER_DEFAULT = 0;

        //This parameter causes LogonUser to create a primary token.
        private const int LOGON32_LOGON_INTERACTIVE = 2;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public MCNJ_IDRController(IDRContext context, IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;
        }

        #endregion Constructors



        #region Pages

        public IActionResult Index()
        {
            IDRViewModel vm = new IDRViewModel(_httpContextAccessor, _viewRenderService, _context);
            return View(vm);
        }

        #endregion Pages



        #region Api

        [HttpPost]
        public JsonResult AddResult(int Idrnumber, string Initiator, string Operation, string Customer, string HeatCode, DateTime? Date, string DieNumber, string WorkOrderNumber, double? WorkOrderQuantity,
            double? DiscrepantQuantity, string SerialNumbers, string Required, string Actual, string DiscrepancyType1, string DiscrepancyType2, string PreDispositionStatus, string PreDispositionStatusNotes,
            double? ReworkQuantity, DateTime? MrbsubmittalDate, string MrbsubmittalNumber, double? MrbsubmittalQuantity, DateTime? MrbdispositionDate, double? FinalAcceptedQuantity, double? FinalRejectedQuantity,
            string FinalDisposition, string FinalDispositionBy, DateTime? FinalDispositionDate, string FinalDispositionSummary, string FinalDispositionSpecialHandlingInstructions, decimal? UnitCost, decimal? MaterialCost,
            decimal? LaborOverheadCost, decimal? UnitSellPrice, decimal? ReworkCost, decimal? RetestCost, decimal? ReplacementTestCost, decimal? AdditionalTestForInfo, decimal? ScrapCost, decimal? SubmittalCost, decimal? DollarsSubmitted,
            decimal? Idrcost, decimal? LostSales, decimal? TotalIdrcost)
        {
            AddResponse response = new AddResponse(_context, _viewRenderService, Idrnumber, Initiator, Operation, Customer, HeatCode, Date, DieNumber, WorkOrderNumber, WorkOrderQuantity,
            DiscrepantQuantity, SerialNumbers, Required, Actual, DiscrepancyType1, DiscrepancyType2, PreDispositionStatus, PreDispositionStatusNotes,
            ReworkQuantity, MrbsubmittalDate, MrbsubmittalNumber, MrbsubmittalQuantity, MrbdispositionDate, FinalAcceptedQuantity, FinalRejectedQuantity,
            FinalDisposition, FinalDispositionBy, FinalDispositionDate, FinalDispositionSummary, FinalDispositionSpecialHandlingInstructions, UnitCost, MaterialCost,
            LaborOverheadCost, UnitSellPrice, ReworkCost, RetestCost, ReplacementTestCost, AdditionalTestForInfo, ScrapCost, SubmittalCost, DollarsSubmitted,
            Idrcost, LostSales, TotalIdrcost);

            return Json(response);
        }

        [HttpPost]
        public JsonResult EditResult(int Idrnumber, string Initiator, string Operation, string Customer, string HeatCode, DateTime? Date, string DieNumber, string WorkOrderNumber, double? WorkOrderQuantity,
            double? DiscrepantQuantity, string SerialNumbers, string Required, string Actual, string DiscrepancyType1, string DiscrepancyType2, string PreDispositionStatus, string PreDispositionStatusNotes,
            double? ReworkQuantity, DateTime? MrbsubmittalDate, string MrbsubmittalNumber, double? MrbsubmittalQuantity, DateTime? MrbdispositionDate, double? FinalAcceptedQuantity, double? FinalRejectedQuantity,
            string FinalDisposition, string FinalDispositionBy, DateTime? FinalDispositionDate, string FinalDispositionSummary, string FinalDispositionSpecialHandlingInstructions, decimal? UnitCost, decimal? MaterialCost,
            decimal? LaborOverheadCost, decimal? UnitSellPrice, decimal? ReworkCost, decimal? RetestCost, decimal? ReplacementTestCost, decimal? AdditionalTestForInfo, decimal? ScrapCost, decimal? SubmittalCost, decimal? DollarsSubmitted,
            decimal? Idrcost, decimal? LostSales, decimal? TotalIdrcost)
        {
            EditResponse response = new EditResponse(_context, _viewRenderService, Idrnumber, Initiator, Operation, Customer, HeatCode, Date, DieNumber, WorkOrderNumber, WorkOrderQuantity,
            DiscrepantQuantity, SerialNumbers, Required, Actual, DiscrepancyType1, DiscrepancyType2, PreDispositionStatus, PreDispositionStatusNotes,
            ReworkQuantity, MrbsubmittalDate, MrbsubmittalNumber, MrbsubmittalQuantity, MrbdispositionDate, FinalAcceptedQuantity, FinalRejectedQuantity,
            FinalDisposition, FinalDispositionBy, FinalDispositionDate, FinalDispositionSummary, FinalDispositionSpecialHandlingInstructions, UnitCost, MaterialCost,
            LaborOverheadCost, UnitSellPrice, ReworkCost, RetestCost, ReplacementTestCost, AdditionalTestForInfo, ScrapCost, SubmittalCost, DollarsSubmitted,
            Idrcost, LostSales, TotalIdrcost);

            return Json(response);
        }

        public JsonResult EditRequestPartial(string ID)
        {
            SelectEditRequestResponse response = new SelectEditRequestResponse();
            EditIDRViewModel vm = new EditIDRViewModel(_httpContextAccessor, _viewRenderService, _context, ID);
            try
            {
                response.Form = _viewRenderService.RenderToStringAsync("MCNJ/IDR/MCNJ_IDR/EditRequestPartial", vm);

                response.success = true;
            }
            catch (Exception e)
            {
                response.success = false;
                response.message = "Die change record retrieval failed. " + e.Message;
            }

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

            IDRDataTableData dataTableData = new IDRDataTableData(_context, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
            //return Json("");
        }

        #endregion Api    
    }
}