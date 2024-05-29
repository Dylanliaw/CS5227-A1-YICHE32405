using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CS5227_A1_YICHE32405.Migrations
{
    /// <inheritdoc />
    public partial class specialoffer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.CreateTable(
                name: "SpecialOffers",
                columns: table => new
                {
                    FoodId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<float>(type: "real", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SpecialOffers", x => x.FoodId);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SpecialOffers");

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
                    { "463ef86d-0b7f-4fad-934f-bc982fe9d79b", null, "admin", "admin" },
                    { "5b167529-07e4-4ed1-af05-a70444d09fb0", null, "client", "client" },
                    { "c9da7174-9b31-4f0e-ae58-0838af9abf97", null, "seller", "seller" }
                });
        }
    }
}
