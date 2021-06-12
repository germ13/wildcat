using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportSpecimen
    {
        public Guid SSpecimenGuid { get; set; }
        public Guid STestGuid { get; set; }
        public string SSpecimenNumber { get; set; }
        public string SSampleNum { get; set; }
        public string SStatus { get; set; }
        public string SClassGradeCode { get; set; }
        public string SMaterial { get; set; }
        public string SHeatNumber { get; set; }
        public string SLotNumber { get; set; }
        public string SPartNumber { get; set; }
        public string SDrawingNumber { get; set; }
        public string SMill { get; set; }
        public string SSerialNum { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportTest STestGu { get; set; }
    }
}
