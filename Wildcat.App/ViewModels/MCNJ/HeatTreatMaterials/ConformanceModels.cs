using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wildcat.App.Models;
using Wildcat.Entities.MCNJ.HeatsSecured;
using Wildcat.Logic.MCNJ.HeatTreatMaterials;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.MCNJ.HeatTreatMaterials
{
    #region - ViewModels

    public class ConformanceCertsViewModel
    {
        public List<CertsMcW> Certs { get; set; }
        public ConformanceCertsViewModel()
        {
            Certs = new List<CertsMcW>();
        }
    }

    public class AddConformanceCertsViewModel
    {
        public CertsMcW Cert { get; set; }
        public List<TblDieWoqtyHt> TblDieWoqtyHts { get; set; }
        public TblDieWoqtyHt NewTblDieWoqtyHt { get; set; }
        public TblDieWoqtyHt EditTblDieWoqtyHt { get; set; }
        public CertsMill Mill { get; set; }
        public Dies Die { get; set; }
        public bool DisplayQty { get; set; }
        public string Disclaimer { get; set; }
        public List<SelectListItem> Disclaimers { get; set; }
        public AddConformanceCertsViewModel(HeatsSecuredContext context, IViewRenderService viewRenderService)
        {
            Cert = new CertsMcW(); Disclaimers = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();
            TblDieWoqtyHts = new List<TblDieWoqtyHt>();
            NewTblDieWoqtyHt = new TblDieWoqtyHt();
            Die = new Wildcat.Entities.MCNJ.HeatsSecured.Dies();
            Mill = new CertsMill();
            EditTblDieWoqtyHt = new TblDieWoqtyHt();
            Disclaimers = new List<SelectListItem>();

            foreach (var doctype in context.TblDisclamerNote)
            {
                Disclaimers.Add(new SelectListItem
                {
                    Text = doctype.NoteType,
                    Value = doctype.NoteType
                });
            }
        }
    }

    public class EditConformanceCertsViewModel
    {
        public CertsMcW Cert { get; set; }
        public List<TblDieWoqtyHt> TblDieWoqtyHts { get; set; }
        public TblDieWoqtyHt NewTblDieWoqtyHt { get; set; }
        public TblDieWoqtyHt EditTblDieWoqtyHt { get; set; }
        public CertsMill Mill { get; set; }
        public Dies Die { get; set; }
        public bool DisplayQty { get; set; }
        public string Disclaimer { get; set; }
        public List<SelectListItem> Disclaimers { get; set; }
        public EditConformanceCertsViewModel(HeatsSecuredContext _context, IViewRenderService viewRenderService, string id)
        {
            var ID = Convert.ToInt32(id);
            Cert = _context.CertsMcW.Where(x => x.McWCn == ID).FirstOrDefault(); Disclaimers = new List<Microsoft.AspNetCore.Mvc.Rendering.SelectListItem>();
            TblDieWoqtyHts = new List<TblDieWoqtyHt>(); TblDieWoqtyHts = _context.TblDieWoqtyHt.Where(x => x.Crn == Cert.Crn && x.ProcessNo == Cert.Die).ToList();
            NewTblDieWoqtyHt = new TblDieWoqtyHt();
            NewTblDieWoqtyHt.ProcessNo = Cert.Die;
            NewTblDieWoqtyHt.Crn = Cert.Crn;
            EditTblDieWoqtyHt = new TblDieWoqtyHt();
            Disclaimers = new List<SelectListItem>();

            Die = _context.Dies.Where(x => x.Die == Cert.Die).FirstOrDefault();

            Mill = new CertsMill(); Mill = _context.CertsMill.Where(x => x.Crn == Cert.Crn).FirstOrDefault();

            foreach (var doctype in _context.TblDisclamerNote)
            {
                Disclaimers.Add(new SelectListItem
                {
                    Text = doctype.NoteType,
                    Value = doctype.NoteType,
                    Selected = (doctype.NoteType == Cert.NoteType) ? true : false
                });
            }
        }
    }

    public class EditDieCardsHeatOpViewModel
    {
        public TblDieWoqtyHt EditTblDieWoqtyHt { get; set; }
    }

    public class SelectEditHeatResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public SelectEditHeatResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, string ID)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var id = Convert.ToInt32(ID);
                var res = context.TblDieWoqtyHt.Where(x => x.RowId == id).FirstOrDefault();

                Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatMaterials/Conformance/EditHeatPartial", res);

                success = true;
                message = "Heat op edited successfully.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    #endregion - ViewModels


    #region - Models

    public class AddConfResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public int CrnResult { get; set; }
        public string DieNum { get; set; }
        public Task<string> FormTable { get; set; }
        public AddConfResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, int McWCn, int? Crn, DateTime? Date, int? CustId, string CustPo, string Heat, string GsMcW, string Hardness, string HeatTreatNotes, string CertificationNotes, string ProcessNo, string NoteType, int? QtyShipped, string Die, string WorkOrder, string requestor)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var operation = HeatTreatMaterials_ConformanceClass.Add(context, viewRenderService, McWCn, Crn, Date, CustId, CustPo, Heat, GsMcW, Hardness, HeatTreatNotes, CertificationNotes, ProcessNo, NoteType, QtyShipped, Die, WorkOrder, requestor);
                DieNum = operation.ProcessNo;
                CrnResult = operation.Crn.Value;
                success = true;
                message = "Heat op added successfully.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditConfResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public int CrnResult { get; set; }
        public string DieNum { get; set; }
        public Task<string> FormTable { get; set; }
        public EditConfResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, int McWCn, int? Crn, DateTime? Date, int? CustId, string CustPo, string Heat, string GsMcW, string Hardness, string HeatTreatNotes, string CertificationNotes, string ProcessNo, string NoteType, int? QtyShipped, string Die, string WorkOrder, string requestor)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var op = HeatTreatMaterials_ConformanceClass.Edit(context, viewRenderService, McWCn, Crn, Date, CustId, CustPo, Heat, GsMcW, Hardness, HeatTreatNotes, CertificationNotes, ProcessNo, NoteType, QtyShipped, Die, WorkOrder, requestor);
                DieNum = op.ProcessNo;
                CrnResult = op.Crn.Value;

                var ops = HeatTreatMaterials_ConformanceClass.GetOps(context, viewRenderService, Crn, ProcessNo, requestor);
                FormTable = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatMaterials/Conformance/HeatOperationsPartial", ops);

                success = true;
                message = "Heat op edited successfully.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class AddConfOpResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public int CrnResult { get; set; }
        public string DieNum { get; set; }
        public Task<string> FormTable { get; set; }
        public AddConfOpResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, int? ControlNo, int? Crn, string ProcessNo, string WorkOrder, string Woqty, string McwHtCodes, int RowId, string requestor)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var op = HeatTreatMaterials_ConformanceClass.AddOp(context, viewRenderService, ControlNo, Crn, ProcessNo, WorkOrder, Woqty, McwHtCodes, RowId, requestor);
                DieNum = op.ProcessNo;
                CrnResult = op.Crn.Value;

                var ops = HeatTreatMaterials_ConformanceClass.GetOps(context, viewRenderService, Crn, ProcessNo, requestor);
                FormTable = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatMaterials/Conformance/HeatOperationsPartial", ops);

                //FormTable = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatMaterials/Conformance/HeatOperationsPartial", op);

                success = true;
                message = "Die added successful.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditConfOpResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> FormHt { get; set; }
        public Task<string> FormTable { get; set; }
        public EditConfOpResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, int? ControlNo, int? Crn, string ProcessNo, string WorkOrder, string Woqty, string McwHtCodes, int RowId, string requestor)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var op = HeatTreatMaterials_ConformanceClass.EditOp(context, viewRenderService, ControlNo, Crn, ProcessNo, WorkOrder, Woqty, McwHtCodes, RowId, requestor);

                var ops = HeatTreatMaterials_ConformanceClass.GetOps(context, viewRenderService, Crn, ProcessNo, requestor);
                FormTable = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatMaterials/Conformance/HeatOperationsPartial", ops);

                success = true;
                message = "Die edit successful.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class ConformanceCertDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<Wildcat.Entities.MCNJ.HeatsSecured.CertsMcW> data { get; set; }

        public ConformanceCertDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<CertsMcW>();
        }

    }

    public class ConformanceCertDataTableData
    {
        public ConformanceCertDataSet set;
        public ConformanceCertDataTableData(HeatsSecuredContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new ConformanceCertDataSet();

            HeatTreatMaterials_ConformanceClass dieClass = new HeatTreatMaterials_ConformanceClass(context, viewRenderService);

            set.draw = draw;
            set.data = dieClass.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Models
}
