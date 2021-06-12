using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class MachineType
    {
        public MachineType()
        {
            Machine = new HashSet<Machine>();
        }

        public string Id { get; set; }
        public string MachineType1 { get; set; }
        public string LocationCode { get; set; }
        public string Definition { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }

        public ICollection<Machine> Machine { get; set; }
    }
}
