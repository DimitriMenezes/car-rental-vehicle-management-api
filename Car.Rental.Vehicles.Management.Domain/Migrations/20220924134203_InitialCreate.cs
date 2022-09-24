using Microsoft.EntityFrameworkCore.Migrations;

namespace Car.Rental.Vehicles.Management.Domain.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "vehicle");

            migrationBuilder.CreateTable(
                name: "Category",
                schema: "vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Category", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FuelType",
                schema: "vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Mark",
                schema: "vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mark", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Model",
                schema: "vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Model", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vehicle",
                schema: "vehicle",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LicensePlate = table.Column<string>(maxLength: 12, nullable: false),
                    Year = table.Column<int>(nullable: false),
                    HourlyRate = table.Column<decimal>(nullable: false),
                    TrunkCapacity = table.Column<decimal>(nullable: false),
                    MarkId = table.Column<int>(nullable: false),
                    ModelId = table.Column<int>(nullable: false),
                    FuelTypeId = table.Column<int>(nullable: false),
                    CategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicle", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vehicle_Category_CategoryId",
                        column: x => x.CategoryId,
                        principalSchema: "vehicle",
                        principalTable: "Category",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_FuelType_FuelTypeId",
                        column: x => x.FuelTypeId,
                        principalSchema: "vehicle",
                        principalTable: "FuelType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_Mark_MarkId",
                        column: x => x.MarkId,
                        principalSchema: "vehicle",
                        principalTable: "Mark",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Vehicle_Model_ModelId",
                        column: x => x.ModelId,
                        principalSchema: "vehicle",
                        principalTable: "Model",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_CategoryId",
                schema: "vehicle",
                table: "Vehicle",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_FuelTypeId",
                schema: "vehicle",
                table: "Vehicle",
                column: "FuelTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_MarkId",
                schema: "vehicle",
                table: "Vehicle",
                column: "MarkId");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicle_ModelId",
                schema: "vehicle",
                table: "Vehicle",
                column: "ModelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vehicle",
                schema: "vehicle");

            migrationBuilder.DropTable(
                name: "Category",
                schema: "vehicle");

            migrationBuilder.DropTable(
                name: "FuelType",
                schema: "vehicle");

            migrationBuilder.DropTable(
                name: "Mark",
                schema: "vehicle");

            migrationBuilder.DropTable(
                name: "Model",
                schema: "vehicle");
        }
    }
}
