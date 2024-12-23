using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sportlife.Migrations
{
    /// <inheritdoc />
    public partial class AddCategoryTraining : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TrainingCategoryEntity",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TrainingCategoryEntity", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tblCoachCategoriesTraining",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CoachId = table.Column<int>(type: "int", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    TrainingCategoryId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tblCoachCategoriesTraining", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tblCoachCategoriesTraining_TrainingCategoryEntity_TrainingCategoryId",
                        column: x => x.TrainingCategoryId,
                        principalTable: "TrainingCategoryEntity",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_tblCoachCategoriesTraining_tblCoaches_CoachId",
                        column: x => x.CoachId,
                        principalTable: "tblCoaches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_tblCoachCategoriesTraining_CoachId",
                table: "tblCoachCategoriesTraining",
                column: "CoachId");

            migrationBuilder.CreateIndex(
                name: "IX_tblCoachCategoriesTraining_TrainingCategoryId",
                table: "tblCoachCategoriesTraining",
                column: "TrainingCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tblCoachCategoriesTraining");

            migrationBuilder.DropTable(
                name: "TrainingCategoryEntity");
        }
    }
}
