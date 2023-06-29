using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Widget
    {
        [Keyless]
        public class TopReturnedItems
        {
            public int ClientId { get; set; }

            public string ProductId { get; set; } = default!;

            public int ReturnQuantity { get; set; } = default!;

            public int ReturnRank { get; set; } = default!;

            public string Sku { get; set; } = default!;

            public string Name { get; set; } = default!;
        }
    }
}
