using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TUser
    {
        public TUser()
        {
            TControlledDocumentApproval = new HashSet<TControlledDocumentApproval>();
            TControlledDocumentAuthoringUser = new HashSet<TControlledDocumentAuthoringUser>();
            THelpDeskInvolvedUser = new HashSet<THelpDeskInvolvedUser>();
            TSecUserToGroup = new HashSet<TSecUserToGroup>();
            TUserExtendedProperty = new HashSet<TUserExtendedProperty>();
            TWidgetToUser = new HashSet<TWidgetToUser>();
        }

        public Guid SUserGuid { get; set; }
        public Guid? SEmployeeGuid { get; set; }
        public string SUserName { get; set; }
        public string SPassword { get; set; }
        public int ILoginAttempts { get; set; }
        public string SPinNum { get; set; }
        public DateTime? DtLastLogin { get; set; }
        public string SLastOpenSection { get; set; }
        public bool BIsUpdatingUser { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }

        public TEmployee SEmployeeGu { get; set; }
        public ICollection<TControlledDocumentApproval> TControlledDocumentApproval { get; set; }
        public ICollection<TControlledDocumentAuthoringUser> TControlledDocumentAuthoringUser { get; set; }
        public ICollection<THelpDeskInvolvedUser> THelpDeskInvolvedUser { get; set; }
        public ICollection<TSecUserToGroup> TSecUserToGroup { get; set; }
        public ICollection<TUserExtendedProperty> TUserExtendedProperty { get; set; }
        public ICollection<TWidgetToUser> TWidgetToUser { get; set; }
    }
}
