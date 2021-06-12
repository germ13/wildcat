using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeLoadMapFurnace
    {
        public TForgeLoadMapFurnace()
        {
            TForgeLoadMapBatch = new HashSet<TForgeLoadMapBatch>();
            TForgeLoadMapTag = new HashSet<TForgeLoadMapTag>();
        }

        public Guid SFurnaceGuid { get; set; }
        public string SFurnaceName { get; set; }
        public int? IWidth { get; set; }
        public int? IHeight { get; set; }
        public string SFurnaceType { get; set; }
        public bool BCenterColumn { get; set; }
        public int? ICenterColumnWidth { get; set; }
        public int? ICenterColumnHeight { get; set; }
        public decimal? DblDoorOpeningWidth { get; set; }
        public int? IRotationAngle { get; set; }
        public bool BLoadCcw { get; set; }
        public DateTime? DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TForgeLoadMapBatch> TForgeLoadMapBatch { get; set; }
        public ICollection<TForgeLoadMapTag> TForgeLoadMapTag { get; set; }
    }
}
