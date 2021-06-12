using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeLoadMapDetailRegister
    {
        public Guid SRegisterGuid { get; set; }
        public Guid SDetailGuid { get; set; }
        public string SActionType { get; set; }
        public string SMachine { get; set; }
        public DateTime DtStart { get; set; }
        public DateTime? DtEnd { get; set; }
        public int IFurnaceAngle { get; set; }
        public decimal DblPerctFromRadius { get; set; }
        public decimal DblAngleOnFurnace { get; set; }
        public decimal DblPerctWidthOfCanvas { get; set; }
        public decimal DblPerctHeightOfCanvas { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TForgeLoadMapDetail SDetailGu { get; set; }
    }
}
