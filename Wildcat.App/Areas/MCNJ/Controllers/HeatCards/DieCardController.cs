using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wildcat.App.ViewModels.MCNJ.HeatCards;
using Wildcat.Entities.MCNJ.SecureHeatCards;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.MCNJ.HeatCards
{
    [Area("MCNJ")]
    public class DieCardController : Controller
    {
        #region Private Fields

        private readonly IHttpContextAccessor _httpContextAccessor;
        private SecureHeatCardsContext _context;
        private IViewRenderService _viewRenderService;

        private const int LOGON32_PROVIDER_DEFAULT = 0;

        //This parameter causes LogonUser to create a primary token.
        private const int LOGON32_LOGON_INTERACTIVE = 2;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public DieCardController(IHttpContextAccessor httpContextAccessor, SecureHeatCardsContext context, IViewRenderService viewRenderService)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Pages   

        public IActionResult Index()
        {
            DiesViewModel vm = new DiesViewModel(_context, _viewRenderService);
            return View(vm.Dies);
        }

        public IActionResult Add()
        {
            AddDiesViewModel vm = new AddDiesViewModel(_context);
            return View(vm);
        }

        public IActionResult Edit(string id)
        {
            EditDiesViewModel vm = new EditDiesViewModel(_context, id);
            return View(vm);
        }

        public JsonResult EditHeatCardPartial(string ID)
        {
            SelectEditHeatCardsResponse response = new SelectEditHeatCardsResponse(ID, _context, _viewRenderService);
            return Json(response);
        }

        #endregion Pages



        #region Api

        [HttpPost]
        public JsonResult AddResult(string Die, string CustomerPart, int? CustId, string PartType, string Material)
        {
            AddDiesResponse response = new AddDiesResponse(_context, _viewRenderService, Die, CustomerPart, CustId, PartType, Material, null, HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult EditResult(string Die, string CustomerPart, int? CustId, string PartType, string Material)
        {
            EditDiesResponse response = new EditDiesResponse(_context, _viewRenderService, Die, CustomerPart, CustId, PartType, Material, null, HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult AddHeatResult(int Hcn, string DieNumber, DateTime? Date, string NucPrefix, string HeatCode, string HeatNumber, string ShopOrderNumber, short? QuantityOrderedCut, string Range, string Notes)
        {
            AddHeatCardResponse response = new AddHeatCardResponse(_context, _viewRenderService, Hcn, DieNumber, Date, NucPrefix, HeatCode, HeatNumber, ShopOrderNumber, QuantityOrderedCut, Range, Notes, HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult EditHeatResult(int Hcn, string DieNumber, DateTime? Date, string NucPrefix, string HeatCode, string HeatNumber, string ShopOrderNumber, short? QuantityOrderedCut, string Range, string Notes)
        {
            EditHeatCardResponse response = new EditHeatCardResponse(_context, _viewRenderService, Hcn, DieNumber, Date, NucPrefix, HeatCode, HeatNumber, ShopOrderNumber, QuantityOrderedCut, Range, Notes, HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult AutoCompleteMaterial(string prefix)
        {
            var materials = (from material in _context.RawMaterial
                             where material.MaterialField.StartsWith(prefix.ToUpper())
                             select new
                             {
                                 label = material.MaterialField,
                                 val = material.MaterialField
                             }).ToList();

            return Json(materials);
        }

        public JsonResult AutoCompleteCustomers(string prefix)
        {
            var vendors = (from vendor in _context.Customer
                           where vendor.Name.StartsWith(prefix.ToUpper())
                           select new
                           {
                               label = vendor.Name,
                               val = vendor.CustId
                           }).ToList();

            return Json(vendors);

        }

        public JsonResult AutoCompletePartType(string prefix)
        {
            var vendors = (from vendor in _context.TblPartType
                           where vendor.PartType.StartsWith(prefix.ToUpper())
                           select new
                           {
                               label = vendor.PartType,
                               val = vendor.ID
                           }).ToList();

            return Json(vendors);

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

            DiesDataTableData dataTableData = new DiesDataTableData(_context, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
        }

        #endregion Api    
    }
}