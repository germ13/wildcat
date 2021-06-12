using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THelpDeskAsset
    {
        public THelpDeskAsset()
        {
            THelpDeskAssetNote = new HashSet<THelpDeskAssetNote>();
            THelpDeskAssetToRequest = new HashSet<THelpDeskAssetToRequest>();
        }

        public Guid SAssetGuid { get; set; }
        public string SAssetType { get; set; }
        public string SName { get; set; }
        public string SIdtag { get; set; }
        public string SSerialNum { get; set; }
        public Guid? SParentAssetGuid { get; set; }
        public Guid? SCompanyGuid { get; set; }
        public Guid? SDeptGuid { get; set; }
        public Guid? SUserGuid { get; set; }
        public bool BAllocatedToStock { get; set; }
        public Guid? SProductGuid { get; set; }
        public Guid? SVendorGuid { get; set; }
        public Guid? SAttachmentGuid { get; set; }
        public decimal? CurCost { get; set; }
        public DateTime? DtAcquisition { get; set; }
        public DateTime? DtWarrantyExpiration { get; set; }
        public string SDisposition { get; set; }
        public DateTime? DtRemovedFromService { get; set; }
        public DateTime? DtLastBackup { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<THelpDeskAssetNote> THelpDeskAssetNote { get; set; }
        public ICollection<THelpDeskAssetToRequest> THelpDeskAssetToRequest { get; set; }
    }
}
