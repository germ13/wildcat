using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TEmployee
    {
        public TEmployee()
        {
            TEmployeeAttendance = new HashSet<TEmployeeAttendance>();
            TEmployeeBank = new HashSet<TEmployeeBank>();
            TEmployeeDate = new HashSet<TEmployeeDate>();
            TLabPurchaseOrderApproval = new HashSet<TLabPurchaseOrderApproval>();
            TUser = new HashSet<TUser>();
            TUserBadge = new HashSet<TUserBadge>();
        }

        public Guid SEmployeeGuid { get; set; }
        public int IDeptNum { get; set; }
        public int IEmpId { get; set; }
        public Guid? SCompanyGuid { get; set; }
        public string SLastName { get; set; }
        public string SFirstName { get; set; }
        public string SGoesByLastName { get; set; }
        public string SGoesByFirstName { get; set; }
        public DateTime? DtHire { get; set; }
        public DateTime? DtTermination { get; set; }
        public string SEmail { get; set; }
        public string SAttenuation { get; set; }
        public string SAttenuationExtended { get; set; }
        public bool BIsSalary { get; set; }
        public int? IPhoneExtension { get; set; }
        public string SBusinessPhone { get; set; }
        public string SCellPhone1 { get; set; }
        public string SCellPhone2 { get; set; }
        public string SJobTitle { get; set; }
        public string SWorkAddress { get; set; }
        public string SWorkCity { get; set; }
        public string SWorkState { get; set; }
        public string SWorkZip { get; set; }
        public bool BIsVeteran { get; set; }
        public bool BIsDisabled { get; set; }
        public string SDeptText { get; set; }
        public int? IExecutiveLevel { get; set; }
        public decimal? DblYearsService { get; set; }
        public int? IAdpnumber { get; set; }
        public string SEmpNumber { get; set; }
        public DateTime? DtLastAnniversary { get; set; }
        public DateTime? DtNextAnniversary { get; set; }
        public int? IShift { get; set; }
        public int? ITempAccessKey { get; set; }
        public string STempEmpId { get; set; }
        public string SSsnlastFour { get; set; }
        public string SSsn { get; set; }
        public decimal? DblShiftDifferential { get; set; }
        public decimal? DblMarkup { get; set; }
        public decimal? DblAffordableCareAct { get; set; }
        public string SNotes { get; set; }
        public Guid? SSupervisorGuid { get; set; }
        public string STempStatus { get; set; }
        public bool BFraudFalsification { get; set; }
        public bool BIsTemp { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TEmployeeAttendance> TEmployeeAttendance { get; set; }
        public ICollection<TEmployeeBank> TEmployeeBank { get; set; }
        public ICollection<TEmployeeDate> TEmployeeDate { get; set; }
        public ICollection<TLabPurchaseOrderApproval> TLabPurchaseOrderApproval { get; set; }
        public ICollection<TUser> TUser { get; set; }
        public ICollection<TUserBadge> TUserBadge { get; set; }
    }
}
