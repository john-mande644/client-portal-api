using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientPortal_API.Migrations
{
    /// <inheritdoc />
    public partial class TopReturnedItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE OR ALTER VIEW [dbo].[vw_portal_widget_top_returned_items] AS
            SELECT
                ClientId = 640,
                ProductId = '124',
                ReturnQuantity = 360,
                ReturnRank = 1,
                Sku = '453512134',
                Name = 'Product 1'
            UNION ALL
            SELECT
                ClientId = 640,
                ProductId = '125',
                ReturnQuantity = 340,
                ReturnRank = 2,
                Sku = '453512135',
                Name = 'Product 2'
            UNION ALL
            SELECT
                ClientId = 640,
                ProductId = '126',
                ReturnQuantity = 320,
                ReturnRank = 3,
                Sku = '453512136',
                Name = 'Product 3'
            UNION ALL
            SELECT
                ClientId = 640,
                ProductId = '127',
                ReturnQuantity = 300,
                ReturnRank = 4,
                Sku = '453512137',
                Name = 'Product 4'
            UNION ALL
            SELECT
                ClientId = 640,
                ProductId = '128',
                ReturnQuantity = 280,
                ReturnRank = 5,
                Sku = '453512138',
                Name = 'Product 5'
            UNION ALL
            SELECT
                ClientId = 640,
                ProductId = '129',
                ReturnQuantity = 260,
                ReturnRank = 6,
                Sku = '453512139',
                Name = 'Product 6'
            UNION ALL
            SELECT
                ClientId = 640,
                ProductId = '130',
                ReturnQuantity = 240,
                ReturnRank = 7,
                Sku = '453512140',
                Name = 'Product 7'
            UNION ALL
            SELECT
                ClientId = 640,
                ProductId = '131',
                ReturnQuantity = 220,
                ReturnRank = 8,
                Sku = '453512141',
                Name = 'Product 8'
            UNION ALL
            SELECT
                ClientId = 640,
                ProductId = '132',
                ReturnQuantity = 200,
                ReturnRank = 9,
                Sku = '453512142',
                Name = 'Product 9'
            UNION ALL
            SELECT
                ClientId = 640,
                ProductId = '133',
                ReturnQuantity = 180,
                ReturnRank = 10,
                Sku = '453512143',
                Name = 'Product 10';");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW [dbo].[vw_portal_widget_top_returned_items];");
        }
    }
}
