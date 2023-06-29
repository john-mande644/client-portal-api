using Microsoft.EntityFrameworkCore;
using System.Text.Json.Serialization;

namespace ClientPortal_API.Schemas.v1
{
    public partial class Dashboard
    {
        public class Returns
        {
            [JsonPropertyName("returnedOrders")]
            public List<Widget.ReturnedOrders> ReturnedOrders { get; set; } = default!;

            [JsonPropertyName("averageReturns")]
            public Widget.AverageReturns AverageReturns { get; set; } = default!;

            [JsonPropertyName("averageUnitsReturned")]
            public Widget.AverageUnitsReturned AverageUnitsReturned { get; set; } = default!;

            [JsonPropertyName("returnedUnits")]
            public List<Widget.ReturnedUnits> ReturnedUnits { get; set; } = default!;
            
            [JsonPropertyName("topReturnedItems")]
            public List<Widget.TopReturnedItems> TopReturnedItems { get; set; } = default!;
        }
    }
}
