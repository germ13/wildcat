using System;

namespace Wildcat.Entities.MCNJ.DCR
{
    public partial class TblDcr
    {
        public int Dcrnumber { get; set; }
        public string RequestedBy { get; set; }
        public DateTime? RequestedDate { get; set; }
        public string ToolNumber { get; set; }
        public string Unit { get; set; }
        public string Reason { get; set; }
        public string Description { get; set; }
        public string EngApproval { get; set; }
        public string EngApprovalSignature { get; set; }
        public DateTime? EngApprovalDate { get; set; }
        public string DateRequired { get; set; }
        public string HoldProductionYesOrNo { get; set; }
        public string ToolsChangedYesOrNo { get; set; }
        public string DieShopSignature { get; set; }
        public DateTime? DieShopSignatureDate { get; set; }
        public byte[] SsmaTimeStamp { get; set; }
    }
}
