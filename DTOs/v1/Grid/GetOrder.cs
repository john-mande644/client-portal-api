namespace ClientPortal_API.DTOs.v1
{
    public partial class GridDTO
    {
        public class GetOrder
        {
            public int OrderId { get; set; }
            public string? CustomerName { get; set; }
            public string? OrderReferenceNumber { get; set; }
            public string? OrderStatus { get; set; }
            public string? ReceivedDate { get; set; }
            public string? ShipDate { get; set; }
            public decimal OrderTotal { get; set; }
            public string? Notes { get; set; }
            public string? Comments { get; set; }
            public int ClientId { get; set; }
        }
    }    
}


