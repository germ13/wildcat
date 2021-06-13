using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aspose.Pdf;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wildcat.App.ViewModels.MCNJ.HeatTreatBatchRecords;
using Wildcat.Entities.MCNJ.SecureHeatTreatBatchBook;
using Wildcat.Utilities;

namespace Wildcat.App.Controllers.MCNJ.HeatTreatBatchRecords
{
    public class MetRecordController : Controller
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

        public MetRecordController(IHttpContextAccessor httpContextAccessor, SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService)
        {
            _httpContextAccessor = httpContextAccessor;
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Pages   

        public IActionResult Index()
        {
            MetRecordViewModel vm = new MetRecordViewModel();
            vm.MetRecords = new List<Entities.MCNJ.SecureHeatTreatBatchBook.TblMetRecords>();
            //vm.MetRecords = _context.TblMetRecords.Take(100).ToList();

            vm.AddMetRecord = new TblMetRecords();
            vm.EditMetRecord = new TblMetRecords();

            vm.NewOp = new TblHtacutal();
            vm.EditOp = new TblHtacutal();
            
            vm.HeatOperations = new List<TblHtacutal>();

            return View(vm);
        }

        public IActionResult Add()
        {
            AddMetRecordViewModel vm = new AddMetRecordViewModel(_context);
            return View(vm);
        }

        public IActionResult Edit(int ID)
        {
            EditMetRecordViewModel vm = new EditMetRecordViewModel(_context, ID);
            return View(vm);
        }

        #endregion Pages



        #region Api

        public JsonResult EditMetPartial(string ID)
        {
            SelectEditMetResponse response = new SelectEditMetResponse();
            EditMetRecordViewModel vm = new EditMetRecordViewModel();
            try
            {
                var id = Convert.ToInt32(ID);
                vm.EditMetRecord = _context.TblMetRecords.Where(x => x.RowId == id).FirstOrDefault();

                response.Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/MetRecord/EditMetPartial", vm);

                response.success = true;


            }
            catch (Exception e)
            {
                //vm.EditMetRecord = new TblMetRecords();

                //response.Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/MetRecord/EditHeatOp", vm);

                response.success = false;
                response.message = "Metallurgical record retrieval failed. " + e.Message;
            }

            return Json(response);
        }

        public JsonResult AddHeatPartial(string ID)
        {
            SelectAddHeatResponse response = new SelectAddHeatResponse();
            AddHeatOpViewModel vm = new AddHeatOpViewModel();
            try
            {
                var id = Convert.ToInt32(ID);
                var met = _context.TblMetRecords.Where(x => x.RowId == id).FirstOrDefault();

                vm.NewOp = new TblHtacutal();
                vm.HeatOperations = new List<TblHtacutal>(); vm.HeatOperations = _context.TblHtacutal.Where(x => x.OrderNo == met.OrderNo).ToList();

                response.Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/MetRecord/AddHeatPartial", vm);

                response.success = true;


            }
            catch (Exception e)
            {
                //vm.EditOp = new TblHtacutal();

                //response.Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/MetRecord/EditHeatOp", vm);

                response.success = false;
                response.message = "Batch edit failed. " + e.Message;
            }

            return Json(response);
        }

        public JsonResult EditHeatPartial(string ID)
        {
            SelectEditHeatResponse response = new SelectEditHeatResponse();
            EditHeatOpViewModel vm = new EditHeatOpViewModel();
            try
            {
                var id = Convert.ToInt32(ID);
                vm.EditOp = _context.TblHtacutal.Where(x => x.RowId == id).FirstOrDefault();

                response.Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/MetRecord/EditHeatPartial", vm);

                response.success = true;


            }
            catch (Exception e)
            {
                //vm.EditOp = new TblHtacutal();

                //response.Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/MetRecord/EditHeatOp", vm);

                response.success = false;
                response.message = "Batch edit failed. " + e.Message;
            }

            return Json(response);
        }

        [HttpPost]
        public JsonResult AddMetResult(string DieNo, string OrderNo, int QuantityRun, int TestBars, string TotalFurnaceTime, int QuenchTempStart, int QuenchTempFinish, string Notes, string ApprovedBy, string SectionSize, string Weight)
        {
            AddMetResponse response = new AddMetResponse(_context, _viewRenderService, DieNo, OrderNo, QuantityRun, TestBars, TotalFurnaceTime, QuenchTempStart, QuenchTempFinish, Notes, ApprovedBy, SectionSize, Weight);
            return Json(response);
        }

        [HttpPost]
        public JsonResult EditMetResult(int RowId, string DieNo, string OrderNo, int QuantityRun, int TestBars, string TotalFurnaceTime, int QuenchTempStart, int QuenchTempFinish, string Notes, string ApprovedBy, string SectionSize, string Weight)
        {
            EditMetResponse response = new EditMetResponse(_context, _viewRenderService, RowId, DieNo, OrderNo, QuantityRun, TestBars, TotalFurnaceTime, QuenchTempStart, QuenchTempFinish, Notes, ApprovedBy, SectionSize, Weight);
            return Json(response);
        }

        [HttpPost]
        public JsonResult AddHtActualResult(string OrderNo, DateTime Date, int NoPcs, string FceNo, string Operation, int Temp, string HoldTime, string CoolRate, string HoldComplete, string Bhn, int QuenchTempStart, int QuenchTempFinish, int QuenchTempRise, string AtTemp)
        {
            AddHtActualResponse response = new AddHtActualResponse(_context, _viewRenderService, OrderNo, Date, NoPcs, FceNo, Operation, Temp, HoldTime, CoolRate, HoldComplete, Bhn, QuenchTempStart, QuenchTempFinish, QuenchTempRise, AtTemp);
            return Json(response);
        }

        [HttpPost]
        public JsonResult EditHtActualResult(int RowId, string OrderNo, DateTime Date, int NoPcs, string FceNo, string Operation, int Temp, string HoldTime, string CoolRate, string HoldComplete, string Bhn, int QuenchTempStart, int QuenchTempFinish, int QuenchTempRise, string AtTemp)
        {
            EditHtActualResponse response = new EditHtActualResponse(_context, _viewRenderService, RowId, OrderNo, Date, NoPcs, FceNo, Operation, Temp, HoldTime, CoolRate, HoldComplete, Bhn, QuenchTempStart, QuenchTempFinish, QuenchTempRise, AtTemp);
            return Json(response);
        }

        [HttpPost]
        public JsonResult AutoCompleteDies(string prefix)
        {
            var dies = (from die in _context.TblDieCard
                         where die.DieNo.StartsWith(prefix.ToUpper())
                         || die.MatL.StartsWith(prefix.ToUpper())
                         select new
                         {
                             label = die.DieNo,
                             val = die.DieNo
                         }).ToList();

            return Json(dies);
        }

        public IActionResult DownloadAction(string id)
        {
            SelectEditHeatResponse response = new SelectEditHeatResponse();
            EditHeatOpViewModel vm = new EditHeatOpViewModel();

            var ID = Convert.ToInt32(id);
            vm.EditOp = _context.TblHtacutal.Where(x => x.RowId == ID).FirstOrDefault();

            FileContentResult result;


            var results = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/MetRecord/EditHeatPartial", vm);
            // Create a PDF from the rendered view content
            byte[] byteArray = Encoding.UTF8.GetBytes(results.Result);
            Aspose.Pdf.Generator.Pdf pdf = new Aspose.Pdf.Generator.Pdf();
            using (MemoryStream ms = new MemoryStream(byteArray))
            {
                //pdf.BindHTML(ms, null);
                HtmlLoadOptions options = new HtmlLoadOptions("https:// En.wikipedia.org/wiki/");


                // Load HTML file
                //Document pdfDocument = new Document(ms, options);

                // Save output as PDF format
                //pdfDocument.Save(outputPath);
                pdf.Save(ms);
                result = new FileContentResult(ms.ToArray(), "application/pdf")
                {
                    FileDownloadName = "x.pdf"
                };

            }

            // Save the PDF to the response stream
            // Save the PDF to the response stream
            //using (MemoryStream ms = new MemoryStream())
            //{
            //    pdf.Save(ms);
            //    result = new FileContentResult(ms.ToArray(), "application/pdf")
            //    {
            //        FileDownloadName = "x"
            //    };
            //}
            return result;
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

            //// note: we only sort one column at a time
            //if (_httpContextAccessor.HttpContext.Request.QueryString.Value.Equals("order[0][column]").ToString() != null)
            //{
            //    sortColumn = int.Parse(_httpContextAccessor.HttpContext.Request.QueryString.Value.Equals("order[0][column]").ToString());
            //}
            //if (_httpContextAccessor.HttpContext.Request.QueryString.Value.Equals("order[0][dir]").ToString() != null)
            //{
            //    sortDirection = _httpContextAccessor.HttpContext.Request.QueryString.Value.Equals("order[0][dir]").ToString();
            //}

            //DataTableData dataTableData = new DataTableData();
            //dataTableData.draw = draw;
            //dataTableData.recordsTotal = TOTAL_ROWS = _context.TblMetRecords.Count();
            //int recordsFiltered = 0;
            //dataTableData.data = FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            //dataTableData.recordsFiltered = recordsFiltered;

            MetRecordDataTableData dataTableData = new MetRecordDataTableData(_context, _viewRenderService, draw, start, length, search, sortColumn, sortDirection);

            return Json(dataTableData.set);
        }

        [HttpPost]
        public ActionResult AjaxGetJsonDataHtActual(int draw, int start, int length)
        {
            int TOTAL_ROWS = 0;
            string search = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "search[value]").FirstOrDefault().Value;
            int sortColumn = Convert.ToInt32(_httpContextAccessor.HttpContext.Request.Query.Where(x => x.Key == "order[0][column]").FirstOrDefault().Value);
            string sortDirection = _httpContextAccessor.HttpContext.Request.Query.Where(x => x.Key == "order[0][dir]").FirstOrDefault().Value;
            string ID = _httpContextAccessor.HttpContext.Request.Form.Where(x => x.Key == "OrderNo").FirstOrDefault().Value;
            if (length == -1)
            {
                length = TOTAL_ROWS;
            }

            //// note: we only sort one column at a time
            //if (_httpContextAccessor.HttpContext.Request.QueryString.Value.Equals("order[0][column]").ToString() != null)
            //{
            //    sortColumn = int.Parse(_httpContextAccessor.HttpContext.Request.QueryString.Value.Equals("order[0][column]").ToString());
            //}
            //if (_httpContextAccessor.HttpContext.Request.QueryString.Value.Equals("order[0][dir]").ToString() != null)
            //{
            //    sortDirection = _httpContextAccessor.HttpContext.Request.QueryString.Value.Equals("order[0][dir]").ToString();
            //}

            //DataTableData dataTableData = new DataTableData();
            //dataTableData.draw = draw;
            //dataTableData.recordsTotal = TOTAL_ROWS = _context.TblMetRecords.Count();
            //int recordsFiltered = 0;
            //dataTableData.data = FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            //dataTableData.recordsFiltered = recordsFiltered;

            HtActualDataTableData dataTableData = new HtActualDataTableData(_context, _viewRenderService, draw, start, length, search, sortColumn, sortDirection, ID);

            return Json(dataTableData.set);
        }

        private const int TOTAL_ROWS = 995;
        private static readonly List<TblMetRecords> _data;

        public class DataItem
        {
            public string Name { get; set; }
            public string Age { get; set; }
            public string DoB { get; set; }
        }

        public class DataTableData
        {
            public int draw { get; set; }
            public int recordsTotal { get; set; }
            public int recordsFiltered { get; set; }
            public List<TblMetRecords> data { get; set; }
        }

        // here we simulate data from a database table.
        // !!!!DO NOT DO THIS IN REAL APPLICATION !!!!
        private static List<DataItem> CreateData()
        {
            Random rnd = new Random();
            List<DataItem> list = new List<DataItem>();
            for (int i = 1; i <= TOTAL_ROWS; i++)
            {
                DataItem item = new DataItem();
                item.Name = "Name_" + i.ToString().PadLeft(5, '0');
                DateTime dob = new DateTime(1900 + rnd.Next(1, 100), rnd.Next(1, 13), rnd.Next(1, 28));
                item.Age = ((DateTime.Now - dob).Days / 365).ToString();
                item.DoB = dob.ToShortDateString();
                list.Add(item);
            }
            return list;
        }

        private int SortString(string s1, string s2, string sortDirection)
        {
            if (s1 == null) { s1 = ""; }
            if (s2 == null) { s2 = ""; }
            return sortDirection == "asc" ? s1.CompareTo(s2) : s2.CompareTo(s1);
        }

        private int SortInteger(string s1, string s2, string sortDirection)
        {
            int i1 = int.Parse(s1);
            int i2 = int.Parse(s2);
            return sortDirection == "asc" ? i1.CompareTo(i2) : i2.CompareTo(i1);
        }

        private int SortDateTime(string s1, string s2, string sortDirection)
        {
            DateTime d1 = DateTime.Parse(s1);
            DateTime d2 = DateTime.Parse(s2);
            return sortDirection == "asc" ? d1.CompareTo(d2) : d2.CompareTo(d1);
        }

        // here we simulate SQL search, sorting and paging operations
        // !!!! DO NOT DO THIS IN REAL APPLICATION !!!!
        private List<TblMetRecords> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<TblMetRecords> list = new List<TblMetRecords>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.TblMetRecords.ToList(); ;
            }
            else
            {
                // simulate search
                foreach (TblMetRecords dataItem in _context.TblMetRecords)
                {
                    //if (propCheckString())
                    //{

                    //}
                    //if ((dataItem.Die != null && dataItem.Die.ToString().Contains(search.ToUpper())))
                    //{
                    //    list.Add(dataItem);
                    //}
                    //else if ((dataItem.Crn != null && dataItem.Crn.ToString().Contains(search.ToUpper())))
                    //{
                    //    list.Add(dataItem);
                    //}
                    //else if ((dataItem.CustPo != null && dataItem.CustPo.ToString().Contains(search.ToUpper())))
                    //{
                    //    list.Add(dataItem);
                    //}
                    //else if ((dataItem.Die != null && dataItem.Die.ToString().Contains(search.ToUpper())))
                    //{
                    //    list.Add(dataItem);
                    //}


                    if ((dataItem.OrderNo != null && dataItem.OrderNo.ToString().Contains(search.ToUpper())) ||
                        (dataItem.DieNo != null && dataItem.DieNo.ToString().Contains(search.ToUpper())) ||
                        (dataItem.TotalFurnaceTime != null && dataItem.TotalFurnaceTime.ToString().Contains(search.ToUpper())) ||
                        (dataItem.ApprovedBy != null && dataItem.ApprovedBy.ToString().Contains(search.ToUpper())))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                list.Sort((x, y) => SortString(x.OrderNo.ToString(), y.OrderNo.ToString(), sortDirection));
            }
            else if (sortColumn == 1)
            {// sort Age
                list.Sort((x, y) => SortString(x.DieNo.ToString(), y.DieNo.ToString(), sortDirection));
            }
            else if (sortColumn == 4)
            {// sort Age
                list.Sort((x, y) => SortInteger(x.TotalFurnaceTime.ToString(), y.TotalFurnaceTime.ToString(), sortDirection));
            }
            else if (sortColumn == 7)
            {// sort Name
                list.Sort((x, y) => SortString(x.ApprovedBy, y.ApprovedBy, sortDirection));
            }

            recordFiltered = list.Count;

            // get just one page of data
            list = list.GetRange(start, Math.Min(length, list.Count - start));

            return list;
        }
        #endregion Api    

    }
}