using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Widget
    {
        [Keyless]
        public class ReturnedUnits
        {
            public int ClientId { get; set; }

            public DateTime Date { get; set; } = default!;

            public string Channel { get; set; } = default!;

            public int Total { get; set; } = default!;
        }
    }
}
