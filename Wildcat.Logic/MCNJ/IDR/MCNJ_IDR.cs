using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.MCNJ.IDR;
using Wildcat.Utilities;

namespace Wildcat.Logic.MCNJ.IDR
{
    public class MCNJ_IDR
    {
        #region Private Fields

        private IDRContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public MCNJ_IDR(IDRContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 

        public TblIdrdata AddIDR(int Idrnumber, string Initiator, string Operation, string Customer, string HeatCode, DateTime? Date, string DieNumber, string WorkOrderNumber, double? WorkOrderQuantity,
            double? DiscrepantQuantity, string SerialNumbers, string Required, string Actual, string DiscrepancyType1, string DiscrepancyType2, string PreDispositionStatus, string PreDispositionStatusNotes,
            double? ReworkQuantity, DateTime? MrbsubmittalDate, string MrbsubmittalNumber, double? MrbsubmittalQuantity, DateTime? MrbdispositionDate, double? FinalAcceptedQuantity, double? FinalRejectedQuantity,
            string FinalDisposition, string FinalDispositionBy, DateTime? FinalDispositionDate, string FinalDispositionSummary, string FinalDispositionSpecialHandlingInstructions, decimal? UnitCost, decimal? MaterialCost,
            decimal? LaborOverheadCost, decimal? UnitSellPrice, decimal? ReworkCost, decimal? RetestCost, decimal? ReplacementTestCost, decimal? AdditionalTestForInfo, decimal? ScrapCost, decimal? SubmittalCost, decimal? DollarsSubmitted,
            decimal? Idrcost, decimal? LostSales, decimal? TotalIdrcost)
        {
            TblIdrdata op = new TblIdrdata();
            op.Initiator = Initiator; op.Operation = Operation; op.Customer = Customer; op.HeatCode = HeatCode; op.Date = Date;
            op.DieNumber = DieNumber; op.WorkOrderNumber = WorkOrderNumber; op.WorkOrderQuantity = WorkOrderQuantity; op.DiscrepantQuantity = DiscrepantQuantity;
            op.SerialNumbers = SerialNumbers; op.Required = Required; op.Actual = Actual; op.DiscrepancyType1 = DiscrepancyType1; op.DiscrepancyType2 = DiscrepancyType2;
            op.PreDispositionStatus = PreDispositionStatus; op.PreDispositionStatusNotes = PreDispositionStatusNotes; op.ReworkQuantity = ReworkQuantity; op.MrbsubmittalDate = MrbsubmittalDate;
            op.MrbsubmittalNumber = MrbsubmittalNumber; op.MrbsubmittalQuantity = MrbsubmittalQuantity; op.MrbdispositionDate = MrbdispositionDate; op.FinalAcceptedQuantity = FinalAcceptedQuantity;
            op.FinalRejectedQuantity = FinalRejectedQuantity; op.FinalDisposition = FinalDisposition; op.FinalDispositionBy = FinalDispositionBy; op.FinalDispositionDate = FinalDispositionDate; op.FinalDispositionSummary = FinalDispositionSummary;
            op.FinalDispositionSpecialHandlingInstructions = FinalDispositionSpecialHandlingInstructions; op.UnitCost = UnitCost; op.MaterialCost = MaterialCost;
            op.LaborOverheadCost = LaborOverheadCost;
            op.UnitSellPrice = UnitSellPrice;
            op.ReworkCost = ReworkCost;
            op.RetestCost = RetestCost;
            op.ReplacementTestCost = ReplacementTestCost;
            op.AdditionalTestForInfo = AdditionalTestForInfo;
            op.ScrapCost = ScrapCost;
            op.SubmittalCost = SubmittalCost;
            op.DollarsSubmitted = DollarsSubmitted;
            op.Idrcost = Idrcost;
            op.LostSales = LostSales;
            op.TotalIdrcost = TotalIdrcost;

            _context.Add(op);

            _context.SaveChanges();

            return op;
        }

        public TblIdrdata EditIDR(int Idrnumber, string Initiator, string Operation, string Customer, string HeatCode, DateTime? Date, string DieNumber, string WorkOrderNumber, double? WorkOrderQuantity,
            double? DiscrepantQuantity, string SerialNumbers, string Required, string Actual, string DiscrepancyType1, string DiscrepancyType2, string PreDispositionStatus, string PreDispositionStatusNotes,
            double? ReworkQuantity, DateTime? MrbsubmittalDate, string MrbsubmittalNumber, double? MrbsubmittalQuantity, DateTime? MrbdispositionDate, double? FinalAcceptedQuantity, double? FinalRejectedQuantity,
            string FinalDisposition, string FinalDispositionBy, DateTime? FinalDispositionDate, string FinalDispositionSummary, string FinalDispositionSpecialHandlingInstructions, decimal? UnitCost, decimal? MaterialCost,
            decimal? LaborOverheadCost, decimal? UnitSellPrice, decimal? ReworkCost, decimal? RetestCost, decimal? ReplacementTestCost, decimal? AdditionalTestForInfo, decimal? ScrapCost, decimal? SubmittalCost, decimal? DollarsSubmitted,
            decimal? Idrcost, decimal? LostSales, decimal? TotalIdrcost)
        {
            TblIdrdata op = _context.TblIdrdata.Where(x => x.Idrnumber == Idrnumber).FirstOrDefault();
            op.Initiator = Initiator; op.Operation = Operation; op.Customer = Customer; op.HeatCode = HeatCode; op.Date = Date;
            op.DieNumber = DieNumber; op.WorkOrderNumber = WorkOrderNumber; op.WorkOrderQuantity = WorkOrderQuantity; op.DiscrepantQuantity = DiscrepantQuantity;
            op.SerialNumbers = SerialNumbers; op.Required = Required; op.Actual = Actual; op.DiscrepancyType1 = DiscrepancyType1; op.DiscrepancyType2 = DiscrepancyType2;
            op.PreDispositionStatus = PreDispositionStatus; op.PreDispositionStatusNotes = PreDispositionStatusNotes; op.ReworkQuantity = ReworkQuantity; op.MrbsubmittalDate = MrbsubmittalDate;
            op.MrbsubmittalNumber = MrbsubmittalNumber; op.MrbsubmittalQuantity = MrbsubmittalQuantity; op.MrbdispositionDate = MrbdispositionDate; op.FinalAcceptedQuantity = FinalAcceptedQuantity;
            op.FinalRejectedQuantity = FinalRejectedQuantity; op.FinalDisposition = FinalDisposition; op.FinalDispositionBy = FinalDispositionBy; op.FinalDispositionDate = FinalDispositionDate; op.FinalDispositionSummary = FinalDispositionSummary;
            op.FinalDispositionSpecialHandlingInstructions = FinalDispositionSpecialHandlingInstructions; op.UnitCost = UnitCost; op.MaterialCost = MaterialCost;
            op.LaborOverheadCost = LaborOverheadCost;
            op.UnitSellPrice = UnitSellPrice;
            op.ReworkCost = ReworkCost;
            op.RetestCost = RetestCost;
            op.ReplacementTestCost = ReplacementTestCost;
            op.AdditionalTestForInfo = AdditionalTestForInfo;
            op.ScrapCost = ScrapCost;
            op.SubmittalCost = SubmittalCost;
            op.DollarsSubmitted = DollarsSubmitted;
            op.Idrcost = Idrcost;
            op.LostSales = LostSales;
            op.TotalIdrcost = TotalIdrcost;
            _context.SaveChanges();

            return op;
        }

        //public TblHeatCard AddTblHeatCard(int Hcn, string DieNumber, DateTime? Date, string NucPrefix, string HeatCode, string HeatNumber, string ShopOrderNumber, short? QuantityOrderedCut, string Range, string Notes, string requestor)
        //{
        //    TblHeatCard op = new TblHeatCard
        //    {
        //        DieNumber = DieNumber,
        //        Date = Date,
        //        NucPrefix = NucPrefix,
        //        HeatCode = HeatCode,
        //        HeatNumber = HeatNumber,
        //        ShopOrderNumber = ShopOrderNumber,
        //        QuantityOrderedCut = QuantityOrderedCut,
        //        Range = Range,
        //        Notes = Notes
        //    };

        //    _context.Add(op);

        //    _context.SaveChanges();

        //    return op;
        //}



        //public TblHeatCard EditTblHeatCard(int Hcn, string DieNumber, DateTime? Date, string NucPrefix, string HeatCode, string HeatNumber, string ShopOrderNumber, short? QuantityOrderedCut, string Range, string Notes, string requestor)
        //{
        //    TblHeatCard op = _context.TblHeatCard.Where(x => x.Hcn == Hcn).FirstOrDefault();
        //    op.DieNumber = DieNumber;
        //    op.Date = Date;
        //    op.NucPrefix = NucPrefix;
        //    op.HeatCode = HeatCode;
        //    op.HeatNumber = HeatNumber;
        //    op.ShopOrderNumber = ShopOrderNumber;
        //    op.QuantityOrderedCut = QuantityOrderedCut;
        //    op.Range = Range;
        //    op.Notes = Notes;
        //    //op.StdcertNotes = StdcertNotes == null ? "" : StdcertNotes;
        //    _context.SaveChanges();

        //    return op;
        //}

        public List<TblIdrdata> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<TblIdrdata> list = new List<TblIdrdata>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.TblIdrdata.ToList(); ;
            }
            else
            {
                // simulate search
                foreach (TblIdrdata dataItem in _context.TblIdrdata)
                {
                    if ((dataItem.WorkOrderNumber != null && dataItem.WorkOrderNumber.ToUpper().Contains(search.ToUpper())) ||
                        (dataItem.HeatCode != null && dataItem.HeatCode.ToString().Contains(search)) ||
                        (dataItem.DieNumber != null && dataItem.DieNumber.ToString().Contains(search)) ||
                        (dataItem.DiscrepancyType1 != null && dataItem.DiscrepancyType1.ToString().Contains(search)) ||
                        (dataItem.DiscrepancyType2 != null && dataItem.DiscrepancyType2.ToString().Contains(search)) ||
                        (dataItem.PreDispositionStatus != null && dataItem.PreDispositionStatus.ToString().Contains(search)) ||
                        (dataItem.FinalDisposition != null && dataItem.FinalDisposition.ToString().Contains(search)))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            ////simulate sort
            //if (sortColumn == 0)
            //{// sort Age
            //    list.Sort((x, y) => SortInteger(x.Idrnumber.ToString(), y.Idrnumber.ToString(), sortDirection));
            //}
            //else if (sortColumn == 1)
            //{// sort Age
            //    list.Sort((x, y) => SortString(x.WorkOrderNumber.ToString(), y.WorkOrderNumber.ToString(), sortDirection));
            //}
            //else if (sortColumn == 2)
            //{// sort Age
            //    list.Sort((x, y) => SortString(x.HeatCode.ToString(), y.HeatCode.ToString(), sortDirection));
            //}
            //else if (sortColumn == 3)
            //{// sort Age
            //    list.Sort((x, y) => SortInteger(x.DieNumber.ToString(), y.DieNumber.ToString(), sortDirection));
            //}
            //else if (sortColumn == 4)
            //{// sort Name
            //    list.Sort((x, y) => SortString(x.DiscrepancyType1, y.DiscrepancyType1, sortDirection));
            //}
            //else if (sortColumn == 5)
            //{// sort Name
            //    list.Sort((x, y) => SortString(x.DiscrepancyType2, y.DiscrepancyType2, sortDirection));
            //}
            //else if (sortColumn == 6)
            //{// sort Name
            //    list.Sort((x, y) => SortString(x.PreDispositionStatus, y.PreDispositionStatus, sortDirection));
            //}
            //else if (sortColumn == 7)
            //{// sort Name
            //    list.Sort((x, y) => SortString(x.FinalDisposition, y.FinalDisposition, sortDirection));
            //}

            recordFiltered = list.Count;

            // get just one page of data
            list = list.GetRange(start, Math.Min(length, list.Count - start));

            return list;
        }

        #endregion Public Methods



        #region Private Methods

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

        #endregion Private Methods
    }
}
