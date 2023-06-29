using Microsoft.EntityFrameworkCore;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Widget
    {
        [Keyless]
        public class ShippedOrders
        {
            public int ClientId { get; set; }

            public DateTime Date { get; set; } = default!;

            public string Channel { get; set; } = default!;

            public int Total { get; set; } = default!;

        }
    }
}
