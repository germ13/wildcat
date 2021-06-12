using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class Machine
    {
        public Machine()
        {
            MachineNote = new HashSet<MachineNote>();
            MachineProperty = new HashSet<MachineProperty>();
        }

        public string Id { get; set; }
        public string MachineName { get; set; }
        public string LocationCode { get; set; }
        public string Status { get; set; }
        public bool Active { get; set; }
        public string Type { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Rowversion { get; set; }

        public MachineType TypeNavigation { get; set; }
        public ICollection<MachineNote> MachineNote { get; set; }
        public ICollection<MachineProperty> MachineProperty { get; set; }
    }
}
