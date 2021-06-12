using System;
using System.Collections.Generic;
using System.Linq;
using Wildcat.Entities.PCC.Wildcat;
using Wildcat.Utilities;

namespace Wildcat.Logic.Administration.SecurityGroups
{
    public class SecurityGroupsAdministration
    {
        #region Private Fields

        private WildcatContext _context;
        private IViewRenderService _viewRenderService;

        #endregion Private Fields



        #region Public Properties
        #endregion Public Properties



        #region Constructors

        public SecurityGroupsAdministration(WildcatContext context, IViewRenderService viewRenderService)
        {
            _context = context;
            _viewRenderService = viewRenderService;
        }

        #endregion Constructors



        #region Public Methods 

        public List<SecurityGroup> FilterData(ref int recordFiltered, int start, int length, string search, int sortColumn, string sortDirection)
        {
            List<SecurityGroup> list = new List<SecurityGroup>();
            if (string.IsNullOrEmpty(search))
            {
                list = _context.SecurityGroup.ToList(); ;
            }
            else
            {
                // simulate search
                foreach (SecurityGroup dataItem in _context.SecurityGroup)
                {
                    if ((dataItem.SecurityName != null && dataItem.SecurityName.ToString().Contains(search)))
                    {
                        list.Add(dataItem);
                    }
                }
            }

            // simulate sort
            if (sortColumn == 0)
            {// sort Age
                list.Sort((x, y) => SortString(x.SecurityName.ToString(), y.SecurityName.ToString(), sortDirection));
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
