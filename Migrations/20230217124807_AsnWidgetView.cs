using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ClientPortal_API.Migrations
{
    /// <inheritdoc />
    public partial class AsnWidgetView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE OR ALTER VIEW [dbo].[vw_portal_widget_asn] AS
                SELECT
                    ClientId = 652,
                    PendingCount = 40,
                    InProcessCount = 33,
                    ArrivedCount = 222,
                    NonconformingCount = 3;");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP VIEW [dbo].[vw_portal_wdiget_asn];");
        }
    }
}
