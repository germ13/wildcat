using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using Wildcat.App.ViewModels.Engineering;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.Engineering
{
    public class MachineController : Controller
    {
        #region Private Fields

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IViewRenderService _viewRenderService;

        private readonly WildcatContext _wildcatContext;

        private const int LOGON32_PROVIDER_DEFAULT = 0;
        private const int LOGON32_LOGON_INTERACTIVE = 2;

        #endregion Private Fields

        #region Public Properties

        //[DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        //public static extern bool LogonUser(String lpszUsername, String lpszDomain, String lpszPassword, int dwLogonType, int dwLogonProvider, out SafeAccessTokenHandle phToken);

        #endregion Public Properties

        #region Constructors

        public MachineController(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _wildcatContext = wildcatContext;
        }

        #endregion Constructors



        #region Pages     

        public IActionResult Index()
        {
            MachineIndexViewModel vm = new MachineIndexViewModel(_httpContextAccessor, _viewRenderService, _wildcatContext);
            return View(vm);
        }

        public IActionResult AddMachine()
        {
            AddMachineViewModel vm = new AddMachineViewModel(_httpContextAccessor, _viewRenderService, _wildcatContext);
            return View(vm);
        }

        public IActionResult EditMachine(Guid Id)
        {
            EditMachineViewModel vm = new EditMachineViewModel(_httpContextAccessor, _viewRenderService, _wildcatContext, Id);
            return View(vm);
        }

        public IActionResult MachineTypes()
        {
            MachineTypeViewModel vm = new MachineTypeViewModel(_httpContextAccessor, _viewRenderService, _wildcatContext);
            return View(vm);
        }

        public JsonResult EditMachineTypePartial(string Id)
        {
            EditMachineTypePartial vm = new EditMachineTypePartial(_httpContextAccessor, _viewRenderService, _wildcatContext, Id);
            return new JsonResult(vm);
        }

        public IActionResult MachineProperties()
        {
            MachinePropertyViewModel vm = new MachinePropertyViewModel(_httpContextAccessor, _viewRenderService, _wildcatContext);
            return View(vm);
        }

        /// <summary>
        /// machine properties edit property metadata partial
        /// </summary>
        /// <returns></returns>
        public JsonResult MachinePropertyPartial(string ID)
        {
            MachinePropertyPartial vm = new MachinePropertyPartial(_httpContextAccessor, _viewRenderService, _wildcatContext, ID);
            return new JsonResult(vm);
        }

        /// <summary>
        /// add/edit machine pages edit property partial
        /// </summary>
        /// <returns></returns>
        public JsonResult EditMachinePropertyValuePartial(string ID)
        {
            EditMachinePropertyValuePartial vm = new EditMachinePropertyValuePartial(_httpContextAccessor, _viewRenderService, _wildcatContext, ID);
            return new JsonResult(vm);
        }

        public JsonResult EditMachineNotePartial(string ID)
        {
            EditMachineNotePartial vm = new EditMachineNotePartial(_httpContextAccessor, _viewRenderService, _wildcatContext, ID);
            return new JsonResult(vm);
        }

        #endregion Pages



        #region Api

        public JsonResult AddMachineResult(string MachineName, string Status, bool Active, string MachineType)
        {
            AddMachineResult vm = new AddMachineResult(_httpContextAccessor, _viewRenderService, _wildcatContext, MachineName, Status, Active, MachineType);
            return new JsonResult(vm);
        }

        public JsonResult EditMachineResult(string Id, string MachineName, string Status, bool Active, string MachineType)
        {
            EditMachineResult vm = new EditMachineResult(_httpContextAccessor, _viewRenderService, _wildcatContext, Id, MachineName, Status, Active, MachineType);
            return new JsonResult(vm);
        }

        public JsonResult AddTypeResult(string Type, string Definition, bool Active)
        {
            AddTypeResult vm = new AddTypeResult(_httpContextAccessor, _viewRenderService, _wildcatContext, Type, Definition, Active);
            return new JsonResult(vm);
        }

        public JsonResult EditTypeResult(string Id, string Type, string Definition, bool Active)
        {
            EditTypeResult vm = new EditTypeResult(_httpContextAccessor, _viewRenderService, _wildcatContext, Id, Type, Definition, Active);
            return new JsonResult(vm);
        }

        public JsonResult AddMetadataResult(string Property, string DisplayName, bool IsRequired, string Definition, string DataType, bool Active)
        {
            AddMetadataResult vm = new AddMetadataResult(_httpContextAccessor, _viewRenderService, _wildcatContext, Property, DisplayName, IsRequired, Definition, DataType, Active);
            return new JsonResult(vm);
        }

        public JsonResult EditMetadataResult(string Id, string Property, string DisplayName, bool IsRequired, string Definition, string DataType, bool Active)
        {
            EditMetadataResult vm = new EditMetadataResult(_httpContextAccessor, _viewRenderService, _wildcatContext, Id, Property, DisplayName, IsRequired, Definition, DataType, Active);
            return new JsonResult(vm);
        }

        public JsonResult AddPropertyResult(string MachineId, string PropertyId, string Value, bool Active)
        {
            AddPropertyResult vm = new AddPropertyResult(_httpContextAccessor, _viewRenderService, _wildcatContext, MachineId, PropertyId, Value, Active);
            return new JsonResult(vm);
        }

        public JsonResult EditPropertyResult(string Id, string Value, bool Active)
        {
            EditPropertyResult vm = new EditPropertyResult(_httpContextAccessor, _viewRenderService, _wildcatContext, Id, Value, Active);
            return new JsonResult(vm);
        }

        public JsonResult AddNoteResult(string MachineId, string NoteType, string Note, bool Active)
        {
            AddNoteResult vm = new AddNoteResult(_httpContextAccessor, _viewRenderService, _wildcatContext, MachineId, NoteType, Note, Active);
            return new JsonResult(vm);
        }

        public JsonResult EditNoteResult(string Id, string NoteType, string Note, bool Active)
        {
            EditNoteResult vm = new EditNoteResult(_httpContextAccessor, _viewRenderService, _wildcatContext, Id, NoteType, Note, Active);
            return new JsonResult(vm);
        }
        public JsonResult MachineTypeSelect(string ID)
        {
            var result = _wildcatContext.MachineType.Where(x => x.Id == ID).FirstOrDefault();
            return new JsonResult(result);
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

            MachineDataTableData dataTableData = new MachineDataTableData(_wildcatContext, _httpContextAccessor, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
        }

        [HttpPost]
        public ActionResult AjaxGetMachineTypesJsonData(int draw, int start, int length)
        {
            int TOTAL_ROWS = 0;
            string search = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "search[value]").FirstOrDefault().Value;
            int sortColumn = Convert.ToInt32(_httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][column]").FirstOrDefault().Value);
            string sortDirection = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][dir]").FirstOrDefault().Value;
            if (length == -1)
            {
                length = TOTAL_ROWS;
            }

            MachineTypeDataTableData dataTableData = new MachineTypeDataTableData(_wildcatContext, _httpContextAccessor, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
        }

        [HttpPost]
        public ActionResult AjaxGetMachinePropertiesJsonData(int draw, int start, int length)
        {
            int TOTAL_ROWS = 0;
            string search = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "search[value]").FirstOrDefault().Value;
            int sortColumn = Convert.ToInt32(_httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][column]").FirstOrDefault().Value);
            string sortDirection = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][dir]").FirstOrDefault().Value;
            if (length == -1)
            {
                length = TOTAL_ROWS;
            }

            MachinePropertyDataTableData dataTableData = new MachinePropertyDataTableData(_wildcatContext, _httpContextAccessor, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
        }

        #endregion - Api
    }
}