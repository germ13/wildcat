using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.MCNJ.HeatsSecured;
using Wildcat.Utilities;

namespace Wildcat.Logic.MCNJ.HeatTreatMaterials
{
    public class HeatTreatMaterials_Packing
    {
        #region Private Fields

        private HeatsSecuredContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public HeatTreatMaterials_Packing(HeatsSecuredContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 

        public static TblPackingSlips Add(HeatsSecuredContext context, IViewRenderService viewRenderService, string McWCn, DateTime? Date, string Die, string WorkOrder, string CustPo, short Quantity, string ProcessNo, string SerialNumber, string Freight, string ItemNumber, string ShipVia, int? NumberOfSkids, int? NumberOfBoxes, int? TotalWeight, string Notes, bool ShipAir, int? Crn2, int? Crn, int? ShipTo, int? SoldTo, string requestor)
        {
            TblPackingSlips slip = new TblPackingSlips
            {
                McWCn = McWCn,
                Date = Date,
                Die = Die,
                WorkOrder = WorkOrder,
                CustPo = CustPo,
                Quantity = Quantity,
                ProcessNo = ProcessNo,
                SerialNumber = SerialNumber,
                Freight = Freight,
                ItemNumber = ItemNumber,
                ShipVia = ShipVia,
                NumberOfSkids = NumberOfSkids,
                NumberOfBoxes = NumberOfBoxes,
                TotalWeight = TotalWeight,
                Notes = Notes,
                ShipAir = ShipAir,
                Crn2 = Crn2,
                Crn = Crn,
                ShipTo = ShipTo,
                SoldTo = SoldTo
            };

            context.Add(slip);
            context.SaveChanges();

            return slip;
        }

        public static TblPackingSlips Edit(HeatsSecuredContext context, IViewRenderService viewRenderService, int Psn, string McWCn, DateTime? Date, string Die, string WorkOrder, string CustPo, short Quantity, string ProcessNo, string SerialNumber, string Freight, string ItemNumber, string ShipVia, int? NumberOfSkids, int? NumberOfBoxes, int? TotalWeight, string Notes, bool ShipAir, int? Crn2, int? Crn, int? ShipTo, int? SoldTo, string requestor)
        {
            TblPackingSlips slip = context.TblPackingSlips.Where(x => x.Psn == Psn).FirstOrDefault();
            slip.McWCn = McWCn;
            slip.Date = Date;
            slip.Die = Die;
            slip.WorkOrder = WorkOrder;
            slip.CustPo = CustPo;
            slip.Quantity = Quantity;
            slip.ProcessNo = ProcessNo;
            slip.SerialNumber = SerialNumber;
            slip.Freight = Freight;
            slip.ItemNumber = ItemNumber;
            slip.ShipVia = ShipVia;
            slip.NumberOfSkids = NumberOfSkids;
            slip.NumberOfBoxes = NumberOfBoxes;
            slip.TotalWeight = TotalWeight;
            slip.Notes = Notes;
            slip.ShipAir = ShipAir;
            slip.Crn2 = Crn2;
            slip.Crn = Crn;
            slip.ShipTo = ShipTo;
            slip.SoldTo = SoldTo;

            context.SaveChanges();

            return slip;
        }

        public List<TblPackingSlips> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<TblPackingSlips> list = new List<TblPackingSlips>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.TblPackingSlips.ToList(); ;
            }
            else
            {
                // simulate search
                foreach (TblPackingSlips dataItem in _context.TblPackingSlips)
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


                    if ((dataItem.McWCn != null && dataItem.McWCn.ToString().Contains(search.ToUpper())) ||
                        (dataItem.Die != null && dataItem.Die.ToString().Contains(search.ToUpper())) ||
                        (dataItem.WorkOrder != null && dataItem.WorkOrder.ToString().Contains(search.ToUpper())) ||
                        (dataItem.CustPo != null && dataItem.CustPo.ToString().Contains(search.ToUpper())))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 1)
            {// sort Name
                list.Sort((x, y) => SortString(x.McWCn, y.McWCn, sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Name
                list.Sort((x, y) => SortString(x.Die, y.Die, sortDirection));
            }
            else if (sortColumn == 3)
            {// sort Name
                list.Sort((x, y) => SortString(x.WorkOrder, y.WorkOrder, sortDirection));
            }
            else if (sortColumn == 4)
            {// sort Age
                list.Sort((x, y) => SortString(x.CustPo, y.CustPo, sortDirection));
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

        private int SortInteger(int s1, int s2, string sortDirection)
        {
            //int i1 = int.Parse(s1);
            //int i2 = int.Parse(s2);
            return sortDirection == "asc" ? s1.CompareTo(s2) : s2.CompareTo(s1);
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
