using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportHeatTreatmentLine
    {
        public Guid SHtlineGuid { get; set; }
        public Guid SHtguid { get; set; }
        public string SValue { get; set; }
        public string SRecId { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportHeatTreatment SHtgu { get; set; }
    }
}
