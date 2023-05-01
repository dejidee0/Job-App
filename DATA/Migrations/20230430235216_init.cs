using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DATA.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ApplicationForms",
                columns: table => new
                {
                    ApplicationFormId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    UploadImage = table.Column<string>(type: "TEXT", nullable: false),
                    FirstName = table.Column<string>(type: "TEXT", nullable: false),
                    LastName = table.Column<string>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: false),
                    Place = table.Column<string>(type: "TEXT", nullable: false),
                    Nationality = table.Column<string>(type: "TEXT", nullable: false),
                    CurrentRecidence = table.Column<string>(type: "TEXT", nullable: false),
                    NumberId = table.Column<string>(type: "TEXT", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Gender = table.Column<int>(type: "INTEGER", nullable: false),
                    Location = table.Column<string>(type: "TEXT", nullable: false),
                    Experience = table.Column<string>(type: "TEXT", nullable: false),
                    Resume = table.Column<string>(type: "TEXT", nullable: false),
                    AboutYourself = table.Column<string>(type: "TEXT", nullable: false),
                    Question = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApplicationForms", x => x.ApplicationFormId);
                });

            migrationBuilder.CreateTable(
                name: "ProgramDetails",
                columns: table => new
                {
                    ProgramDetailsId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Title = table.Column<string>(type: "TEXT", nullable: false),
                    Summary = table.Column<string>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", nullable: false),
                    KeySlides = table.Column<string>(type: "TEXT", nullable: false),
                    ProgramBenefits = table.Column<string>(type: "TEXT", nullable: false),
                    ApplicationCriteria = table.Column<string>(type: "TEXT", nullable: false),
                    ProgramType = table.Column<string>(type: "TEXT", nullable: false),
                    ProgramStart = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ApplicationOpen = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ApplicationClose = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Duration = table.Column<TimeSpan>(type: "TEXT", nullable: false),
                    ProgramLocation = table.Column<string>(type: "TEXT", nullable: false),
                    MinQualification = table.Column<string>(type: "TEXT", nullable: false),
                    MaxApplications = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProgramDetails", x => x.ProgramDetailsId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApplicationForms");

            migrationBuilder.DropTable(
                name: "ProgramDetails");
        }
    }
}
