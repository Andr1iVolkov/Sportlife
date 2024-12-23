using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sportlife.Migrations
{
    /// <inheritdoc />
    public partial class recreatetblcoachcategorytra : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblCoachCategoriesTraining_tblTrainingCategory_TrainingCategoryId",
                table: "tblCoachCategoriesTraining");

            migrationBuilder.DropIndex(
                name: "IX_tblCoachCategoriesTraining_TrainingCategoryId",
                table: "tblCoachCategoriesTraining");

            migrationBuilder.DropColumn(
                name: "TrainingCategoryId",
                table: "tblCoachCategoriesTraining");

            migrationBuilder.CreateIndex(
                name: "IX_tblCoachCategoriesTraining_CategoryId",
                table: "tblCoachCategoriesTraining",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblCoachCategoriesTraining_tblTrainingCategory_CategoryId",
                table: "tblCoachCategoriesTraining",
                column: "CategoryId",
                principalTable: "tblTrainingCategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblCoachCategoriesTraining_tblTrainingCategory_CategoryId",
                table: "tblCoachCategoriesTraining");

            migrationBuilder.DropIndex(
                name: "IX_tblCoachCategoriesTraining_CategoryId",
                table: "tblCoachCategoriesTraining");

            migrationBuilder.AddColumn<int>(
                name: "TrainingCategoryId",
                table: "tblCoachCategoriesTraining",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_tblCoachCategoriesTraining_TrainingCategoryId",
                table: "tblCoachCategoriesTraining",
                column: "TrainingCategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_tblCoachCategoriesTraining_tblTrainingCategory_TrainingCategoryId",
                table: "tblCoachCategoriesTraining",
                column: "TrainingCategoryId",
                principalTable: "tblTrainingCategory",
                principalColumn: "Id");
        }
    }
}
