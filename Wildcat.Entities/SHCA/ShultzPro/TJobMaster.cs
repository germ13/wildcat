using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TJobMaster
    {
        public TJobMaster()
        {
            TJobDetail = new HashSet<TJobDetail>();
        }

        public Guid SMasterGuid { get; set; }
        public string SFilePath { get; set; }
        public string SJob { get; set; }
        public string SVersion { get; set; }
        public string SHeader { get; set; }
        public string SFooter { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TJobDetail> TJobDetail { get; set; }
    }
}
