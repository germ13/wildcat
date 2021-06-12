using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TForgeLoadMapBatch
    {
        public TForgeLoadMapBatch()
        {
            TForgeLoadMapJob = new HashSet<TForgeLoadMapJob>();
        }

        public Guid SBatchGuid { get; set; }
        public string SBatchInstance { get; set; }
        public DateTime? DtCreated { get; set; }
        public DateTime DtRunScheduled { get; set; }
        public int IFurnaceAngle { get; set; }
        public Guid SFurnaceGuid { get; set; }
        public Guid? SAttachmentGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
        public DateTime? DtDoNotForgeBefore { get; set; }
        public DateTime? DtLightAtTime { get; set; }
        public bool BWillAdvise1 { get; set; }
        public int? ISetTemp1 { get; set; }
        public DateTime? DtRaiseAt1 { get; set; }
        public bool BLowerAtSelected1 { get; set; }
        public bool BWillAdvise2 { get; set; }
        public int? ISetTemp2 { get; set; }
        public DateTime? DtRaiseAt2 { get; set; }
        public bool BLowerAtSelected2 { get; set; }
        public bool BWillAdvise3 { get; set; }
        public int? ISetTemp3 { get; set; }
        public DateTime? DtRaiseAt3 { get; set; }
        public bool BLowerAtSelected3 { get; set; }
        public bool BWillAdvise4 { get; set; }
        public int? ISetTemp4 { get; set; }
        public string SOverTempSetPoint1Signed { get; set; }
        public string SOverTempSetPoint2Signed { get; set; }
        public string SOverTempSetPoint3Signed { get; set; }
        public string SNoteText { get; set; }
        public string SNoteRtf { get; set; }
        public int? IEstWeightLbs { get; set; }
        public DateTime? DtSigned { get; set; }
        public string SSignedBy { get; set; }
        public string SJobNumber { get; set; }

        public TForgeLoadMapFurnace SFurnaceGu { get; set; }
        public ICollection<TForgeLoadMapJob> TForgeLoadMapJob { get; set; }
    }
}
