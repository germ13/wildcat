using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TPcc004FileList
    {
        public TPcc004FileList()
        {
            TPcc004 = new HashSet<TPcc004>();
        }

        public Guid SFileGuid { get; set; }
        public string SFileName { get; set; }
        public DateTime DtRun { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TPcc004> TPcc004 { get; set; }
    }
}
