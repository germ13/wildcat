using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.MCNJ.SecureHeatCards;
using Wildcat.Utilities;

namespace Wildcat.Logic.MCNJ.HeatsSecured
{
    public class HeatsSecured_DiesClass
    {
        #region Private Fields

        private SecureHeatCardsContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public HeatsSecured_DiesClass(SecureHeatCardsContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 

        /// <summary>
        /// get a Dies
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Dies GetDie(string ID)
        {
            return _context.Dies.Where(x => x.Die == ID).FirstOrDefault();
        }

        /// <summary>
        /// get a TblHeatCard
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public TblHeatCard GetHeatCard(int ID)
        {
            return _context.TblHeatCard.Where(x => x.Hcn == ID).FirstOrDefault();
        }


        public Dies AddDies(string Die, string CustomerPart, int? CustId, string PartType, string Material, byte[] Picture, string requestor)
        {
            Dies op = new Dies
            {
                Die = Die,
                CustomerPart = CustomerPart,
                CustId = CustId,
                PartType = PartType,
                Material = Material,
                Picture = null,
            };

            _context.Add(op);

            _context.SaveChanges();

            return op;
        }

        public TblHeatCard AddTblHeatCard(int Hcn, string DieNumber, DateTime? Date, string NucPrefix, string HeatCode, string HeatNumber, string ShopOrderNumber, short? QuantityOrderedCut, string Range, string Notes, string requestor)
        {
            TblHeatCard op = new TblHeatCard
            {
                DieNumber = DieNumber,
                Date = Date,
                NucPrefix = NucPrefix,
                HeatCode = HeatCode,
                HeatNumber = HeatNumber,
                ShopOrderNumber = ShopOrderNumber,
                QuantityOrderedCut = QuantityOrderedCut,
                Range = Range,
                Notes = Notes
            };

            _context.Add(op);

            _context.SaveChanges();

            return op;
        }

        public Dies EditDies(string Die, string CustomerPart, int? CustId, string PartType, string Material, byte[] Picture, string requestor)
        {
            Dies op = _context.Dies.Where(x => x.Die == Die).FirstOrDefault();
            op.CustomerPart = CustomerPart;
            op.CustId = CustId;
            op.PartType = PartType;
            op.Material = Material;
            op.Picture = Picture;
            _context.SaveChanges();

            return op;
        }

        public TblHeatCard EditTblHeatCard(int Hcn, string DieNumber, DateTime? Date, string NucPrefix, string HeatCode, string HeatNumber, string ShopOrderNumber, short? QuantityOrderedCut, string Range, string Notes, string requestor)
        {
            TblHeatCard op = _context.TblHeatCard.Where(x => x.Hcn == Hcn).FirstOrDefault();
            op.DieNumber = DieNumber;
            op.Date = Date;
            op.NucPrefix = NucPrefix;
            op.HeatCode = HeatCode;
            op.HeatNumber = HeatNumber;
            op.ShopOrderNumber = ShopOrderNumber;
            op.QuantityOrderedCut = QuantityOrderedCut;
            op.Range = Range;
            op.Notes = Notes;
            //op.StdcertNotes = StdcertNotes == null ? "" : StdcertNotes;
            _context.SaveChanges();

            return op;
        }

        public List<Dies> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<Dies> list = new List<Dies>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.Dies.ToList(); ;
            }
            else
            {
                // simulate search
                foreach (Dies dataItem in _context.Dies)
                {
                    if ((dataItem.Die != null && dataItem.Die.ToUpper().Contains(search.ToUpper())) ||
                        (dataItem.CustomerPart != null && dataItem.CustomerPart.ToString().Contains(search)) ||
                        (dataItem.PartType != null && dataItem.PartType.ToString().Contains(search)) ||
                        (dataItem.Material != null && dataItem.Material.ToString().Contains(search)))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                list.Sort((x, y) => SortString(x.Die.ToString(), y.Die.ToString(), sortDirection));
            }
            else if (sortColumn == 1)
            {// sort Age
                list.Sort((x, y) => SortString(x.CustomerPart.ToString(), y.CustomerPart.ToString(), sortDirection));
            }
            else if (sortColumn == 3)
            {// sort Age
                list.Sort((x, y) => SortInteger(x.PartType.ToString(), y.PartType.ToString(), sortDirection));
            }
            else if (sortColumn == 4)
            {// sort Name
                list.Sort((x, y) => SortString(x.Material, y.Material, sortDirection));
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
