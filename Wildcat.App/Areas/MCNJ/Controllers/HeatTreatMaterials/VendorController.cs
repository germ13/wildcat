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
    public class VendorController : Controller
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

        public VendorController(IHttpContextAccessor httpContextAccessor, HeatsSecuredContext context, IViewRenderService viewRenderService)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Pages   

        public IActionResult Index()
        {
            VendorModel vm = new VendorModel();
            return View(vm);
        }

        #endregion Pages



        #region Api

        public JsonResult EditVendorPartial(string ID)
        {
            SelectEditVendorResponse response = new SelectEditVendorResponse(_context, _viewRenderService, ID);
            return Json(response);
        }

        [HttpPost]
        public JsonResult AddVendorResult(string Name, string Address, string City, string State, string ZipCode, string Country, string Contact, bool Print)
        {
            AddVendorResponse response = new AddVendorResponse(_context, _viewRenderService, Name, Address, City, State, ZipCode, Country, Contact, Print, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult EditVendorResult(int MillId, string Name, string Address, string City, string State, string ZipCode, string Country, string Contact, bool Print)
        {
            EditVendorResponse response = new EditVendorResponse(_context, _viewRenderService, MillId, Name, Address, City, State, ZipCode, Country, Contact, Print, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpGet]
        public ActionResult AjaxGetJsonData(int draw, int start, int length)
        {
            int TOTAL_ROWS = 0;
            string search = _httpContextAccessor.HttpContext.Request.Query.Where(x => x.Key == "search[value]").FirstOrDefault().Value;
            int sortColumn = Convert.ToInt32(_httpContextAccessor.HttpContext.Request.Query.Where(x => x.Key == "order[0][column]").FirstOrDefault().Value);
            string sortDirection = _httpContextAccessor.HttpContext.Request.Query.Where(x => x.Key == "order[0][dir]").FirstOrDefault().Value;
            if (length == -1)
            {
                length = TOTAL_ROWS;
            }

            VendorDataTableData dataTableData = new VendorDataTableData(_context, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
        }


        #endregion Api    
    }
}