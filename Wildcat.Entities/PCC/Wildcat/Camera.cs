using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class Camera
    {
        public Camera()
        {
            CameraJob = new HashSet<CameraJob>();
        }

        public int Id { get; set; }
        public string LocationCode { get; set; }
        public string DisplayName { get; set; }
        public string Details { get; set; }
        public int MainType { get; set; }
        public int SubType { get; set; }
        public int Version { get; set; }
        public int Flags { get; set; }
        public int LogicalId { get; set; }
        public string NetworkAddress { get; set; }
        public string Model { get; set; }
        public string Firmware { get; set; }
        public string Archiver { get; set; }
        public string UserName { get; set; }
        public string UserNamePassword { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public ICollection<CameraJob> CameraJob { get; set; }
    }
}
