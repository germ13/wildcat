using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportCompression
    {
        public TLabImportCompression()
        {
            TLabImportCompressionOffset = new HashSet<TLabImportCompressionOffset>();
        }

        public Guid SCompressionGuid { get; set; }
        public Guid STestGuid { get; set; }
        public string SSpecimenNumber { get; set; }
        public string SSpecimenDirection { get; set; }
        public string SRemarks { get; set; }
        public string SReqUom { get; set; }
        public decimal? DblGageDiameter { get; set; }
        public decimal? DblGageWidth { get; set; }
        public decimal? DblGageThickness { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportTest STestGu { get; set; }
        public ICollection<TLabImportCompressionOffset> TLabImportCompressionOffset { get; set; }
    }
}
