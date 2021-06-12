using System;

namespace Wildcat.Entities.PCC.Wildcat
{
    public partial class CameraJobSnapshot
    {
        public int Id { get; set; }
        public int CameraJobId { get; set; }
        public string FileNamePath { get; set; }
        public DateTime? Added { get; set; }
        public string AddedBy { get; set; }

        public CameraJob CameraJob { get; set; }
    }
}
