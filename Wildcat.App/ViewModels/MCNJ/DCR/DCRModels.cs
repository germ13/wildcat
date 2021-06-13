using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wildcat.App.Models;
using Wildcat.Entities.MCNJ.DCR;
using Wildcat.Entities.MCNJ.IDR;
using Wildcat.Logic.MCNJ.DCR;
using Wildcat.Logic.MCNJ.IDR;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.MCNJ.DCR
{
    #region - ViewModels

    public class DCRViewModel
    {
        private DCRContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;

        public List<TblDcr> DCR { get; set; }
        public TblDcr AddDCR { get; set; }
        public TblDcr EditDCR { get; set; }
        public List<SelectListItem> RequestedBy { get; set; }
        public List<SelectListItem> Units { get; set; }
        public List<SelectListItem> Approvals { get; set; }

        public DCRViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, DCRContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;

            RequestedBy = new List<SelectListItem>();
            Units = new List<SelectListItem>();
            Approvals = new List<SelectListItem>();

            foreach (var i in _context.TblInitiatorNames)
            {
                RequestedBy.Add(new SelectListItem(i.Names, i.Names));
            }

            foreach (var i in _context.TblUnit)
            {
                Units.Add(new SelectListItem(i.Sphammer, i.Sphammer));
            }

            foreach (var i in _context.TblEngineeringNames)
            {
                Approvals.Add(new SelectListItem(i.Names, i.Names));
            }

            DCR = new List<TblDcr>();
            AddDCR = new TblDcr { RequestedBy = _httpContextAccessor.HttpContext.User.Identity.Name, RequestedDate = DateTime.UtcNow.Date };
            EditDCR = new TblDcr();
        }
    }

    public class EditDCRViewModel
    {
        private DCRContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;   

        public TblDcr EditDCR { get; set; }
        public List<SelectListItem> RequestedBy { get; set; }
        public List<SelectListItem> Units { get; set; }
        public List<SelectListItem> Approvals { get; set; }

        public EditDCRViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, DCRContext context, string ID)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;

            EditDCR = _context.TblDcr.Where(x => x.Dcrnumber == Convert.ToInt32(ID)).FirstOrDefault();

            RequestedBy = new List<SelectListItem>();
            Units = new List<SelectListItem>();
            Approvals = new List<SelectListItem>();

            foreach (var i in _context.TblInitiatorNames)
            {
                RequestedBy.Add(new SelectListItem(i.Names, i.Names, i.Names == EditDCR.RequestedBy ? true : false));
            }

            foreach (var i in _context.TblUnit)
            {
                Units.Add(new SelectListItem(i.Sphammer, i.Sphammer, i.Sphammer == EditDCR.Unit ? true : false));
            }

            foreach (var i in _context.TblEngineeringNames)
            {
                Approvals.Add(new SelectListItem(i.Names, i.Names, i.Names == EditDCR.EngApprovalSignature ? true : false));
            }

        }
    }

    public class DCRReportsViewModel
    {
        private DCRContext _context;
        private IViewRenderService _viewRenderService;
        private IHttpContextAccessor _httpContextAccessor;

        public List<TblDcr> DCR { get; set; }
        public TblDcr AddDCR { get; set; }
        public TblDcr EditDCR { get; set; }
        public List<SelectListItem> RequestedBy { get; set; }
        public List<SelectListItem> Units { get; set; }
        public List<SelectListItem> Approvals { get; set; }
        public List<SelectListItem> Reports { get; set; }

        public string ToolNumber { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public string SelectedReportType { get; set; }

        public DCRReportsViewModel(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, DCRContext context)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _context = context;

            RequestedBy = new List<SelectListItem>();
            Units = new List<SelectListItem>();
            Approvals = new List<SelectListItem>();
            Reports = new List<SelectListItem>();

            foreach (var i in _context.TblInitiatorNames)
            {
                RequestedBy.Add(new SelectListItem(i.Names, i.Names));
            }

            foreach (var i in _context.TblUnit)
            {
                Units.Add(new SelectListItem(i.Sphammer, i.Sphammer));
            }

            foreach (var i in _context.TblEngineeringNames)
            {
                Approvals.Add(new SelectListItem(i.Names, i.Names));
            }

            Reports.Add(new SelectListItem("", "", true));
            Reports.Add(new SelectListItem(DCRReportTypes.ReportType1.ToString(), DCRReportTypes.ReportType1, false));
            Reports.Add(new SelectListItem(DCRReportTypes.ReportType2.ToString(), DCRReportTypes.ReportType2, false));
            Reports.Add(new SelectListItem(DCRReportTypes.ReportType3.ToString(), DCRReportTypes.ReportType3, false));
            Reports.Add(new SelectListItem(DCRReportTypes.ReportType4.ToString(), DCRReportTypes.ReportType4, false));
            Reports.Add(new SelectListItem(DCRReportTypes.ReportType5.ToString(), DCRReportTypes.ReportType5, false));
            Reports.Add(new SelectListItem(DCRReportTypes.ReportType6.ToString(), DCRReportTypes.ReportType6, false));
            Reports.Add(new SelectListItem(DCRReportTypes.ReportType7.ToString(), DCRReportTypes.ReportType7, false));
            Reports.Add(new SelectListItem(DCRReportTypes.ReportType8.ToString(), DCRReportTypes.ReportType8, false));

            DCR = new List<TblDcr>();
            AddDCR = new TblDcr { RequestedBy = _httpContextAccessor.HttpContext.User.Identity.Name, RequestedDate = DateTime.UtcNow.Date };
            EditDCR = new TblDcr();
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

    public static class DCRReportTypes
    {
        public const string
            ReportType1 = "All Open DCRs (short)",
            ReportType2 = "All Open DCRs (full)",
            ReportType3 = "Eng Approval(short)",
            ReportType4 = "Eng Approval (full)",
            ReportType5 = "Die Shop Work List (short)",
            ReportType6 = "Die Shop Work List (full)",
            ReportType7 = "Closed DCRs",
            ReportType8 = "Complete Tool History";
    }

    public class GetSelectedReportsResponse : Response
    {
        public TblDcr Dcr { get; set; }
        public Task<string> Form { get; set; }

        public GetSelectedReportsResponse(DCRContext context, IViewRenderService viewRenderService, string ReportType, string ToolNumber, DateTime? StartDate, DateTime? EndDate)
        {
            try
            {
                List<TblDcr> DCRs = new List<TblDcr>();

                switch (ReportType)
                {
                    case DCRReportTypes.ReportType1:
                        DCRs = context.TblDcr.Where(x => x.ToolsChangedYesOrNo == null).ToList();
                        break;
                    case DCRReportTypes.ReportType2:
                        DCRs = context.TblDcr.Where(x => x.ToolsChangedYesOrNo == null).ToList();
                        break;
                    case DCRReportTypes.ReportType3:
                        DCRs = context.TblDcr.Where(x => x.EngApproval == null).ToList();
                        break;
                    case DCRReportTypes.ReportType4:
                        DCRs = context.TblDcr.Where(x => x.EngApproval == null).ToList();
                        break;
                    case DCRReportTypes.ReportType5:
                        DCRs = context.TblDcr.Where(x => x.EngApproval != null && x.ToolsChangedYesOrNo == null).ToList();
                        break;
                    case DCRReportTypes.ReportType6:
                        DCRs = context.TblDcr.Where(x => x.EngApproval != null && x.ToolsChangedYesOrNo == null).ToList();
                        break;
                    case DCRReportTypes.ReportType7:
                        DCRs = context.TblDcr.Where(x => x.DieShopSignatureDate >= (StartDate == null ? DateTime.Now.AddYears(-50) : StartDate) && x.DieShopSignatureDate <= (EndDate == null ? DateTime.Now : EndDate)).ToList();
                        break;
                    case DCRReportTypes.ReportType8:
                        DCRs = context.TblDcr.Where(x => x.ToolNumber.Contains(ToolNumber)).ToList();
                        break;
                    default:
                        DCRs = new List<TblDcr>();
                        break;
                }

                Form = viewRenderService.RenderToStringAsync("MCNJ/DCR/DieChangeReports/ReportsPartial", DCRs);
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
        public TblDcr Dcr { get; set; }
        public AddResponse(DCRContext context, IViewRenderService viewRenderService, int Dcrnumber, string ToolNumber, string Unit, string EngApproval, string EngApprovalSignature, DateTime? EngApprovalDate, string DateRequired, string HoldProductionYesOrNo, string ToolsChangedYesOrNo, string DieShopSignature, DateTime? DieShopSignatureDate, string Reason, string Description, string RequestedBy, DateTime? RequestedDate)
        {
            try
            {
                MCNJ_DCR logic = new MCNJ_DCR(context, viewRenderService);

                var result = logic.AddDcr(Dcrnumber, ToolNumber, Unit, EngApproval, EngApprovalSignature, EngApprovalDate, DateRequired, HoldProductionYesOrNo, ToolsChangedYesOrNo, DieShopSignature, DieShopSignatureDate, Reason, Description, RequestedBy, RequestedDate);

                success = true;
                message = "DCR: " + result.Dcrnumber + " added.";
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
        public EditResponse(DCRContext context, IViewRenderService viewRenderService, int Dcrnumber, string ToolNumber, string Unit, string EngApproval, string EngApprovalSignature, DateTime? EngApprovalDate, string DateRequired, string HoldProductionYesOrNo, string ToolsChangedYesOrNo, string DieShopSignature, DateTime? DieShopSignatureDate, string Reason, string Description, string RequestedBy, DateTime? RequestedDate)
        {
            try
            {
                MCNJ_DCR logic = new MCNJ_DCR(context, viewRenderService);

                var result = logic.EditDcr(Dcrnumber, ToolNumber, Unit, EngApproval, EngApprovalSignature, EngApprovalDate, DateRequired, HoldProductionYesOrNo, ToolsChangedYesOrNo, DieShopSignature, DieShopSignatureDate, Reason, Description, RequestedBy, RequestedDate);

                success = true;
                message = "DCR: " + result.Dcrnumber + " edited.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class DCRDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<TblDcr> data { get; set; }

        public DCRDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<TblDcr>();
        }

    }

    public class DCRReportDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<TblDcr> data { get; set; }

        public DCRReportDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<TblDcr>();
        }

    }

    #endregion - Models



    #region - Api

    public class SelectEditRequestResponse : Response
    {
        public Task<string> Form { get; set; }
    }

    public class DCRDataTableData
    {
        public DCRDataSet set;
        public DCRDataTableData(DCRContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new DCRDataSet();

            MCNJ_DCR dcr = new MCNJ_DCR(context, viewRenderService);

            set.draw = draw;
            set.data = dcr.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    public class DCRReportsDataTableData
    {
        public DCRDataSet set;
        public DCRReportsDataTableData(DCRContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new DCRDataSet();

            MCNJ_DCR dcr = new MCNJ_DCR(context, viewRenderService);

            set.draw = draw;
            set.data = dcr.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Api
}
