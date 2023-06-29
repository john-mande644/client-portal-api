using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientPortal_API.Migrations
{
    /// <inheritdoc />
    public partial class TopSellingItems : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            CREATE OR ALTER VIEW [dbo].[vw_portal_widget_top_selling_items] AS
            SELECT
                ClientId = 652,
                ProductId = '124',
                SoldQuantity = 360,
                SoldRank = 1,
                Sku = 'SKU-124',
                Name = 'Product 1'
            UNION ALL
            SELECT
                ClientId = 652,
                ProductId = '125',
                SoldQuantity = 340,
                SoldRank = 2,
                Sku = 'SKU-125',
                Name = 'Product 2'
            UNION ALL
            SELECT
                ClientId = 652,
                ProductId = '126',
                SoldQuantity = 320,
                SoldRank = 3,
                Sku = 'SKU-126',
                Name = 'Product 3'
            UNION ALL
            SELECT
                ClientId = 652,
                ProductId = '127',
                SoldQuantity = 300,
                SoldRank = 4,
                Sku = 'SKU-127',
                Name = 'Product 4'
            UNION ALL
            SELECT
                ClientId = 652,
                ProductId = '128',
                SoldQuantity = 280,
                SoldRank = 5,
                Sku = 'SKU-128',
                Name = 'Product 5'
            UNION ALL
            SELECT
                ClientId = 652,
                ProductId = '129',
                SoldQuantity = 260,
                SoldRank = 6,
                Sku = 'SKU-129',
                Name = 'Product 6'
            UNION ALL
            SELECT
                ClientId = 652,
                ProductId = '130',
                SoldQuantity = 240,
                SoldRank = 7,
                Sku = 'SKU-130',
                Name = 'Product 7'
            UNION ALL
            SELECT
                ClientId = 652,
                ProductId = '131',
                SoldQuantity = 220,
                SoldRank = 8,
                Sku = 'SKU-131',
                Name = 'Product 8'
            UNION ALL
            SELECT
                ClientId = 652,
                ProductId = '132',
                SoldQuantity = 200,
                SoldRank = 9,
                Sku = 'SKU-132',
                Name = 'Product 9'
            UNION ALL
            SELECT
                ClientId = 652,
                ProductId = '133',
                SoldQuantity = 180,
                SoldRank = 10,
                Sku = 'SKU-133',
                Name = 'Product 10';");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW [dbo].[vw_portal_widget_top_selling_items];");
        }
    }
}
