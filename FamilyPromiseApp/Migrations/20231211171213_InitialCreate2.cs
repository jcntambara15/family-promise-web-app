using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FamilyPromiseApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NewCase");

            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TakenBy = table.Column<string>(type: "TEXT", nullable: true),
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Time = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ReferringAgency = table.Column<string>(type: "TEXT", nullable: true),
                    CurrentSituation = table.Column<string>(type: "TEXT", nullable: true),
                    IsHoused = table.Column<string>(type: "TEXT", nullable: true),
                    IsEmployed = table.Column<string>(type: "TEXT", nullable: true),
                    TransportMethod = table.Column<string>(type: "TEXT", nullable: true),
                    Substance = table.Column<string>(type: "TEXT", nullable: true),
                    HealthChallenge = table.Column<string>(type: "TEXT", nullable: true),
                    DomesticViolenceHistory = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "IntakeModel",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    EmergencyLast = table.Column<string>(type: "TEXT", nullable: true),
                    SubstanceIss = table.Column<string>(type: "TEXT", nullable: true),
                    ShelterBefore = table.Column<string>(type: "TEXT", nullable: true),
                    Income = table.Column<string>(type: "TEXT", nullable: true),
                    FatherChild = table.Column<string>(type: "TEXT", nullable: true),
                    Gender = table.Column<string>(type: "TEXT", nullable: true),
                    TakenByNow = table.Column<string>(type: "TEXT", nullable: true),
                    TimeNow = table.Column<DateTime>(type: "TEXT", nullable: false),
                    DateToday = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Education = table.Column<string>(type: "TEXT", nullable: true),
                    ReferralAgency = table.Column<string>(type: "TEXT", nullable: true),
                    EmployerPhone = table.Column<int>(type: "INTEGER", nullable: false),
                    JobDescription = table.Column<string>(type: "TEXT", nullable: true),
                    Unemployed = table.Column<string>(type: "TEXT", nullable: true),
                    Fired = table.Column<int>(type: "INTEGER", nullable: true),
                    LengthOfEmploy = table.Column<string>(type: "TEXT", nullable: true),
                    Skills = table.Column<string>(type: "TEXT", nullable: true),
                    Arrest = table.Column<string>(type: "TEXT", nullable: true),
                    ArrestLoc = table.Column<string>(type: "TEXT", nullable: true),
                    Convictions = table.Column<string>(type: "TEXT", nullable: true),
                    Parole = table.Column<string>(type: "TEXT", nullable: true),
                    ParolePhone = table.Column<int>(type: "INTEGER", nullable: false),
                    ParoleEmail = table.Column<string>(type: "TEXT", nullable: true),
                    EmployedWhere = table.Column<string>(type: "TEXT", nullable: true),
                    Bankruptcy = table.Column<int>(type: "INTEGER", nullable: true),
                    IsEmployed = table.Column<string>(type: "TEXT", nullable: true),
                    IsHoused = table.Column<int>(type: "INTEGER", nullable: false),
                    Relationships = table.Column<string>(type: "TEXT", nullable: true),
                    WorkStudy = table.Column<string>(type: "TEXT", nullable: true),
                    AdultNum = table.Column<int>(type: "INTEGER", nullable: false),
                    SSN = table.Column<int>(type: "INTEGER", nullable: false),
                    Reason = table.Column<string>(type: "TEXT", nullable: true),
                    Reason2 = table.Column<string>(type: "TEXT", nullable: true),
                    IDNum = table.Column<int>(type: "INTEGER", nullable: false),
                    Race = table.Column<string>(type: "TEXT", nullable: true),
                    ChildGender = table.Column<string>(type: "TEXT", nullable: true),
                    Transportation1 = table.Column<int>(type: "INTEGER", nullable: false),
                    Transportation2 = table.Column<string>(type: "TEXT", nullable: true),
                    Transportation3 = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    FirstMidName = table.Column<string>(type: "TEXT", nullable: true),
                    MaritalStatus = table.Column<string>(type: "TEXT", nullable: true),
                    ChildSchool = table.Column<string>(type: "TEXT", nullable: true),
                    DCF = table.Column<string>(type: "TEXT", nullable: true),
                    EmergencyFirst = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    DateAdmitted = table.Column<int>(type: "INTEGER", nullable: false),
                    CompletionDate = table.Column<int>(type: "INTEGER", nullable: false),
                    DOB = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CellPhoneNum = table.Column<int>(type: "INTEGER", nullable: false),
                    WorkPhoneNum = table.Column<int>(type: "INTEGER", nullable: false),
                    EmailAdd = table.Column<string>(type: "TEXT", nullable: true),
                    HomeAddress = table.Column<string>(type: "TEXT", nullable: true),
                    SubstanceAbuse = table.Column<string>(type: "TEXT", nullable: true),
                    HouseHoldMemberExists = table.Column<int>(type: "INTEGER", nullable: true),
                    AdultName = table.Column<string>(type: "TEXT", nullable: true),
                    Assets = table.Column<int>(type: "INTEGER", nullable: false),
                    AdultAge = table.Column<int>(type: "INTEGER", nullable: false),
                    Debts = table.Column<int>(type: "INTEGER", nullable: false),
                    AdultDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AdultCellPhone = table.Column<string>(type: "TEXT", nullable: true),
                    AdultWorkPhone = table.Column<string>(type: "TEXT", nullable: true),
                    AdultEmail = table.Column<string>(type: "TEXT", nullable: true),
                    HouseHoldChildrenExists = table.Column<int>(type: "INTEGER", nullable: true),
                    RecentHousing = table.Column<int>(type: "INTEGER", nullable: true),
                    HouseType = table.Column<int>(type: "INTEGER", nullable: true),
                    ChildNum = table.Column<int>(type: "INTEGER", nullable: false),
                    ChildName = table.Column<string>(type: "TEXT", nullable: true),
                    ChildDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChildAge = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IntakeModel", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Person",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    CellPhone = table.Column<string>(type: "TEXT", nullable: true),
                    WorkPhone = table.Column<string>(type: "TEXT", nullable: true),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    HouseHoldMemberExist = table.Column<int>(type: "INTEGER", nullable: true),
                    HouseHoldNum = table.Column<int>(type: "INTEGER", nullable: false),
                    AdultName = table.Column<string>(type: "TEXT", nullable: true),
                    AdultAge = table.Column<int>(type: "INTEGER", nullable: false),
                    AdultDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AdultCellPhone = table.Column<string>(type: "TEXT", nullable: true),
                    AdultWorkPhone = table.Column<string>(type: "TEXT", nullable: true),
                    AdultEmail = table.Column<string>(type: "TEXT", nullable: true),
                    HouseHoldChildrenExist = table.Column<int>(type: "INTEGER", nullable: true),
                    ChildNum = table.Column<int>(type: "INTEGER", nullable: false),
                    ChildName = table.Column<string>(type: "TEXT", nullable: true),
                    ChildDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChildAge = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Person", x => x.ID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Case");

            migrationBuilder.DropTable(
                name: "IntakeModel");

            migrationBuilder.DropTable(
                name: "Person");

            migrationBuilder.CreateTable(
                name: "NewCase",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Age = table.Column<int>(type: "INTEGER", nullable: false),
                    CellPhone = table.Column<string>(type: "TEXT", nullable: true),
                    ChildAge = table.Column<int>(type: "INTEGER", nullable: false),
                    ChildDateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ChildName = table.Column<string>(type: "TEXT", nullable: true),
                    ChildNum = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Email = table.Column<string>(type: "TEXT", nullable: true),
                    FirstName = table.Column<string>(type: "TEXT", nullable: true),
                    LastName = table.Column<string>(type: "TEXT", nullable: true),
                    WorkPhone = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewCase", x => x.ID);
                });
        }
    }
}
