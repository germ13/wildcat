using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TInfoSysNewEmployeeMaster
    {
        public TInfoSysNewEmployeeMaster()
        {
            TInfoSysNewEmployeeDetail = new HashSet<TInfoSysNewEmployeeDetail>();
        }

        public Guid SNewEmpGuid { get; set; }
        public DateTime DtRequest { get; set; }
        public DateTime DtEmpStarts { get; set; }
        public string SShift { get; set; }
        public string SFirstName { get; set; }
        public string SLastName { get; set; }
        public string SComputerCode { get; set; }
        public string SDeptAssignedTo { get; set; }
        public string SSupervisor { get; set; }
        public string SBuilding { get; set; }
        public string SDeskLocation { get; set; }
        public string SRequestor { get; set; }
        public string SIsmanager { get; set; }
        public DateTime? DtOrientation { get; set; }
        public string SInternalNotes { get; set; }
        public bool BComputer { get; set; }
        public bool BNetwork { get; set; }
        public bool BTelco { get; set; }
        public bool BVideo { get; set; }
        public bool BCopier { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TInfoSysNewEmployeeDetail> TInfoSysNewEmployeeDetail { get; set; }
    }
}
