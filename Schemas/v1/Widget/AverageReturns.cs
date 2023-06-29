using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Widget {

        [Keyless]
        public class AverageReturns
        {
            public int ClientId { get; set; }

            public int Total { get; set; } = 0;
        }
    }
}
