using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientPortal_API.Migrations
{
    /// <inheritdoc />
    public partial class SalesOrdersByChannel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE OR ALTER VIEW [dbo].[vw_portal_widget_sales_orders_by_channel] AS
                SELECT
                    ClientId = 652,
                    Rolling = 'day',
                    Channel = 'Amazon',
                    Total = 12
                UNION ALL
                    SELECT
                    ClientId = 652,
                    Rolling = 'day',
                    Channel = 'UPS',
                    Total = 10
                UNION ALL
                    SELECT
                    ClientId = 652,
                    Rolling = 'day',
                    Channel = 'FedEx',
                    Total = 12
                UNION ALL
                    SELECT
                    ClientId = 652,
                    Rolling = 'month',
                    Channel = 'Amazon',
                    Total = 122
                UNION ALL
                    SELECT
                    ClientId = 652,
                    Rolling = 'month',
                    Channel = 'FedEx',
                    Total = 33
                UNION ALL
                    SELECT
                    ClientId = 652,
                    Rolling = 'month',
                    Channel = 'UPS',
                    Total = 22
                UNION ALL
                    SELECT
                    ClientId = 652,
                    Rolling = 'quarter',
                    Channel = 'Amazon',
                    Total = 2200
                UNION ALL
                    SELECT
                    ClientId = 652,
                    Rolling = 'quarter',
                    Channel = 'FedEx',
                    Total = 500
                UNION ALL
                    SELECT
                    ClientId = 652,
                    Rolling = 'quarter',
                    Channel = 'UPS',
                    Total = 323
                UNION ALL
                    SELECT
                    ClientId = 652,
                    Rolling = 'year',
                    Channel = 'Amazon',
                    Total = 10402
                UNION ALL
                    SELECT
                    ClientId = 652,
                    Rolling = 'year',
                    Channel = 'FedEx',
                    Total = 5023
                UNION ALL
                    SELECT
                    ClientId = 652,
                    Rolling = 'year',
                    Channel = 'UPS',
                    Total = 3233;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW [dbo].[vw_portal_widget_sales_orders_by_channel];");
        }
    }
}
