using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class WidgetDTO
    {
        public class GetReturnedUnits
        {
            [JsonPropertyName("date")]
            public string Date { get; set; } = default!;

            [JsonPropertyName("channels")]
            public List<Channel> Channels { get; set; } = default!;
        }
    }
}
