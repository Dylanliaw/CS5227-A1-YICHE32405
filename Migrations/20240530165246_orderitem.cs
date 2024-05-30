using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS5227_A1_YICHE32405.Migrations
{
    /// <inheritdoc />
    public partial class orderitem : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "OrderItems");

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
    }
}
