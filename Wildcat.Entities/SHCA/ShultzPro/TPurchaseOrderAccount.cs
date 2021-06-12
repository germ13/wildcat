using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPurchaseOrderAccount
    {
        public Guid SRecGuid { get; set; }
        public Guid SPoguid { get; set; }
        public Guid? SDepartmentGuid { get; set; }
        public Guid? SAccountGuid { get; set; }
        public string SAccountNum { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TPurchaseOrder SPogu { get; set; }
    }
}
