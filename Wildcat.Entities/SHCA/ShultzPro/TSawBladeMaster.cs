using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSawBladeMaster
    {
        public TSawBladeMaster()
        {
            TSawBladeDetail = new HashSet<TSawBladeDetail>();
        }

        public Guid SBladeMasterGuid { get; set; }
        public string SBladeNum { get; set; }
        public string SToothType { get; set; }
        public string SManufacturer { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TSawBladeDetail> TSawBladeDetail { get; set; }
    }
}
