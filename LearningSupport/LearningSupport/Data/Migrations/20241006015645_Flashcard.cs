using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LearningSupport.Data.Migrations
{
    /// <inheritdoc />
    public partial class Flashcard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsCorrect",
                table: "Option",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "Definition",
                table: "Flashcards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Flashcards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Term",
                table: "Flashcards",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsCorrect",
                table: "Option");

            migrationBuilder.DropColumn(
                name: "Definition",
                table: "Flashcards");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Flashcards");

            migrationBuilder.DropColumn(
                name: "Term",
                table: "Flashcards");
        }
    }
}
