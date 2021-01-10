using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeBenefitPackageCalc.Migrations
{
    public partial class BaseMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.CreateTable(
            //    name: "Employee",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        payRate = table.Column<int>(type: "int", nullable: false),
            //        insured = table.Column<bool>(type: "bit", nullable: false),
            //        firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        birthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Employee", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Settings",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        InsuranceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EmployeeCost = table.Column<int>(type: "int", nullable: false),
            //        DependantCost = table.Column<int>(type: "int", nullable: false),
            //        DiscountString = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DiscountPercentage = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Settings", x => x.id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Dependent",
            //    columns: table => new
            //    {
            //        id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        employeeId = table.Column<int>(type: "int", nullable: true),
            //        firstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        lastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        birthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Dependant", x => x.id);
            //        table.ForeignKey(
            //            name: "FK_Dependant_Employee_EmployeeId",
            //            column: x => x.employeeId,
            //            principalTable: "Employee",
            //            principalColumn: "id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Dependant_EmployeeId",
            //    table: "Dependent",
            //    column: "employeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dependent");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
