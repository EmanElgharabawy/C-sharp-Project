using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C_sharp_Project.Migrations
{
    /// <inheritdoc />
    public partial class updateNewTabledocPat : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctorspatient",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Medicine = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    Diagnosis = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    PatientID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctorspatient", x => x.Id);
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

            migrationBuilder.CreateIndex(
                name: "IX_Doctorspatient_PatientID",
                table: "Doctorspatient",
                column: "PatientID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctorspatient");
        }
    }
}
