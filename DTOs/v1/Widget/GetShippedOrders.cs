using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class WidgetDTO
    {
        public class GetShippedOrders
        {
            [JsonPropertyName("date")]
            public string Date { get; set; }

            [JsonPropertyName("channels")]
            public List<Channel> Channels { get; set; }
        }
    }
}
