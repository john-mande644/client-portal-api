using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class WidgetDTO
    {
        public class GetPromisesMet
        {
            [JsonPropertyName("onTimePercent")]
            public int OnTimePercent { get; set; }

            [JsonPropertyName("fulfilmentAccuracyPercent")]
            public int FulfilmentAccuracyPercent { get; set; }

            [JsonPropertyName("fulfilmentSavings")]
            public int FulfilmentSavings { get; set; }
        }
    }
}
