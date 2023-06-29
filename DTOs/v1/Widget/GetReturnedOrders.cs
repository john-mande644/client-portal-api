using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class WidgetDTO
    {
        public class GetReturnedOrders
        {
            [JsonPropertyName("date")]
            public string Date { get; set; } = default!;

            [JsonPropertyName("channels")]
            public List<Channel> Channels { get; set; } = default!;
        }
        public class Channel
        {
            [JsonPropertyName("name")]
            public string Name { get; set; } = default!;

            [JsonPropertyName("total")]
            public int Total { get; set; } = 0;
        }
    }
}
