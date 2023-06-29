using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class WidgetDTO
    {
        public class GetTopSellingItems
        {
            [JsonPropertyName("productId")]
            public string ProductId { get; set; } = default!;

            [JsonPropertyName("soldQuantity")]
            public int SoldQuantity { get; set; } = default!;

            [JsonPropertyName("soldRank")]
            public int SoldRank { get; set; } = default!;

            [JsonPropertyName("sku")]
            public string Sku { get; set; } = default!;

            [JsonPropertyName("name")]
            public string Name { get; set; } = default!;
        }
    }
}
