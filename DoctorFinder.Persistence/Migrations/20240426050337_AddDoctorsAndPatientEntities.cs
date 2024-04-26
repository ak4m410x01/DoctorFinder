using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DoctorFinder.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class AddDoctorsAndPatientEntities : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Medical");

            migrationBuilder.AddColumn<string>(
                name: "Apartment",
                schema: "Account",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<DateOnly>(
                name: "BirthDate",
                schema: "Account",
                table: "Users",
                type: "date",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "City",
                schema: "Account",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Country",
                schema: "Account",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Floor",
                schema: "Account",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                schema: "Account",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Image",
                schema: "Account",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Location",
                schema: "Account",
                table: "Users",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PostalCode",
                schema: "Account",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "State",
                schema: "Account",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                schema: "Account",
                table: "Users",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Patients",
                schema: "Account",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_Users_Id",
                        column: x => x.Id,
                        principalSchema: "Account",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Qualifications",
                schema: "Medical",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Certification = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    YearsOfExperience = table.Column<int>(type: "int", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Qualifications", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Specializations",
                schema: "Medical",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Specializations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Doctors",
                schema: "Account",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    SpecializationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Doctors_Specializations_SpecializationId",
                        column: x => x.SpecializationId,
                        principalSchema: "Medical",
                        principalTable: "Specializations",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Doctors_Users_Id",
                        column: x => x.Id,
                        principalSchema: "Account",
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DoctorQualifications",
                schema: "Medical",
                columns: table => new
                {
                    DoctorId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    QualificationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DoctorQualifications", x => new { x.DoctorId, x.QualificationId });
                    table.ForeignKey(
                        name: "FK_DoctorQualifications_Doctors_DoctorId",
                        column: x => x.DoctorId,
                        principalSchema: "Account",
                        principalTable: "Doctors",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_DoctorQualifications_Qualifications_QualificationId",
                        column: x => x.QualificationId,
                        principalSchema: "Medical",
                        principalTable: "Qualifications",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DoctorQualifications_QualificationId",
                schema: "Medical",
                table: "DoctorQualifications",
                column: "QualificationId");

            migrationBuilder.CreateIndex(
                name: "IX_Doctors_SpecializationId",
                schema: "Account",
                table: "Doctors",
                column: "SpecializationId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DoctorQualifications",
                schema: "Medical");

            migrationBuilder.DropTable(
                name: "Patients",
                schema: "Account");

            migrationBuilder.DropTable(
                name: "Doctors",
                schema: "Account");

            migrationBuilder.DropTable(
                name: "Qualifications",
                schema: "Medical");

            migrationBuilder.DropTable(
                name: "Specializations",
                schema: "Medical");

            migrationBuilder.DropColumn(
                name: "Apartment",
                schema: "Account",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                schema: "Account",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "City",
                schema: "Account",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Country",
                schema: "Account",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Floor",
                schema: "Account",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Gender",
                schema: "Account",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Image",
                schema: "Account",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Location",
                schema: "Account",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "PostalCode",
                schema: "Account",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "State",
                schema: "Account",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "Street",
                schema: "Account",
                table: "Users");
        }
    }
}
