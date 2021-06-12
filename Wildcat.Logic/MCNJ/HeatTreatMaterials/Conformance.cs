using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.MCNJ.HeatsSecured;
using Wildcat.Utilities;

namespace Wildcat.Logic.MCNJ.HeatTreatMaterials
{
    public class HeatTreatMaterials_ConformanceClass
    {
        #region Private Fields

        private HeatsSecuredContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public HeatTreatMaterials_ConformanceClass(HeatsSecuredContext context, IViewRenderService viewRenderService)
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
        public CertsMcW Get(string ID)
        {
            var id = Convert.ToInt32(ID);
            return _context.CertsMcW.Where(x => x.McWCn == id).FirstOrDefault();
        }

        /// <summary>
        /// add a cert
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
        public static CertsMcW Add(HeatsSecuredContext context, IViewRenderService viewRenderService, int McWCn, int? Crn, DateTime? Date, int? CustId, string CustPo, string Heat, string GsMcW, string Hardness, string HeatTreatNotes, string CertificationNotes, string ProcessNo, string NoteType, int? QtyShipped, string Die, string WorkOrder, string requestor)
        {
            CertsMcW cert = new CertsMcW
            {
                Crn = Crn,
                McWCn = McWCn,
                Date = Date,
                CustId = CustId,
                CustPo = CustPo == null ? "" : CustPo,
                Heat = Heat == null ? "" : Heat,
                GsMcW = GsMcW == null ? "" : GsMcW,
                Hardness = Hardness == null ? "" : Hardness,
                HeatTreatNotes = HeatTreatNotes == null ? "" : HeatTreatNotes,
                CertificationNotes = CertificationNotes == null ? "" : CertificationNotes,
                ProcessNo = ProcessNo == null ? "" : ProcessNo,
                NoteType = NoteType == null ? "" : NoteType,
                QtyShipped = QtyShipped,
                Die = Die == null ? "" : Die,
                WorkOrder = WorkOrder == null ? "" : WorkOrder,
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
        public static CertsMcW Edit(HeatsSecuredContext context, IViewRenderService viewRenderService, int McWCn, int? Crn, DateTime? Date, int? CustId, string CustPo, string Heat, string GsMcW, string Hardness, string HeatTreatNotes, string CertificationNotes, string ProcessNo, string NoteType, int? QtyShipped, string Die, string WorkOrder, string requestor)
        {
            CertsMcW cert = context.CertsMcW.Where(x => x.McWCn == McWCn).FirstOrDefault();
            cert.Crn = Crn == null ? null : Crn;
            cert.McWCn = McWCn;
            cert.Date = Date == null ? cert.Date : Date;
            cert.CustId = CustId == null ? cert.CustId : CustId;
            cert.CustPo = CustPo == null ? cert.CustPo : CustPo;
            cert.Heat = Heat == null ? cert.Heat : Heat;
            cert.GsMcW = GsMcW == null ? cert.GsMcW : GsMcW;
            cert.Hardness = Hardness == null ? cert.Hardness : Hardness;
            cert.HeatTreatNotes = HeatTreatNotes == null ? cert.HeatTreatNotes : HeatTreatNotes;
            cert.CertificationNotes = CertificationNotes == null ? cert.CertificationNotes : CertificationNotes;
            cert.ProcessNo = ProcessNo == null ? cert.ProcessNo : ProcessNo;
            cert.NoteType = NoteType == null ? cert.NoteType : NoteType;
            cert.QtyShipped = QtyShipped;
            cert.Die = Die == null ? cert.Die : Die;
            cert.WorkOrder = WorkOrder == null ? cert.WorkOrder : WorkOrder;

            context.SaveChanges();

            return cert;
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

        public List<Wildcat.Entities.MCNJ.HeatsSecured.CertsMcW> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<Wildcat.Entities.MCNJ.HeatsSecured.CertsMcW> list = new List<Wildcat.Entities.MCNJ.HeatsSecured.CertsMcW>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.CertsMcW.ToList();
            }
            else
            {
                // simulate search
                foreach (var dataItem in _context.CertsMcW)
                {
                    if ((dataItem.CustPo != null && dataItem.CustPo.ToString().Contains(search)) ||
                        (dataItem.Heat != null && dataItem.Heat.ToString().Contains(search)) ||
                        (dataItem.GsMcW != null && dataItem.GsMcW.ToString().Contains(search)) ||
                        (dataItem.Hardness != null && dataItem.Hardness.ToString().Contains(search)) ||
                        (dataItem.HeatTreatNotes != null && dataItem.HeatTreatNotes.ToString().Contains(search)) ||
                        (dataItem.CertificationNotes != null && dataItem.CertificationNotes.ToString().Contains(search)) ||
                        (dataItem.ProcessNo != null && dataItem.ProcessNo.ToString().Contains(search)) ||
                        (dataItem.NoteType != null && dataItem.NoteType.ToString().Contains(search)) ||
                        (dataItem.Die != null && dataItem.Die.ToString().Contains(search)) ||
                        (dataItem.WorkOrder != null && dataItem.WorkOrder.ToString().Contains(search)))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Name
                list.Sort((x, y) => SortInteger(x.McWCn, y.McWCn, sortDirection));
            }
            else if (sortColumn == 4)
            {// sort Name
                list.Sort((x, y) => SortString(x.CustPo, y.CustPo, sortDirection));
            }
            else if (sortColumn == 5)
            {// sort Name
                list.Sort((x, y) => SortString(x.WorkOrder, y.WorkOrder, sortDirection));
            }
            else if (sortColumn == 6)
            {// sort Age
                list.Sort((x, y) => SortString(x.Heat, y.Heat, sortDirection));
            }
            else if (sortColumn == 7)
            {// sort Age
                list.Sort((x, y) => SortString(x.GsMcW, y.GsMcW, sortDirection));
            }
            else if (sortColumn == 8)
            {// sort Age
                list.Sort((x, y) => SortString(x.Hardness, y.Hardness, sortDirection));
            }
            else if (sortColumn == 9)
            {// sort Age
                list.Sort((x, y) => SortString(x.HeatTreatNotes, y.HeatTreatNotes, sortDirection));
            }
            else if (sortColumn == 10)
            {// sort Age
                list.Sort((x, y) => SortString(x.CertificationNotes, y.CertificationNotes, sortDirection));
            }
            else if (sortColumn == 11)
            {// sort Age
                list.Sort((x, y) => SortString(x.ProcessNo, y.ProcessNo, sortDirection));
            }
            else if (sortColumn == 12)
            {// sort Age
                list.Sort((x, y) => SortString(x.NoteType, y.NoteType, sortDirection));
            }
            else if (sortColumn == 14)
            {// sort Age
                list.Sort((x, y) => SortString(x.Die, y.Die, sortDirection));
            }
            else if (sortColumn == 15)
            {// sort Age
                list.Sort((x, y) => SortString(x.WorkOrder, y.WorkOrder, sortDirection));
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
