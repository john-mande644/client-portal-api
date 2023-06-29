namespace ClientPortal_API.DTOs.v1
{
    public partial class GridDTO
    {
        public class GetInventory
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

