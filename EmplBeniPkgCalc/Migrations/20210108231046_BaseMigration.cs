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
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        PayRate = table.Column<int>(type: "int", nullable: false),
            //        Insured = table.Column<bool>(type: "bit", nullable: false),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Employee", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Settings",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        InsuranceName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        EmployeeCost = table.Column<int>(type: "int", nullable: false),
            //        DependantCost = table.Column<int>(type: "int", nullable: false),
            //        DiscountString = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        DiscountPercentage = table.Column<int>(type: "int", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Settings", x => x.Id);
            //    });

            //migrationBuilder.CreateTable(
            //    name: "Dependant",
            //    columns: table => new
            //    {
            //        Id = table.Column<int>(type: "int", nullable: false)
            //            .Annotation("SqlServer:Identity", "1, 1"),
            //        EmployeeId = table.Column<int>(type: "int", nullable: true),
            //        FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
            //        BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false)
            //    },
            //    constraints: table =>
            //    {
            //        table.PrimaryKey("PK_Dependant", x => x.Id);
            //        table.ForeignKey(
            //            name: "FK_Dependant_Employee_EmployeeId",
            //            column: x => x.EmployeeId,
            //            principalTable: "Employee",
            //            principalColumn: "Id",
            //            onDelete: ReferentialAction.Restrict);
            //    });

            //migrationBuilder.CreateIndex(
            //    name: "IX_Dependant_EmployeeId",
            //    table: "Dependant",
            //    column: "EmployeeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Dependant");

            migrationBuilder.DropTable(
                name: "Settings");

            migrationBuilder.DropTable(
                name: "Employee");
        }
    }
}
