namespace ClientPortal_API.Schemas.v1
{
    public partial class Grid
    {
        public class Asn
        {
            public int AsnId { get; set; }
            // TODO: This should probably be an enum
            public string? Status { get; set; }
            public string? ClientReferenceNumber { get; set; }
            public string? ClientPurchaseOrderNumber { get; set; }
            public string? ReferenceNumber { get; set; }
            public string? Shipper { get; set; }
            public string? StockRelease { get; set; }
            // TODO: This needs to be a date
            public string? LastReceiveDate { get; set; }
            // TODO: This should probably be PendingReceiveCount
            public int PendingReceiptCount { get; set; }
            public int SkuCount { get; set; }
            public int ClientId { get; set; }
        }    
    }
    
}

