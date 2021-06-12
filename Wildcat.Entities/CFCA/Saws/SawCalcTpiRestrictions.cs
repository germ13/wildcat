namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcTpiRestrictions
    {
        public int TpiRestrictionId { get; set; }
        public double MinDiameter { get; set; }
        public double MaxDiameter { get; set; }
        public double MinTpi { get; set; }
        public double MaxTpi { get; set; }
    }
}
