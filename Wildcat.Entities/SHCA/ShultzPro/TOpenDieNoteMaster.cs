using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TOpenDieNoteMaster
    {
        public TOpenDieNoteMaster()
        {
            TOpenDieNoteCallout = new HashSet<TOpenDieNoteCallout>();
            TOpenDieNoteDetail = new HashSet<TOpenDieNoteDetail>();
        }

        public Guid SNoteGuid { get; set; }
        public string SPress { get; set; }
        public string SJobNumber { get; set; }
        public string SToolingDies { get; set; }
        public string SStampType { get; set; }
        public bool BKaowool { get; set; }
        public bool BGlass { get; set; }
        public string SSize { get; set; }
        public string SJaws { get; set; }
        public string SExtArms { get; set; }
        public string SCaps { get; set; }
        public bool BBoothLeft { get; set; }
        public string SLoadingInstructionsTop1 { get; set; }
        public string SLoadingInstructionsTop2 { get; set; }
        public string SLoadingInstructionsTop3 { get; set; }
        public string SLoadingInstructionsTop4 { get; set; }
        public string SLoadingInstructionsBottom1 { get; set; }
        public string SLoadingInstructionsBottom2 { get; set; }
        public string SLoadingInstructionsBottom3 { get; set; }
        public string SLoadingInstructionsBottom4 { get; set; }
        public int? IMarkingSticks { get; set; }
        public int? IFinishSticks { get; set; }
        public Guid? SAttachmentGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TOpenDieNoteCallout> TOpenDieNoteCallout { get; set; }
        public ICollection<TOpenDieNoteDetail> TOpenDieNoteDetail { get; set; }
    }
}
