using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C_sharp_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddGendertoPatient : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Patient",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Patient");
        }
    }
}
