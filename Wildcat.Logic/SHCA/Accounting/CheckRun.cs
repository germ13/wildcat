using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.SHCA.ShultzPro;
using Wildcat.Utilities;

namespace Wildcat.Logic.SHCA.Accounting
{
    public class CheckRun
    {
        #region Private Fields

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IViewRenderService _viewRenderService;
        private readonly ShultzProContext _shultzProContext;

        private const int LOGON32_PROVIDER_DEFAULT = 0;

        //This parameter causes LogonUser to create a primary token.
        private const int LOGON32_LOGON_INTERACTIVE = 2;

        #endregion Private Fields


        #region Public Properties

        //public class ContactTimeDTO
        //{
        //    public long Id { get; set; }
        //    public string Name { get; set; }
        //    public int? Numericid { get; set; }
        //    public decimal Value { get; set; }
        //    public DateTime? Timestamp { get; set; }
        //    public int? Quality { get; set; }
        //}

        #endregion Public Properties


        #region Constructors

        public CheckRun(IHttpContextAccessor httpContextAccessor, IViewRenderService viewRenderService, ShultzProContext shultzProContext)
        {
            _httpContextAccessor = httpContextAccessor;
            _viewRenderService = viewRenderService;
            _shultzProContext = shultzProContext;
        }

        #endregion Constructors


        #region Public Methods

        public List<TPcc004> GetCheckRunData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection, DateTime from, DateTime to, string checktype)
        {
            List<TPcc004> result = new List<TPcc004>();
            decimal hour = new decimal(); decimal min = new decimal();

            int i = 0;

            if (checktype == "ALL")
            {
                result = _shultzProContext.TPcc004.Where(x => x.DtConnexionTransmit > from && x.DtConnexionTransmit < to).ToList();
            }
            else if (checktype == "MANUAL")
            {
                result = _shultzProContext.TPcc004.Where(x => x.DtConnexionTransmit > from && x.DtConnexionTransmit < to && (x.SRemarks == "PAYROLL" || x.SRemarks == "PAY ROLL" || x.SRemarks == "DUMMY" || x.SRemarks == "PAYDOWN" || x.SRemarks == "PAY DOWN" || x.SVendorName == "PAYDOWN" || x.SVendorName == "PAY DOWN" || x.SRemarks == "PAYDWON" || x.SRemarks == "VOID" || x.SRemarks == "MANUAL" || x.SRemarks == "MANUEL")).ToList();
            }
            else
            {
                result = _shultzProContext.TPcc004.Where(x => x.DtConnexionTransmit > from && x.DtConnexionTransmit < to && (x.SRemarks != "PAYROLL" || x.SRemarks != "PAY ROLL" || x.SRemarks != "DUMMY" || x.SRemarks != "PAYDOWN" || x.SRemarks != "PAY DOWN" || x.SVendorName != "PAYDOWN" || x.SVendorName != "PAY DOWN" || x.SRemarks != "PAYDWON" || x.SRemarks != "VOID" || x.SRemarks != "MANUAL" || x.SRemarks != "MANUEL")).ToList();
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                result.Sort((x, y) => SortString(x.SInvoiceNumber.ToString(), y.SInvoiceNumber.ToString(), sortDirection));
            }
            else if (sortColumn == 1)
            {// sort Age
                result.Sort((x, y) => SortString(x.SVendorNumber.ToString(), y.SVendorNumber.ToString(), sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Age
                result.Sort((x, y) => SortString(x.SVendorName.ToString(), y.SVendorName.ToString(), sortDirection));
            }
            else if (sortColumn == 3)
            {// sort Age
                result.Sort((x, y) => SortString(x.SCheckNumber.ToString(), y.SCheckNumber.ToString(), sortDirection));
            }
            else if (sortColumn == 5)
            {// sort Age
                result.Sort((x, y) => SortString(x.SRemarks.ToString(), y.SRemarks.ToString(), sortDirection));
            }
            else if (sortColumn == 7)
            {// sort Age
                result.Sort((x, y) => SortDateTime(x.DtAdded.ToString(), y.DtAdded.ToString(), sortDirection));
            }
            else if (sortColumn == 8)
            {// sort Age
                result.Sort((x, y) => SortDateTime(x.DtUpdated.ToString(), y.DtUpdated.ToString(), sortDirection));
            }

            recordFiltered = result.Count;

            // get just one page of data
            result = result.GetRange(start, Math.Min(length, result.Count - start));

            return result;
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

        private static bool GetBoolValue(object val)
        {
            bool result = false;

            try
            {
                val = Convert.ToInt32(val);
                return Convert.ToBoolean(val);
            }
            catch
            {
                return false;
            }
        }

        private static string GetBoolColor(object val)
        {
            string result = "red";

            try
            {
                if (Convert.ToBoolean(Convert.ToInt32(val)))
                {
                    result = "green";
                }
            }
            catch
            {
                result = "red";
            }
            return result;
        }

        #endregion Private Methods
    }
}