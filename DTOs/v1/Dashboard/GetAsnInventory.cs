using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class DashboardDTO
    {
        public class GetAsnInventory
        {
            [JsonPropertyName("asn")]
            public WidgetDTO.GetAsn Asn { get; set; } = default!;

            [JsonPropertyName("inventory")]
            public WidgetDTO.GetInventory Inventory { get; set; } = default!;
        }
    }
}
