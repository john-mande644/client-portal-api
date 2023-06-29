using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class WidgetDTO
    {
        public class GetTopReturnedItems
        {
            [JsonPropertyName("productId")]
            public int ProductId { get; set; } = default!;

            [JsonPropertyName("returnQuantity")]
            public int returnQuantity { get; set; } = default!;

            [JsonPropertyName("soldRank")]
            public int returnRank { get; set; } = default!;

            [JsonPropertyName("sku")]
            public int Sku { get; set; } = default!;

            [JsonPropertyName("name")]
            public string Name { get; set; } = default!;
        }
    }
}
