using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class Job
    {
        public Job()
        {
            SerialNumber = new HashSet<SerialNumber>();
        }

        public string JobNumber { get; set; }
        public string LocationCode { get; set; }
        public string CustomerId { get; set; }
        public string PartNumber { get; set; }
        public string DimensionNotes { get; set; }
        public string GeneralNotes { get; set; }
        public string MaterialNotes { get; set; }
        public string WeightNotes { get; set; }
        public string ProspectNotes { get; set; }
        public string OtherNotes { get; set; }
        public string TestingNotes { get; set; }
        public string QualityNotes { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public DateTime? Updated { get; set; }
        public string AddedBy { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<SerialNumber> SerialNumber { get; set; }
    }
}
