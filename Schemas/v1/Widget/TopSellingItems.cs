using Microsoft.AspNetCore.Authorization;
using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Widget
    {
        [Keyless]
        public class TopSellingItems
        {
            public int ClientId { get; set; } = default!;

            public string ProductId { get; set; } = default!;

            public int SoldQuantity { get; set; } = default!;

            public int SoldRank { get; set; } = default!;

            public string Sku { get; set; } = default!;

            public string Name { get; set; } = default!;
        }
    }
}
