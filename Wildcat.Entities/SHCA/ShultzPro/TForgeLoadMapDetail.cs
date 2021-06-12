using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeLoadMapDetail
    {
        public TForgeLoadMapDetail()
        {
            TForgeLoadMapDetailRegister = new HashSet<TForgeLoadMapDetailRegister>();
            TForgeLoadMapWorkBatch = new HashSet<TForgeLoadMapWorkBatch>();
        }

        public Guid SDetailGuid { get; set; }
        public Guid SLoadMapGuid { get; set; }
        public Guid SItemGuid { get; set; }
        public string SSerialNum { get; set; }
        public decimal DblPerctFromRadius { get; set; }
        public decimal DblAngleOnFurnace { get; set; }
        public decimal? DblAngleOnFurnaceOriginal { get; set; }
        public decimal DblPerctWidthOfCanvas { get; set; }
        public decimal DblPerctHeightOfCanvas { get; set; }
        public bool BHasPartBeenProcessed { get; set; }
        public bool BHasPartBeenTransfered { get; set; }
        public bool BHasPartBeenBackCharged { get; set; }
        public bool BPrematurelyUnloaded { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
        public string SPartType { get; set; }
        public bool BHasPartBeenInitialLoaded { get; set; }

        public TForgeLoadMapItem SItemGu { get; set; }
        public TForgeLoadMapJob SLoadMapGu { get; set; }
        public ICollection<TForgeLoadMapDetailRegister> TForgeLoadMapDetailRegister { get; set; }
        public ICollection<TForgeLoadMapWorkBatch> TForgeLoadMapWorkBatch { get; set; }
    }
}
