using Microsoft.EntityFrameworkCore.Migrations;

namespace ClientPortal_API.Migrations
{
    public class AsnGridView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"CREATE OR ALTER VIEW [dbo].[v_portal_grid_asns]
									(
										AsnId,
										Status,
										ClientReferenceNumber,
										ClientPurchaseOrderNumber,
										ReferenceNumber,
										Shipper,
										StockRelease,
										LastReceiveDate,
										PendingReceiptCount,
										SkuCount,	
										ClientId
									)
									AS
									SELECT 
										[AsnId] = a.id,
										[Status] = as2.name,
										[ClientReferenceNumber] = a.client_ref,
										[ClientPurchaseOrderNumber] = a.client_po,
										[ReferenceNumber] = a.id,
										[Shipper] = a.shipper_name,
										[StockRelease] = CASE WHEN a.is_autorelease = 1 THEN 'Auto' ELSE 'Manual' END,
										[LastReceiveDate] = a.last_receive_date,
										[PendingReceiptCount] = 0, --TODO: Figure out how to derive this number
										[SkuCount] = 1, --TODO: Derive this
										[ClientId] = a.client_fkey

									FROM asn a 
									JOIN asn_status as2 
										ON a.status = as2.status_id");
        }
        
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW [dbo].[v_portal_grid_asns];");
        }
    }    
}

