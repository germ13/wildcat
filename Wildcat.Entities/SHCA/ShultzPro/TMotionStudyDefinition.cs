using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMotionStudyDefinition
    {
        public TMotionStudyDefinition()
        {
            TMotionStudyDefinitionToJob = new HashSet<TMotionStudyDefinitionToJob>();
        }

        public Guid SDefinitionGuid { get; set; }
        public string SMachineName { get; set; }
        public string SLetterCode { get; set; }
        public string SDescription { get; set; }
        public int ISortOrder { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TMotionStudyDefinitionToJob> TMotionStudyDefinitionToJob { get; set; }
    }
}
