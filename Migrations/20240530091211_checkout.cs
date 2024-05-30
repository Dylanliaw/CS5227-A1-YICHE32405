using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS5227_A1_YICHE32405.Migrations
{
    /// <inheritdoc />
    public partial class checkout : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "25fbbf7b-1682-4d1a-a125-06ccf55285b1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "72298249-552e-40b0-bfc9-d3112ce67d40");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4212bc2-ce3e-4c9f-be69-72490488ee23");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2271af21-b04e-40ad-872f-8b2e0f46f21c", null, "client", "client" },
                    { "8ba1d36a-c49a-4e1a-a6e4-21607505816c", null, "admin", "admin" },
                    { "d43d9b60-a4f8-439c-964c-81c4d3e639bc", null, "seller", "seller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2271af21-b04e-40ad-872f-8b2e0f46f21c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8ba1d36a-c49a-4e1a-a6e4-21607505816c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d43d9b60-a4f8-439c-964c-81c4d3e639bc");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "25fbbf7b-1682-4d1a-a125-06ccf55285b1", null, "client", "client" },
                    { "72298249-552e-40b0-bfc9-d3112ce67d40", null, "seller", "seller" },
                    { "b4212bc2-ce3e-4c9f-be69-72490488ee23", null, "admin", "admin" }
                });
        }
    }
}
