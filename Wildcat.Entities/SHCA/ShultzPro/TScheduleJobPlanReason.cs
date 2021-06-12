﻿using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TScheduleJobPlanReason
    {
        public Guid SSchedulePlanReasonGuid { get; set; }
        public Guid SPlanGuid { get; set; }
        public string SAction { get; set; }
        public string SReason { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }
    }
}