using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TWidget
    {
        public TWidget()
        {
            TWidgetToUser = new HashSet<TWidgetToUser>();
        }

        public Guid SWidgetGuid { get; set; }
        public string SCategory { get; set; }
        public string STitle { get; set; }
        public string SDescription { get; set; }
        public string SImagePath { get; set; }
        public Guid? SControlKeyGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TWidgetToUser> TWidgetToUser { get; set; }
    }
}
