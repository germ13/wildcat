using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TInfoSysNewEmployeeDetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SNewEmpGuid { get; set; }
        public string SInfoNeeded { get; set; }
        public bool BRequired { get; set; }
        public string SNotesInstructions { get; set; }
        public string SIsdeptUse { get; set; }
        public int ISortOrder { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TInfoSysNewEmployeeMaster SNewEmpGu { get; set; }
    }
}
