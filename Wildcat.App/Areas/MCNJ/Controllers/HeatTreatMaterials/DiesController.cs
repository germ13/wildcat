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
    public class DiesController : Controller
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

        public DiesController(IHttpContextAccessor httpContextAccessor, HeatsSecuredContext context, IViewRenderService viewRenderService)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Pages   

        public IActionResult Index()
        {
            DiesViewModel vm = new DiesViewModel();
            return View(vm);
        }

        public JsonResult EditDiePartial(string ID)
        {
            SelectEditDieResponse response = new SelectEditDieResponse(ID, _viewRenderService);
            return Json(response);
        }

        #endregion Pages



        #region Api

        public JsonResult AddResult(string Die, string PartNum, string AuxDoc, string Revision, string PartDescription, string ProcessNo, string StdhtrNotes, string StdcertNotes)
        {
            AddDieResponse response = new AddDieResponse( _context, _viewRenderService, Die, PartNum, AuxDoc, Revision,PartDescription,ProcessNo,StdhtrNotes,StdcertNotes, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
        }

        public JsonResult EditResult(string Die, string PartNum, string AuxDoc, string Revision, string PartDescription, string ProcessNo, string StdhtrNotes, string StdcertNotes)
        {
            EditDieResponse response = new EditDieResponse(_context, _viewRenderService, Die, PartNum, AuxDoc, Revision, PartDescription, ProcessNo, StdhtrNotes, StdcertNotes, _httpContextAccessor.HttpContext.User.Identity.Name);
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