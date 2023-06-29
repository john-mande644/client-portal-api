using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Dashboard
    {
        [Keyless]
        public class AsnInventory
        {
            [JsonPropertyName("asn")]
            public Widget.Asn Asn { get; set; } = default!;

            [JsonPropertyName("inventory")]
            public Widget.Inventory Inventory { get; set; } = default!;
        }
    }
}
