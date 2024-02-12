using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C_sharp_Project.Migrations
{
    /// <inheritdoc />
    public partial class updateNewProp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctorspatient");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctorspatient",
                columns: table => new
                {
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Medicine = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctorspatient", x => new { x.PatientID, x.DoctorID });
                    table.ForeignKey(
                        name: "FK_Doctorspatient_Doctor_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Doctorspatient_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctorspatient_DoctorID",
                table: "Doctorspatient",
                column: "DoctorID");
        }
    }
}
