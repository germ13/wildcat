using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TMrPiece
    {
        public TMrPiece()
        {
            THtJobPiece = new HashSet<THtJobPiece>();
        }

        public Guid SPieceGuid { get; set; }
        public int IPieceNo { get; set; }
        public Guid? SPieceTypeGuid { get; set; }
        public decimal DblSectionSize { get; set; }
        public int IWeight { get; set; }
        public Guid SMaterialGuid { get; set; }
        public string SLayoutImagePath { get; set; }
        public string SRackingImagePath { get; set; }
        public bool BHardnessRequired { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUser { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TMrMaterial SMaterialGu { get; set; }
        public TMrPieceType SPieceTypeGu { get; set; }
        public ICollection<THtJobPiece> THtJobPiece { get; set; }
    }
}
