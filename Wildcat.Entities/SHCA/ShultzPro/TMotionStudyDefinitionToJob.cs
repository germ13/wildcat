using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMotionStudyDefinitionToJob
    {
        public Guid SLinkGuid { get; set; }
        public Guid SJobGuid { get; set; }
        public Guid SDefinitionGuid { get; set; }
        public string SNewText { get; set; }
        public int ISortOrder { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMotionStudyDefinition SDefinitionGu { get; set; }
        public TMotionStudyJob SJobGu { get; set; }
    }
}
