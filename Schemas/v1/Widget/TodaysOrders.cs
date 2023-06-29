using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Widget
    {
        [Keyless]
        public class TodaysOrders
        {
            public int ClientId { get; set; }

            public int Posted { get; set; } = 0;

            public int OnHold { get; set; } = 0;

            public int FulfilmentStatusPercent { get; set; } = 0;
        }
    }
}
