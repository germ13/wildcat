using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.MCNJ.SecureHeatTreatBatchBook;
using Wildcat.Utilities;

namespace Wildcat.Logic.MCNJ.HeatTreatBatchRecords
{
    public class HeatTreatBatchRecords_BatchClass
    {
        #region Private Fields

        private SecureHeatTreatBatchBookContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public HeatTreatBatchRecords_BatchClass(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 

        /// <summary>
        /// get a TblHtbatchInfo
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public TblHtbatchInfo Get(int ID)
        {
            return _context.TblHtbatchInfo.Where(x => x.RunKey == ID).FirstOrDefault();
        }


        public TblHtbatchInfo Add(int RunKey, string DieNo, string WorkOrder, DateTime? Date, int? Qty, int? Weight, string BatchNo, double? Customer, string HeatCode, string Htno, string MatL, string Furnace, string Cycle, string RunTemp, float? TimeAtTemp, string requestor)
        {
            TblHtbatchInfo op = new TblHtbatchInfo
            {
                DieNo = DieNo,
                WorkOrder = WorkOrder,
                Date = Date,
                Qty = Qty,
                Weight = Weight,
                BatchNo = BatchNo,
                Customer = (int)Customer,
                HeatCode = HeatCode,
                Htno = Htno,
                MatL = MatL,
                Furnace = Furnace,
                Cycle = Cycle,
                RunTemp = RunTemp,
                TimeAtTemp = TimeAtTemp
            };

            _context.Add(op);

            _context.SaveChanges();

            return op;
        }


        public TblHtbatchInfo Edit(int RunKey, string DieNo, string WorkOrder, DateTime? Date, int? Qty, int? Weight, string BatchNo, double? Customer, string HeatCode, string Htno, string MatL, string Furnace, string Cycle, string RunTemp, float? TimeAtTemp, string requestor)
        {
            TblHtbatchInfo op = _context.TblHtbatchInfo.Where(x => x.RunKey == RunKey).FirstOrDefault();
            op.DieNo = DieNo;
            op.WorkOrder = WorkOrder;
            op.Date = Date;
            op.Qty = Qty;
            op.Weight = Weight;
            op.BatchNo = BatchNo;
            op.Customer = (int)Customer;
            op.HeatCode = HeatCode;
            op.Htno = Htno;
            op.MatL = MatL;
            op.Furnace = Furnace;
            op.Cycle = Cycle;
            op.RunTemp = RunTemp;
            op.TimeAtTemp = TimeAtTemp;
            //op.StdcertNotes = StdcertNotes == null ? "" : StdcertNotes;
            _context.SaveChanges();

            return op;
        }

        public List<TblHtbatchInfo> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<TblHtbatchInfo> list = new List<TblHtbatchInfo>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.TblHtbatchInfo.ToList(); ;
            }
            else
            {
                // simulate search
                foreach (TblHtbatchInfo dataItem in _context.TblHtbatchInfo)
                {
                    if ((dataItem.BatchNo != null && dataItem.BatchNo.ToString().Contains(search.ToUpper())) ||
                        (dataItem.WorkOrder != null && dataItem.WorkOrder.ToString().Contains(search.ToUpper())) ||
                        (dataItem.DieNo != null && dataItem.DieNo.ToString().Contains(search.ToUpper())) ||
                        (dataItem.HeatCode != null && dataItem.HeatCode.ToString().Contains(search.ToUpper())) ||
                        (dataItem.Htno != null && dataItem.Htno.ToString().Contains(search.ToUpper())) ||
                        (dataItem.MatL != null && dataItem.MatL.ToString().Contains(search.ToUpper())) ||
                        (dataItem.Furnace != null && dataItem.Furnace.ToString().Contains(search.ToUpper())) ||
                        (dataItem.Cycle != null && dataItem.Cycle.ToString().Contains(search.ToUpper())) ||
                        (dataItem.RunTemp != null && dataItem.RunTemp.ToString().Contains(search.ToUpper())))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 1)
            {// sort Age
                list.Sort((x, y) => SortString(x.BatchNo.ToString(), y.BatchNo.ToString(), sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Age
                list.Sort((x, y) => SortString(x.WorkOrder.ToString(), y.WorkOrder.ToString(), sortDirection));
            }
            else if (sortColumn == 3)
            {// sort Age
                list.Sort((x, y) => SortInteger(x.DieNo.ToString(), y.DieNo.ToString(), sortDirection));
            }
            else if (sortColumn == 5)
            {// sort Name
                list.Sort((x, y) => SortString(x.HeatCode, y.HeatCode, sortDirection));
            }
            else if (sortColumn == 6)
            {// sort Name
                list.Sort((x, y) => SortString(x.Htno, y.Htno, sortDirection));
            }
            else if (sortColumn == 7)
            {// sort Name
                list.Sort((x, y) => SortString(x.MatL, y.MatL, sortDirection));
            }
            else if (sortColumn == 9)
            {// sort Name
                list.Sort((x, y) => SortString(x.Furnace, y.Furnace, sortDirection));
            }
            else if (sortColumn == 10)
            {// sort Name
                list.Sort((x, y) => SortString(x.Cycle, y.Cycle, sortDirection));
            }
            //else if (sortColumn == 5)
            //{   // sort DoB
            //    list.Sort((x, y) => SortDateTime(x.Date, y.Date, sortDirection));
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
