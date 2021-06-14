using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Wildcat.App.ViewModels.PCC03.Integrations;
using Wildcat.Entities.PCC.PCC03Integration;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.PCC03
{
    //TODO renamespace
    [Area("SMCA")]
    public class IntegrationController : Controller
    {
        #region Private Fields

        private readonly IHttpContextAccessor _httpContextAccessor;
        private PCC03_IntegrationContext _context;
        private WildcatContext _wildcatContext;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields

        #region Public Properties


        #endregion Public Properties

        #region Constructors

    
        public IntegrationController(IHttpContextAccessor httpContextAccessor, PCC03_IntegrationContext context, WildcatContext wildcatContext, IViewRenderService viewRenderService)
        {
            //this._config = config;
            this._httpContextAccessor = httpContextAccessor;
            this._context = context;
            this._wildcatContext = wildcatContext;

            _viewRenderService = viewRenderService;
        }

        #endregion Constructors

        #region Pages

        public IActionResult Index()
        {
            RequestsViewModel vm = new RequestsViewModel(_httpContextAccessor, _viewRenderService, _context);
            return View(vm);
        }

        public IActionResult JobMaster()
        {
            JobsMasterViewModel vm = new JobsMasterViewModel(_httpContextAccessor, _viewRenderService, _context);
            return View(vm);
        }

        public JsonResult JobNoteRequestPartial(Guid ID)
        {
            SelectJsonRequestResponse response = new SelectJsonRequestResponse();

            try
            {
                JobNoteViewModel vm = new JobNoteViewModel(_httpContextAccessor, _viewRenderService, _context, ID);

                response.Form = _viewRenderService.RenderToStringAsync("PCC03/Integration/JobNoteRequestPartial", vm);

                response.success = true;
            }
            catch (Exception e)
            {
                response.success = false;
                response.message = "Job note retrieval failed. " + e.Message;
            }

            return Json(response);
        }

        public JsonResult JsonRequestPartial(string Table, Guid ID)
        {
            SelectJsonRequestResponse response = new SelectJsonRequestResponse();

            try
            {
                JsonObjectViewModel vm = new JsonObjectViewModel(_httpContextAccessor, _viewRenderService, _context, Table, ID);

                response.Form = _viewRenderService.RenderToStringAsync("PCC03/Integration/JsonRequestPartial", vm);

                response.success = true;
            }
            catch (Exception e)
            {
                response.success = false;
                response.message = "Json record retrieval failed. " + e.Message;
            }

            return Json(response);
        }

        public JsonResult ResponseRequestPartial(string Table, Guid ID)
        {
            SelectExceptionRequestResponse response = new SelectExceptionRequestResponse();

            try
            {
                ResponseObjectViewModel vm = new ResponseObjectViewModel(_httpContextAccessor, _viewRenderService, _context, Table, ID);

                response.Form = _viewRenderService.RenderToStringAsync("PCC03/Integration/ResponseRequestPartial", vm);

                response.success = true;
            }
            catch (Exception e)
            {
                response.success = false;
                response.message = "Response record retrieval failed. " + e.Message;
            }

            return Json(response);
        }

        public JsonResult ExceptionRequestPartial(string Table, Guid ID)
        {
            SelectExceptionRequestResponse response = new SelectExceptionRequestResponse();

            try
            {
                ExceptionObjectViewModel vm = new ExceptionObjectViewModel(_httpContextAccessor, _viewRenderService, _context, Table, ID);

                response.Form = _viewRenderService.RenderToStringAsync("PCC03/Integration/ExceptionRequestPartial", vm);

                response.success = true;
            }
            catch (Exception e)
            {
                response.success = false;
                response.message = "Exception record retrieval failed. " + e.Message;
            }

            return Json(response);
        }

        #endregion Pages

        #region Api

        [HttpPost]
        public JsonResult EditJobMasterNoteResult(Guid Id, string Note)
        {
            EditJobMasterNoteResponse response = new EditJobMasterNoteResponse(_context, _viewRenderService, Id, Note, HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult ReleaseRequestResult(Guid Id, string Table)
        {
            ReleaseRequestResponse response = new ReleaseRequestResponse(_context, _viewRenderService, Id, Table, HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public ActionResult AjaxGetJobMasterJsonData(int draw, int start, int length)
        {
            int TOTAL_ROWS = 0;
            string search = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "search[value]").FirstOrDefault().Value;
            int sortColumn = Convert.ToInt32(_httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][column]").FirstOrDefault().Value);
            string sortDirection = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][dir]").FirstOrDefault().Value;
            if (length == -1)
            {
                length = TOTAL_ROWS;
            }

            MasterJobsDataTableData dataTableData = new MasterJobsDataTableData(_context, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
        }


        [HttpPost]
        public ActionResult AjaxGetJsonData(int draw, int start, int length)
        {
            int TOTAL_ROWS = 0;
            string table = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "IntegrationPnt").FirstOrDefault().Value;
            string search = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "search[value]").FirstOrDefault().Value;
            int sortColumn = Convert.ToInt32(_httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][column]").FirstOrDefault().Value);
            string sortDirection = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][dir]").FirstOrDefault().Value;
            if (length == -1)
            {
                length = TOTAL_ROWS;
            }

            RequestsDataTableData dataTableData = new RequestsDataTableData(_context, _viewRenderService, draw, start, length, search, sortColumn, sortDirection, table);

            return Json(dataTableData.set);
        }

        #endregion Api
    }
}