using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TFcsmandata
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SJobNumber { get; set; }
        public string SOverRide { get; set; }
        public string SMilestoneNotes { get; set; }
        public string SActionRequiredBy { get; set; }
        public string SLocation { get; set; }
        public string SCprJobCode { get; set; }
        public string SMaterialType { get; set; }
        public DateTime? DtMaterialReadyDate { get; set; }
        public string SLotQuantity { get; set; }
        public DateTime? DtVarstartDate { get; set; }
        public DateTime? DtConverstionStartDate { get; set; }
        public DateTime? DtJobStartDate { get; set; }
        public string SCustomerBackOffDays { get; set; }
        public DateTime? DtPlannedShipDate { get; set; }
        public string SJobStarted { get; set; }
        public DateTime? DtFirestoneCompletionDate { get; set; }
        public string SFirestoneComplete { get; set; }
        public string SDueDateOverride { get; set; }
        public string SFinishForgeDateOverride { get; set; }
        public string SFinishForgeDone { get; set; }
        public string SOpen01 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
