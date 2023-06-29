namespace ClientPortal_API.Schemas.v1
{
    public partial class Grid
    {
        public class Order
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

