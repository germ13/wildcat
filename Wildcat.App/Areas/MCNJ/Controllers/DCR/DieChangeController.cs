using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wildcat.App.ViewModels.MCNJ.DCR;
using Wildcat.Entities.MCNJ.DCR;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.MCNJ.DCR
{
    [Area("MCNJ")]
    public class DieChangeController : Controller
    {
        #region Private Fields

        private readonly IHttpContextAccessor _httpContextAccessor;
        private IViewRenderService _viewRenderService;
        private DCRContext _context;

        private const int LOGON32_PROVIDER_DEFAULT = 0;

        //This parameter causes LogonUser to create a primary token.
        private const int LOGON32_LOGON_INTERACTIVE = 2;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public DieChangeController(DCRContext context, IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;
        }

        #endregion Constructors



        #region Pages

        public IActionResult Index()
        {
            DCRViewModel vm = new DCRViewModel(_httpContextAccessor, _viewRenderService, _context);
            return View(vm);
        }

        #endregion Pages



        #region Api

        [HttpPost]
        public JsonResult AddResult(int Dcrnumber, string ToolNumber, string Unit, string EngApproval, string EngApprovalSignature, DateTime? EngApprovalDate, string DateRequired, string HoldProductionYesOrNo, string ToolsChangedYesOrNo, string DieShopSignature, DateTime? DieShopSignatureDate, string Reason, string Description, string RequestedBy, DateTime? RequestedDate)
        {
            AddResponse response = new AddResponse(_context, _viewRenderService, Dcrnumber, ToolNumber, Unit, EngApproval, EngApprovalSignature, EngApprovalDate, DateRequired, HoldProductionYesOrNo, ToolsChangedYesOrNo, DieShopSignature, DieShopSignatureDate, Reason, Description, RequestedBy, RequestedDate);

            return Json(response);
        }

        [HttpPost]
        public JsonResult EditResult(int Dcrnumber, string ToolNumber, string Unit, string EngApproval, string EngApprovalSignature, DateTime? EngApprovalDate, string DateRequired, string HoldProductionYesOrNo, string ToolsChangedYesOrNo, string DieShopSignature, DateTime? DieShopSignatureDate, string Reason, string Description, string RequestedBy, DateTime? RequestedDate)
        {
            EditResponse response = new EditResponse(_context, _viewRenderService, Dcrnumber, ToolNumber, Unit, EngApproval, EngApprovalSignature, EngApprovalDate, DateRequired, HoldProductionYesOrNo, ToolsChangedYesOrNo, DieShopSignature, DieShopSignatureDate, Reason, Description, RequestedBy, RequestedDate);

            return Json(response);
        }

        public JsonResult EditRequestPartial(string ID)
        {
            SelectEditRequestResponse response = new SelectEditRequestResponse();
            EditDCRViewModel vm = new EditDCRViewModel(_httpContextAccessor, _viewRenderService, _context, ID);
            try
            {
                response.Form = _viewRenderService.RenderToStringAsync("MCNJ/DCR/DieChange/EditRequestPartial", vm);

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

            DCRDataTableData dataTableData = new DCRDataTableData(_context, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
            //return Json("");
        }

        #endregion Api    
    }
}