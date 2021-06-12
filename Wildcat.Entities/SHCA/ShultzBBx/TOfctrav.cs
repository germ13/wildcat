using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TOfctrav
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SJobNumber { get; set; }
        public string SQa180number { get; set; }
        public string SBrownFolderCreateDate { get; set; }
        public string SBrownFolderCreator { get; set; }
        public string SSalesManagerReviewEstDate { get; set; }
        public string SSalesManagerReviewActdDate { get; set; }
        public string SQualityReviewEstDate { get; set; }
        public string SQualityReviewActDate { get; set; }
        public string SStockReservationEstDate { get; set; }
        public string SStockReservationActDate { get; set; }
        public string SOrderEnteredActDate { get; set; }
        public string SOrderEnteredEstDate { get; set; }
        public string SOrderPrintedActDate { get; set; }
        public string SOrderPrintedEstDate { get; set; }
        public string SOeCopiesForPcestDate { get; set; }
        public string SOeCopiesForPcactDate { get; set; }
        public string SAccountingApprovalActDate { get; set; }
        public string SAccountingApprovalEstDate { get; set; }
        public string SDistrAndAckSentEstDate { get; set; }
        public string SDistrAndAckSentActDate { get; set; }
        public string STravelerPrepTrialPrtEstDate { get; set; }
        public string STravelerPrepTrialPrtActDate { get; set; }
        public string SEngineeringApprovalEstDate { get; set; }
        public string SEngineeringApprovalActDate { get; set; }
        public string SQcmetallurgyApprovalEstDate { get; set; }
        public string SQcmetallurgyApprovalActDate { get; set; }
        public string STrialTravelerReprintEstDate { get; set; }
        public string STrialTravelerReprintActDate { get; set; }
        public string SFinalTravelerReprintEstDate { get; set; }
        public string SFinalTravelerReprintActDate { get; set; }
        public string SEstCashVerifiedEstDate { get; set; }
        public string SEstCashVerifiedActDate { get; set; }
        public string STravelersPrintedFinalEstDate { get; set; }
        public string STravelersPrintedFinalActDate { get; set; }
        public string SMachiningCopyEstDate { get; set; }
        public string SMachiningCopyActDate { get; set; }
        public string SFinalTravelerApprovalEstDate { get; set; }
        public string SFinalTravelerApprovalActDate { get; set; }
        public string STravelerDistributedEstDate { get; set; }
        public string STravelerDistributedActDate { get; set; }
        public string SHydra01 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
