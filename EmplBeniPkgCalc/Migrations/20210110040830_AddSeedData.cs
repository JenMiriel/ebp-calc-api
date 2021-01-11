using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EmployeeBenefitPackageCalc.Migrations
{
    public partial class AddSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Employee",
                columns: new[] { "id", "birthDate", "firstName", "insured", "lastName", "payRate" },
                values: new object[,]
                {
                    { 1, new DateTime(1964, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gomez", true, "Addams", 2000 },
                    { 2, new DateTime(1979, 8, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bob", true, "Parr", 2000 },
                    { 3, new DateTime(1980, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Helen", false, "Parr", 2000 },
                    { 4, new DateTime(1984, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "April", true, "O'Neil", 2000 },
                    { 5, new DateTime(1981, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sarah", true, "Connor", 2000 },
                    { 6, new DateTime(1977, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Agnarr", true, "Runeardsson", 2000 }
                });

            migrationBuilder.InsertData(
                table: "Settings",
                columns: new[] { "id", "DependantCost", "DiscountPercentage", "DiscountString", "EmployeeCost", "InsuranceName" },
                values: new object[] { 1, 500, 10, "A", 1000, "Hyrule Health Network" });

            migrationBuilder.InsertData(
                table: "Dependent",
                columns: new[] { "id", "isSpouse", "employeeId", "firstName",  "lastName", "birthDate"},
                values: new object[,]
                {
                    { 1, true, 1, "Morticia", "Addams", new DateTime(1964, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, false, 1, "Wednesday", "Addams", new DateTime(2007, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, false, 1, "Pugsley", "Addams", new DateTime(2009, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, false, 1, "Grandmama", "Addams", new DateTime(1942, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, true, 2, "Helen", "Parr", new DateTime(1980, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, false, 2, "Violet", "Parr", new DateTime(2005, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, false, 2, "Dash", "Parr", new DateTime(2011, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, false, 2, "Jack-Jack", "Parr", new DateTime(2019, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, false, 5, "John", "Connor", new DateTime(2006, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, true, 6, "Iduna", "Runeardsson", new DateTime(1977, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, false, 6, "Elsa", "Runeardsson", new DateTime(2010, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, false, 6, "Anna", "Runeardsson", new DateTime(2013, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                });

        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
               table: "Employee",
               keyColumn: "id",
               keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employee",
                keyColumn: "id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Settings",
                keyColumn: "id",
                keyValue: 1);
        }
    }
}
