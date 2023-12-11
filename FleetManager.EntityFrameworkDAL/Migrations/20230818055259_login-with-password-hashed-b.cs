using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManager.EntityFrameworkDAL.Migrations
{
    /// <inheritdoc />
    public partial class loginwithpasswordhashedb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Login_Drivers_DriverID",
                table: "Login");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Login",
                table: "Login");

            migrationBuilder.RenameTable(
                name: "Login",
                newName: "Logins");

            migrationBuilder.RenameIndex(
                name: "IX_Login_DriverID",
                table: "Logins",
                newName: "IX_Logins_DriverID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Logins",
                table: "Logins",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 27, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 79, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 47, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 47, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 67, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 4, 13 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 33, 7 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 79, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 37, 17 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 97, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 38, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 73, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 23, 17 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 86, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 51, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 21, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 81, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 39, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 36, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 57, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 18, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 38, 7 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 92, 7 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 11, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 74, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 62, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 99, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 89, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 94, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 23, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 26, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 31, 13 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 90, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 55, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 99, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 21, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 30, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 19, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 9, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 82, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 72, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 72, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 78, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 43, 20 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 84, 17 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 13, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 53, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 87, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 89, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 41, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 78, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 3, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 72, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 58, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 60, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 71, 17 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 93, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 35, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 70, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 71, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 42, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 41, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 70, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 93, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 10, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 31, 3 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 94, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 60, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 56, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 59, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 89, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 20, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 74, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 50, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 7, 3 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 88, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 87, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 24, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 82, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 74, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 41, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 96, 13 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 49, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 85, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 38, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 25, 13 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 20, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 63, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 80, 20 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 40, 17 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 65, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 56, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 33, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 41, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 75, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 15, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 19, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 48, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 61, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 100,
                column: "VehicleID",
                value: 11);

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "ID",
                keyValue: 1,
                column: "Password",
                value: "$2a$10$M1JwzXvmLWBr5v.k4vI6Oek7tO1AQDaTDsnuaIgDCAhvI3JdfwNVO");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "ID",
                keyValue: 2,
                column: "Password",
                value: "$2a$10$aZ1kFL5B2skx3Dvd34NJO.Upb5S.a1x1AGWEG.M5fP5eIcNM7v0Hy");

            migrationBuilder.UpdateData(
                table: "Logins",
                keyColumn: "ID",
                keyValue: 3,
                column: "Password",
                value: "$2a$10$20eLjTvG2NrwJpWLFZCjtusqz0WsTVe94wqm9xCbg9rpa8kXzLwIy");

            migrationBuilder.AddForeignKey(
                name: "FK_Logins_Drivers_DriverID",
                table: "Logins",
                column: "DriverID",
                principalTable: "Drivers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Logins_Drivers_DriverID",
                table: "Logins");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Logins",
                table: "Logins");

            migrationBuilder.RenameTable(
                name: "Logins",
                newName: "Login");

            migrationBuilder.RenameIndex(
                name: "IX_Logins_DriverID",
                table: "Login",
                newName: "IX_Login_DriverID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Login",
                table: "Login",
                column: "ID");

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 53, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 19, 17 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 65, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 99, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 63, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 39, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 79, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 76, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 91, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 76, 7 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 77, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 89, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 47, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 71, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 77, 3 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 47, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 59, 7 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 76, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 80, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 77, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 10, 13 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 55, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 30, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 23, 13 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 64, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 27,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 57, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 40, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 56, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 16, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 54, 3 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 41, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 65, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 82, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 22, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 32, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 24, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 90, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 51, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 79, 20 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 55, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 71, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 24, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 65, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 40, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 57, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 19, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 80, 7 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 11, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 88, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 77, 13 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 54,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 93, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 96, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 60, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 12, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 89, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 59,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 71, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 37, 20 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 86, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 25, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 80, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 17, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 64, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 76, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 27, 7 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 88, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 61, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 83, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 33, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 16, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 36, 3 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 18, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 41, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 54, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 49, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 30, 20 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 61, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 14, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 82,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 14, 3 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 2, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 17, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 85,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 23, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 35, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 4, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 14, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 46, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 62, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 93, 20 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 74, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 73, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 6, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 74, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 44, 13 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 92, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 23, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 56, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 100,
                column: "VehicleID",
                value: 16);

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "ID",
                keyValue: 1,
                column: "Password",
                value: "$2a$10$nlnijwa3PdnFDBXp27e8w..fU57VctQ4UhNianV.TNbJnYOl2n7vi");

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "ID",
                keyValue: 2,
                column: "Password",
                value: "$2a$10$7./ruw/cXwLzfh9lab7RFuuRJxjHZI50Dw/dpTSWr/b807rHYCwWK");

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "ID",
                keyValue: 3,
                column: "Password",
                value: "$2a$10$.dOuchnDW1xm3Tv8EsYVxumPRA7DRYPgP3Uv01.xcGRscYl/79fre");

            migrationBuilder.AddForeignKey(
                name: "FK_Login_Drivers_DriverID",
                table: "Login",
                column: "DriverID",
                principalTable: "Drivers",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
