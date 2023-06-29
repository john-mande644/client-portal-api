using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class WidgetDTO
    {
        public class GetSalesOrdersByChannel
        {
            [JsonPropertyName("day")]
            public List<Channel> Day { get; set; } = default!;

            [JsonPropertyName("month")]
            public List<Channel> Month { get; set; } = default!;

            [JsonPropertyName("quarter")]
            public List<Channel> Quarter { get; set; } = default!;

            [JsonPropertyName("year")]
            public List<Channel> Year { get; set; } = default!;
        }
    }
}
