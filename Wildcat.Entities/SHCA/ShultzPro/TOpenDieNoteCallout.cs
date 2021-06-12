using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TOpenDieNoteCallout
    {
        public Guid SCalloutGuid { get; set; }
        public Guid SNoteGuid { get; set; }
        public string SCalloutText { get; set; }
        public decimal? DblXpositionCallout { get; set; }
        public decimal? DblYpositionCallout { get; set; }
        public decimal? DblXpositionPointOnDiagram { get; set; }
        public decimal? DblYpositionPointOnDiagram { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TOpenDieNoteMaster SNoteGu { get; set; }
    }
}
