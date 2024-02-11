using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C_sharp_Project.Migrations
{
    /// <inheritdoc />
    public partial class updatemigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Recip_Id",
                table: "Reciptionist",
                newName: "Id");

            migrationBuilder.AlterColumn<string>(
                name: "password",
                table: "Doctor",
                type: "nvarchar(15)",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldMaxLength: 15);

            migrationBuilder.InsertData(
                table: "Doctor",
                columns: new[] { "Id", "Address", "Name", "Phone", "department", "password" },
                values: new object[] { 1, "Cairo", "Eman", "012345698715", "Surgery Department", "Doctor123" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Doctor",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Reciptionist",
                newName: "Recip_Id");

            migrationBuilder.AlterColumn<int>(
                name: "password",
                table: "Doctor",
                type: "int",
                maxLength: 15,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(15)",
                oldMaxLength: 15);
        }
    }
}
