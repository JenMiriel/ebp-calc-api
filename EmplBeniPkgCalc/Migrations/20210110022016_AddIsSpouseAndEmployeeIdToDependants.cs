using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeBenefitPackageCalc.Migrations
{
    public partial class AddIsSpouseAndEmployeeIdToDependants : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropForeignKey(
            //    name: "FK_Dependant_Employee_EmployeeId",
            //    table: "Dependant");

            //migrationBuilder.AlterColumn<int>(
            //    name: "EmployeeId",
            //    table: "Dependant",
            //    type: "int",
            //    nullable: false,
            //    defaultValue: 0,
            //    oldClrType: typeof(int),
            //    oldType: "int",
            //    oldNullable: true);

            //migrationBuilder.AddColumn<bool>(
            //    name: "IsSpouse",
            //    table: "Dependant",
            //    type: "bit",
            //    nullable: false,
            //    defaultValue: false);

            //migrationBuilder.AddForeignKey(
            //    name: "FK_Dependant_Employee_EmployeeId",
            //    table: "Dependant",
            //    column: "EmployeeId",
            //    principalTable: "Employee",
            //    principalColumn: "Id",
            //    onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dependant_Employee_EmployeeId",
                table: "Dependant");

            migrationBuilder.DropColumn(
                name: "IsSpouse",
                table: "Dependant");

            migrationBuilder.AlterColumn<int>(
                name: "EmployeeId",
                table: "Dependant",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Dependant_Employee_EmployeeId",
                table: "Dependant",
                column: "EmployeeId",
                principalTable: "Employee",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
