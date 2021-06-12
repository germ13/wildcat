using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TZendeskUserPhoto
    {
        public Guid SPhotoGuid { get; set; }
        public string SEmail { get; set; }
        public string SPhotoNetworkPath { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
