using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSecObject
    {
        public TSecObject()
        {
            TSecGroupToObject = new HashSet<TSecGroupToObject>();
        }

        public Guid SObjectGuid { get; set; }
        public Guid? SParentObjectGuid { get; set; }
        public string SType { get; set; }
        public string SMenuName { get; set; }
        public string SMenuText { get; set; }
        public string SNavBarKey { get; set; }
        public string SNavBarText { get; set; }
        public string SNavBarTextColor { get; set; }
        public string SNavBarTextDesc { get; set; }
        public string SNavBarTextDescColor { get; set; }
        public string SNavBarExtDesc { get; set; }
        public string SNavBarImage { get; set; }
        public int INavButtonColumn { get; set; }
        public string SScreenName { get; set; }
        public string SScreenText { get; set; }
        public string SControlName { get; set; }
        public string SGridColumnName { get; set; }
        public string SToolTip { get; set; }
        public string SHelpHref { get; set; }
        public string SFormHref { get; set; }
        public string SFormName { get; set; }
        public string SWebUrl { get; set; }
        public bool BVisibleToAdminOnly { get; set; }
        public bool BHideFromTreeView { get; set; }
        public bool BIsWindows { get; set; }
        public bool BIsWeb { get; set; }
        public int? ISortOrder { get; set; }
        public string SLineage { get; set; }
        public string SLineageSort { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TSecGroupToObject> TSecGroupToObject { get; set; }
    }
}
