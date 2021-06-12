using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.MCNJ.SecureHeatTreatBatchBook;
using Wildcat.Utilities;

namespace Wildcat.Logic.MCNJ.HeatTreatBatchRecords
{
    public class HeatTreatBatchRecords_MetRecordClass
    {
        #region Private Fields

        private SecureHeatTreatBatchBookContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors
        public HeatTreatBatchRecords_MetRecordClass(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 

        public List<Entities.MCNJ.SecureHeatTreatBatchBook.TblDieCard> GetDieCards(SecureHeatTreatBatchBookContext context)
        {
            List<TblDieCard> cards = new List<TblDieCard>();
            //cards = context.TblDieCard.;
            return cards;
        }

        /// <summary>
        /// get a die
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public TblDieCard Get(string ID)
        {
            return _context.TblDieCard.Where(x => x.DieNo == ID).FirstOrDefault();
        }

        /// <summary>
        /// add a die card
        /// </summary>
        /// <param name="DieNo"></param>
        /// <param name="SectionSize"></param>
        /// <param name="MatL"></param>
        /// <param name="ForgingsPerTray"></param>
        /// <param name="Remarks"></param>
        /// <param name="Bhn"></param>
        /// <param name="Weight"></param>
        /// <param name="requestor"></param>
        /// <returns></returns>
        public TblDieCard Add(string DieNo, string SectionSize, string MatL, int? ForgingsPerTray, string Remarks, string Bhn, string Weight, string requestor)
        {
            TblDieCard die = new TblDieCard();
            die.DieNo = DieNo;
            die.SectionSize = SectionSize == null ? "" : SectionSize;
            die.MatL = MatL == null ? "" : MatL;
            die.ForgingsPerTray = ForgingsPerTray;
            die.Remarks = Remarks == null ? "" : Remarks;
            die.Bhn = Bhn == null ? "" : Bhn;
            die.Weight = Weight == null ? "" : Weight;
            //die.StdcertNotes = StdcertNotes == null ? "" : StdcertNotes;
            _context.Add(die);
            _context.SaveChanges();

            return die;
        }

        /// <summary>
        /// edit a die card
        /// </summary>
        /// <param name="DieNo"></param>
        /// <param name="SectionSize"></param>
        /// <param name="MatL"></param>
        /// <param name="ForgingsPerTray"></param>
        /// <param name="Remarks"></param>
        /// <param name="Bhn"></param>
        /// <param name="Weight"></param>
        /// <param name="requestor"></param>
        /// <returns></returns>
        public TblDieCard Edit(string DieNo, string SectionSize, string MatL, int? ForgingsPerTray, string Remarks, string Bhn, string Weight, string requestor)
        {
            TblDieCard die = _context.TblDieCard.Where(x => x.DieNo == DieNo).FirstOrDefault();
            die.SectionSize = SectionSize == null ? "" : SectionSize;
            die.MatL = MatL == null ? "" : MatL;
            die.ForgingsPerTray = ForgingsPerTray;
            die.Remarks = Remarks == null ? "" : Remarks;
            die.Bhn = Bhn == null ? "" : Bhn;
            die.Weight = Weight == null ? "" : Weight;
            //die.StdcertNotes = StdcertNotes == null ? "" : StdcertNotes;
            _context.SaveChanges();

            return die;
        }

        /// <summary>
        /// get a die
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public TblHtoperations GetTblHtoperations(string ID)
        {
            var id = Convert.ToInt32(ID);
            return _context.TblHtoperations.Where(x => x.OpKey == id).FirstOrDefault();
        }

        /// <summary>
        /// add a ht operation
        /// </summary>
        /// <param name="OpKey"></param>
        /// <param name="DieNo"></param>
        /// <param name="Operation"></param>
        /// <param name="Furnace"></param>
        /// <param name="Zone"></param>
        /// <param name="Temperature"></param>
        /// <param name="PushTime"></param>
        /// <param name="HoldTime"></param>
        /// <param name="Quench"></param>
        /// <param name="requestor"></param>
        /// <returns></returns>
        public TblHtoperations AddTblHtoperations(int OpKey, string DieNo, string Operation, string Furnace, string Zone, int? Temperature, string PushTime, string HoldTime, string Quench, string requestor)
        {
            TblHtoperations ht = new TblHtoperations();

            ht.DieNo = DieNo.ToUpper().Trim();
            ht.Operation = Operation == null ? "" : Operation;
            ht.Furnace = Furnace == null ? "" : Furnace;
            ht.Zone = Zone == null ? "" : Zone;
            ht.Temperature = Temperature;
            ht.PushTime = PushTime == null ? "" : PushTime;
            ht.HoldTime = HoldTime == null ? "" : HoldTime;
            ht.Quench = Quench == null ? "" : Quench;

            _context.Add(ht);
            _context.SaveChanges();

            return ht;
        }

        /// <summary>
        /// edit a ht operation
        /// </summary>
        /// <param name="OpKey"></param>
        /// <param name="DieNo"></param>
        /// <param name="Operation"></param>
        /// <param name="Furnace"></param>
        /// <param name="Zone"></param>
        /// <param name="Temperature"></param>
        /// <param name="PushTime"></param>
        /// <param name="HoldTime"></param>
        /// <param name="Quench"></param>
        /// <param name="requestor"></param>
        /// <returns></returns>
        public TblHtoperations EditTblHtoperations(int OpKey, string DieNo, string Operation, string Furnace, string Zone, int? Temperature, string PushTime, string HoldTime, string Quench, string requestor)
        {
            TblHtoperations ht = _context.TblHtoperations.Where(x => x.OpKey == OpKey).FirstOrDefault();

            ht.DieNo = DieNo;
            ht.Operation = Operation == null ? "" : Operation;
            ht.Furnace = Furnace == null ? "" : Furnace;
            ht.Zone = Zone == null ? "" : Zone;
            ht.Temperature = Temperature;
            ht.PushTime = PushTime == null ? "" : PushTime;
            ht.HoldTime = HoldTime == null ? "" : HoldTime;
            ht.Quench = Quench == null ? "" : Quench;

            _context.SaveChanges();

            return ht;
        }

        public List<TblDieCard> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<TblDieCard> list = new List<TblDieCard>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.TblDieCard.ToList();
            }
            else
            {
                // simulate search
                foreach (TblDieCard dataItem in _context.TblDieCard)
                {
                    if ((dataItem.DieNo != null && dataItem.DieNo.ToString().ToUpper().Trim().Contains(search.ToUpper().Trim())) ||
                        (dataItem.SectionSize != null && dataItem.SectionSize.ToString().Contains(search)) ||
                        (dataItem.MatL != null && dataItem.MatL.ToString().Contains(search)) ||
                        (dataItem.Remarks != null && dataItem.Remarks.ToString().Contains(search)) ||
                        (dataItem.Bhn != null && dataItem.Bhn.ToString().Contains(search)) ||
                        (dataItem.Weight != null && dataItem.Weight.ToString().Contains(search)))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                list.Sort((x, y) => SortString(x.DieNo.ToString(), y.DieNo.ToString(), sortDirection));
            }
            else if (sortColumn == 1)
            {// sort Age
                list.Sort((x, y) => SortString(x.SectionSize.ToString(), y.SectionSize.ToString(), sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Age
                list.Sort((x, y) => SortInteger(x.MatL.ToString(), y.MatL.ToString(), sortDirection));
            }
            else if (sortColumn == 4)
            {// sort Name
                list.Sort((x, y) => SortString(x.Bhn, y.Bhn, sortDirection));
            }

            recordFiltered = list.Count;

            // get just one page of data
            list = list.GetRange(start, Math.Min(length, list.Count - start));

            return list;
        }

        public List<TblMetRecords> FilterDataMetRecord(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<TblMetRecords> list = new List<TblMetRecords>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.TblMetRecords.ToList();
            }
            else
            {
                // simulate search
                foreach (TblMetRecords dataItem in _context.TblMetRecords)
                {
                    if ((dataItem.DieNo != null && dataItem.DieNo.ToString().ToUpper().Trim().Contains(search.ToUpper().Trim())) ||
                        (dataItem.OrderNo != null && dataItem.OrderNo.ToString().Contains(search)) ||
                        (dataItem.TotalFurnaceTime != null && dataItem.TotalFurnaceTime.ToString().Contains(search)) ||
                        (dataItem.Notes != null && dataItem.Notes.ToString().Contains(search)) ||
                        (dataItem.ApprovedBy != null && dataItem.ApprovedBy.ToString().Contains(search)) ||
                        (dataItem.SectionSize != null && dataItem.SectionSize.ToString().Contains(search)) ||
                        (dataItem.Weight != null && dataItem.Weight.ToString().Contains(search)))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            if (sortColumn == 0)
            {// sort RowId
                list.Sort((x, y) => SortInteger(x.RowId.ToString(), y.RowId.ToString(), sortDirection));
            }
            if (sortColumn == 1)
            {// sort Order Number
                list.Sort((x, y) => SortString(x.OrderNo.ToString(), y.OrderNo.ToString(), sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Die Number
                list.Sort((x, y) => SortString(x.DieNo.ToString(), y.DieNo.ToString(), sortDirection));
            }
            else if (sortColumn == 5)
            {// sort Approved By
                list.Sort((x, y) => SortString(x.ApprovedBy, y.ApprovedBy, sortDirection));
            }


            recordFiltered = list.Count;

            // get just one page of data
            list = list.GetRange(start, Math.Min(length, list.Count - start));

            return list;
        }

        public List<TblHtacutal> FilterDataHtActual(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection, string ID)
        {
            List<TblHtacutal> list = new List<TblHtacutal>();

            if (!string.IsNullOrEmpty(ID))
            {
                if (string.IsNullOrEmpty(search))
                {
                    list = _context.TblHtacutal.Where(x => x.OrderNo == ID).ToList();
                }
                else
                {
                    // simulate search
                    foreach (TblHtacutal dataItem in _context.TblHtacutal.Where(x => x.OrderNo == ID))
                    {
                        if ((dataItem.OrderNo != null && dataItem.OrderNo.ToString().ToUpper().Trim().Contains(search.ToUpper().Trim())) ||
                            (dataItem.FceNo != null && dataItem.FceNo.ToString().Contains(search)) ||
                            (dataItem.Operation != null && dataItem.Operation.ToString().Contains(search)) ||
                            (dataItem.Bhn != null && dataItem.Bhn.ToString().Contains(search)))
                        {
                            list.Add(dataItem);
                        }
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                list.Sort((x, y) => SortString(x.OrderNo.ToString(), y.OrderNo.ToString(), sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Age
                list.Sort((x, y) => SortString(x.Operation.ToString(), y.Operation.ToString(), sortDirection));
            }
            else if (sortColumn == 3)
            {// sort Age
                list.Sort((x, y) => SortInteger(x.FceNo.ToString(), y.FceNo.ToString(), sortDirection));
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
