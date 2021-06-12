using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TE4ref
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SPoNumber { get; set; }
        public string SJobNumber { get; set; }
        public string SBackOrderSequence { get; set; }
        public DateTime? DtDateOrderReceived { get; set; }
        public DateTime? DtDueDate { get; set; }
        public DateTime? DtShipDate { get; set; }
        public string SBackOrderCode { get; set; }
        public string SMachineCode { get; set; }
        public string SCustomerNumber { get; set; }
        public string SMicrofilm { get; set; }
        public string SHydra01 { get; set; }
        public string SHydra02 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
