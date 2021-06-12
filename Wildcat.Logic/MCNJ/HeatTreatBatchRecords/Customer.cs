using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.MCNJ.SecureHeatTreatBatchBook;
using Wildcat.Utilities;

namespace Wildcat.Logic.MCNJ.HeatTreatBatchRecords
{
    public class HeatTreatBatchRecords_CustomerClass
    {
        #region Private Fields

        private SecureHeatTreatBatchBookContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public HeatTreatBatchRecords_CustomerClass(SecureHeatTreatBatchBookContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 

        /// <summary>
        /// get a TblCustomer
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public TblCustomer Get(int ID)
        {
            return _context.TblCustomer.Where(w => w.CustId == ID).FirstOrDefault();
        }


        public TblCustomer Add(int CustId, string Name, string requestor)
        {
            TblCustomer cust = new TblCustomer
            {
                Name = Name,
            };

            _context.Add(cust);

            _context.SaveChanges();

            return cust;
        }


        public TblCustomer Edit(int CustId, string Name, string requestor)
        {
            TblCustomer cust = _context.TblCustomer.Where(x => x.CustId == CustId).FirstOrDefault();
            cust.CustId = CustId;
            cust.Name = Name;
            _context.SaveChanges();

            return cust;
        }

        public List<TblCustomer> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<TblCustomer> list = new List<TblCustomer>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.TblCustomer.ToList(); ;
            }
            else
            {
                // simulate search
                foreach (TblCustomer dataItem in _context.TblCustomer)
                {
                    if ((dataItem.CustId != null && dataItem.CustId.ToString().Contains(search.ToUpper())) ||
                        (dataItem.Name != null && dataItem.Name.ToString().Contains(search.ToUpper())))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Customer ID
                list.Sort((x, y) => SortInteger(x.CustId.ToString(), y.CustId.ToString(), sortDirection));
            }
            else if (sortColumn == 1)
            {// sort Name
                list.Sort((x, y) => SortString(x.Name.ToString(), y.Name.ToString(), sortDirection));
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
