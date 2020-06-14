using Microsoft.EntityFrameworkCore.Migrations;

namespace KE.ERP.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Touchpoints",
                columns: table => new
                {
                    TouchpointId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TouchpointName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Touchpoints", x => x.TouchpointId);
                });

            migrationBuilder.InsertData(
                table: "Touchpoints",
                columns: new[] { "TouchpointId", "TouchpointName" },
                values: new object[] { 1, "Rental" });

            migrationBuilder.InsertData(
                table: "Touchpoints",
                columns: new[] { "TouchpointId", "TouchpointName" },
                values: new object[] { 2, "Sales" });

            migrationBuilder.InsertData(
                table: "Touchpoints",
                columns: new[] { "TouchpointId", "TouchpointName" },
                values: new object[] { 3, "Service" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Touchpoints");
        }
    }
}
