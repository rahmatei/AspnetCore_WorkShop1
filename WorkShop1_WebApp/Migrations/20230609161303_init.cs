using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WorkShop1_WebApp.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Category", "Description", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "LapTop", "Dell_V110 tetsttsttstst", "Dell_V110", 100 },
                    { 2, "LapTop", "Acer_V110 tetsttsttstst", "Acer_V110", 522 },
                    { 3, "LapTop", "Toshiba_V110 tetsttsttstst", "Toshiba_V110", 500 },
                    { 4, "Computer", "tetsttsttstst", "AllInOne_V110", 800 },
                    { 5, "Computer", "tetsttsttstst", "Dell_V110", 600 },
                    { 6, "Mobile", "tetsttsttstst", "Iphone_V110", 500 },
                    { 7, "Mobile", "tetsttsttstst", "Sumsung_V110", 750 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
