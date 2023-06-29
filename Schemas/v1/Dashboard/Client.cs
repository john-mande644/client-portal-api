using Microsoft.EntityFrameworkCore;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Dashboard
    {
        public class Client
        {
            [JsonPropertyName("promisesMet")]
            public Widget.PromisesMet PromisesMet { get; set; } = default!;

            [JsonPropertyName("todaysOrders")]
            public Widget.TodaysOrders TodaysOrders { get; set; } = default!;

            [JsonPropertyName("asn")]
            public Widget.Asn Asn { get; set; } = default!;

            [JsonPropertyName("receives")]
            public Widget.Receives Receives { get; set; } = default!;

            [JsonPropertyName("inventory")]
            public Widget.Inventory Inventory { get; set; } = default!;
        }
    }
}
