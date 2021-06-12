using System;
using System.Collections.Generic;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class CameraJob
    {
        public CameraJob()
        {
            CameraJobSnapshot = new HashSet<CameraJobSnapshot>();
        }

        public int Id { get; set; }
        public int EndUserId { get; set; }
        public int CameraId { get; set; }
        public string JobStatus { get; set; }
        public DateTime StartTime { get; set; }
        public int FrequencyInSeconds { get; set; }
        public int? FrequencyThreshold { get; set; }
        public DateTime? EndTimeThreshold { get; set; }
        public Guid? SnapshotNamePrefix { get; set; }
        public bool Active { get; set; }
        public DateTime Added { get; set; }
        public string AddedBy { get; set; }
        public DateTime? Updated { get; set; }
        public string UpdatedBy { get; set; }

        public Camera Camera { get; set; }
        public ICollection<CameraJobSnapshot> CameraJobSnapshot { get; set; }
    }
}
