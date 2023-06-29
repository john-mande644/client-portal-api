using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class WidgetDTO
    {
        public class GetSalesOrdersByShipMethod
        {
            [JsonPropertyName("date")]
            public string Date { get; set; } = default!;

            [JsonPropertyName("methods")]
            public List<ShipMethod> Methods { get; set; } = default!;
        }

        public class ShipMethod
        {
            [JsonPropertyName("name")]
            public string Name { get; set; } = default!;

            [JsonPropertyName("total")]
            public int Total { get; set; } = default;
        }
    }
}
