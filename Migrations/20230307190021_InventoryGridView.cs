using Microsoft.EntityFrameworkCore.Migrations;

namespace ClientPortal_API.Migrations
{
    public partial class InventoryGridView : Migration
    {
	    /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql(@"CREATE OR ALTER VIEW [dbo].[v_portal_grid_inventory]
									(
										InventoryId, 
										InventoryNumber,
										Description,
										QuantityOnHand,
										UnitPrice,
										Supplier
									)
									AS
									SELECT 
										[InventoryId] = oi.inventory_id,
										[InventoryNumber] = oi.inventory_num,
										[Description] = oi.description,
										[QuantityOnHand] = oio.qty_on_hand,
										[UnitPrice] = oi.price,
										[Supplier] = oi.supplier 
									FROM owd_inventory oi
									JOIN owd_inventory_oh oio 
										ON oi.inventory_id = oio.inventory_fkey ");
        }
        
        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
	        migrationBuilder.Sql(@"DROP VIEW [dbo].[v_portal_grid_inventory];");
        }
    }    
}


