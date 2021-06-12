﻿using System;

namespace Wildcat.Entities.SHCA.ShultzBBx
{
    public partial class TR1jnl
    {
        public int IRecId { get; set; }
        public string SKey { get; set; }
        public string SInvoiceNumber { get; set; }
        public string SCustomerNumber { get; set; }
        public string SCustomerName { get; set; }
        public decimal? DblGrossAmount { get; set; }
        public decimal? DblTaxAmount { get; set; }
        public decimal? DblFreightAmount { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
