using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeLoadMapItem
    {
        public TForgeLoadMapItem()
        {
            TForgeLoadMapDetail = new HashSet<TForgeLoadMapDetail>();
        }

        public Guid SItemGuid { get; set; }
        public decimal? DblPartLength { get; set; }
        public decimal? DblPartWidth { get; set; }
        public string SJobNum { get; set; }
        public string SImagePathLarge { get; set; }
        public string SImagePathSmall { get; set; }
        public int? IImageHeight { get; set; }
        public int? IImageWidth { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TForgeLoadMapDetail> TForgeLoadMapDetail { get; set; }
    }
}
