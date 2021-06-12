using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.SHCA.EngineeringData;
using Wildcat.Utilities;

namespace Wildcat.Logic.SHCA.Engineering.Kepware
{
    public class KepwareMachineLogic
    {
        #region Private Fields

        private EngineeringDataContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties

        public enum Status
        {
            Active = 0,
            InProcess = 1,
            Completed = 2,
            Failed = 3
        }

        #endregion Public Properties



        #region Constructors

        public KepwareMachineLogic(EngineeringDataContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 

        public List<KepwareMachine> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<KepwareMachine> listdto = new List<KepwareMachine>();
            if (string.IsNullOrEmpty(search))
            {
                listdto = _context.KepwareMachine.ToList();
            }
            else
            {
                foreach (KepwareMachine dataItem in _context.KepwareMachine)
                {
                    if ((dataItem.KepwareMachineId != null && dataItem.KepwareMachineId.ToUpper().Contains(search.ToUpper())) ||
                        (dataItem.DisplayName != null && dataItem.DisplayName.ToString().Contains(search)))
                    {
                        listdto.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                listdto.Sort((x, y) => SortString(x.KepwareMachineId.ToString(), y.KepwareMachineId.ToString(), sortDirection));
            }
            else if (sortColumn == 1)
            {// sort Age
                listdto.Sort((x, y) => SortString(x.DisplayName.ToString(), y.DisplayName.ToString(), sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Age
                listdto.Sort((x, y) => SortString(x.Active.ToString(), y.Active.ToString(), sortDirection));
            }
            else if (sortColumn == 3)
            {// sort Age
                listdto.Sort((x, y) => SortDateTime(x.Added.ToString(), y.Added.ToString(), sortDirection));
            }
            //else if (sortColumn == 4)
            //{// sort Name
            //    listdto.Sort((x, y) => SortDateTime(x.Added.ToString(), y.Added.ToString(), sortDirection));
            //}

            recordFiltered = listdto.Count;

            // get just one page of data
            listdto = listdto.GetRange(start, Math.Min(length, listdto.Count - start));

            return listdto;
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
