using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CustodianProduct.Infrastructure.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "EventInsurance",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InvolvementDetails = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventHoldingType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedGuests = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SumInsured = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EventDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EventDuration = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PublicLiability = table.Column<bool>(type: "bit", nullable: false),
                    ProfessionalIndemnity = table.Column<bool>(type: "bit", nullable: false),
                    EventEquipment = table.Column<bool>(type: "bit", nullable: false),
                    EventCancellation = table.Column<bool>(type: "bit", nullable: false),
                    EmployeeAccidentBenefit = table.Column<bool>(type: "bit", nullable: false),
                    CookieConcent = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EventInsurance", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SafetyPlusPlans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PolicyPeriod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Units = table.Column<int>(type: "int", nullable: false),
                    Premium = table.Column<decimal>(type: "decimal(18,4)", nullable: false),
                    BeneficiaryIdentificationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeneficiaryIdentificationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeneficiaryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeneficiaryDateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BeneficiaryGender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BeneficiaryMeansOfIdentification = table.Column<byte[]>(type: "varbinary(max)", nullable: false),
                    BeneficairyRelationship = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConsentCookie = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TelePhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentificationType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdentificationNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MeansOfIdentification = table.Column<byte[]>(type: "varbinary(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SafetyPlusPlans", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EventInsurance");

            migrationBuilder.DropTable(
                name: "SafetyPlusPlans");
        }
    }
}
