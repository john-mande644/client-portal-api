using Microsoft.EntityFrameworkCore.Migrations;

namespace ClientPortal_API.Migrations
{
    public partial class OrdersGridView : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE OR ALTER VIEW [dbo].[v_portal_grid_sales_orders]
				(
					OrderId, 
					CustomerName,
					OrderReferenceNumber,
					OrderStatus,
					ReceivedDate,
					ShipDate,
					OrderTotal,
					Notes,
					Comments,
					ClientId
				)
				AS
				SELECT 
					[OrderId] = order_id,
					[CustomerName] = CASE WHEN (ISNULL(bill_company_name,'.')='.' OR ISNULL(bill_company_name,'')='') THEN (bill_first_name+' '+bill_last_name) ELSE bill_company_name END,
					[OrderReferenceNumber] = order_refnum,
					[OrderStatus] = CASE WHEN is_backorder = 1 and o.is_void=0 THEN ('BO (Level' + CONVERT(varchar, backorder_level + 1 ) + ')') ELSE order_status END,
					[ReceivedDate] = ISNULL(CONVERT(varchar,post_date,107),'<B>Held</B>'),
					[ShipDate] = ISNULL(CONVERT(varchar,o.shipped_on,107),'<B>Not Shipped</B>'),
					[OrderTotal] = order_total,
					[Notes] = whse_notes,
					[Comments] = ISNULL(e.message,''),
					[ClientId] = o.client_fkey 
				FROM owd_order o (NOLOCK) 
				JOIN owd_order_ship_info os (NOLOCK) ON o.order_id = os.order_fkey 
				OUTER APPLY (SELECT TOP 1 message FROM order_events oe WITH (NOLOCK) WHERE oe.order_fkey = o.order_id AND oe.event_type = 1 ORDER BY event_stamp DESC) e");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW [dbo].[v_portal_grid_sales_orders];");
        }
    }    
}
