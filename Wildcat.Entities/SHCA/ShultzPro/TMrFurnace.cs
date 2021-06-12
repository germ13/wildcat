using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMrFurnace
    {
        public TMrFurnace()
        {
            TMrFurnaceHearth = new HashSet<TMrFurnaceHearth>();
            TMrFurnaceQuery = new HashSet<TMrFurnaceQuery>();
        }

        public Guid SFurnaceGuid { get; set; }
        public string SName { get; set; }
        public string SLayoutImagePath { get; set; }
        public int? IRangeLo1 { get; set; }
        public int? IRangeHi1 { get; set; }
        public int? IToleranceRange1 { get; set; }
        public int? IRangeLo2 { get; set; }
        public int? IRangeHi2 { get; set; }
        public int? IToleranceRange2 { get; set; }
        public int? IRangeLo3 { get; set; }
        public int? IRangeHi3 { get; set; }
        public int? IToleranceRange3 { get; set; }
        public int? IRangeLo4 { get; set; }
        public int? IRangeHi4 { get; set; }
        public int? IToleranceRange4 { get; set; }
        public int? IRangeLo5 { get; set; }
        public int? IRangeHi5 { get; set; }
        public int? IToleranceRange5 { get; set; }
        public bool BManualWaterQuench { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TMrFurnaceHearth> TMrFurnaceHearth { get; set; }
        public ICollection<TMrFurnaceQuery> TMrFurnaceQuery { get; set; }
    }
}
