using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata;

namespace TennisTime.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Make",
                columns: table => new
                {
                    MakeId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Make", x => x.MakeId);
                });

            migrationBuilder.CreateTable(
                name: "Racquets",
                columns: table => new
                {
                    RacquetId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Year = table.Column<int>(type: "int", nullable: true),
                    MakeId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    Price = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Racquets", x => x.RacquetId);
                    table.ForeignKey(
                        name: "FK_Racquets_Make_MakeId",
                        column: x => x.MakeId,
                        principalTable: "Make",
                        principalColumn: "MakeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "MakeId", "Name" },
                values: new object[,]
                {
                    { "W", "Wilson" },
                    { "B", "Babolat" },
                    { "Y", "Yonex" }
                });

            migrationBuilder.InsertData(
                table: "Racquets",
                columns: new[] { "RacquetId", "MakeId", "Model", "Price", "Year" },
                values: new object[,]
                {
                    { 1, "W", "Blade 98 v7", "200", 2020 },
                    { 2, "W", "Pro Staff", "200", 2018 },
                    { 4, "Y", "Vcore 98", "200", 2021 }
                });

            migrationBuilder.InsertData(
                table: "Racquets",
                columns: new[] { "RacquetId", "MakeId", "Model", "Price", "Year" },
                values: new object[] { 3, "B", "Aero Pro Drive", "180", 2019 });

            migrationBuilder.CreateIndex(
                name: "IX_Racquets_MakeId",
                table: "Racquets",
                column: "MakeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Racquets");

            migrationBuilder.DropTable(
                name: "Make");
        }
    }
}
