using System.Text.Json.Serialization;

namespace ClientPortal_API.DTOs.v1
{
    public partial class DashboardDTO
    {
        public class GetReturns
        {
            [JsonPropertyName("returnedOrders")]
            public List<WidgetDTO.GetReturnedOrders> ReturnedOrders { get; set; } = default!;

            [JsonPropertyName("averageReturns")]
            public WidgetDTO.GetAverageReturns AverageReturns { get; set; } = default!;

            [JsonPropertyName("averageUnitsReturned")]
            public WidgetDTO.GetAverageUnitsReturned AverageUnitsReturned { get; set; } = default!;

            [JsonPropertyName("returnedUnits")]
            public List<WidgetDTO.GetReturnedUnits> ReturnedUnits { get; set; } = default!;
            
            [JsonPropertyName("topReturnedItems")]
            public List<WidgetDTO.GetTopReturnedItems> TopReturnedItems { get; set; } = default!;
        }
    }
}
