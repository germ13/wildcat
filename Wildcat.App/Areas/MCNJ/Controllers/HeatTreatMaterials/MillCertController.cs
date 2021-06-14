using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wildcat.App.ViewModels.MCNJ.HeatTreatMaterials;
using Wildcat.Entities.MCNJ.HeatsSecured;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.MCNJ.HeatTreatMaterials
{
    [Area("MCNJ")]
    public class MillCertController : Controller
    {
        #region Private Fields

        private readonly IHttpContextAccessor _httpContextAccessor;
        private HeatsSecuredContext _context;
        private IViewRenderService _viewRenderService;

        private const int LOGON32_PROVIDER_DEFAULT = 0;

        //This parameter causes LogonUser to create a primary token.
        private const int LOGON32_LOGON_INTERACTIVE = 2;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public MillCertController(IHttpContextAccessor httpContextAccessor, HeatsSecuredContext context, IViewRenderService viewRenderService)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Pages   

        public IActionResult Index()
        {
            MillCertModel vm = new MillCertModel();
            return View(vm.MillCerts);
        }

        public IActionResult Add()
        {
            AddMillCertViewModel vm = new AddMillCertViewModel(_context);
            return View(vm);
        }

        public IActionResult Edit(int id)
        {
            EditMillCertViewModel vm = new EditMillCertViewModel(_context, id);
            return View(vm);
        }

        #endregion Pages



        #region Api

        public JsonResult EditHeatPartial(string ID)
        {
            SelectEditMillCertHeatResponse response = new SelectEditMillCertHeatResponse(_context, _viewRenderService, ID);
            return Json(response);
        }

        [HttpPost]
        public JsonResult AddResult(int Crn, DateTime? DateIn, int? MillId, string MillCn, string Heat, string HtDesc, string Material, string Spec, string Pwcode, string BetaTransus)
        {
            AddMillCertResponse response = new AddMillCertResponse(_context, _viewRenderService, Crn, DateIn, MillId, MillCn, Heat, HtDesc, Material, Spec, Pwcode, BetaTransus, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult EditResult(int Crn, DateTime? DateIn, int? MillId, string MillCn, string Heat, string HtDesc, string Material, string Spec, string Pwcode, string BetaTransus)
        {
            EditMillCertResponse response = new EditMillCertResponse(_context, _viewRenderService, Crn, DateIn, MillId, MillCn, Heat, HtDesc, Material, Spec, Pwcode, BetaTransus, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult AddOpResult(int? Crn, int Hrn, DateTime? Date, string Size, string McWPo, short? Vendor, int? TotWt, short? Billets, string BilletId, bool Bsr, bool CutBillets, string Remarks)
        {
            AddMillCertOpResponse response = new AddMillCertOpResponse(_context, _viewRenderService, Crn, Hrn, Date, Size, McWPo, Vendor, TotWt, Billets, BilletId, Bsr, CutBillets, Remarks, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult EditOpResult(int? Crn, int Hrn, DateTime? Date, string Size, string McWPo, short? Vendor, int? TotWt, short? Billets, string BilletId, bool Bsr, bool CutBillets, string Remarks)
        {
            EditMillCertOpResponse response = new EditMillCertOpResponse(_context, _viewRenderService, Crn, Hrn, Date, Size, McWPo, Vendor, TotWt, Billets, BilletId, Bsr, CutBillets, Remarks, _httpContextAccessor.HttpContext.User.Identity.Name);
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

        public JsonResult AutoCompleteVendors(string prefix)
        {
            var vendors = (from vendor in _context.Vendors
                             where vendor.Name.StartsWith(prefix.ToUpper())
                             select new
                             {
                                 label = vendor.Name,
                                 val = vendor.MillId
                             }).ToList();

            return Json(vendors);

        }

        //todo: compolete this function
        public JsonResult AutoCompleteHeats(string prefix)
        {
            var vendors = (from cert in _context.CertsMill
                           where cert.Heat.StartsWith(prefix)
                           || cert.HtDesc.StartsWith(prefix)
                           select new
                           {
                               label = cert.Heat + "|" + cert.HtDesc + "|" + cert.Crn,
                               val = cert.Heat
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

            CertsMillDataTableData dataTableData = new CertsMillDataTableData(_context, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
        }

        #endregion Api    
    }
}