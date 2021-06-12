﻿using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TCustomerContactAddress
    {
        public Guid SAddressGuid { get; set; }
        public Guid SContactGuid { get; set; }
        public string STypeCode { get; set; }
        public string SAddress1 { get; set; }
        public string SAddress2 { get; set; }
        public string SCity { get; set; }
        public string SState { get; set; }
        public string SPostalCode { get; set; }
        public string SCountry { get; set; }
        public string SAddressHash { get; set; }
        public bool BIsDefault { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TCustomerContact SContactGu { get; set; }
    }
}
