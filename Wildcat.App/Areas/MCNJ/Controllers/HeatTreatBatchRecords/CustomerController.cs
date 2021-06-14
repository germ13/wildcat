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
    public class CustomerController : Controller
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

        public CustomerController(IHttpContextAccessor httpContextAccessor, SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors

        public IActionResult Index()
        {
            CustomerViewModel vm = new CustomerViewModel();
            return View(vm);
        }

        public JsonResult EditCustomerPartial(int CustId)
        {
            SelectEditCustomerResponse response = new SelectEditCustomerResponse(CustId, _context, _viewRenderService);
            return Json(response);
        }

        #region Api

        [HttpPost]
        public JsonResult AddResult(int CustId, string Name)
        {
            AddCustomerResponse response = new AddCustomerResponse(_context, _viewRenderService, CustId, Name, HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult EditResult(int CustId, string Name)
        {
            EditCustomerResponse response = new EditCustomerResponse(_context, _viewRenderService, CustId, Name, HttpContext.User.Identity.Name);
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

            CustomerDataTableData dataTableData = new CustomerDataTableData(_context, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
        }

        #endregion Api    

    }
}