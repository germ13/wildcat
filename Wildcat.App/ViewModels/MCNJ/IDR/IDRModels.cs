using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wildcat.App.Models;
using Wildcat.Entities.MCNJ.IDR;
using Wildcat.Entities.MCNJ.IDR;
using Wildcat.Logic.MCNJ.IDR;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.MCNJ.IDR
{
    #region - ViewModels

    public class IDRViewModel
    {
        private IDRContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;

        public List<TblIdrdata> IDR { get; set; }
        public TblIdrdata AddIDR { get; set; }
        public TblIdrdata EditIDR { get; set; }
        public List<SelectListItem> Customers { get; set; }
        public List<SelectListItem> DiscrepancyTypes { get; set; }
        public List<SelectListItem> Discrepancy2TypeList { get; set; }
        public List<SelectListItem> PredispositionStatus { get; set; }
        public List<SelectListItem> FinalDisposition { get; set; }

        public IDRViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, IDRContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;

            Customers = new List<SelectListItem>();
            DiscrepancyTypes = new List<SelectListItem>();
            Discrepancy2TypeList = new List<SelectListItem>();
            PredispositionStatus = new List<SelectListItem>();
            FinalDisposition = new List<SelectListItem>();

            foreach (var i in _context.TblCustomerNames)
            {
                Customers.Add(new SelectListItem(i.CustomerName, i.CustomerName));
            }

            foreach (var i in _context.TblDiscrepancyTypes)
            {
                DiscrepancyTypes.Add(new SelectListItem(i.DiscrepancyTypes, i.DiscrepancyTypes));
            }

            foreach (var i in _context.TblPreDispositionStatus)
            {
                PredispositionStatus.Add(new SelectListItem(i.PreDispositionStatus, i.PreDispositionStatus));
            }

            Discrepancy2TypeList.Add(new SelectListItem(Discrepancy2Types.Discrepancy2Type1, Discrepancy2Types.Discrepancy2Type1, false));
            Discrepancy2TypeList.Add(new SelectListItem(Discrepancy2Types.Discrepancy2Type2, Discrepancy2Types.Discrepancy2Type2, false));
            Discrepancy2TypeList.Add(new SelectListItem(Discrepancy2Types.Discrepancy2Type3, Discrepancy2Types.Discrepancy2Type3, false));

            FinalDisposition.Add(new SelectListItem("", "", true));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType1, FinalDispositionTypes.FinalDispositionType1, false));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType2, FinalDispositionTypes.FinalDispositionType2, false));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType3, FinalDispositionTypes.FinalDispositionType3, false));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType4, FinalDispositionTypes.FinalDispositionType4, false));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType5, FinalDispositionTypes.FinalDispositionType5, false));

            IDR = new List<TblIdrdata>();
            AddIDR = new TblIdrdata();
            EditIDR = new TblIdrdata();
        }
    }

    public class EditIDRViewModel
    {
        private IDRContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;   

        public TblIdrdata EditIDR { get; set; }
        public List<SelectListItem> Customers { get; set; }
        public List<SelectListItem> DiscrepancyTypes { get; set; }
        public List<SelectListItem> Discrepancy2TypeList { get; set; }
        public List<SelectListItem> PredispositionStatus { get; set; }
        public List<SelectListItem> FinalDisposition { get; set; }

        public EditIDRViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, IDRContext context, string ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;

            Customers = new List<SelectListItem>();
            DiscrepancyTypes = new List<SelectListItem>();
            Discrepancy2TypeList = new List<SelectListItem>();
            PredispositionStatus = new List<SelectListItem>();
            FinalDisposition = new List<SelectListItem>();

            EditIDR = _context.TblIdrdata.Where(x => x.Idrnumber == Convert.ToInt32(ID)).FirstOrDefault();

            foreach (var i in _context.TblCustomerNames)
            {
                Customers.Add(new SelectListItem(i.CustomerName, i.CustomerName, i.CustomerName == EditIDR.Customer));
            }

            foreach (var i in _context.TblDiscrepancyTypes)
            {
                DiscrepancyTypes.Add(new SelectListItem(i.DiscrepancyTypes, i.DiscrepancyTypes, i.DiscrepancyTypes == EditIDR.DiscrepancyType1));
            }

            foreach (var i in _context.TblPreDispositionStatus)
            {
                PredispositionStatus.Add(new SelectListItem(i.PreDispositionStatus, i.PreDispositionStatus, i.PreDispositionStatus == EditIDR.PreDispositionStatus));
            }

            Discrepancy2TypeList.Add(new SelectListItem(Discrepancy2Types.Discrepancy2Type1, Discrepancy2Types.Discrepancy2Type1, EditIDR.DiscrepancyType2 == Discrepancy2Types.Discrepancy2Type1));
            Discrepancy2TypeList.Add(new SelectListItem(Discrepancy2Types.Discrepancy2Type2, Discrepancy2Types.Discrepancy2Type2, EditIDR.DiscrepancyType2 == Discrepancy2Types.Discrepancy2Type2));
            Discrepancy2TypeList.Add(new SelectListItem(Discrepancy2Types.Discrepancy2Type3, Discrepancy2Types.Discrepancy2Type3, EditIDR.DiscrepancyType2 == Discrepancy2Types.Discrepancy2Type3));

            FinalDisposition.Add(new SelectListItem("", "", true));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType1, FinalDispositionTypes.FinalDispositionType1, EditIDR.FinalDisposition == FinalDispositionTypes.FinalDispositionType1));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType2, FinalDispositionTypes.FinalDispositionType2, EditIDR.FinalDisposition == FinalDispositionTypes.FinalDispositionType2));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType3, FinalDispositionTypes.FinalDispositionType3, EditIDR.FinalDisposition == FinalDispositionTypes.FinalDispositionType3));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType4, FinalDispositionTypes.FinalDispositionType4, EditIDR.FinalDisposition == FinalDispositionTypes.FinalDispositionType4));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType5, FinalDispositionTypes.FinalDispositionType5, EditIDR.FinalDisposition == FinalDispositionTypes.FinalDispositionType5));
        }
    }

    public class IDRReportsViewModel
    {
        private IDRContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;

        public List<TblIdrdata> IDR { get; set; }
        public TblIdrdata AddIDR { get; set; }
        public TblIdrdata EditIDR { get; set; }

        public List<SelectListItem> Reports { get; set; }
        public List<SelectListItem> Customers { get; set; }
        public List<SelectListItem> DiscrepancyTypes { get; set; }
        public List<SelectListItem> Discrepancy2TypeList { get; set; }
        public List<SelectListItem> PredispositionStatus { get; set; }
        public List<SelectListItem> FinalDisposition { get; set; }

        public string ToolNumber { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public string SelectedReportType { get; set; }

        public IDRReportsViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, IDRContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;

            Reports = new List<SelectListItem>();
            Customers = new List<SelectListItem>();
            DiscrepancyTypes = new List<SelectListItem>();
            Discrepancy2TypeList = new List<SelectListItem>();
            PredispositionStatus = new List<SelectListItem>();
            FinalDisposition = new List<SelectListItem>();

            Reports.Add(new SelectListItem("", "", true));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType1, IDRReportTypes.ReportType1, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType2, IDRReportTypes.ReportType2, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType3, IDRReportTypes.ReportType3, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType4, IDRReportTypes.ReportType4, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType6, IDRReportTypes.ReportType6, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType7, IDRReportTypes.ReportType7, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType8, IDRReportTypes.ReportType8, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType9, IDRReportTypes.ReportType9, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType10, IDRReportTypes.ReportType10, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType11, IDRReportTypes.ReportType11, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType12, IDRReportTypes.ReportType12, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType13, IDRReportTypes.ReportType13, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType14, IDRReportTypes.ReportType14, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType15, IDRReportTypes.ReportType15, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType16, IDRReportTypes.ReportType16, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType17, IDRReportTypes.ReportType17, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType18, IDRReportTypes.ReportType18, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType19, IDRReportTypes.ReportType19, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType20, IDRReportTypes.ReportType20, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType21, IDRReportTypes.ReportType21, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType22, IDRReportTypes.ReportType22, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType23, IDRReportTypes.ReportType23, false));
            Reports.Add(new SelectListItem(IDRReportTypes.ReportType24, IDRReportTypes.ReportType24, false));

            foreach (var i in _context.TblCustomerNames)
            {
                Customers.Add(new SelectListItem(i.CustomerName, i.CustomerName));
            }

            foreach (var i in _context.TblDiscrepancyTypes)
            {
                DiscrepancyTypes.Add(new SelectListItem(i.DiscrepancyTypes, i.DiscrepancyTypes));
            }

            foreach (var i in _context.TblPreDispositionStatus)
            {
                PredispositionStatus.Add(new SelectListItem(i.PreDispositionStatus, i.PreDispositionStatus));
            }

            Discrepancy2TypeList.Add(new SelectListItem(Discrepancy2Types.Discrepancy2Type1, Discrepancy2Types.Discrepancy2Type1, false));
            Discrepancy2TypeList.Add(new SelectListItem(Discrepancy2Types.Discrepancy2Type2, Discrepancy2Types.Discrepancy2Type2, false));
            Discrepancy2TypeList.Add(new SelectListItem(Discrepancy2Types.Discrepancy2Type3, Discrepancy2Types.Discrepancy2Type3, false));

            FinalDisposition.Add(new SelectListItem("", "", true));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType1, FinalDispositionTypes.FinalDispositionType1, false));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType2, FinalDispositionTypes.FinalDispositionType2, false));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType3, FinalDispositionTypes.FinalDispositionType3, false));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType4, FinalDispositionTypes.FinalDispositionType4, false));
            FinalDisposition.Add(new SelectListItem(FinalDispositionTypes.FinalDispositionType5, FinalDispositionTypes.FinalDispositionType5, false));

            IDR = new List<TblIdrdata>();
            AddIDR = new TblIdrdata();
            EditIDR = new TblIdrdata();
        }
    }

    #endregion - ViewModels



    #region - Models

    public class ReportTypes
    {
        public int Value { get; set; }
        public string Text { get; set; }
        public ReportTypes(int _value, string _Text)
        {
            Value = _value;
            Text = _Text;
        }
    }

    public static class IDRReportTypes
    {
        public const string
            ReportType1 = "All Open IDRs",
            ReportType2 = "Open IDRs By Die Number",
            ReportType3 = "Open IDRs By Work Order",
            ReportType4 = "Closed IDRs By Work Order",
            ReportType5 = "Open IDRs By Customer Name",
            ReportType6 = "Closed IDRs By Customer Name",
            ReportType7 = "Open/Closed IDRs By Date",
            ReportType8 = "Closed IDRs By Date Report",
            ReportType9 = "Complete Die History",
            ReportType10 = "Scrap Cost Analysis",
            ReportType11 = "Rework Cost Analysis",
            ReportType12 = "Open IDRs By Discrepancy",
            ReportType13 = "No Demand",
            ReportType14 = "Engineering Review",
            ReportType15 = "Rework Report",
            ReportType16 = "Retest Report",
            ReportType17 = "Fixed Process Report",
            ReportType18 = "IDR Cost Report",
            ReportType19 = "Pending Customer Submits (short)",
            ReportType20 = "Pending Customer Submits (full)",
            ReportType21 = "Closed IDRs By Die and Date Range",
            ReportType22 = "IDRs To Be Costed (short)",
            ReportType23 = "IDRs To Be Costed (full)",
            ReportType24 = "All IDRs";

    }

    public static class FinalDispositionTypes
    {
        public const string
            FinalDispositionType1 = "ACCEPTABLE",
            FinalDispositionType2 = "USE AS IS",
            FinalDispositionType3 = "SCRAP",
            FinalDispositionType4 = "COMB USE AS IS/SCRAP",
            FinalDispositionType5 = "INFORMATION ONLY";
    }

    public static class Discrepancy2Types
    {
        public const string
            Discrepancy2Type1 = "INTERNAL",
            Discrepancy2Type2 = "VENDOR",
            Discrepancy2Type3 = "CUSTOMER";
    }

    public class GetSelectedReportsResponse : Response
    {
        public TblIdrdata IDR { get; set; }
        public Task<string> Form { get; set; }

        public GetSelectedReportsResponse(IDRContext context, IViewRenderService viewRenderService, string ReportType, string ToolNumber, DateTime? StartDate, DateTime? EndDate)
        {
            try
            {
                List<TblIdrdata> IDRs = new List<TblIdrdata>();

                //switch (ReportType)
                //{
                //    case IDRReportTypes.ReportType1:
                //        IDRs = context.TblIdrdata.Where(x => x.ToolsChangedYesOrNo == null).ToList();
                //        break;
                //    case IDRReportTypes.ReportType2:
                //        IDRs = context.TblIdrdata.Where(x => x.ToolsChangedYesOrNo == null).ToList();
                //        break;
                //    case IDRReportTypes.ReportType3:
                //        IDRs = context.TblIdrdata.Where(x => x.EngApproval == null).ToList();
                //        break;
                //    case IDRReportTypes.ReportType4:
                //        IDRs = context.TblIdrdata.Where(x => x.EngApproval == null).ToList();
                //        break;
                //    case IDRReportTypes.ReportType5:
                //        IDRs = context.TblIdrdata.Where(x => x.EngApproval != null && x.ToolsChangedYesOrNo == null).ToList();
                //        break;
                //    case IDRReportTypes.ReportType6:
                //        IDRs = context.TblIdrdata.Where(x => x.EngApproval != null && x.ToolsChangedYesOrNo == null).ToList();
                //        break;
                //    case IDRReportTypes.ReportType7:
                //        IDRs = context.TblIdrdata.Where(x => x.DieShopSignatureDate >= (StartDate == null ? DateTime.Now.AddYears(-50) : StartDate) && x.DieShopSignatureDate <= (EndDate == null ? DateTime.Now : EndDate)).ToList();
                //        break;
                //    case IDRReportTypes.ReportType8:
                //        IDRs = context.TblIdrdata.Where(x => x.ToolNumber.Contains(ToolNumber)).ToList();
                //        break;
                //    default:
                //        IDRs = new List<TblIDR>();
                //        break;
                //}

                Form = viewRenderService.RenderToStringAsync("MCNJ/IDR/MCNJ_IDRReports/ReportsPartial", IDRs);
                success = true;
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class AddResponse : Response
    {
        public TblIdrdata IDR { get; set; }
        public AddResponse(IDRContext context, IViewRenderService viewRenderService, int Idrnumber, string Initiator, string Operation, string Customer, string HeatCode, DateTime? Date, string DieNumber, string WorkOrderNumber, double? WorkOrderQuantity,
            double? DiscrepantQuantity, string SerialNumbers, string Required, string Actual, string DiscrepancyType1, string DiscrepancyType2, string PreDispositionStatus, string PreDispositionStatusNotes,
            double? ReworkQuantity, DateTime? MrbsubmittalDate, string MrbsubmittalNumber, double? MrbsubmittalQuantity, DateTime? MrbdispositionDate, double? FinalAcceptedQuantity, double? FinalRejectedQuantity,
            string FinalDisposition, string FinalDispositionBy, DateTime? FinalDispositionDate, string FinalDispositionSummary, string FinalDispositionSpecialHandlingInstructions, decimal? UnitCost, decimal? MaterialCost,
            decimal? LaborOverheadCost, decimal? UnitSellPrice, decimal? ReworkCost, decimal? RetestCost, decimal? ReplacementTestCost, decimal? AdditionalTestForInfo, decimal? ScrapCost, decimal? SubmittalCost, decimal? DollarsSubmitted,
            decimal? Idrcost, decimal? LostSales, decimal? TotalIdrcost)
        {
            try
            {
                MCNJ_IDR logic = new MCNJ_IDR(context, viewRenderService);

                var result = logic.AddIDR(Idrnumber, Initiator, Operation, Customer, HeatCode, Date, DieNumber, WorkOrderNumber, WorkOrderQuantity,
                DiscrepantQuantity, SerialNumbers, Required, Actual, DiscrepancyType1, DiscrepancyType2, PreDispositionStatus, PreDispositionStatusNotes,
                ReworkQuantity, MrbsubmittalDate, MrbsubmittalNumber, MrbsubmittalQuantity, MrbdispositionDate, FinalAcceptedQuantity, FinalRejectedQuantity,
                FinalDisposition, FinalDispositionBy, FinalDispositionDate, FinalDispositionSummary, FinalDispositionSpecialHandlingInstructions, UnitCost, MaterialCost,
                LaborOverheadCost, UnitSellPrice, ReworkCost, RetestCost, ReplacementTestCost, AdditionalTestForInfo, ScrapCost, SubmittalCost, DollarsSubmitted,
                Idrcost, LostSales, TotalIdrcost);

                success = true;
                message = "IDR: " + result.Idrnumber + " added.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditResponse : Response
    {
        public EditResponse(IDRContext context, IViewRenderService viewRenderService, int Idrnumber, string Initiator, string Operation, string Customer, string HeatCode, DateTime? Date, string DieNumber, string WorkOrderNumber, double? WorkOrderQuantity,
            double? DiscrepantQuantity, string SerialNumbers, string Required, string Actual, string DiscrepancyType1, string DiscrepancyType2, string PreDispositionStatus, string PreDispositionStatusNotes,
            double? ReworkQuantity, DateTime? MrbsubmittalDate, string MrbsubmittalNumber, double? MrbsubmittalQuantity, DateTime? MrbdispositionDate, double? FinalAcceptedQuantity, double? FinalRejectedQuantity,
            string FinalDisposition, string FinalDispositionBy, DateTime? FinalDispositionDate, string FinalDispositionSummary, string FinalDispositionSpecialHandlingInstructions, decimal? UnitCost, decimal? MaterialCost,
            decimal? LaborOverheadCost, decimal? UnitSellPrice, decimal? ReworkCost, decimal? RetestCost, decimal? ReplacementTestCost, decimal? AdditionalTestForInfo, decimal? ScrapCost, decimal? SubmittalCost, decimal? DollarsSubmitted,
            decimal? Idrcost, decimal? LostSales, decimal? TotalIdrcost)
        {
            try
            {
                MCNJ_IDR logic = new MCNJ_IDR(context, viewRenderService);

                var result = logic.EditIDR(Idrnumber, Initiator, Operation, Customer, HeatCode, Date, DieNumber, WorkOrderNumber, WorkOrderQuantity,
                DiscrepantQuantity, SerialNumbers, Required, Actual, DiscrepancyType1, DiscrepancyType2, PreDispositionStatus, PreDispositionStatusNotes,
                ReworkQuantity, MrbsubmittalDate, MrbsubmittalNumber, MrbsubmittalQuantity, MrbdispositionDate, FinalAcceptedQuantity, FinalRejectedQuantity,
                FinalDisposition, FinalDispositionBy, FinalDispositionDate, FinalDispositionSummary, FinalDispositionSpecialHandlingInstructions, UnitCost, MaterialCost,
                LaborOverheadCost, UnitSellPrice, ReworkCost, RetestCost, ReplacementTestCost, AdditionalTestForInfo, ScrapCost, SubmittalCost, DollarsSubmitted,
                Idrcost, LostSales, TotalIdrcost);

                success = true;
                message = "IDR: " + result.Idrnumber + " edited.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class IDRDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<TblIdrdata> data { get; set; }

        public IDRDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<TblIdrdata>();
        }

    }

    public class IDRReportDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<TblIdrdata> data { get; set; }

        public IDRReportDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<TblIdrdata>();
        }

    }

    #endregion - Models



    #region - Api

    public class SelectEditRequestResponse : Response
    {
        public Task<string> Form { get; set; }
    }

    public class IDRDataTableData
    {
        public IDRDataSet set;
        public IDRDataTableData(IDRContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new IDRDataSet();

            MCNJ_IDR IDR = new MCNJ_IDR(context, viewRenderService);

            set.draw = draw;
            set.data = IDR.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    public class IDRReportsDataTableData
    {
        public IDRDataSet set;
        public IDRReportsDataTableData(IDRContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new IDRDataSet();

            MCNJ_IDR IDR = new MCNJ_IDR(context, viewRenderService);

            set.draw = draw;
            set.data = IDR.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Api
}
