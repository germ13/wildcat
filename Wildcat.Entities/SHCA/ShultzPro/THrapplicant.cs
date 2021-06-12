using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class THrapplicant
    {
        public THrapplicant()
        {
            THrapplicantDate = new HashSet<THrapplicantDate>();
        }

        public Guid SApplicantGuid { get; set; }
        public string SFirstName { get; set; }
        public string SLastName { get; set; }
        public string SGender { get; set; }
        public string SEthnicity { get; set; }
        public int IApplicantNumber { get; set; }
        public string SStatusCode { get; set; }
        public string SJobCode { get; set; }
        public string SRecruiterSupervisor { get; set; }
        public string SReferralSource { get; set; }
        public bool BIsVeteran { get; set; }
        public bool BIsDisabled { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<THrapplicantDate> THrapplicantDate { get; set; }
    }
}
