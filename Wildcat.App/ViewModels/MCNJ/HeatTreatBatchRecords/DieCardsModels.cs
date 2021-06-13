using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Wildcat.App.Models;
using Wildcat.Entities.MCNJ.SecureHeatTreatBatchBook;
using Wildcat.Logic.MCNJ.HeatTreatBatchRecords;
using Wildcat.Utilities;

namespace Wildcat.App.ViewModels.MCNJ.HeatTreatBatchRecords
{
    #region - ViewModels

    public class DieCardsViewModel
    {
        public List<TblDieCard> DieCards { get; set; }
        public DieCardsViewModel()
        {
            DieCards = new List<TblDieCard>();
        }
    }

    public class AddDieCardsViewModel
    {
        private SecureHeatTreatBatchBookContext _context;
        private IViewRenderService _viewRenderService;

        public TblDieCard DieCard { get; set; }
        public List<TblHtoperations> Operations { get; set; }
        public TblHtoperations NewOp { get; set; }
        public TblHtoperations EditOp { get; set; }

        public AddDieCardsViewModel(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;

            DieCard = new TblDieCard();
            Operations = new List<TblHtoperations>();
            NewOp = new TblHtoperations();
            EditOp = new TblHtoperations();
        }
    }

    public class EditDieCardsViewModel
    {
        private SecureHeatTreatBatchBookContext _context;
        private IViewRenderService _viewRenderService;

        public TblDieCard DieCard { get; set; }
        public List<TblHtoperations> Operations { get; set; }
        public TblHtoperations NewOp { get; set; }
        public TblHtoperations EditOp { get; set; }

        public EditDieCardsViewModel(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, string ID)
        {
            _context = context;
            _viewRenderService = viewRenderService;
            DieCard = new TblDieCard();
            DieCard = _context.TblDieCard.Where(x => x.DieNo.Trim() == ID).FirstOrDefault();
            Operations = _context.TblHtoperations.Where(x => x.DieNo == ID).ToList();
            NewOp = new TblHtoperations { DieNo = ID };
            EditOp = new TblHtoperations();
        }
    }

    public class EditDieCardsHeatOpViewModel
    {
        private SecureHeatTreatBatchBookContext _context;
        private IViewRenderService _viewRenderService;

        public TblHtoperations EditOp { get; set; }

        public EditDieCardsHeatOpViewModel(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, string ID)
        {
            _context = context;
            _viewRenderService = viewRenderService;

            var id = Convert.ToInt32(ID);
            EditOp = _context.TblHtoperations.Where(x => x.OpKey == id).FirstOrDefault();
        }
    }

    #endregion - ViewModels


    #region - Models

    public class AddDieResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public string DieNum { get; set; }
        public Task<string> FormHt { get; set; }
        public Task<string> FormTable { get; set; }
        public AddDieResponse(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, string DieNo, string SectionSize, string MatL, int? ForgingsPerTray, string Remarks, string Bhn, string Weight, string User)
        {
            _viewRenderService = viewRenderService;
            try
            {
                HeatTreatBatchRecords_DieCards opClass = new HeatTreatBatchRecords_DieCards(context, viewRenderService);
                opClass.Add(DieNo, SectionSize, MatL, ForgingsPerTray, Remarks, Bhn, Weight, User);

                var newhtop = new TblHtoperations { DieNo = DieNo };
                var htops = context.TblHtoperations.Where(x => x.DieNo == DieNo).ToList();

                FormHt = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/DieCards/EditHeatPartial", newhtop);
                FormTable = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/DieCards/HeatOperationsPartial", htops);

                DieNum = DieNo;

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

    public class EditDieResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> FormHt { get; set; }
        public Task<string> FormTable { get; set; }
        public EditDieResponse(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, string DieNo, string SectionSize, string MatL, int? ForgingsPerTray, string Remarks, string Bhn, string Weight, string User)
        {
            _viewRenderService = viewRenderService;
            try
            {
                HeatTreatBatchRecords_DieCards opClass = new HeatTreatBatchRecords_DieCards(context, viewRenderService);
                opClass.Edit(DieNo, SectionSize, MatL, ForgingsPerTray, Remarks, Bhn, Weight, User);

                //var newhtop = new TblHtoperations { DieNo = DieNo };
                //var htops = context.TblHtoperations.Where(x => x.DieNo == DieNo).ToList();

                //FormHt = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/DieCards/EditHeatPartial", newhtop);
                //FormTable = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/DieCards/HeatOperationsPartial", htops);

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

    public class AddDieHeatResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public string DieNum { get; set; }
        public Task<string> FormHt { get; set; }
        public Task<string> FormTable { get; set; }
        public TblHtoperations op { get; set; }
        public AddDieHeatResponse(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, int OpKey, string DieNo, string Operation, string Furnace, string Zone, int? Temperature, string PushTime, string HoldTime, string Quench, string User)
        {
            _viewRenderService = viewRenderService;
            try
            {
                HeatTreatBatchRecords_DieCards opClass = new HeatTreatBatchRecords_DieCards(context, viewRenderService);
                 var operation = opClass.AddTblHtoperations(OpKey, DieNo, Operation, Furnace, Zone, Temperature, PushTime, HoldTime, Quench, User);

                var newhtop = new TblHtoperations { DieNo = DieNo };
                var htops = context.TblHtoperations.Where(x => x.DieNo == DieNo).ToList();

                FormTable = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/DieCards/HeatOperationsPartial", htops);

                DieNum = DieNo;
                op = operation;
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

    public class EditDieHeatResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public string DieNum { get; set; }
        public Task<string> FormTable { get; set; }
        public EditDieHeatResponse(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, int OpKey, string DieNo, string Operation, string Furnace, string Zone, int? Temperature, string PushTime, string HoldTime, string Quench, string User)
        {
            _viewRenderService = viewRenderService;
            try
            {
                HeatTreatBatchRecords_DieCards opClass = new HeatTreatBatchRecords_DieCards(context, viewRenderService);
                opClass.EditTblHtoperations(OpKey, DieNo, Operation, Furnace, Zone, Temperature, PushTime, HoldTime, Quench, User);

                var newhtop = new TblHtoperations { DieNo = DieNo };
                var htops = context.TblHtoperations.Where(x => x.DieNo == DieNo).ToList();

                FormTable = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/DieCards/HeatOperationsPartial", htops);

                DieNum = DieNo;

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


    public class SelectEditDieCardHeatResponse : Response
    {
        private SecureHeatTreatBatchBookContext _context;
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public SelectEditDieCardHeatResponse(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, string ID)
        {
            _context = context;
            _viewRenderService = viewRenderService;

            try
            {
                var id = Convert.ToInt32(ID);
                var EditOp = _context.TblHtoperations.Where(x => x.OpKey == id).FirstOrDefault();

                if (EditOp == null)
                {
                    success = false;
                    message = "Could not find requested heat operation, please contact administrator.";
                }
                else
                {
                    Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/DieCards/EditHeatPartial", EditOp);
                    success = true;
                    message = "";
                }
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class DieCardDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<TblDieCard> data { get; set; }

        public DieCardDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<TblDieCard>();
        }

    }

    public class DataTableData
    {
        public DieCardDataSet set;
        public DataTableData(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new DieCardDataSet();

            HeatTreatBatchRecords_DieCards dieCards = new HeatTreatBatchRecords_DieCards(context, viewRenderService);

            set.draw = draw;
            set.data = dieCards.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Models
}
