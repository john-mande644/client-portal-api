using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class WidgetDTO
    {
        public class GetAverageReturns
        {
            [JsonPropertyName("total")]
            public int Total { get; set; } = 0;
        }
    }
}
