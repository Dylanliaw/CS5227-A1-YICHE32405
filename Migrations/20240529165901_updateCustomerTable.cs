using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS5227_A1_YICHE32405.Migrations
{
    /// <inheritdoc />
    public partial class updateCustomerTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1dfe74f0-6d75-47de-bb6d-5bd3c62edd7b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "519bd9f5-14d4-4016-9be4-f79423ef66de");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89d0034c-9885-4627-8a8d-0ce3443ea063");

            migrationBuilder.AddColumn<string>(
                name: "Message",
                table: "Customer",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "463ef86d-0b7f-4fad-934f-bc982fe9d79b", null, "admin", "admin" },
                    { "5b167529-07e4-4ed1-af05-a70444d09fb0", null, "client", "client" },
                    { "c9da7174-9b31-4f0e-ae58-0838af9abf97", null, "seller", "seller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "463ef86d-0b7f-4fad-934f-bc982fe9d79b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5b167529-07e4-4ed1-af05-a70444d09fb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c9da7174-9b31-4f0e-ae58-0838af9abf97");

            migrationBuilder.DropColumn(
                name: "Message",
                table: "Customer");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1dfe74f0-6d75-47de-bb6d-5bd3c62edd7b", null, "admin", "admin" },
                    { "519bd9f5-14d4-4016-9be4-f79423ef66de", null, "seller", "seller" },
                    { "89d0034c-9885-4627-8a8d-0ce3443ea063", null, "client", "client" }
                });
        }
    }
}
