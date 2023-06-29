using System.Text.Json.Serialization;
using ClientPortal_API.DTOs.v1;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Dashboard
    {
        public class SalesOrders
        {
            [JsonPropertyName("todaysOrders")]
            public Widget.TodaysOrders TodaysOrders { get; set; } = default!;

            [JsonPropertyName("shippedOrders")]
            public List<WidgetDTO.GetShippedOrders> ShippedOrders { get; set; } = default!;

            [JsonPropertyName("salesOrdersByChannel")]
            public List<Widget.SalesOrdersByChannel> SalesOrdersByChannel { get; set; } = default!;

            [JsonPropertyName("topSellingItems")]
            public List<Widget.TopSellingItems> TopSellingItems { get; set; } = default!;

            [JsonPropertyName("ordersByShipMethod")]

            public List<Widget.SalesOrdersByShipMethod> SalesOrdersByShipMethod { get; set; } = default!;
        }

        public class Channel
        {
            [JsonPropertyName("name")]
            public string Name { get; set; } = default!;

            [JsonPropertyName("total")]
            public int Total { get; set; } = default;
        }
    }
}