using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Widget
    {
        [Keyless]
        public class Asn
        {
            public int ClientId { get; set; }

            public int PendingCount { get; set; } = 0;

            public int InProcessCount { get; set; } = 0;

            public int ArrivedCount { get; set; } = 0;

            public int NonconformingCount { get; set; } = 0;
        }
    }
}
