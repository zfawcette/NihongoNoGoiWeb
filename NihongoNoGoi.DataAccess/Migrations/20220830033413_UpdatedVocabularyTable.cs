using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NihongoNoGoi.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedVocabularyTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Answer",
                table: "Vocabulary",
                newName: "Reading");

            migrationBuilder.AddColumn<int>(
                name: "AppLevel",
                table: "Vocabulary",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Meaning",
                table: "Vocabulary",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AppLevel",
                table: "Vocabulary");

            migrationBuilder.DropColumn(
                name: "Meaning",
                table: "Vocabulary");

            migrationBuilder.RenameColumn(
                name: "Reading",
                table: "Vocabulary",
                newName: "Answer");
        }
    }
}
