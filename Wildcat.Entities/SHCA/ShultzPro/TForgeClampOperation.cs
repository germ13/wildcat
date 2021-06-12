using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeClampOperation
    {
        public TForgeClampOperation()
        {
            TForgeClampDetail = new HashSet<TForgeClampDetail>();
        }

        public Guid SOpGuid { get; set; }
        public Guid SMasterGuid { get; set; }
        public string SOperation { get; set; }
        public string SFlashTextTop { get; set; }
        public string SFlashTextBottom { get; set; }
        public string SDieLocationTopLeft { get; set; }
        public string SDieLocationTopRight { get; set; }
        public string SDieLocationBottomLeft { get; set; }
        public string SDieLocationBottomRight { get; set; }
        public Guid? STopLeftImageAttachmentGuid { get; set; }
        public Guid? STopRightImageAttachmentGuid { get; set; }
        public Guid? SBottomLeftImageAttachmentGuid { get; set; }
        public Guid? SBottomRightImageAttachmentGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TForgeClampMaster SMasterGu { get; set; }
        public ICollection<TForgeClampDetail> TForgeClampDetail { get; set; }
    }
}
