using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Repository.Migrations
{
    public partial class MyFirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    FirstName = table.Column<string>(nullable: false),
                    MidName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: false),
                    Suffix = table.Column<string>(nullable: true),
                    AddressLine1 = table.Column<string>(nullable: false),
                    AddressLine2 = table.Column<string>(nullable: false),
                    POBox = table.Column<string>(nullable: true),
                    Sex = table.Column<string>(nullable: false),
                    DateOfBirth = table.Column<DateTime>(nullable: false),
                    PassportNumber = table.Column<string>(nullable: false),
                    EmiratesID = table.Column<string>(nullable: false),
                    WorkTitle = table.Column<string>(nullable: true),
                    MailAddress = table.Column<string>(nullable: true),
                    MobilePhone = table.Column<string>(nullable: false),
                    HomePhone = table.Column<string>(nullable: false),
                    WorkPhone = table.Column<string>(nullable: true),
                    HasGaurdian = table.Column<bool>(nullable: false),
                    Nationality = table.Column<string>(nullable: false),
                    InsuranceCoverage = table.Column<string>(nullable: false),
                    MartialStatus = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guardian",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddedDate = table.Column<DateTime>(nullable: false),
                    ModifiedDate = table.Column<DateTime>(nullable: false),
                    Phone = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: false),
                    Relation = table.Column<string>(nullable: false),
                    PatientID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guardian", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Guardian_Patient_PatientID",
                        column: x => x.PatientID,
                        principalTable: "Patient",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Guardian_PatientID",
                table: "Guardian",
                column: "PatientID",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Guardian");

            migrationBuilder.DropTable(
                name: "Patient");
        }
    }
}
