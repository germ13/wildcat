using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Wildcat.App.ViewModels.MCNJ.HeatTreatMaterials;
using Wildcat.Entities.MCNJ.HeatsSecured;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.MCNJ.HeatTreatMaterials
{
    [Area("MCNJ")]
    public class ConformanceController : Controller
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

        public ConformanceController(IHttpContextAccessor httpContextAccessor, HeatsSecuredContext context, IViewRenderService viewRenderService)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Pages   

        public IActionResult Index()
        {
            ConformanceCertsViewModel vm = new ConformanceCertsViewModel();
            return View(vm.Certs);
        }

        public IActionResult Add()
        {
            AddConformanceCertsViewModel vm = new AddConformanceCertsViewModel(_context, _viewRenderService);
            return View(vm);
        }

        public IActionResult Edit(string id)
        {
            EditConformanceCertsViewModel vm = new EditConformanceCertsViewModel(_context, _viewRenderService, id);
            return View(vm);
        }

        #endregion Pages



        #region Api

        public JsonResult EditHeatPartial(string ID)
        {
            SelectEditHeatResponse response = new SelectEditHeatResponse(_context, _viewRenderService, ID);
            return Json(response);
        }

        [HttpPost]
        public JsonResult AddResult(int McWCn, int? Crn, DateTime? Date, int? CustId, string CustPo, string Heat, string GsMcW, string Hardness, string HeatTreatNotes, string CertificationNotes, string ProcessNo, string NoteType, int? QtyShipped, string Die, string WorkOrder)
        {
            AddConfResponse response = new AddConfResponse(_context, _viewRenderService, McWCn, Crn, Date, CustId, CustPo, Heat, GsMcW, Hardness, HeatTreatNotes, CertificationNotes, ProcessNo, NoteType, QtyShipped, Die, WorkOrder, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult EditResult(int McWCn, int? Crn, DateTime? Date, int? CustId, string CustPo, string Heat, string GsMcW, string Hardness, string HeatTreatNotes, string CertificationNotes, string ProcessNo, string NoteType, int? QtyShipped, string Die, string WorkOrder)
        {
            EditConfResponse response = new EditConfResponse(_context, _viewRenderService, McWCn, Crn, Date, CustId, CustPo, Heat, GsMcW, Hardness, HeatTreatNotes, CertificationNotes, ProcessNo, NoteType, QtyShipped, Die, WorkOrder, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult AddOpResult(int? ControlNo, int? Crn, string ProcessNo, string WorkOrder, string Woqty, string McwHtCodes, int RowId)
        {
            AddConfOpResponse response = new AddConfOpResponse(_context, _viewRenderService, ControlNo, Crn, ProcessNo, WorkOrder, Woqty, McwHtCodes, RowId, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult EditOpResult(int? Crn, string ProcessNo, string WorkOrder, string Woqty, string McwHtCodes, int RowId)
        {
            EditConfOpResponse response = new EditConfOpResponse(_context, _viewRenderService, null, Crn, ProcessNo, WorkOrder, Woqty, McwHtCodes, RowId, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult AutoCompleteHeat(string prefix)
        {
            var mills = (from mill in _context.CertsMill
                        where mill.Heat.StartsWith(prefix.ToUpper())
                        || mill.Heat.StartsWith(prefix.ToUpper())
                        select new
                        {
                            label = mill.Heat,
                            val = mill.Heat
                        }).ToList();

            return Json(mills);
        }

        [HttpPost]
        public JsonResult GetHeatInfo(string prefix)
        {
            var mills = (from mill in _context.CertsMill
                         where mill.Heat.Equals(prefix)
                         select mill);

            return Json(mills);
        }

        [HttpPost]
        public JsonResult AutoCompleteDies(string prefix)
        {
            //_context entities = new NorthwindEntities();
            var dies = (from die in _context.Dies
                        where die.Die.StartsWith(prefix.ToUpper())
                        select new
                        {
                            label = die.Die,
                            val = die.Die
                        }).ToList();

            return Json(dies);
        }

        [HttpPost]
        public JsonResult GetDiesInfo(string prefix)
        {
            var dies = from die in _context.Dies
                       where die.Die.Equals(prefix.ToUpper())
                       select die;

            return Json(dies);
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

            ConformanceCertDataTableData dataTableData = new ConformanceCertDataTableData(_context, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
        }

        #endregion Api    
    }
}