using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace C_sharp_Project.Migrations
{
    /// <inheritdoc />
    public partial class updateRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ReciptionAddPatientDoc",
                columns: table => new
                {
                    PatientID = table.Column<int>(type: "int", nullable: false),
                    DoctorID = table.Column<int>(type: "int", nullable: false),
                    ReciptionistID = table.Column<int>(type: "int", nullable: false),
                    State = table.Column<bool>(type: "bit", nullable: false),
                    Price = table.Column<int>(type: "int", nullable: false),
                    Appointment = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReciptionAddPatientDoc", x => new { x.PatientID, x.DoctorID, x.ReciptionistID });
                    table.ForeignKey(
                        name: "FK_ReciptionAddPatientDoc_Doctor_DoctorID",
                        column: x => x.DoctorID,
                        principalTable: "Doctor",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReciptionAddPatientDoc_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ReciptionAddPatientDoc_Reciptionist_ReciptionistID",
                        column: x => x.ReciptionistID,
                        principalTable: "Reciptionist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ReciptionAddPatientDoc_DoctorID",
                table: "ReciptionAddPatientDoc",
                column: "DoctorID");

            migrationBuilder.CreateIndex(
                name: "IX_ReciptionAddPatientDoc_ReciptionistID",
                table: "ReciptionAddPatientDoc",
                column: "ReciptionistID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ReciptionAddPatientDoc");
        }
    }
}
