using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.MCNJ.DCR;
using Wildcat.Utilities;

namespace Wildcat.Logic.MCNJ.DCR
{
    public class MCNJ_DCR
    {
        #region Private Fields

        private DCRContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public MCNJ_DCR(DCRContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 

        public TblDcr AddDcr(int Dcrnumber, string ToolNumber, string Unit, string EngApproval, string EngApprovalSignature, DateTime? EngApprovalDate, string DateRequired, string HoldProductionYesOrNo, string ToolsChangedYesOrNo, string DieShopSignature, DateTime? DieShopSignatureDate, string Reason, string Description, string RequestedBy, DateTime? RequestedDate)
        {
            TblDcr op = new TblDcr();
            op.ToolNumber = ToolNumber;
            op.Unit = Unit;
            op.EngApproval = EngApproval;
            op.EngApprovalSignature = EngApprovalSignature;
            op.EngApprovalDate = EngApprovalDate;
            op.DateRequired = DateRequired;
            op.HoldProductionYesOrNo = HoldProductionYesOrNo;
            op.ToolsChangedYesOrNo = ToolsChangedYesOrNo;
            op.DieShopSignature = DieShopSignature;
            op.DieShopSignatureDate = DieShopSignatureDate;
            op.Reason = Reason;
            op.Description = Description;
            op.RequestedBy = RequestedBy;
            op.RequestedDate = RequestedDate;

            _context.Add(op);

            _context.SaveChanges();

            return op;
        }

        public TblDcr EditDcr(int Dcrnumber, string ToolNumber, string Unit, string EngApproval, string EngApprovalSignature, DateTime? EngApprovalDate, string DateRequired, string HoldProductionYesOrNo, string ToolsChangedYesOrNo, string DieShopSignature, DateTime? DieShopSignatureDate, string Reason, string Description, string RequestedBy, DateTime? RequestedDate)
        {
            TblDcr op = _context.TblDcr.Where(x => x.Dcrnumber == Dcrnumber).FirstOrDefault();
            op.ToolNumber = ToolNumber;
            op.Unit = Unit;
            op.EngApproval = EngApproval;
            op.EngApprovalSignature = EngApprovalSignature;
            op.EngApprovalDate = EngApprovalDate;
            op.DateRequired = DateRequired;
            op.HoldProductionYesOrNo = HoldProductionYesOrNo;
            op.ToolsChangedYesOrNo = ToolsChangedYesOrNo;
            op.DieShopSignature = DieShopSignature;
            op.DieShopSignatureDate = DieShopSignatureDate;
            op.Reason = Reason;
            op.Description = Description;
            op.RequestedBy = RequestedBy;
            op.RequestedDate = RequestedDate;
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

        public List<TblDcr> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<TblDcr> list = new List<TblDcr>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.TblDcr.ToList(); ;
            }
            else
            {
                // simulate search
                foreach (TblDcr dataItem in _context.TblDcr)
                {
                    if ((dataItem.ToolNumber != null && dataItem.ToolNumber.ToUpper().Contains(search.ToUpper())) ||
                        (dataItem.EngApproval != null && dataItem.EngApproval.ToString().Contains(search)) ||
                        (dataItem.Unit != null && dataItem.Unit.ToString().Contains(search)) ||
                        (dataItem.EngApprovalSignature != null && dataItem.EngApprovalSignature.ToString().Contains(search)) ||
                        (dataItem.Reason != null && dataItem.Reason.ToString().Contains(search)) ||
                        (dataItem.Description != null && dataItem.Description.ToString().Contains(search)))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                list.Sort((x, y) => SortInteger(x.Dcrnumber.ToString(), y.Dcrnumber.ToString(), sortDirection));
            }
            else if (sortColumn == 1)
            {// sort Age
                list.Sort((x, y) => SortString(x.ToolNumber.ToString(), y.ToolNumber.ToString(), sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Age
                list.Sort((x, y) => SortString(x.Unit.ToString(), y.Unit.ToString(), sortDirection));
            }
            else if (sortColumn == 3)
            {// sort Age
                list.Sort((x, y) => SortInteger(x.EngApproval.ToString(), y.EngApproval.ToString(), sortDirection));
            }
            else if (sortColumn == 4)
            {// sort Name
                list.Sort((x, y) => SortString(x.HoldProductionYesOrNo, y.HoldProductionYesOrNo, sortDirection));
            }
            else if (sortColumn == 5)
            {// sort Name
                list.Sort((x, y) => SortString(x.ToolsChangedYesOrNo, y.ToolsChangedYesOrNo, sortDirection));
            }

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
