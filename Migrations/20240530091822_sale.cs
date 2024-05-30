using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS5227_A1_YICHE32405.Migrations
{
    /// <inheritdoc />
    public partial class sale : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "2f09d980-6eab-4390-bdc5-7f494fdbcfbc", null, "seller", "seller" },
                    { "5301998e-35c4-4cb6-8364-8b0c94a6388e", null, "admin", "admin" },
                    { "f790bc57-24d9-45e2-a23b-a12c6b141275", null, "client", "client" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2f09d980-6eab-4390-bdc5-7f494fdbcfbc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5301998e-35c4-4cb6-8364-8b0c94a6388e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f790bc57-24d9-45e2-a23b-a12c6b141275");

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
    }
}
