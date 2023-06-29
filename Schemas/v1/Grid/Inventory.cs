namespace ClientPortal_API.Schemas.v1
{
    public partial class Grid
    {
        public class Inventory
        {
            public int InventoryId { get; set; }
            public string? InventoryNumber { get; set; }
            public string? Description { get; set; }
            public int QuantityOnHand { get; set; }
            public decimal UnitPrice { get; set; }
            public string? Supplier { get; set; }
        }        
    }
}

