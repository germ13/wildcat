using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Utilities;

namespace Wildcat.Logic.Administration.Users
{
    public class UserAdministration
    {
        #region Private Fields

        private WildcatContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties


        #endregion Public Properties



        #region Constructors

        public UserAdministration(WildcatContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 
        public List<EndUser> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<EndUser> list = new List<EndUser>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.EndUser.ToList(); ;
            }
            else
            {
                // simulate search
                foreach (EndUser dataItem in _context.EndUser)
                {
                    if ((dataItem.AppLoginName != null && dataItem.AppLoginName.ToString().Contains(search)) ||
                        (dataItem.DisplayName != null && dataItem.DisplayName.ToString().Contains(search)) ||
                        (dataItem.Domain != null && dataItem.Domain.ToString().Contains(search)) ||
                        (dataItem.Email != null && dataItem.Email.ToString().Contains(search)))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                list.Sort((x, y) => SortString(x.AppLoginName.ToString(), y.AppLoginName.ToString(), sortDirection));
            }
            else if (sortColumn == 1)
            {// sort Age
                list.Sort((x, y) => SortString(x.DisplayName.ToString(), y.DisplayName.ToString(), sortDirection));
            }
            else if (sortColumn == 2)
            {// sort Age
                list.Sort((x, y) => SortInteger(x.Domain.ToString(), y.Domain.ToString(), sortDirection));
            }
            else if (sortColumn == 3)
            {// sort Name
                list.Sort((x, y) => SortString(x.Email, y.Email, sortDirection));
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
