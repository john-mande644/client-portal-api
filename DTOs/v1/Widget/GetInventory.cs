using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class WidgetDTO
    {
        public class GetInventory
        {
            [JsonPropertyName("lowStockProductCount")]
            public int LowStockProductCount { get; set; } = 0;

            [JsonPropertyName("outOfStockProductCount")]
            public int OutOfStockProductCount { get; set; } = 0;

            [JsonPropertyName("damagedProductCount")]
            public int DamagedProductCount { get; set; } = 0;
        }
    }
}
