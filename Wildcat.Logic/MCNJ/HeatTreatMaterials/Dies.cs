using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.MCNJ.HeatsSecured;
using Wildcat.Utilities;

namespace Wildcat.Logic.MCNJ.HeatTreatMaterials
{
    public class HeatTreatMaterials_DieClass
    {
        #region Private Fields

        private HeatsSecuredContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public HeatTreatMaterials_DieClass(HeatsSecuredContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 

        /// <summary>
        /// get a die
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public Dies Get(string ID)
        {
            Dies die = null;
            using (var context = new HeatsSecuredContext())
            {
                die = context.Dies.Where(x => x.Die == ID).FirstOrDefault();
            }

            return die;
        }

        /// <summary>
        /// add a die
        /// </summary>
        /// <param name="Die"></param>
        /// <param name="PartNum"></param>
        /// <param name="AuxDoc"></param>
        /// <param name="Revision"></param>
        /// <param name="PartDescription"></param>
        /// <param name="ProcessNo"></param>
        /// <param name="StdhtrNotes"></param>
        /// <param name="StdcertNotes"></param>
        /// <returns></returns>
        public Dies Add(string Die, string PartNum, string AuxDoc, string Revision, string PartDescription, string ProcessNo, string StdhtrNotes, string StdcertNotes, string requestor)
        {
            Dies die = new Dies
            {
                Die = Die.ToUpper(),
                PartNum = PartNum == null ? "" : PartNum,
                AuxDoc = AuxDoc == null ? "" : AuxDoc,
                Revision = Revision == null ? "" : Revision,
                PartDescription = PartDescription == null ? "" : PartDescription,
                ProcessNo = ProcessNo == null ? "" : ProcessNo,
                StdhtrNotes = StdhtrNotes == null ? "" : StdhtrNotes,
                StdcertNotes = StdcertNotes == null ? "" : StdcertNotes,
            };

            _context.Add(die);
            _context.SaveChanges();

            return die;
        }

        /// <summary>
        /// edit a die
        /// </summary>
        /// <param name="Die"></param>
        /// <param name="PartNum"></param>
        /// <param name="AuxDoc"></param>
        /// <param name="Revision"></param>
        /// <param name="PartDescription"></param>
        /// <param name="ProcessNo"></param>
        /// <param name="StdhtrNotes"></param>
        /// <param name="StdcertNotes"></param>
        /// <returns></returns>
        public Dies Edit(string Die, string PartNum, string AuxDoc, string Revision, string PartDescription, string ProcessNo, string StdhtrNotes, string StdcertNotes, string requestor)
        {
            Dies die = _context.Dies.Where(x => x.Die == Die).FirstOrDefault();
            die.PartNum = PartNum == null ? "" : PartNum;
            die.AuxDoc = AuxDoc == null ? "" : AuxDoc;
            die.Revision = Revision == null ? "" : Revision;
            die.PartDescription = PartDescription == null ? "" : PartDescription;
            die.ProcessNo = ProcessNo == null ? "" : ProcessNo;
            die.StdhtrNotes = StdhtrNotes == null ? "" : StdhtrNotes;
            die.StdcertNotes = StdcertNotes == null ? "" : StdcertNotes;
            _context.SaveChanges();

            return die;
        }

        public List<Wildcat.Entities.MCNJ.HeatsSecured.Dies> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<Wildcat.Entities.MCNJ.HeatsSecured.Dies> list = new List<Wildcat.Entities.MCNJ.HeatsSecured.Dies>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.Dies.ToList();
            }
            else
            {
                // simulate search
                foreach (var dataItem in _context.Dies)
                {
                    if ((dataItem.Die != null && dataItem.Die.ToString().Contains(search.ToUpper())) ||
                        (dataItem.PartNum != null && dataItem.PartNum.ToString().Contains(search)) ||
                        (dataItem.AuxDoc != null && dataItem.AuxDoc.ToString().Contains(search)) ||
                        (dataItem.Revision != null && dataItem.Revision.ToString().Contains(search)) ||
                        (dataItem.ProcessNo != null && dataItem.ProcessNo.ToString().Contains(search)))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Name
                list.Sort((x, y) => SortString(x.Die, y.Die, sortDirection));
            }
            else if (sortColumn == 1)
            {// sort Name
                list.Sort((x, y) => SortString(x.PartNum, y.PartNum, sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Name
                list.Sort((x, y) => SortString(x.AuxDoc, y.AuxDoc, sortDirection));
            }
            else if (sortColumn == 3)
            {// sort Age
                list.Sort((x, y) => SortString(x.Revision.ToString(), y.Revision.ToString(), sortDirection));
            }
            else if (sortColumn == 4)
            {// sort Age
                list.Sort((x, y) => SortString(x.ProcessNo.ToString(), y.ProcessNo.ToString(), sortDirection));
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
