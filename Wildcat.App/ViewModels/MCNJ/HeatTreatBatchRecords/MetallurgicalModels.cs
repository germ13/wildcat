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

    public class MetRecordViewModel
    {
        public TblMetRecords AddMetRecord { get; set; }
        public TblMetRecords EditMetRecord { get; set; }

        public List<TblMetRecords> MetRecords { get; set; }

        public TblHtacutal NewOp { get; set; }
        public TblHtacutal EditOp { get; set; }

        public List<TblHtacutal> HeatOperations { get; set; }
    }

    public class AddMetRecordViewModel
    {
        public TblMetRecords AddMetRecord { get; set; }
        public TblHtacutal NewOp { get; set; }
        public TblHtacutal EditOp { get; set; }
        public List<TblHtacutal> HeatActual { get; set; }

        public AddMetRecordViewModel()
        {

        }
        public AddMetRecordViewModel(SecureHeatTreatBatchBookContext context)
        {
            AddMetRecord = new TblMetRecords();
            NewOp = new TblHtacutal();
            EditOp = new TblHtacutal();
            HeatActual = new List<TblHtacutal>();
        }
    }

    public class EditMetRecordViewModel
    {
        public TblMetRecords EditMetRecord { get; set; }
        public TblHtacutal NewOp { get; set; }
        public TblHtacutal EditOp { get; set; }
        public List<TblHtacutal> HeatActual { get; set; }
        public EditMetRecordViewModel()
        {

        }
        public EditMetRecordViewModel(SecureHeatTreatBatchBookContext context, int id)
        {
            EditMetRecord = context.TblMetRecords.Where(x => x.RowId == id).FirstOrDefault();
            NewOp = new TblHtacutal(); NewOp.OrderNo = EditMetRecord.OrderNo;
            EditOp = new TblHtacutal();
            HeatActual = context.TblHtacutal.Where(x => x.OrderNo == EditMetRecord.OrderNo).ToList();
        }
    }

    public class AddHeatOpViewModel
    {
        public TblHtacutal NewOp { get; set; }
        public List<TblHtacutal> HeatOperations { get; set; }

    }

    public class EditHeatOpViewModel
    {
        public TblHtacutal EditOp { get; set; }
    }

    #endregion - ViewModels


    #region - Models

    public class SelectEditMetResponse : Response
    {
        public Task<string> Form { get; set; }

    }

    public class SelectAddHeatResponse : Response
    {
        public Task<string> Form { get; set; }

    }


    public class SelectEditHeatResponse : Response
    {
        public Task<string> Form { get; set; }

    }

    public class AddMetResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public TblMetRecords Record { get; set; }
        public AddMetResponse(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, string DieNo, string OrderNo, int QuantityRun, int TestBars, string TotalFurnaceTime, int QuenchTempStart, int QuenchTempFinish, string Notes, string ApprovedBy, string SectionSize, string Weight)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var mt = new TblMetRecords
                {
                    DieNo = DieNo,
                    OrderNo = OrderNo,
                    QuantityRun = QuantityRun,
                    TestBars = TestBars,
                    TotalFurnaceTime = TotalFurnaceTime,
                    QuenchTempStart = QuenchTempStart,
                    QuenchTempFinish = QuenchTempFinish,
                    Notes = Notes,
                    ApprovedBy = ApprovedBy,
                    SectionSize = SectionSize,
                    Weight = Weight
                };

                var result = context.TblMetRecords.Add(mt);
                context.SaveChanges();

                var vm = context.TblHtacutal.Where(x => x.OrderNo == OrderNo).ToList();
                Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/MetRecord/HeatOperationsPartial", vm);

                Record = mt;
                success = true;
                message = "Met record added.";
            }
            catch (Exception e)
            {
                success = false;
                message = "Met record not added. " + e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditMetResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public TblMetRecords Record { get; set; }
        public EditMetResponse(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, int RowId, string DieNo, string OrderNo, int QuantityRun, int TestBars, string TotalFurnaceTime, int QuenchTempStart, int QuenchTempFinish, string Notes, string ApprovedBy, string SectionSize, string Weight)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var mt = context.TblMetRecords.Where(x => x.RowId == RowId).FirstOrDefault();
                mt.DieNo = DieNo;
                mt.OrderNo = OrderNo;
                mt.QuantityRun = QuantityRun;
                mt.TestBars = TestBars;
                mt.TotalFurnaceTime = TotalFurnaceTime;
                mt.QuenchTempStart = QuenchTempStart;
                mt.QuenchTempFinish = QuenchTempFinish;
                mt.Notes = Notes;
                mt.ApprovedBy = ApprovedBy;
                mt.SectionSize = SectionSize;
                mt.Weight = Weight;

                context.SaveChanges();

                var vm = context.TblHtacutal.Where(x => x.OrderNo == OrderNo).ToList();
                Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/MetRecord/HeatOperationsPartial", vm);

                Record = mt;
                success = true;
                message = "Record successfully edited.";
            }
            catch (Exception e)
            {
                success = false;
                message = "Met record edit failed. " + e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class AddHtActualResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public AddHtActualResponse(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, string OrderNo, DateTime Date, int NoPcs, string FceNo, string Operation, int Temp, string HoldTime, string CoolRate, string HoldComplete, string Bhn, int QuenchStart, int QuenchFinish, int QuenchTempRise, string AtTemp)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var ht = new TblHtacutal
                {
                    OrderNo = OrderNo,
                    Date = Date,
                    NoPcs = NoPcs,
                    FceNo = FceNo,
                    Operation = Operation,
                    Temp = Temp,
                    AtTemp = AtTemp,
                    HoldTime = HoldTime,
                    CoolRate = CoolRate,
                    HoldComplete = HoldComplete,
                    Bhn = Bhn,
                    QuenchTempStart = QuenchStart,
                    QuenchTempFinish = QuenchFinish,
                    QuenchRiseTemp = QuenchTempRise
                };

                var result = context.TblHtacutal.Add(ht);
                context.SaveChanges();

                var vm = context.TblHtacutal.Where(x => x.OrderNo == OrderNo).ToList();
                Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/MetRecord/HeatOperationsPartial", vm);

                success = true;
                message = "Record successfully added.";
            }
            catch (Exception e)
            {
                success = false;
                message = "Record edit failed. " + e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditHtActualResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public EditHtActualResponse(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, int RowId, string OrderNo, DateTime Date, int NoPcs, string FceNo, string Operation, int Temp, string HoldTime, string CoolRate, string HoldComplete, string Bhn, int QuenchStart, int QuenchFinish, int QuenchTempRise, string AtTemp)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var ht = context.TblHtacutal.Where(x => x.RowId == RowId).FirstOrDefault();
                ht.OrderNo = OrderNo;
                ht.Date = Date;
                ht.NoPcs = NoPcs;
                ht.FceNo = FceNo;
                ht.Operation = Operation;
                ht.Temp = Temp;
                ht.AtTemp = AtTemp;
                ht.HoldTime = HoldTime;
                ht.CoolRate = CoolRate;
                ht.HoldComplete = HoldComplete;
                ht.Bhn = Bhn;
                ht.QuenchTempStart = QuenchStart;
                ht.QuenchTempFinish = QuenchFinish;
                ht.QuenchRiseTemp = QuenchTempRise;

                context.SaveChanges();

                var vm = context.TblHtacutal.Where(x => x.OrderNo == OrderNo).ToList();
                Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/MetRecord/HeatOperationsPartial", vm);

                success = true;
                message = "Record successfully edited.";
            }
            catch (Exception e)
            {
                success = false;
                message = "Record edit failed. " + e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class MetRecordDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<TblMetRecords> data { get; set; }

        public MetRecordDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<TblMetRecords>();
        }
    }

    public class MetRecordDataTableData
    {
        public MetRecordDataSet set;
        public MetRecordDataTableData(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new MetRecordDataSet();

            HeatTreatBatchRecords_MetRecordClass dieClass = new HeatTreatBatchRecords_MetRecordClass(context, viewRenderService);

            set.draw = draw;
            set.data = dieClass.FilterDataMetRecord(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    public class MetRecordHtActualDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<TblHtacutal> data { get; set; }

        public MetRecordHtActualDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<TblHtacutal>();
        }
    }

    public class HtActualDataTableData
    {
        public MetRecordHtActualDataSet set;
        public HtActualDataTableData(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection, string ID)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new MetRecordHtActualDataSet();

            HeatTreatBatchRecords_MetRecordClass dieClass = new HeatTreatBatchRecords_MetRecordClass(context, viewRenderService);

            set.draw = draw;
            set.data = dieClass.FilterDataHtActual(ref recordsFiltered, start, length, search, sortColumn, sortDirection, ID);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Models
}
