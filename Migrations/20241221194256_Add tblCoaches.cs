using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sportlife.Migrations
{
    /// <inheritdoc />
    public partial class AddtblCoaches : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tblCoaches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    SecondName = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    MainImage = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false),
                    Quote = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    GymId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCoaches", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCoaches_tblGyms_GymId",
                        column: x => x.GymId,
                        principalTable: "tblGyms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCoaches_GymId",
                table: "tblCoaches",
                column: "GymId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCoaches");
        }
    }
}
