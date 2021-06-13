using Microsoft.AspNetCore.Mvc.Rendering;
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

    public class BatchViewModel
    {
        private SecureHeatTreatBatchBookContext _context;
        private IViewRenderService _viewRenderService;

        public List<TblHtbatchInfo> Batches { get; set; }
        public List<SelectListItem> Customers { get; set; }
        public List<SelectListItem> Dies { get; set; }
        public TblHtbatchInfo AddBatch { get; set; }
        public TblHtbatchInfo EditBatch { get; set; }
        public BatchViewModel(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService)
        {
            Batches = new List<TblHtbatchInfo>();
            Customers = new List<SelectListItem>();
            Dies = new List<SelectListItem>();
            AddBatch = new TblHtbatchInfo(); AddBatch.Date = DateTime.Now;
            EditBatch = new TblHtbatchInfo();

            _context = context;
            _viewRenderService = viewRenderService;

            foreach (var c in _context.TblCustomer)
            {
                Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(c.Name, c.CustId.ToString()));
            }

            foreach (var c in _context.TblDieCard)
            {
                Dies.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(c.DieNo, c.DieNo.ToString()));
            }
        }
    }

    public class EditBatchViewModel
    {
        public List<SelectListItem> Customers { get; set; }
        public List<SelectListItem> Dies { get; set; }
        public TblHtbatchInfo Batch { get; set; }
        public EditBatchViewModel(SecureHeatTreatBatchBookContext _context, string ID)
        {
            Customers = new List<SelectListItem>();
            Dies = new List<SelectListItem>();
            foreach (var c in _context.TblCustomer.OrderBy(o => o.Name))
            {
                Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(c.Name, c.CustId.ToString()));
            }

            foreach (var c in _context.TblDieCard)
            {
                Dies.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(c.DieNo, c.DieNo.ToString()));
            }

            var id = Convert.ToInt32(ID);
            Batch = _context.TblHtbatchInfo.Where(x => x.RunKey == id).FirstOrDefault();
        }
    }

    #endregion - ViewModels


    #region - Models

    public class AddBatchResponse : Response
    {
        public AddBatchResponse(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, int RunKey, string DieNo, string WorkOrder, DateTime? Date, int? Qty, int? Weight, string BatchNo, double? Customer, string HeatCode, string Htno, string MatL, string Furnace, string Cycle, string RunTemp, float? TimeAtTemp, string requestor)
        {
            try
            {
                HeatTreatBatchRecords_BatchClass batchClass = new HeatTreatBatchRecords_BatchClass(context, viewRenderService);

                var result = batchClass.Add(RunKey, DieNo, WorkOrder, Date, Qty, Weight, BatchNo, Customer, HeatCode, Htno, MatL, Furnace, Cycle, RunTemp, TimeAtTemp, requestor);

                success = true;
                message = "BATCH: " + result.BatchNo + " added.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditBatchResponse : Response
    {
        public EditBatchResponse(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, int RunKey, string DieNo, string WorkOrder, DateTime? Date, int? Qty, int? Weight, string BatchNo, double? Customer, string HeatCode, string Htno, string MatL, string Furnace, string Cycle, string RunTemp, float? TimeAtTemp, string requestor)
        {
            try
            {
                HeatTreatBatchRecords_BatchClass batchClass = new HeatTreatBatchRecords_BatchClass(context, viewRenderService);

                var result = batchClass.Edit(RunKey, DieNo, WorkOrder, Date, Qty, Weight, BatchNo, Customer, HeatCode, Htno, MatL, Furnace, Cycle, RunTemp, TimeAtTemp, requestor);

                success = true;
                message = "BATCH: " + result.BatchNo + " edited.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class SelectEditBatchResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public Task<string> Form { get; set; }
        public SelectEditBatchResponse(string ID, SecureHeatTreatBatchBookContext _context, IViewRenderService viewRenderService)
        {
            _viewRenderService = viewRenderService;
            try
            {
                EditBatchViewModel vm = new EditBatchViewModel(_context, ID); 
                if (vm.Batch == null)
                {
                    success = false;
                    message = "Could not find requested batch, please contact administrator.";
                }
                else
                {
                    Form = _viewRenderService.RenderToStringAsync("MCNJ/HeatTreatBatchRecords/Batch/EditBatchPartial", vm);
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

    public class BatchDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<TblHtbatchInfo> data { get; set; }

        public BatchDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<TblHtbatchInfo>();
        }

    }

    public class BatchDataTableData
    {
        public BatchDataSet set;
        public BatchDataTableData(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new BatchDataSet();

            HeatTreatBatchRecords_BatchClass batchClass = new HeatTreatBatchRecords_BatchClass(context, viewRenderService);

            set.draw = draw;
            set.data = batchClass.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Models
}
