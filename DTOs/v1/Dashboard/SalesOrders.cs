using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class DashboardDTO
    {
        public class GetSalesOrders
        {
            [JsonPropertyName("todaysOrders")]
            public WidgetDTO.GetTodaysOrders TodaysOrders { get; set; } = default!;

            [JsonPropertyName("shippedOrders")]
            public List<WidgetDTO.GetShippedOrders> ShippedOrders { get; set; } = default!;

            [JsonPropertyName("salesOrdersByChannel")]
            public List<WidgetDTO.GetSalesOrdersByChannel> SalesOrdersByChannel { get; set; } = default!;

            [JsonPropertyName("topSellingItems")]
            public List<WidgetDTO.GetTopSellingItems> TopSellingItems { get; set; } = default!;

            [JsonPropertyName("salesOrdersByShipMethod")]
            public List<WidgetDTO.GetSalesOrdersByShipMethod> SalesOrdersByShipMethod { get; set; } = default!;
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