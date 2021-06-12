using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TState
    {
        public TState()
        {
            TCity = new HashSet<TCity>();
            TZipCode = new HashSet<TZipCode>();
        }

        public Guid SStateGuid { get; set; }
        public string SStateCode { get; set; }
        public string SStateName { get; set; }
        public Guid? SCountryGuid { get; set; }
        public decimal DblTaxRate { get; set; }
        public bool BIsDefault { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TCity> TCity { get; set; }
        public ICollection<TZipCode> TZipCode { get; set; }
    }
}
