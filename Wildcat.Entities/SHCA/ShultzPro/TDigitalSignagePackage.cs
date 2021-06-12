using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TDigitalSignagePackage
    {
        public TDigitalSignagePackage()
        {
            TDigitalSignagePackageDetail = new HashSet<TDigitalSignagePackageDetail>();
        }

        public Guid SPackageGuid { get; set; }
        public string SJobName { get; set; }
        public string STargetComputerName { get; set; }
        public string STargetIpaddress { get; set; }
        public DateTime DtRunPackageFrom { get; set; }
        public DateTime DtRunPackageTo { get; set; }
        public bool BEmergencyPackage { get; set; }
        public bool BScreenSaverPackage { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TDigitalSignagePackageDetail> TDigitalSignagePackageDetail { get; set; }
    }
}
