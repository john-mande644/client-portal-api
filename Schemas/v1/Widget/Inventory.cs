using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Widget
    {
        [Keyless]
        public class Inventory
        {
            public int ClientId { get; set; } = 0;

            public int LowStockProductCount { get; set; } = 0;

            public int OutOfStockProductCount { get; set; } = 0;

            public int DamagedProductCount { get; set; } = 0;
        }
    }
}
