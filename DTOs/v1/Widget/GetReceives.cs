using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class WidgetDTO
    {
        public class GetReceives
        {
            [JsonPropertyName("total")]
            public int Total { get; set; } = 0;

            [JsonPropertyName("nonconforming")]
            public int Nonconforming { get; set; } = 0;
        }
    }
}
