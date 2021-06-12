using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TJobDetail
    {
        public Guid SDetailGuid { get; set; }
        public Guid SMasterGuid { get; set; }
        public int IOperationIndex { get; set; }
        public string SOperationSummary { get; set; }
        public string SOperationDetail { get; set; }
        public string SCoatingNotes { get; set; }
        public bool? BIsCoatingUsed { get; set; }
        public string STemperatureNotes { get; set; }
        public int? ITemperature { get; set; }
        public int? IMaxSoakTime { get; set; }
        public string SDieTemperatureNotes { get; set; }
        public int? IDieTemperature { get; set; }
        public string STonnageNotes { get; set; }
        public int? ITonnage { get; set; }
        public string SSpeedNotes { get; set; }
        public int? ISpeed { get; set; }
        public string SSquareInchNotes { get; set; }
        public int? ISquareInches { get; set; }
        public string SInstructions { get; set; }
        public string SIdentification { get; set; }
        public string SCooling { get; set; }
        public string SKeyCharacteristics { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TJobMaster SMasterGu { get; set; }
    }
}
