using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TScheduleBreak
    {
        public Guid SScheduleBreakGuid { get; set; }
        public int? IShift { get; set; }
        public int? ITimeBeforeShift { get; set; }
        public int? IStartFirstBreak { get; set; }
        public int? IEndFirstBreak { get; set; }
        public int? IStartLunch { get; set; }
        public int? IEndLunch { get; set; }
        public int? IStartSecondBreak { get; set; }
        public int? IEndSecondBreak { get; set; }
        public int? IStartOverTimeBreak1 { get; set; }
        public int? IEndOverTimeBreak1 { get; set; }
        public int? IStartOverTimeBreak2 { get; set; }
        public int? IEndOverTimeBreak2 { get; set; }
        public int? IStartOverTimeBreak3 { get; set; }
        public int? IEndOverTimeBreak3 { get; set; }
        public int? IStartOverTimeBreak4 { get; set; }
        public int? IEndOverTimeBreak4 { get; set; }
        public bool BInActive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
