using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Widget
    {
        [Keyless]
        public class PromisesMet
        {
            public int ClientId { get; set; }

            public int OnTimePercent { get; set; } = 0;

            public int FulfilmentAccuracyPercent { get; set; } = 0;

            public int FulfilmentSavings { get; set; } = 0;
        }
    }
}
