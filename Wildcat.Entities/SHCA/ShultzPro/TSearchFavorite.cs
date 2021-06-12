using System;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TSearchFavorite
    {
        public Guid SSearchGuid { get; set; }
        public Guid? SUserGuid { get; set; }
        public Guid? SGroupGuid { get; set; }
        public Guid? SScreenObjectGuid { get; set; }
        public string SName { get; set; }
        public bool BIsDefault { get; set; }
        public bool BAppearsInLhside { get; set; }
        public string SViewDefinition { get; set; }
        public bool BIsSystemDefault { get; set; }
        public string SCriteriaString { get; set; }
        public string SVisibleColumns { get; set; }
        public DateTime DtAdded { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUser { get; set; }
        public byte[] BRowversion { get; set; }
    }
}
