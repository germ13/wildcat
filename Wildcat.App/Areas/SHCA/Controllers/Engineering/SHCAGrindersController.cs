using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
//using Wildcat.App.Classes.Engineering.Grinders;
using Wildcat.App.SHCA.ViewModels.Grinders;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Entities.SHCA.EngineeringData;
//using Wildcat.Entities.SHCA.Grinders.FGA;
//using Wildcat.Entities.SHCA.Grinders.FGD;
//using Wildcat.Entities.SHCA.Grinders.FGQ;
//using Wildcat.Entities.SHCA.Grinders.FGX;
//using Wildcat.Entities.SHCA.Grinders.Wildcat;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.Engineering
{
    [Area("SHCA")]
    public class SHCAGrindersController : Controller
    {
        #region Private Fields

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly WildcatContext _wildcatContext;
        private readonly EngineeringDataContext _engineeringContext;

        private readonly IViewRenderService _viewRenderService;

        private const int LOGON32_PROVIDER_DEFAULT = 0;
        private const int LOGON32_LOGON_INTERACTIVE = 2;

        #endregion Private Fields

        #region Public Properties

        //[DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        //public static extern bool LogonUser(String lpszUsername, String lpszDomain, String lpszPassword, int dwLogonType, int dwLogonProvider, out SafeAccessTokenHandle phToken);

        #endregion Public Properties

        #region Constructors

        public SHCAGrindersController(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, WildcatContext wildcatContext, EngineeringDataContext engineeringContext)
        {
            this._httpContextAccessor = httpContextAccessor;
            this._wildcatContext = wildcatContext;
            this._engineeringContext = engineeringContext;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors

        #region Pages 

        public IActionResult Index()
        {
            SHCAGrindersIndexViewModel vm = new SHCAGrindersIndexViewModel(_httpContextAccessor, _viewRenderService, _engineeringContext, "FGA", DateTime.Now.AddDays(-15).Date, DateTime.Now.Date);
            return View(vm);
        }

        public IActionResult ContactTime()
        {
            //_FGAContext, _FGQContext, _FGXContext, _FGDContext, 
            SHCAGrindersContactTimeViewModel vm = new SHCAGrindersContactTimeViewModel(_httpContextAccessor, _viewRenderService, _engineeringContext, "FGA", DateTime.Now.AddDays(-15).Date, DateTime.Now.Date);
            return View(vm);
        }

        public IActionResult ProductionData()
        {
            SHCAGrindersProductionViewModel vm = new SHCAGrindersProductionViewModel(_httpContextAccessor, _viewRenderService, _engineeringContext, "FGA", DateTime.Now.AddDays(-15).Date, DateTime.Now.Date);
            return View(vm);
        }

        public IActionResult ProductionCharts()
        {
            SHCAGrindersProductionChartsViewModel vm = new SHCAGrindersProductionChartsViewModel(_httpContextAccessor, _viewRenderService, _engineeringContext, "FGA", DateTime.Now.AddDays(-15).Date, DateTime.Now.Date);
            return View(vm);
        }

        public IActionResult GrindersView()
        {
            SHCAGrindersIndexViewModel vm = new SHCAGrindersIndexViewModel(_httpContextAccessor, _viewRenderService, _engineeringContext, "FGA", DateTime.Now.AddDays(-15).Date, DateTime.Now.Date);
            return View(vm);
        }

        #endregion Pages

        #region Api

        ///// <summary>
        ///// from contact time page
        ///// gets refreshed table data based on selected grinder
        ///// </summary>
        ///// <param name="MachineId"></param>
        ///// <returns></returns>
        //public IActionResult GetContactTimeTableData(string MachineId)
        //{
        //    var response = new GrinderContactTimeResponse(_httpContextAccessor, _viewRenderService, _engineeringContext, _FGAContext, _FGQContext, _FGXContext, _FGDContext, MachineId);
        //    return new JsonResult(response);
        //}

        /// <summary>
        /// from production data page
        /// gets series of refreshed table data based on selected grinder and dates
        /// </summary>
        /// <param name="selectedGrinder"></param>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SHCAGrindersProductionResponse(string selectedGrinder, DateTime fromdate, DateTime todate)
        {
            var response = new GrinderProductionResponse(_httpContextAccessor, _viewRenderService, _engineeringContext, selectedGrinder, fromdate, todate);
            return new JsonResult(response);
        }

        /// <summary>
        /// from production charts page
        /// gets series of refreshed data arrays for chart display based on selected grinder and dates
        /// </summary>
        /// <param name="selectedGrinder"></param>
        /// <param name="fromdate"></param>
        /// <param name="todate"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult SHCAGrindersProductionChartsResponse(string selectedGrinder, DateTime fromdate, DateTime todate)
        {
            var response = new GrinderProductionChartsResponse(_httpContextAccessor, _viewRenderService, _engineeringContext, selectedGrinder, fromdate.Date, todate.Date);
            return new JsonResult(response);
        }

        #endregion Api


        //public IActionResult ProductionChartRefresh()
        //{
        //    SHCAGrindersProductionChartsViewModel vm = new SHCAGrindersProductionChartsViewModel(_httpContextAccessor, _engineeringContext, _FGAContext, _FGQContext, _FGXContext, _FGDContext, "FGA", DateTime.Now.AddDays(-15).Date, DateTime.Now.Date);
        //    return View(vm);
        //}

        //public IActionResult GrindersView()
        //{
        //    SHCAGrindersIndexViewModel vm = new SHCAGrindersIndexViewModel(_httpContextAccessor, _engineeringContext, _FGAContext, _FGQContext, _FGXContext, _FGDContext, "FGA", DateTime.Now.AddDays(-7), DateTime.Now);

        //    //vm = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrindersData("FGA");

        //    //manually adding the grinders available
        //    vm.GrindersSelect = new List<SelectListItem>();
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGA", Value = "FGA", Selected = true });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGQ", Value = "FGQ", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGX", Value = "FGX", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGD1", Value = "FGD1", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGD2", Value = "FGD2", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGD3", Value = "FGD3", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGD4", Value = "FGD4", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGD5", Value = "FGD5", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGD6", Value = "FGD6", Selected = false });

        //    return View(vm);
        //}

        //public IActionResult SelectedGrinders(string ID)
        //{
        //    SHCAGrindersIndexViewModel vm = new SHCAGrindersIndexViewModel(_httpContextAccessor, _engineeringContext, _FGAContext, _FGQContext, _FGXContext, _FGDContext, ID, DateTime.Now.AddDays(-7), DateTime.Now);

        //    vm = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrindersData(ID);

        //    //manually adding the grinders available
        //    vm.GrindersSelect = new List<SelectListItem>();
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGA", Value = "FGA", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGQ", Value = "FGQ", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGX", Value = "FGX", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGD1", Value = "FGD1", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGD2", Value = "FGD2", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGD3", Value = "FGD3", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGD4", Value = "FGD4", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGD5", Value = "FGD5", Selected = false });
        //    vm.GrindersSelect.Add(new SelectListItem { Text = "FGD6", Value = "FGD6", Selected = false });

        //    foreach (var m in vm.GrindersSelect)
        //    {
        //        if (m.Text == ID)
        //        {
        //            m.Selected = true;
        //        }
        //    }

        //    return View("GrindersView", vm);
        //}


        //public IActionResult DataRefresh(SHCAGrindersIndexViewModel vm)
        //{
        //    return View(vm);
        //}

        public IActionResult DataRefresh(SHCAGrindersIndexViewModel vm)
        {
            //SHCAGrindersIndexViewModel vm = new SHCAGrindersIndexViewModel();

            //vm = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrindersData(ID);

            ////manually adding the grinders available
            //vm.GrindersSelect = new List<SelectListItem>();
            //vm.GrindersSelect.Add(new SelectListItem { Text = "FGA", Value = "FGA", Selected = false });
            //vm.GrindersSelect.Add(new SelectListItem { Text = "FGQ", Value = "FGQ", Selected = false });
            //vm.GrindersSelect.Add(new SelectListItem { Text = "FGX", Value = "FGX", Selected = false });

            //foreach (var m in vm.GrindersSelect)
            //{
            //    if (m.Text == ID)
            //    {
            //        m.Selected = true;
            //    }
            //}

            return View(vm);
        }


        //public IActionResult GetGrinderViewDataData(string ID)
        //{
        //    var response = new GrinderSelectedResponse();

        //    try
        //    {
        //        SHCAGrindersIndexViewModel vm = new SHCAGrindersIndexViewModel(_httpContextAccessor,_engineeringContext, _FGAContext, _FGQContext, _FGXContext, _FGDContext,ID, DateTime.Now.AddDays(-7), DateTime.Now);

        //        vm = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrindersData(ID);

        //        //manually adding the grinders available
        //        vm.GrindersSelect = new List<SelectListItem>();
        //        vm.GrindersSelect.Add(new SelectListItem { Text = "FGA", Value = "FGA", Selected = false });
        //        vm.GrindersSelect.Add(new SelectListItem { Text = "FGQ", Value = "FGQ", Selected = false });
        //        vm.GrindersSelect.Add(new SelectListItem { Text = "FGX", Value = "FGX", Selected = false });
        //        vm.GrindersSelect.Add(new SelectListItem { Text = "FGD1", Value = "FGD1", Selected = false });
        //        vm.GrindersSelect.Add(new SelectListItem { Text = "FGD2", Value = "FGD2", Selected = false });
        //        vm.GrindersSelect.Add(new SelectListItem { Text = "FGD3", Value = "FGD3", Selected = false });
        //        vm.GrindersSelect.Add(new SelectListItem { Text = "FGD4", Value = "FGD4", Selected = false });
        //        vm.GrindersSelect.Add(new SelectListItem { Text = "FGD5", Value = "FGD5", Selected = false });
        //        vm.GrindersSelect.Add(new SelectListItem { Text = "FGD6", Value = "FGD6", Selected = false });

        //        foreach (var m in vm.GrindersSelect)
        //        {
        //            if (m.Text == ID)
        //            {
        //                m.Selected = true;
        //            }
        //        }
        //        response.viewRefresh = _viewRenderService.RenderToStringAsync("Engineering/SHCAGrinders/DataRefresh", vm);
        //        response.vm = vm;
        //        response.success = true; response.message = "";
        //    }
        //    catch (Exception e)
        //    {
        //        response.success = false;
        //        response.message = "Please Contact administrator. " + Environment.NewLine + e.Message;
        //    }

        //    return new JsonResult(response);
        //}

        #region - api for the index page

        //public IActionResult GetGrinderPressureWarning(string ID)
        //{
        //    var response = new LightResponse();

        //    try
        //    {
        //        response = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrinderPressureWarning(ID);
        //    }
        //    catch (Exception e)
        //    {
        //        response.success = false;
        //        response.message = "Please Contact administrator. " + Environment.NewLine + e.Message;
        //    }

        //    return new JsonResult(response);
        //}

        //public IActionResult GetGrinderAutoGrind(string ID)
        //{
        //    var response = new LightResponse();

        //    try
        //    {
        //        response = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrinderAutoGrind(ID);
        //    }
        //    catch (Exception e)
        //    {
        //        response.success = false;
        //        response.message = "Please Contact administrator. " + Environment.NewLine + e.Message;
        //    }

        //    return new JsonResult(response);
        //}

        //public IActionResult GetGrinderBoomIn(string ID)
        //{
        //    var response = new LightResponse();

        //    try
        //    {
        //        response = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrinderBoomIn(ID);
        //    }
        //    catch (Exception e)
        //    {
        //        response.success = false;
        //        response.message = "Please Contact administrator. " + Environment.NewLine + e.Message;
        //    }

        //    return new JsonResult(response);
        //}

        //public IActionResult GetGrinderBoomOut(string ID)
        //{
        //    var response = new LightResponse();

        //    try
        //    {
        //        response = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrinderBoomOut(ID);
        //    }
        //    catch (Exception e)
        //    {
        //        response.success = false;
        //        response.message = "Please Contact administrator. " + Environment.NewLine + e.Message;
        //    }

        //    return new JsonResult(response);
        //}

        //public IActionResult GetGrinderInGrindArea(string ID)
        //{
        //    var response = new LightResponse();

        //    try
        //    {
        //        response = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrinderInGrindArea(ID);
        //    }
        //    catch (Exception e)
        //    {
        //        response.success = false;
        //        response.message = "Please Contact administrator. " + Environment.NewLine + e.Message;
        //    }

        //    return new JsonResult(response);
        //}

        //public IActionResult GetGrinderContactTime(string ID)
        //{
        //    var response = new DataResponse();

        //    try
        //    {
        //        response = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrinderContactTime(ID);
        //    }
        //    catch (Exception e)
        //    {
        //        response.success = false;
        //        response.message = "Please Contact administrator. " + Environment.NewLine + e.Message;
        //    }

        //    return new JsonResult(response);
        //}

        //public IActionResult GetGrinderIndexPosition(string ID)
        //{
        //    var response = new DataResponse();

        //    try
        //    {
        //        response = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrinderIndexPosition(ID);
        //    }
        //    catch (Exception e)
        //    {
        //        response.success = false;
        //        response.message = "Please Contact administrator. " + Environment.NewLine + e.Message;
        //    }

        //    return new JsonResult(response);
        //}

        //public IActionResult GetGrinderTravelSpeed(string ID)
        //{
        //    var response = new DataResponse();

        //    try
        //    {
        //        response = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrinderTravelSpeed(ID);
        //    }
        //    catch (Exception e)
        //    {
        //        response.success = false;
        //        response.message = "Please Contact administrator. " + Environment.NewLine + e.Message;
        //    }

        //    return new JsonResult(response);
        //}

        //public IActionResult GetGrinderPressureDiff(string ID)
        //{
        //    var response = new DataResponse();

        //    try
        //    {
        //        response = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrinderPressureDiff(ID);
        //    }
        //    catch (Exception e)
        //    {
        //        response.success = false;
        //        response.message = "Please Contact administrator. " + Environment.NewLine + e.Message;
        //    }

        //    return new JsonResult(response);
        //}

        //public IActionResult GetGrinderLubeTempReturn(string ID)
        //{
        //    var response = new DataResponse();

        //    try
        //    {
        //        response = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrinderLubeTempReturn(ID);
        //    }
        //    catch (Exception e)
        //    {
        //        response.success = false;
        //        response.message = "Please Contact administrator. " + Environment.NewLine + e.Message;
        //    }

        //    return new JsonResult(response);
        //}

        //public IActionResult GetGrinderLubeTempSupply(string ID)
        //{
        //    var response = new DataResponse();

        //    try
        //    {
        //        response = new GrindersData(_httpContextAccessor, _FGAContext, _FGQContext, _FGXContext, _FGDContext).GetGrinderLubeTempSupply(ID);
        //    }
        //    catch (Exception e)
        //    {
        //        response.success = false;
        //        response.message = "Please Contact administrator. " + Environment.NewLine + e.Message;
        //    }

        //    return new JsonResult(response);
        //}

        #endregion



        [HttpPost]
        public ActionResult AjaxGetJsonProductionData(int draw, int start, int length)
        {
            int TOTAL_ROWS = 0;
            string grinder = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "selectedGrinder").FirstOrDefault().Value;
            string search = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "search[value]").FirstOrDefault().Value;
            int sortColumn = Convert.ToInt32(_httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][column]").FirstOrDefault().Value);
            string sortDirection = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][dir]").FirstOrDefault().Value;
            if (length == -1)
            {
                length = TOTAL_ROWS;
            }

            GrinderProductionDataTableData dataTableData = new GrinderProductionDataTableData(_httpContextAccessor, _viewRenderService, _engineeringContext, draw, start, length, search, sortColumn, sortDirection, grinder);

            return Json(dataTableData.set);
        }

        [HttpPost]
        public ActionResult AjaxGetJsonContactTimeData(int draw, int start, int length)
        {
            int TOTAL_ROWS = 0;
            string grinder = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "selectedGrinder").FirstOrDefault().Value;
            string search = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "search[value]").FirstOrDefault().Value;
            int sortColumn = Convert.ToInt32(_httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][column]").FirstOrDefault().Value);
            string sortDirection = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "order[0][dir]").FirstOrDefault().Value;
            if (length == -1)
            {
                length = TOTAL_ROWS;
            }

            GrinderContactTimeDataTableData dataTableData = new GrinderContactTimeDataTableData(_httpContextAccessor, _viewRenderService, _engineeringContext, draw, start, length, search, sortColumn, sortDirection, grinder);

            return Json(dataTableData.set);
        }
    }
}