using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSystemSetting
    {
        public Guid SSettingGuid { get; set; }
        public Guid? SParentSettingGuid { get; set; }
        public string SCategory { get; set; }
        public string SKey { get; set; }
        public string SDefaultStringValue { get; set; }
        public string SDefaultStringValueDesc { get; set; }
        public int? IDefaultIntegerValue { get; set; }
        public bool BDefaultBooleanValue { get; set; }
        public byte[] ImgDefaultImageValue { get; set; }
        public string SDefaultTextValue { get; set; }
        public decimal DblDefaultNumericValue { get; set; }
        public bool BDefault { get; set; }
        public string SSettingType { get; set; }
        public string SProgrammerComments { get; set; }
        public int ISortOrder { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
