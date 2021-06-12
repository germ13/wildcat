using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMotionStudyJob
    {
        public TMotionStudyJob()
        {
            TMotionStudyDefinitionToJob = new HashSet<TMotionStudyDefinitionToJob>();
        }

        public Guid SJobGuid { get; set; }
        public string SJobNum { get; set; }
        public string SCustomer { get; set; }
        public string SOperation { get; set; }
        public string SMachineCode { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TMotionStudyDefinitionToJob> TMotionStudyDefinitionToJob { get; set; }
    }
}
