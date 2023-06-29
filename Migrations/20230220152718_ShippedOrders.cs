using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientPortal_API.Migrations
{
    /// <inheritdoc />
    public partial class ShippedOrders : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE OR ALTER VIEW [dbo].[vw_portal_widget_shipped_orders] AS
                SELECT
                    ClientId = 652,
                    CAST('2023-02-01' as datetime) as Date,
                    Channel = 'Amazon',
                    Total = 12
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-01' as datetime) as Date,
                    Channel = 'UPS',
                    Total = 10
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-01' as datetime) as Date,
                    Channel = 'FedEx',
                    Total = 0
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-02' as datetime) as Date,
                    Channel = 'FedEx',
                    Total = 23
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-02' as datetime) as Date,
                    Channel = 'Amazon',
                    Total = 12
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-02' as datetime) as Date,
                    Channel = 'USPS',
                    Total = 11
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-03' as datetime) as Date,
                    Channel = 'UPS',
                    Total = 12
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-04' as datetime) as Date,
                    Channel = 'USPS',
                    Total = 11
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-04' as datetime) as Date,
                    Channel = 'FedEx',
                    Total = 12
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-04' as datetime) as Date,
                    Channel = 'Amazon',
                    Total = 44
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-05' as datetime) as Date,
                    Channel = 'Other',
                    Total = 1
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-06' as datetime) as Date,
                    Channel = 'Amazon',
                    Total = 11
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-07' as datetime) as Date,
                    Channel = 'FedEx',
                    Total = 12
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-08' as datetime) as Date,
                    Channel = 'UPS',
                    Total = 11
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-09' as datetime) as Date,
                    Channel = 'USPS',
                    Total = 12
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-10' as datetime) as Date,
                    Channel = 'Other',
                    Total = 1
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-11' as datetime) as Date,
                    Channel = 'Amazon',
                    Total = 12
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-12' as datetime) as Date,
                    Channel = 'FedEx',
                    Total = 11
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-13' as datetime) as Date,
                    Channel = 'UPS',
                    Total = 12
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-14' as datetime) as Date,
                    Channel = 'USPS',
                    Total = 11
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-15' as datetime) as Date,
                    Channel = 'Other',
                    Total = 1
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-12' as datetime) as Date,
                    Channel = 'Amazon',
                    Total = 24
                UNION ALL
                    SELECT
                    ClientId = 652,
                    CAST('2023-02-12' as datetime) as Date,
                    Channel = 'UPS',
                    Total = 12;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW [dbo].[vw_portal_widget_shipped_orders];");
        }
    }
}
