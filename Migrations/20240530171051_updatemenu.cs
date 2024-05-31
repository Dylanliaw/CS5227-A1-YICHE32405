using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS5227_A1_YICHE32405.Migrations
{
    /// <inheritdoc />
    public partial class updatemenu : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a57f78aa-52f0-45b7-ae10-ad71c0ea7199");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d9aa959d-d024-44dc-a883-aafe2206eee7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edc6f971-8295-4d2d-a15c-b1b1e55572be");

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Menus",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9a3acf30-b364-4335-8b1f-69af967e8bcc", null, "client", "client" },
                    { "e49a1d08-f060-4518-b9e2-cc6d15cb8074", null, "admin", "admin" },
                    { "f754bffb-264d-457d-a49d-4fb28830b3cf", null, "seller", "seller" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9a3acf30-b364-4335-8b1f-69af967e8bcc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e49a1d08-f060-4518-b9e2-cc6d15cb8074");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f754bffb-264d-457d-a49d-4fb28830b3cf");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Menus");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a57f78aa-52f0-45b7-ae10-ad71c0ea7199", null, "client", "client" },
                    { "d9aa959d-d024-44dc-a883-aafe2206eee7", null, "admin", "admin" },
                    { "edc6f971-8295-4d2d-a15c-b1b1e55572be", null, "seller", "seller" }
                });
        }
    }
}
