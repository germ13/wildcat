using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMrMaterial
    {
        public TMrMaterial()
        {
            TMrPiece = new HashSet<TMrPiece>();
        }

        public Guid SMaterialGuid { get; set; }
        public string SName { get; set; }
        public Guid SMaterialTypeGuid { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMrMaterialType SMaterialTypeGu { get; set; }
        public ICollection<TMrPiece> TMrPiece { get; set; }
    }
}
