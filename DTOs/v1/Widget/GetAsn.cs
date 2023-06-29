using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class WidgetDTO
    {
        public class GetAsn
        {
            public int PendingCount { get; set; }

            [JsonPropertyName("inProcessCount")]
            public int InProcessCount { get; set; }

            [JsonPropertyName("arrivedCount")]
            public int ArrivedCount { get; set; }

            [JsonPropertyName("nonconformingCount")]
            public int NonconformingCount { get; set; }
        }
    }
}
