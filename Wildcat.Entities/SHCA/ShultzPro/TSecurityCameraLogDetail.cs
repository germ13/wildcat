using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSecurityCameraLogDetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SLogGuid { get; set; }
        public string SCameraIp { get; set; }
        public string SCameraName { get; set; }
        public string SDescription { get; set; }
        public string SMacaddress { get; set; }
        public bool BIsOnline { get; set; }
        public int IFlags { get; set; }
        public int? IImageHeight { get; set; }
        public int? IImageWidth { get; set; }
        public string SFirmwareVersion { get; set; }
        public string SDeviceType { get; set; }
        public bool? BAudioOption { get; set; }
        public bool? BStorageAttached { get; set; }
        public string SInitiatorName { get; set; }
        public string SStream1 { get; set; }
        public string SStream2 { get; set; }
        public string SFirmwareVersionCamera { get; set; }
        public string STemperature { get; set; }
        public string SSerialNumber { get; set; }
        public string SAspectRatio { get; set; }
        public DateTime? DtTimeOnCamera { get; set; }
        public int? ITimeZoneOffset { get; set; }
        public Guid? SAttachmentGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TSecurityCameraLog SLogGu { get; set; }
    }
}
