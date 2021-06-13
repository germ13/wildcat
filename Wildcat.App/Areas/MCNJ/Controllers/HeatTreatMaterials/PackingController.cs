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
    public class PackingController : Controller
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

        public PackingController(IHttpContextAccessor httpContextAccessor, HeatsSecuredContext context, IViewRenderService viewRenderService)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Pages   

        public IActionResult Index()
        {
            PackingSlipsViewModel vm = new PackingSlipsViewModel();
            return View(vm.PackingSlip);
        }

        public IActionResult Add()
        {
            AddPackingSlipsViewModel vm = new AddPackingSlipsViewModel(_context);

            //MetRecordViewModel vm = new MetRecordViewModel();
            //vm.MetRecords = new List<Entities.MCNJ.SecureHeatTreatBatchBook.TblMetRecords>();
            //vm.MetRecords = _context.TblMetRecords.Take(100).ToList();
            return View(vm);
        }

        public IActionResult Edit(int PSN)
        {
            EditPackingSlipsViewModel vm = new EditPackingSlipsViewModel(_context, PSN);

            //vm.PackingSlip = _context.TblPackingSlips.Where(x => x.Psn == PSN).FirstOrDefault();
            //vm.ShipTo = new TblCustomers();
            //vm.SoldTo = new TblCustomers();
            
            //vm.Die = vm.PackingSlip.Die;
            //foreach (var p in _context.TblPackingSlips)
            //{
            //    vm.Dies.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(p.Die, p.Die));
            //}

            //foreach (var c in _context.TblCustomers)
            //{
            //    vm.Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(c.CustomerName, c.CustId.ToString()));
            //}

            //foreach(var l in vm.Freight)
            //{
            //    if(l.Value == vm.PackingSlip.Freight)
            //    {
            //        l.Selected = true;
            //    }
            //}

            //var die = _context.Dies.Where(x => x.Die == vm.PackingSlip.Die).FirstOrDefault();

            //vm.PackingSlip.Die = die.Die;  vm.PartNumber = die.PartNum; vm.RevisionNumber = die.Revision;

            //if(vm.PackingSlip.ShipTo != null)
            //{
            //    var ShipTo = _context.TblCustomers.Where(x => x.CustId == vm.PackingSlip.ShipTo).FirstOrDefault();
            //    if (ShipTo != null)
            //    {
            //        vm.ShipTo = ShipTo;
            //    }
            //}

            //if (vm.PackingSlip.SoldTo != null)
            //{
            //    var SoldTo = _context.TblCustomers.Where(x => x.CustId == vm.PackingSlip.SoldTo).FirstOrDefault();
            //    if(SoldTo != null)
            //    {
            //        vm.SoldTo = SoldTo;
            //    }
            //}

            return View(vm);
        }

        #endregion Pages



        #region Api

        [HttpPost]
        public JsonResult AddResult(string McWCn, DateTime? Date, string Die, string WorkOrder, string CustPo, short Quantity, string ProcessNo, string SerialNumber, string Freight, string ItemNumber, string ShipVia, int? NumberOfSkids, int? NumberOfBoxes, int? TotalWeight, string Notes, bool ShipAir, int? Crn2, int? Crn, int? ShipTo, int? SoldTo)
        {
            AddPackingSlipResponse response = new AddPackingSlipResponse(_context, _viewRenderService, McWCn, Date, Die, WorkOrder, CustPo, Quantity, ProcessNo, SerialNumber, Freight, ItemNumber, ShipVia, NumberOfSkids, NumberOfBoxes, TotalWeight, Notes, ShipAir, Crn2, Crn, ShipTo, SoldTo, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
        }

        [HttpPost]
        public JsonResult EditResult(int Psn, string McWCn, DateTime? Date, string Die, string WorkOrder, string CustPo, short Quantity, string ProcessNo, string SerialNumber, string Freight, string ItemNumber, string ShipVia, int? NumberOfSkids, int? NumberOfBoxes, int? TotalWeight, string Notes, bool ShipAir, int? Crn2, int? Crn, int? ShipTo, int? SoldTo)
        {
            EditPackingSlipResponse response = new EditPackingSlipResponse(_context, _viewRenderService, Psn, McWCn, Date, Die, WorkOrder, CustPo, Quantity, ProcessNo, SerialNumber, Freight, ItemNumber, ShipVia, NumberOfSkids, NumberOfBoxes, TotalWeight, Notes, ShipAir, Crn2, Crn, ShipTo, SoldTo, _httpContextAccessor.HttpContext.User.Identity.Name);
            return Json(response);
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
            //var diesx = (from die in _context.Dies
            //            where die.Die.Contains(prefix.ToUpper())
            //            select new
            //            {
            //                label = die.Die,
            //                val = die.Die
            //            }).ToList();

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
        public JsonResult AutoCompleteCustomers(string prefix)
        {
            var customers = (from customer in _context.TblCustomers
                            where customer.CustomerName.StartsWith(prefix.ToUpper())
                            select new
                            {
                                label = customer.CustomerName,
                                val = customer.CustId
                            }).ToList();

            return Json(customers);

        }

        [HttpPost]
        public JsonResult GetCustomerInfo(int prefix)
        {
            //var id = Convert.ToInt32(prefix);
            //_context entities = new NorthwindEntities();
            var customers = from customer in _context.TblCustomers
                             where customer.CustId.Equals(prefix)
                            select customer;
            //var diesx = (from die in _context.Dies
            //            where die.Die.Contains(prefix.ToUpper())
            //            select new
            //            {
            //                label = die.Die,
            //                val = die.Die
            //            }).ToList();

            return Json(customers);
        }

        [HttpPost]
        public JsonResult AutoCompleteShipVia(string prefix)
        {
            var shipvias = (from shipvia in _context.TblPackingSlips
                             where shipvia.ShipVia.StartsWith(prefix.ToUpper())
                             select new
                             {
                                 label = shipvia.ShipVia,
                                 val = shipvia.ShipVia
                             }).ToList().Distinct();

            return Json(shipvias);

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

            PackingDataTableData dataTableData = new PackingDataTableData(_context, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            //// note: we only sort one column at a time
            //if (_httpContextAccessor.HttpContext.Request.QueryString.Value.Equals("order[0][column]").ToString() != null)
            //{TblPackingSlips
            //    sortColumn = int.Parse(_httpContextAccessor.HttpContext.Request.QueryString.Value.Equals("order[0][column]").ToString());
            //}
            //if (_httpContextAccessor.HttpContext.Request.QueryString.Value.Equals("order[0][dir]").ToString() != null)
            //{
            //    sortDirection = _httpContextAccessor.HttpContext.Request.QueryString.Value.Equals("order[0][dir]").ToString();
            //}

            //DataTableData dataTableData = new DataTableData();
            //dataTableData.draw = draw;
            //dataTableData.recordsTotal = TOTAL_ROWS = _context.TblPackingSlips.Count();
            //int recordsFiltered = 0;
            //dataTableData.data = FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            //dataTableData.recordsFiltered = recordsFiltered;

            return Json(dataTableData.set);
        }


        //private const int TOTAL_ROWS = 995;
        //private static readonly List<TblPackingSlips> _data;

        //public class DataItem
        //{
        //    public string Name { get; set; }
        //    public string Age { get; set; }
        //    public string DoB { get; set; }
        //}

        //public class DataTableData
        //{
        //    public int draw { get; set; }
        //    public int recordsTotal { get; set; }
        //    public int recordsFiltered { get; set; }
        //    public List<TblPackingSlips> data { get; set; }
        //}

        //// here we simulate data from a database table.
        //// !!!!DO NOT DO THIS IN REAL APPLICATION !!!!
        //private static List<DataItem> CreateData()
        //{
        //    Random rnd = new Random();
        //    List<DataItem> list = new List<DataItem>();
        //    for (int i = 1; i <= TOTAL_ROWS; i++)
        //    {
        //        DataItem item = new DataItem();
        //        item.Name = "Name_" + i.ToString().PadLeft(5, '0');
        //        DateTime dob = new DateTime(1900 + rnd.Next(1, 100), rnd.Next(1, 13), rnd.Next(1, 28));
        //        item.Age = ((DateTime.Now - dob).Days / 365).ToString();
        //        item.DoB = dob.ToShortDateString();
        //        list.Add(item);
        //    }
        //    return list;
        //}

        //private int SortString(string s1, string s2, string sortDirection)
        //{
        //    if (s1 == null) { s1 = ""; }
        //    if (s2 == null) { s2 = ""; }
        //    return sortDirection == "asc" ? s1.CompareTo(s2) : s2.CompareTo(s1);
        //}

        //private int SortInteger(string s1, string s2, string sortDirection)
        //{
        //    int i1 = int.Parse(s1);
        //    int i2 = int.Parse(s2);
        //    return sortDirection == "asc" ? i1.CompareTo(i2) : i2.CompareTo(i1);
        //}

        //private int SortDateTime(string s1, string s2, string sortDirection)
        //{
        //    DateTime d1 = DateTime.Parse(s1);
        //    DateTime d2 = DateTime.Parse(s2);
        //    return sortDirection == "asc" ? d1.CompareTo(d2) : d2.CompareTo(d1);
        //}

        //// here we simulate SQL search, sorting and paging operations
        //// !!!! DO NOT DO THIS IN REAL APPLICATION !!!!
        //private List<TblPackingSlips> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        //{
        //    List<TblPackingSlips> list = new List<TblPackingSlips>();
        //    if (string.IsNullOrEmpty(search))
        //    {
        //        list = _context.TblPackingSlips.ToList(); ;
        //    }
        //    else
        //    {
        //        // simulate search
        //        foreach (TblPackingSlips dataItem in _context.TblPackingSlips)
        //        {
        //            //if (propCheckString())
        //            //{

        //            //}
        //            //if ((dataItem.Die != null && dataItem.Die.ToString().Contains(search.ToUpper())))
        //            //{
        //            //    list.Add(dataItem);
        //            //}
        //            //else if ((dataItem.Crn != null && dataItem.Crn.ToString().Contains(search.ToUpper())))
        //            //{
        //            //    list.Add(dataItem);
        //            //}
        //            //else if ((dataItem.CustPo != null && dataItem.CustPo.ToString().Contains(search.ToUpper())))
        //            //{
        //            //    list.Add(dataItem);
        //            //}
        //            //else if ((dataItem.Die != null && dataItem.Die.ToString().Contains(search.ToUpper())))
        //            //{
        //            //    list.Add(dataItem);
        //            //}


        //            if ((dataItem.McWCn != null && dataItem.McWCn.ToString().Contains(search.ToUpper())) ||
        //                (dataItem.Die != null && dataItem.Die.ToString().Contains(search.ToUpper())) ||
        //                (dataItem.WorkOrder != null && dataItem.WorkOrder.ToString().Contains(search.ToUpper())) ||
        //                (dataItem.CustPo != null && dataItem.CustPo.ToString().Contains(search.ToUpper())))
        //            {
        //                list.Add(dataItem);
        //            }
        //        }
        //    }

        //    // simulate sort
        //    if (sortColumn == 1)
        //    {// sort Name
        //        list.Sort((x, y) => SortString(x.McWCn, y.McWCn, sortDirection));
        //    }
        //    else if (sortColumn == 2)
        //    {// sort Name
        //        list.Sort((x, y) => SortString(x.Die, y.Die, sortDirection));
        //    }
        //    else if (sortColumn == 3)
        //    {// sort Name
        //        list.Sort((x, y) => SortString(x.WorkOrder, y.WorkOrder, sortDirection));
        //    }
        //    else if (sortColumn == 4)
        //    {// sort Age
        //        list.Sort((x, y) => SortString(x.CustPo, y.CustPo, sortDirection));
        //    }

        //    recordFiltered = list.Count;

        //    // get just one page of data
        //    list = list.GetRange(start, Math.Min(length, list.Count - start));

        //    return list;
        //}

        #endregion Api    
    }
}