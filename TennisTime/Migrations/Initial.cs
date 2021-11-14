using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TennisTime.Migrations
{
    public partial class Initial : Migration
    {

        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Racquets",
                columns: table => new
                {
                    RacquetId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:SqlServerValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(nullable: false),
                    Price = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racquets", x => x.RacquetId);
                }
            );

            migrationBuilder.InsertData(
                table: "Racquets",
                columns: new[] { "RacquetId", "Model", "Price", "Year"},
                values: new object[] { 1, "Blade 98 v7", 200, 2020 }
            );

            migrationBuilder.InsertData(
                table: "Racquets",
                columns: new[] { "RacquetId", "Model", "Price", "Year"},
                values: new object[] { 2, "Pro Staff", 200, 2018 }
            );

            migrationBuilder.InsertData(
                table: "Racquets",
                columns: new[] { "RacquetId", "Model", "Price", "Year"},
                values: new object[] { 3, "Aero Pro Drive", 180, 2019 }
            );

            migrationBuilder.InsertData(
                table: "Racquets",
                columns: new[] { "RacquetId", "Model", "Price", "Year"},
                values: new object[] { 4, "Vcore 98", 200, 2021 }
            );
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Racquets"
            );
        }
    }
}