using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMotionStudyLogDetail
    {
        public TMotionStudyLogDetail()
        {
            TMotionStudyLogDetailNote = new HashSet<TMotionStudyLogDetailNote>();
        }

        public Guid SDetailGuid { get; set; }
        public string SMachineName { get; set; }
        public string SUserName { get; set; }
        public string SComputerName { get; set; }
        public DateTime DtLogged { get; set; }
        public string SJobNum { get; set; }
        public string SCustomer { get; set; }
        public string SOperation { get; set; }
        public int? SStepNum { get; set; }
        public string SLetterCode { get; set; }
        public string SDescription { get; set; }
        public string SSerialNum { get; set; }
        public bool BUndone { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public ICollection<TMotionStudyLogDetailNote> TMotionStudyLogDetailNote { get; set; }
    }
}
