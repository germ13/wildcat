using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TGasMeter
    {
        public TGasMeter()
        {
            TGasMeterReading = new HashSet<TGasMeterReading>();
        }

        public Guid SMeterGuid { get; set; }
        public string SMeterName { get; set; }
        public string SMeterIp { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TGasMeterReading> TGasMeterReading { get; set; }
    }
}
