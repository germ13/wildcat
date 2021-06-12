using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TZipCode
    {
        public TZipCode()
        {
            TCity = new HashSet<TCity>();
        }

        public Guid SZipGuid { get; set; }
        public string SZipCode { get; set; }
        public Guid? SStateGuid { get; set; }
        public decimal? DblLatitude { get; set; }
        public decimal? DblLongitude { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TState SStateGu { get; set; }
        public ICollection<TCity> TCity { get; set; }
    }
}
