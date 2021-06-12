using System;
using System.Collections.Generic;

namespace Wildcat.Entities.SHCA.ShultzPro
{
    public partial class TLabImportTest
    {
        public TLabImportTest()
        {
            TLabImportBend = new HashSet<TLabImportBend>();
            TLabImportChem = new HashSet<TLabImportChem>();
            TLabImportCompression = new HashSet<TLabImportCompression>();
            TLabImportCreep = new HashSet<TLabImportCreep>();
            TLabImportElectricalConductivity = new HashSet<TLabImportElectricalConductivity>();
            TLabImportEmbrittlement = new HashSet<TLabImportEmbrittlement>();
            TLabImportHardness = new HashSet<TLabImportHardness>();
            TLabImportHeatTreatment = new HashSet<TLabImportHeatTreatment>();
            TLabImportImpact = new HashSet<TLabImportImpact>();
            TLabImportMacroMetallurgy = new HashSet<TLabImportMacroMetallurgy>();
            TLabImportMagneticParticle = new HashSet<TLabImportMagneticParticle>();
            TLabImportMicroMetallurgy = new HashSet<TLabImportMicroMetallurgy>();
            TLabImportNote = new HashSet<TLabImportNote>();
            TLabImportPlaneStrain = new HashSet<TLabImportPlaneStrain>();
            TLabImportRevision = new HashSet<TLabImportRevision>();
            TLabImportShear = new HashSet<TLabImportShear>();
            TLabImportSpecification = new HashSet<TLabImportSpecification>();
            TLabImportSpecimen = new HashSet<TLabImportSpecimen>();
            TLabImportStressCorrosion = new HashSet<TLabImportStressCorrosion>();
            TLabImportStressRupture = new HashSet<TLabImportStressRupture>();
            TLabImportTensile = new HashSet<TLabImportTensile>();
        }

        public Guid STestGuid { get; set; }
        public Guid SCompanyGuid { get; set; }
        public string STestId { get; set; }
        public DateTime DtRun { get; set; }
        public string SSsjobNumber { get; set; }
        public string SLabNumber { get; set; }
        public string SLabRevisionLetter { get; set; }
        public DateTime? DtCertification { get; set; }
        public string SCustomerPonumber { get; set; }
        public string SDeliveryNumber { get; set; }
        public string SSize { get; set; }
        public string SFinalCustomer { get; set; }
        public string SFinalCustomerPonumber { get; set; }
        public string SDescription { get; set; }
        public bool BJobHasFailures { get; set; }
        public string SCertificationType { get; set; }
        public bool BShultzCreated { get; set; }
        public bool BInactive { get; set; }
        public DateTime DtAdded { get; set; }
        public string SAddedByUserId { get; set; }
        public DateTime DtUpdated { get; set; }
        public string SUpdatedByUserId { get; set; }
        public byte[] BRowversion { get; set; }

        public TLabImportCompany SCompanyGu { get; set; }
        public ICollection<TLabImportBend> TLabImportBend { get; set; }
        public ICollection<TLabImportChem> TLabImportChem { get; set; }
        public ICollection<TLabImportCompression> TLabImportCompression { get; set; }
        public ICollection<TLabImportCreep> TLabImportCreep { get; set; }
        public ICollection<TLabImportElectricalConductivity> TLabImportElectricalConductivity { get; set; }
        public ICollection<TLabImportEmbrittlement> TLabImportEmbrittlement { get; set; }
        public ICollection<TLabImportHardness> TLabImportHardness { get; set; }
        public ICollection<TLabImportHeatTreatment> TLabImportHeatTreatment { get; set; }
        public ICollection<TLabImportImpact> TLabImportImpact { get; set; }
        public ICollection<TLabImportMacroMetallurgy> TLabImportMacroMetallurgy { get; set; }
        public ICollection<TLabImportMagneticParticle> TLabImportMagneticParticle { get; set; }
        public ICollection<TLabImportMicroMetallurgy> TLabImportMicroMetallurgy { get; set; }
        public ICollection<TLabImportNote> TLabImportNote { get; set; }
        public ICollection<TLabImportPlaneStrain> TLabImportPlaneStrain { get; set; }
        public ICollection<TLabImportRevision> TLabImportRevision { get; set; }
        public ICollection<TLabImportShear> TLabImportShear { get; set; }
        public ICollection<TLabImportSpecification> TLabImportSpecification { get; set; }
        public ICollection<TLabImportSpecimen> TLabImportSpecimen { get; set; }
        public ICollection<TLabImportStressCorrosion> TLabImportStressCorrosion { get; set; }
        public ICollection<TLabImportStressRupture> TLabImportStressRupture { get; set; }
        public ICollection<TLabImportTensile> TLabImportTensile { get; set; }
    }
}
