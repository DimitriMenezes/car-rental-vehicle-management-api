using Microsoft.EntityFrameworkCore.Migrations;

namespace Car.Rental.Vehicles.Management.Domain.Migrations
{
    public partial class StaticDataPopulated : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                schema: "vehicle",
                table: "Category",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Basic" },
                    { 2, "Complet" },
                    { 3, "Lux" }
                });

            migrationBuilder.InsertData(
                schema: "vehicle",
                table: "FuelType",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Gas" },
                    { 2, "Alcohool" },
                    { 3, "Diesel" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                schema: "vehicle",
                table: "Category",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "vehicle",
                table: "Category",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "vehicle",
                table: "Category",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                schema: "vehicle",
                table: "FuelType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                schema: "vehicle",
                table: "FuelType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                schema: "vehicle",
                table: "FuelType",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
