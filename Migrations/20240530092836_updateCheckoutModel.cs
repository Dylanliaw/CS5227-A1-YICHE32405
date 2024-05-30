using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS5227_A1_YICHE32405.Migrations
{
    /// <inheritdoc />
    public partial class updateCheckoutModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16a4f3ee-a85e-4298-9cc3-2fecc5c4b677");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6638ddf0-e2c8-4c4a-9c14-5641edbd7803");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b54a96bb-3e95-4868-83c5-18563a84e5b1");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8a27771a-b799-4e94-87fa-182c2d3682b9", null, "seller", "seller" },
                    { "96611f5e-8822-4374-91e6-dd17971bafc1", null, "admin", "admin" },
                    { "c7e8cbcf-54cb-4766-a7cb-20c75ad40f05", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a27771a-b799-4e94-87fa-182c2d3682b9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96611f5e-8822-4374-91e6-dd17971bafc1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c7e8cbcf-54cb-4766-a7cb-20c75ad40f05");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "16a4f3ee-a85e-4298-9cc3-2fecc5c4b677", null, "admin", "admin" },
                    { "6638ddf0-e2c8-4c4a-9c14-5641edbd7803", null, "client", "client" },
                    { "b54a96bb-3e95-4868-83c5-18563a84e5b1", null, "seller", "seller" }
                });
        }
    }
}
