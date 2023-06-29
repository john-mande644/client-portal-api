using ClientPortal_API.DTOs.v1;
using ClientPortal_API.Schemas.v1;
using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class DashboardDTO
    {
        public class GetClient
        {
            [JsonPropertyName("promisesMet")]
            public WidgetDTO.GetPromisesMet PromisesMet { get; set; } = default!;

            [JsonPropertyName("todaysOrders")]
            public WidgetDTO.GetTodaysOrders TodaysOrders { get; set; } = default!;

            [JsonPropertyName("asn")]
            public WidgetDTO.GetAsn Asn { get; set; } = default!;

            [JsonPropertyName("receives")]
            public WidgetDTO.GetReceives Receives { get; set; } = default!;

            [JsonPropertyName("inventory")]
            public WidgetDTO.GetInventory Inventory { get; set; } = default!;
        }

    }
}
