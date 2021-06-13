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

    public class PackingSlipsViewModel
    {
        public List<TblPackingSlips> PackingSlip { get; set; }
        public PackingSlipsViewModel()
        {
            PackingSlip = new List<TblPackingSlips>();
        }
    }

    public class AddPackingSlipsViewModel
    {
        public TblPackingSlips PackingSlip { get; set; }
        public List<SelectListItem> Dies { get; set; }
        public List<SelectListItem> Freight { get; set; }
        public List<SelectListItem> Customers { get; set; }
        public string PartNumber { get; set; }
        public string RevisionNumber { get; set; }
        public AddPackingSlipsViewModel(HeatsSecuredContext _context)
        {
            PackingSlip = new TblPackingSlips();
            PackingSlip.ShipTo = PackingSlip.SoldTo = 0;

            Freight = new List<SelectListItem>();
            Freight.Add(new SelectListItem("Collect", "Collect"));
            Freight.Add(new SelectListItem("PrePaid", "PrePaid"));

            Dies = new List<SelectListItem>();
            foreach (var p in _context.Dies)
            {
                Dies.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(p.Die, p.Die));
            }

            Customers = new List<SelectListItem>();
            foreach (var c in _context.TblCustomers)
            {
                Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(c.CustomerName, c.CustId.ToString()));
            }
        }
    }

    public class EditPackingSlipsViewModel
    {
        public TblPackingSlips PackingSlip { get; set; }
        public List<SelectListItem> Dies { get; set; }
        public List<SelectListItem> Freight { get; set; }
        public List<SelectListItem> Customers { get; set; }
        public string Die { get; set; }
        public string PartNumber { get; set; }
        public string RevisionNumber { get; set; }
        public TblCustomers SoldTo { get; set; }
        public TblCustomers ShipTo { get; set; }
        public EditPackingSlipsViewModel(HeatsSecuredContext _context, int PSN)
        {
            PackingSlip = _context.TblPackingSlips.Where(x => x.Psn == PSN).FirstOrDefault();
            //PackingSlip.ShipTo = PackingSlip.SoldTo = 0;

            Freight = new List<SelectListItem>();
            Freight.Add(new SelectListItem("Collect", "Collect", PackingSlip.Freight == "Collect" ? true : false));
            Freight.Add(new SelectListItem("PrePaid", "PrePaid", PackingSlip.Freight == "PrePaid" ? true : false));

            Die = PackingSlip.Die;
            Dies = new List<SelectListItem>();
            foreach (var p in _context.Dies)
            {
                Dies.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(p.Die, p.Die));
            }

            Customers = new List<SelectListItem>();
            foreach (var c in _context.TblCustomers)
            {
                Customers.Add(new Microsoft.AspNetCore.Mvc.Rendering.SelectListItem(c.CustomerName, c.CustId.ToString()));
            }

            if (PackingSlip.ShipTo != null)
            {
                var shipTo = _context.TblCustomers.Where(x => x.CustId == PackingSlip.ShipTo).FirstOrDefault();
                if (shipTo != null)
                {
                    ShipTo = shipTo;
                }
                else
                {
                    ShipTo = new TblCustomers();
                    //ShipTo.CustomerName = "";
                    //ShipTo.Addr1 = "";
                    //ShipTo.City = "";
                    //ShipTo.State = "";
                    //ShipTo.Zip = "";
                    //ShipTo.Country = "";
                }
            }

            if (PackingSlip.SoldTo != null)
            {
                var soldTo = _context.TblCustomers.Where(x => x.CustId == PackingSlip.SoldTo).FirstOrDefault();
                if (soldTo != null)
                {
                    SoldTo = soldTo;
                }
                else
                {
                    SoldTo = new TblCustomers();
                    //SoldTo.CustomerName = "";
                    //SoldTo.Addr1 = "";
                    //SoldTo.City = "";
                    //SoldTo.State = "";
                    //SoldTo.Zip = "";
                    //SoldTo.Country = "";
                }
            }
        }
    }
    #endregion - ViewModels


    #region - Models

    public class AddPackingSlipResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public AddPackingSlipResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, string McWCn, DateTime? Date, string Die, string WorkOrder, string CustPo, short Quantity, string ProcessNo, string SerialNumber, string Freight, string ItemNumber, string ShipVia, int? NumberOfSkids, int? NumberOfBoxes, int? TotalWeight, string Notes, bool ShipAir, int? Crn2, int? Crn, int? ShipTo, int? SoldTo, string requestor)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var operation = HeatTreatMaterials_Packing.Add(context, viewRenderService, McWCn, Date, Die, WorkOrder, CustPo, Quantity, ProcessNo, SerialNumber, Freight, ItemNumber, ShipVia, NumberOfSkids, NumberOfBoxes, TotalWeight, Notes, ShipAir, Crn2, Crn, ShipTo, SoldTo, requestor);

                Crn = operation.Crn;
                success = true;
                message = "Packing slip added successfully.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class EditPackingSlipResponse : Response
    {
        private IViewRenderService _viewRenderService;
        public EditPackingSlipResponse(HeatsSecuredContext context, IViewRenderService viewRenderService, int Psn, string McWCn, DateTime? Date, string Die, string WorkOrder, string CustPo, short Quantity, string ProcessNo, string SerialNumber, string Freight, string ItemNumber, string ShipVia, int? NumberOfSkids, int? NumberOfBoxes, int? TotalWeight, string Notes, bool ShipAir, int? Crn2, int? Crn, int? ShipTo, int? SoldTo, string requestor)
        {
            _viewRenderService = viewRenderService;
            try
            {
                var operation = HeatTreatMaterials_Packing.Edit(context, viewRenderService, Psn, McWCn, Date, Die, WorkOrder, CustPo, Quantity, ProcessNo, SerialNumber, Freight, ItemNumber, ShipVia, NumberOfSkids, NumberOfBoxes, TotalWeight, Notes, ShipAir, Crn2, Crn, ShipTo, SoldTo, requestor);

                Crn = operation.Crn;
                success = true;
                message = "Packing slip added successfully.";
            }
            catch (Exception e)
            {
                success = false;
                message = e.Message + Environment.NewLine + Environment.NewLine + (e.InnerException != null && e.InnerException.Message != null ? e.InnerException.Message : "") + Environment.NewLine + Environment.NewLine + "If necessary, please contact help desk";
                exception = e;
            }
        }
    }

    public class PackingDataSet
    {
        public int draw { get; set; }
        public int recordsTotal { get; set; }
        public int recordsFiltered { get; set; }
        public List<TblPackingSlips> data { get; set; }

        public PackingDataSet()
        {
            draw = 0;
            recordsTotal = 0;
            recordsFiltered = 0;
            data = new List<TblPackingSlips>();
        }
    }

    public class PackingDataTableData
    {
        public PackingDataSet set;
        public PackingDataTableData(HeatsSecuredContext context, IViewRenderService viewRenderService, int draw, int start, int length, string search, int sortColumn, string sortDirection)
        {
            int TOTAL_ROWS = 0;
            int recordsFiltered = 0;
            set = new PackingDataSet();

            HeatTreatMaterials_Packing dieClass = new HeatTreatMaterials_Packing(context, viewRenderService);

            set.draw = draw;
            set.data = dieClass.FilterData(ref recordsFiltered, start, length, search, sortColumn, sortDirection);
            set.recordsTotal = TOTAL_ROWS = set.data.Count();
            set.recordsFiltered = recordsFiltered;
        }
    }

    #endregion - Models
}
