using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace EmployeeManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class seed_data : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Designations_DesignationId",
                table: "Employees");

            migrationBuilder.InsertData(
                table: "Departments",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, false, "IT" },
                    { 2, false, "HR" },
                    { 3, false, "Sales" },
                    { 4, false, "Admin" }
                });

            migrationBuilder.InsertData(
                table: "EmployeeTypes",
                columns: new[] { "Id", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, false, "Permanent" },
                    { 2, false, "Temporary" },
                    { 3, false, "Contract" },
                    { 4, false, "Intern" },
                    { 5, false, "Part-Time" }
                });

            migrationBuilder.InsertData(
                table: "Designations",
                columns: new[] { "Id", "DepartmentId", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, 1, false, "Software Developer" },
                    { 2, 1, false, "System Administrator" },
                    { 3, 1, false, "Network Engineer" },
                    { 4, 2, false, "HR Specialist" },
                    { 5, 2, false, "HR Manager" },
                    { 6, 2, false, "Talent Acquisition Coordinator" },
                    { 7, 3, false, "Sales Executive" },
                    { 8, 3, false, "Sales Manager" },
                    { 9, 3, false, "Account Executive" },
                    { 10, 4, false, "Office Manager" },
                    { 11, 4, false, "Executive Assistant" },
                    { 12, 4, false, "Receptionist" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "Id", "DateOfBirth", "DepartmentId", "DesignationId", "Email", "EmployeeTypeId", "FullName", "Gender", "HireDate", "Salary" },
                values: new object[,]
                {
                    { 1, new DateTime(1990, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 1, "john@example.com", 1, "John Doe", "Male", new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 60000m },
                    { 2, new DateTime(1985, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 5, "jane@example.com", 1, "Jane Smith", "Female", new DateTime(2018, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 80000m },
                    { 3, new DateTime(1992, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7, "sam@example.com", 3, "Sam Wilson", "Male", new DateTime(2021, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 50000m },
                    { 4, new DateTime(1995, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 11, "anna@example.com", 2, "Anna Taylor", "Female", new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 40000m },
                    { 5, new DateTime(1989, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3, "tom@example.com", 1, "Tom Brown", "Male", new DateTime(2019, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 70000m },
                    { 6, new DateTime(1987, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, "emma@example.com", 1, "Emma Davis", "Female", new DateTime(2017, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 75000m },
                    { 7, new DateTime(1990, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 8, "luke@example.com", 3, "Luke Miller", "Male", new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 85000m },
                    { 8, new DateTime(1993, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 10, "olivia@example.com", 1, "Olivia Johnson", "Female", new DateTime(2021, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 65000m },
                    { 9, new DateTime(1997, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "mia@example.com", 4, "Mia Moore", "Female", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 30000m },
                    { 10, new DateTime(1986, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 6, "chris@example.com", 2, "Chris Evans", "Other", new DateTime(2018, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 55000m },
                    { 11, new DateTime(1994, 5, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 7, "sophia@example.com", 1, "Sophia White", "Female", new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 52000m },
                    { 12, new DateTime(1996, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 12, "liam@example.com", 2, "Liam Green", "Male", new DateTime(2020, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 38000m },
                    { 13, new DateTime(1991, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2, "noah@example.com", 1, "Noah Black", "Male", new DateTime(2018, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 65000m },
                    { 14, new DateTime(1988, 4, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4, "isabella@example.com", 1, "Isabella Blue", "Female", new DateTime(2017, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 76000m },
                    { 15, new DateTime(1993, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 9, "james@example.com", 3, "James Brown", "Male", new DateTime(2021, 7, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 62000m }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Designations_DesignationId",
                table: "Employees",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employees_Designations_DesignationId",
                table: "Employees");

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Designations",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "EmployeeTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Departments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.AddForeignKey(
                name: "FK_Employees_Designations_DesignationId",
                table: "Employees",
                column: "DesignationId",
                principalTable: "Designations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
