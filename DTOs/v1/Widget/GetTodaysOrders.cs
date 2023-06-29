using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class WidgetDTO
    {
        public class GetTodaysOrders
        {
            [JsonPropertyName("posted")]
            public int Posted { get; set; }

            [JsonPropertyName("onHold")]
            public int OnHold { get; set; }

            [JsonPropertyName("totalValue")]
            public int FulfilmentStatusPercent { get; set; } 
        }
    }
}
