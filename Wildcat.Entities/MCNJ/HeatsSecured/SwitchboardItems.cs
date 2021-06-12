namespace Wildcat.Entities.MCNJ.HeatsSecured
{
    public partial class SwitchboardItems
    {
        public int SwitchboardId { get; set; }
        public short ItemNumber { get; set; }
        public string ItemText { get; set; }
        public short? Command { get; set; }
        public string Argument { get; set; }
    }
}
