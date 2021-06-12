namespace Wildcat.Entities.CFCA.Saws
{
    public partial class SawCalcGlobalSettings
    {
        public int GlobalSettingId { get; set; }
        public double MinimumVariance { get; set; }
        public double MaximumVariance { get; set; }
        public double RedBarUpper { get; set; }
        public double RedBarLower { get; set; }
        public double YellowBarUpper { get; set; }
        public double YellowBarLower { get; set; }
        public byte PercentSawUtilization { get; set; }
        public byte TimePerDayHours { get; set; }
        public byte TimePerDayMinutes { get; set; }
    }
}
