using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.MCNJ.HeatsSecured;
using Wildcat.Utilities;

namespace Wildcat.Logic.MCNJ.HeatTreatMaterials
{
    public class HeatTreatMaterials_MillCertClass
    {
        #region Private Fields

        private HeatsSecuredContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public HeatTreatMaterials_MillCertClass(HeatsSecuredContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 

        /// <summary>
        /// get a cert
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public CertsMill Get(string ID)
        {
            var id = Convert.ToInt32(ID);
            return _context.CertsMill.Where(x => x.Crn == id).FirstOrDefault();
        }

        /// <summary>
        /// add a cert
        /// </summary>
        /// <returns></returns>
        public static CertsMill Add(HeatsSecuredContext context, IViewRenderService viewRenderService, int Crn, DateTime? DateIn, int? MillId, string MillCn, string Heat, string HtDesc, string Material, string Spec, string Pwcode, string BetaTransus, string requestor)
        {
            CertsMill cert = new CertsMill
            {
                DateIn = DateIn,
                MillId = MillId,
                MillCn = MillCn == null ? "" : MillCn,
                Heat = HtDesc == null ? "" : HtDesc,
                HtDesc = HtDesc == null ? "" : HtDesc,
                Material = Material == null ? "" : Material,
                Spec = Spec == null ? "" : Spec,
                Pwcode = Pwcode == null ? "" : Pwcode,
                BetaTransus = BetaTransus == null ? "" : BetaTransus
            };

            context.Add(cert);
            context.SaveChanges();

            return cert;
        }

        /// <summary>
        /// edit a cert
        /// </summary>
        /// <param name="McWCn"></param>
        /// <param name="Crn"></param>
        /// <param name="Date"></param>
        /// <param name="CustId"></param>
        /// <param name="CustPo"></param>
        /// <param name="Heat"></param>
        /// <param name="GsMcW"></param>
        /// <param name="Hardness"></param>
        /// <param name="HeatTreatNotes"></param>
        /// <param name="CertificationNotes"></param>
        /// <param name="ProcessNo"></param>
        /// <param name="NoteType"></param>
        /// <param name="QtyShipped"></param>
        /// <param name="Die"></param>
        /// <param name="WorkOrder"></param>
        /// <param name="requestor"></param>
        /// <returns></returns>
        public static CertsMill Edit(HeatsSecuredContext context, IViewRenderService viewRenderService, int Crn, DateTime? DateIn, int? MillId, string MillCn, string Heat, string HtDesc, string Material, string Spec, string Pwcode, string BetaTransus, string requestor)
        {
            CertsMill cert = context.CertsMill.Where(x => x.Crn == Crn).FirstOrDefault();
            cert.DateIn = DateIn;
            cert.MillId = MillId;
            cert.MillCn = MillCn == null ? cert.MillCn : MillCn;
            cert.Heat = HtDesc == null ? cert.Heat : HtDesc;
            cert.HtDesc = HtDesc == null ? cert.HtDesc : HtDesc;
            cert.Material = Material == null ? cert.Material : Material;
            cert.Spec = Spec == null ? cert.Spec : Spec;
            cert.Pwcode = Pwcode == null ? cert.Pwcode : Pwcode;
            cert.BetaTransus = BetaTransus == null ? cert.BetaTransus : BetaTransus;

            context.SaveChanges();

            return cert;
        }

        /// <summary>
        /// get operation
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public HeatReceipts GetOp(string ID)
        {
            var id = Convert.ToInt32(ID);
            return _context.HeatReceipts.Where(x => x.Hrn == id).FirstOrDefault();
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
        public static List<HeatReceipts> GetOps(HeatsSecuredContext context, IViewRenderService viewRenderService, int? Crn, string ProcessNo, string requestor)
        {
            return context.HeatReceipts.Where(x => x.Crn == Crn).ToList();
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
        public static HeatReceipts AddOp(HeatsSecuredContext context, IViewRenderService viewRenderService, int? Crn, int Hrn, DateTime? Date, string Size, string McWPo, short? VendorId, int? TotWt, short? Billets, string BilletId, bool Bsr, bool CutBillets, string Remarks, string requestor)
        {
            HeatReceipts ht = new HeatReceipts
            {
                Crn = Crn,
                Date = Date,
                Size = Size == null ? "" : Size,
                McWPo = McWPo == null ? "" : McWPo,
                VendorId = VendorId,
                TotWt = TotWt,
                Billets = Billets,
                BilletId = BilletId == null ? "" : BilletId,
                Bsr = Bsr,
                CutBillets = CutBillets
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
        public static HeatReceipts EditOp(HeatsSecuredContext context, IViewRenderService viewRenderService, int? Crn, int Hrn, DateTime? Date, string Size, string McWPo, short? VendorId, int? TotWt, short? Billets, string BilletId, bool Bsr, bool CutBillets, string Remarks, string requestor)
        {
            HeatReceipts ht = context.HeatReceipts.Where(x => x.Hrn == Hrn).FirstOrDefault();

            ht.Crn = Crn == null ? ht.Crn : Crn;
            ht.Date = Date == null ? ht.Date : Date;
            ht.Size = Size == null ? ht.Size : Size;
            ht.McWPo = McWPo == null ? ht.McWPo : McWPo;
            ht.VendorId = VendorId == null ? ht.VendorId : VendorId;
            ht.TotWt = TotWt == null ? ht.TotWt : TotWt;
            ht.Billets = Billets == null ? ht.Billets : Billets;
            ht.BilletId = BilletId == null ? ht.BilletId : BilletId;
            ht.Bsr = Bsr;
            ht.CutBillets = CutBillets;
            ht.Remarks = Remarks == null ? ht.Remarks : Remarks;

            context.SaveChanges();

            return ht;
        }

        public List<Wildcat.Entities.MCNJ.HeatsSecured.CertsMill> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<CertsMill> list = new List<CertsMill>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.CertsMill.ToList(); ;
            }
            else
            {
                // simulate search
                foreach (CertsMill dataItem in _context.CertsMill)
                {

                    if ((dataItem.MillCn != null && dataItem.MillCn.ToString().Contains(search)) ||
                        (dataItem.Heat != null && dataItem.Heat.ToString().Contains(search)) ||
                        (dataItem.HtDesc != null && dataItem.HtDesc.ToString().Contains(search)) ||
                        (dataItem.Material != null && dataItem.Material.ToString().Contains(search)) ||
                        (dataItem.Spec != null && dataItem.Spec.ToString().Contains(search)))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 2)
            {// sort Name
                list.Sort((x, y) => SortString(x.MillCn, y.MillCn, sortDirection));
            }
            else if (sortColumn == 3)
            {// sort Name
                list.Sort((x, y) => SortString(x.Heat, y.Heat, sortDirection));
            }
            else if (sortColumn == 4)
            {// sort Name
                list.Sort((x, y) => SortString(x.HtDesc, y.HtDesc, sortDirection));
            }
            else if (sortColumn == 5)
            {// sort Age
                list.Sort((x, y) => SortString(x.Material, y.Material, sortDirection));
            }
            else if (sortColumn == 6)
            {// sort Age
                list.Sort((x, y) => SortString(x.Spec, y.Spec, sortDirection));
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
