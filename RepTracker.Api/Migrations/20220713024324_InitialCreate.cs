using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace RepTracker.Api.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    CountryId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false),
                    MaritalStatus = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    ImageName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "Name" },
                values: new object[,]
                {
                    { 1, "South Africa" },
                    { 2, "Germany" },
                    { 3, "Portugal" },
                    { 4, "USA" },
                    { 5, "Japan" },
                    { 6, "China" },
                    { 7, "UK" },
                    { 8, "France" },
                    { 9, "Brazil" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BirthDate", "Comment", "CountryId", "Email", "EndDate", "FirstName", "Gender", "ImageName", "LastName", "Latitude", "Longitude", "MaritalStatus", "PhoneNumber", "StartDate" },
                values: new object[] { 1, new DateTime(1988, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "...", 1, "marco@repadmins.com", null, "Marco", 0, null, "Luizinho", -26.166622, 28.309116, 0, "0111237890", new DateTime(2017, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BirthDate", "Comment", "CountryId", "Email", "EndDate", "FirstName", "Gender", "ImageName", "LastName", "Latitude", "Longitude", "MaritalStatus", "PhoneNumber", "StartDate" },
                values: new object[] { 2, new DateTime(1992, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Very Good Employee", 1, "john@repadmins.com", null, "John", 0, null, "Smith", -26.169592999999999, 27.902951999999999, 0, "0123215432", new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "BirthDate", "Comment", "CountryId", "Email", "EndDate", "FirstName", "Gender", "ImageName", "LastName", "Latitude", "Longitude", "MaritalStatus", "PhoneNumber", "StartDate" },
                values: new object[] { 3, new DateTime(1985, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "...", 5, "Joanne@repadmins.com", null, "Joanne", 1, null, "Pinto", 50.850299999999997, 4.3517000000000001, 1, "55523429803", new DateTime(2019, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_Employees_CountryId",
                table: "Employees",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "Countries");
        }
    }
}
