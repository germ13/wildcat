using Newtonsoft.Json;

namespace Wildcat.App.ViewModels.Planning
{
    [JsonObject(MemberSerialization = MemberSerialization.OptIn)]
    public class RowData
    {
        [JsonProperty(PropertyName = "Field00")]
        public string Field00 { get; set; }

        [JsonProperty(PropertyName = "Field01")]
        public string Field01 { get; set; }

        [JsonProperty(PropertyName = "Field02")]
        public string Field02 { get; set; }

        [JsonProperty(PropertyName = "Field03")]
        public string Field03 { get; set; }

        [JsonProperty(PropertyName = "Field04")]
        public string Field04 { get; set; }

        [JsonProperty(PropertyName = "Field05")]
        public string Field05 { get; set; }

        [JsonProperty(PropertyName = "Field06")]
        public string Field06 { get; set; }

        [JsonProperty(PropertyName = "Field07")]
        public string Field07 { get; set; }

        [JsonProperty(PropertyName = "Field08")]
        public string Field08 { get; set; }

        [JsonProperty(PropertyName = "Field09")]
        public string Field09 { get; set; }

        [JsonProperty(PropertyName = "Field10")]
        public string Field10 { get; set; }

        [JsonProperty(PropertyName = "Field11")]
        public string Field11 { get; set; }

        [JsonProperty(PropertyName = "Field12")]
        public string Field12 { get; set; }
    }
}