using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.MCNJ.HeatsSecured;
using Wildcat.Utilities;

namespace Wildcat.Logic.MCNJ.HeatTreatMaterials
{
    public class HeatTreatMaterials_Vendor
    {
        #region Private Fields

        private HeatsSecuredContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public HeatTreatMaterials_Vendor(HeatsSecuredContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 

        /// <summary>
        /// get a vendor
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Vendors Get(string ID)
        {
            var id = Convert.ToInt32(ID);
            return _context.Vendors.Where(x => x.MillId == id).FirstOrDefault();
        }

        /// <summary>
        /// add
        /// </summary>
        /// <param name="context"></param>
        /// <param name="viewRenderService"></param>
        /// <param name="Name"></param>
        /// <param name="Address"></param>
        /// <param name="City"></param>
        /// <param name="State"></param>
        /// <param name="ZipCode"></param>
        /// <param name="Country"></param>
        /// <param name="Contact"></param>
        /// <param name="Print"></param>
        /// <param name="requestor"></param>
        /// <returns></returns>
        public static Vendors Add(HeatsSecuredContext context, IViewRenderService viewRenderService, string Name, string Address, string City, string State, string ZipCode, string Country, string Contact, bool Print, string requestor)
        {
            var last = context.Vendors.OrderByDescending(x => x.MillId).FirstOrDefault();
            var lastcheck = context.Vendors.Where(x => x.MillId == (last.MillId + 1)).FirstOrDefault();
            int mill = lastcheck == null ? last.MillId + 1 : last.MillId + 2;

            Vendors vendor = new Vendors
            {
                MillId = mill,
                Name = Name,
                Address = Address == null ? "" : Address,
                City = City == null ? "" : City,
                State = State == null ? "" : State,
                ZipCode = ZipCode == null ? "" : ZipCode,
                //Heat = Heat == null ? "" : Heat,
                Country = Country == null ? "" : Country,
                Contact = Contact == null ? "" : Contact,
                Print = Print,
            };

            context.Add(vendor);
            context.SaveChanges();

            return vendor;
        }


        /// <summary>
        /// edit
        /// </summary>
        /// <param name="context"></param>
        /// <param name="viewRenderService"></param>
        /// <param name="Name"></param>
        /// <param name="Address"></param>
        /// <param name="City"></param>
        /// <param name="State"></param>
        /// <param name="ZipCode"></param>
        /// <param name="Country"></param>
        /// <param name="Contact"></param>
        /// <param name="Print"></param>
        /// <param name="requestor"></param>
        /// <returns></returns>
        public static Vendors Edit(HeatsSecuredContext context, IViewRenderService viewRenderService, int MillId, string Name, string Address, string City, string State, string ZipCode, string Country, string Contact, bool Print, string requestor)
        {
            Vendors v = context.Vendors.Where(x => x.MillId == MillId).FirstOrDefault();
            v.Name = Name;
            v.Address = Address == null ? v.Address : Address;
            v.City = City == null ? v.City : City;
            v.State = State == null ? v.State : State;
            v.ZipCode = ZipCode == null ? v.ZipCode : ZipCode;
            v.Country = Country == null ? v.Country : Country;
            v.Contact = Contact == null ? v.Contact : Contact;
            v.Print = Print;

            context.SaveChanges();

            return v;
        }

        /// <summary>
        /// get operation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public TblDieWoqtyHt GetOp(string ID)
        {
            var id = Convert.ToInt32(ID);
            return _context.TblDieWoqtyHt.Where(x => x.RowId == id).FirstOrDefault();
        }

        /// <summary>
        /// get all ops for conformance cert
        /// </summary>
        /// <param name="context"></param>
        /// <param name="viewRenderService"></param>
        /// <param name="Crn"></param>
        /// <param name="ProcessNo"></param>
        /// <param name="requestor"></param>
        /// <returns></returns>
        public static List<TblDieWoqtyHt> GetOps(HeatsSecuredContext context, IViewRenderService viewRenderService, int? Crn, string ProcessNo, string requestor)
        {
            return context.TblDieWoqtyHt.Where(x => x.Crn == Crn && x.ProcessNo == ProcessNo).ToList();
        }

        /// <summary>
        /// add an operation
        /// </summary>
        /// <param name="context"></param>
        /// <param name="viewRenderService"></param>
        /// <param name="ControlNo"></param>
        /// <param name="Crn"></param>
        /// <param name="ProcessNo"></param>
        /// <param name="WorkOrder"></param>
        /// <param name="Woqty"></param>
        /// <param name="McwHtCodes"></param>
        /// <param name="RowId"></param>
        /// <param name="requestor"></param>
        /// <returns></returns>
        public static TblDieWoqtyHt AddOp(HeatsSecuredContext context, IViewRenderService viewRenderService, int? ControlNo, int? Crn, string ProcessNo, string WorkOrder, string Woqty, string McwHtCodes, int RowId, string requestor)
        {
            TblDieWoqtyHt ht = new TblDieWoqtyHt
            {
                Crn = Crn == null ? null : Crn,
                ProcessNo = ProcessNo == null ? "" : ProcessNo,
                WorkOrder = WorkOrder == null ? "" : WorkOrder,
                Woqty = Woqty == null ? "" : Woqty,
                McwHtCodes = McwHtCodes == null ? "" : McwHtCodes
            };

            context.Add(ht);
            context.SaveChanges();

            return ht;
        }

        /// <summary>
        /// edit an operation
        /// </summary>
        /// <param name="context"></param>
        /// <param name="viewRenderService"></param>
        /// <param name="ControlNo"></param>
        /// <param name="Crn"></param>
        /// <param name="ProcessNo"></param>
        /// <param name="WorkOrder"></param>
        /// <param name="Woqty"></param>
        /// <param name="McwHtCodes"></param>
        /// <param name="RowId"></param>
        /// <param name="requestor"></param>
        /// <returns></returns>
        public static TblDieWoqtyHt EditOp(HeatsSecuredContext context, IViewRenderService viewRenderService, int? ControlNo, int? Crn, string ProcessNo, string WorkOrder, string Woqty, string McwHtCodes, int RowId, string requestor)
        {
            TblDieWoqtyHt ht = context.TblDieWoqtyHt.Where(x => x.RowId == RowId).FirstOrDefault();

            ht.ControlNo = ControlNo == null ? ht.ControlNo : ControlNo;
            ht.Crn = Crn == null ? ht.Crn : Crn;
            ht.ProcessNo = ProcessNo == null ? ht.ProcessNo : ProcessNo;
            ht.WorkOrder = WorkOrder == null ? ht.WorkOrder : WorkOrder;
            ht.Woqty = Woqty == null ? ht.Woqty : Woqty;
            ht.McwHtCodes = McwHtCodes == null ? ht.McwHtCodes : McwHtCodes;

            context.SaveChanges();

            return ht;
        }

        public List<Vendors> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<Vendors> list = new List<Vendors>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.Vendors.ToList(); ;
            }
            else
            {
                // simulate search
                foreach (Vendors dataItem in _context.Vendors)
                {
                    if ((dataItem.Name != null && dataItem.Name.ToString().Contains(search)) ||
                        (dataItem.Address != null && dataItem.Address.ToString().Contains(search.ToUpper())) ||
                        (dataItem.City != null && dataItem.City.ToString().Contains(search.ToUpper())) ||
                        (dataItem.State != null && dataItem.State.ToString().Contains(search.ToUpper())) ||
                        (dataItem.ZipCode != null && dataItem.ZipCode.ToString().Contains(search.ToUpper())) ||
                        (dataItem.Contact != null && dataItem.Contact.ToString().Contains(search.ToUpper())))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Name
                list.Sort((x, y) => SortString(x.Name, y.Name, sortDirection));
            }
            else if (sortColumn == 1)
            {// sort Name
                list.Sort((x, y) => SortString(x.Address, y.Address, sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Name
                list.Sort((x, y) => SortString(x.City, y.City, sortDirection));
            }
            else if (sortColumn == 3)
            {// sort Age
                list.Sort((x, y) => SortString(x.State, y.State, sortDirection));
            }
            else if (sortColumn == 4)
            {// sort Age
                list.Sort((x, y) => SortString(x.ZipCode, y.ZipCode, sortDirection));
            }
            else if (sortColumn == 5)
            {// sort Age
                list.Sort((x, y) => SortString(x.Contact, y.Contact, sortDirection));
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
