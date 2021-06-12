using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TScheduleJobResource
    {
        public Guid SResourceGuid { get; set; }
        public int IUniqueId { get; set; }
        public int IResourceId { get; set; }
        public string SResourceName { get; set; }
        public int? IColor { get; set; }
        public byte[] BImage { get; set; }
        public string SCustomField1 { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
