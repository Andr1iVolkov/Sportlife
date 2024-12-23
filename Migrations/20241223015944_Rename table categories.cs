using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Sportlife.Migrations
{
    /// <inheritdoc />
    public partial class Renametablecategories : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblCoachCategoriesTraining_TrainingCategoryEntity_TrainingCategoryId",
                table: "tblCoachCategoriesTraining");

            migrationBuilder.DropPrimaryKey(
                name: "PK_TrainingCategoryEntity",
                table: "TrainingCategoryEntity");

            migrationBuilder.RenameTable(
                name: "TrainingCategoryEntity",
                newName: "tblTrainingCategory");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tblTrainingCategory",
                table: "tblTrainingCategory",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblCoachCategoriesTraining_tblTrainingCategory_TrainingCategoryId",
                table: "tblCoachCategoriesTraining",
                column: "TrainingCategoryId",
                principalTable: "tblTrainingCategory",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tblCoachCategoriesTraining_tblTrainingCategory_TrainingCategoryId",
                table: "tblCoachCategoriesTraining");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tblTrainingCategory",
                table: "tblTrainingCategory");

            migrationBuilder.RenameTable(
                name: "tblTrainingCategory",
                newName: "TrainingCategoryEntity");

            migrationBuilder.AddPrimaryKey(
                name: "PK_TrainingCategoryEntity",
                table: "TrainingCategoryEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tblCoachCategoriesTraining_TrainingCategoryEntity_TrainingCategoryId",
                table: "tblCoachCategoriesTraining",
                column: "TrainingCategoryId",
                principalTable: "TrainingCategoryEntity",
                principalColumn: "Id");
        }
    }
}
