using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FleetManager.EntityFrameworkDAL.Migrations
{
    /// <inheritdoc />
    public partial class seedingforloginswithconfigure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Role",
                table: "Login",
                type: "nvarchar(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Login",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 35, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 48, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 58, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 62, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 64, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 88, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 96, 13 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 43, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 33, 20 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 78, 3 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 96, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 36, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 86, 3 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 31, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 96, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 53, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 69, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 28, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 59, 3 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 82, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 16, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 42, 7 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 13, 3 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 57, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 69, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 15, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 27,
                column: "DriverID",
                value: 81);

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 78, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 52, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 28, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 12, 3 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 22, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 81, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 77, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 62, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 89, 7 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 28, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 31, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 85, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 52, 20 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 88, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 37, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 28, 20 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 50, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 60, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 76, 7 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 80, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 40, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 91, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 42, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 51, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 63, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 54,
                column: "DriverID",
                value: 51);

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 27, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 49, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 38, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 59,
                column: "DriverID",
                value: 66);

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
                values: new object[] { 70, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 33, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 33, 13 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 16, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 14, 7 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 44, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 81, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 70, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 86, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 75, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 26, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 16, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 45, 17 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 16, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 8, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 23, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 46, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 80, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 24, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 97, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 34, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 82,
                column: "VehicleID",
                value: 13);

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 88, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 78, 13 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 85,
                column: "DriverID",
                value: 5);

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 51, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 90, 17 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 71, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 2, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 33, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 68, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 72, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 70, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 17, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 53, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 94, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 21, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 95, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 16, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 77, 4 });

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "ID",
                keyValue: 1,
                column: "Role",
                value: "Admin");

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "ID",
                keyValue: 2,
                column: "Role",
                value: "User");

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "ID",
                keyValue: 3,
                column: "Role",
                value: "User");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Role",
                table: "Login",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Login",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 1,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 17, 7 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 2,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 51, 17 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 3,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 14, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 4,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 69, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 5,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 7, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 6,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 5, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 7,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 5, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 8,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 15, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 9,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 10, 18 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 10,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 24, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 11,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 67, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 12,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 9, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 13,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 51, 20 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 14,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 44, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 15,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 11, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 16,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 5, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 17,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 52, 7 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 18,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 97, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 19,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 49, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 20,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 1, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 21,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 22, 17 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 22,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 88, 3 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 23,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 19, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 24,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 30, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 25,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 50, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 26,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 81, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 27,
                column: "DriverID",
                value: 68);

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 28,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 28, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 29,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 54, 16 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 30,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 94, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 31,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 26, 20 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 32,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 41, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 33,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 33, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 34,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 92, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 35,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 28, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 36,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 66, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 37,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 43, 13 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 38,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 7, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 39,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 66, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 40,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 18, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 41,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 55, 3 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 42,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 27, 20 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 43,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 91, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 44,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 56, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 45,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 57, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 46,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 41, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 47,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 39, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 48,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 41, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 49,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 91, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 50,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 9, 17 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 51,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 87, 8 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 52,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 49, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 53,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 46, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 54,
                column: "DriverID",
                value: 13);

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 55,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 41, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 56,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 91, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 57,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 8, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 58,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 61, 3 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 59,
                column: "DriverID",
                value: 53);

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 60,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 31, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 61,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 73, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 62,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 5, 4 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 63,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 27, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 64,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 91, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 65,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 70, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 66,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 27, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 67,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 73, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 68,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 29, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 69,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 21, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 70,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 90, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 71,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 75, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 72,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 29, 10 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 73,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 3, 11 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 74,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 47, 9 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 75,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 64, 15 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 76,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 68, 1 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 77,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 8, 13 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 78,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 64, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 79,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 95, 17 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 80,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 84, 20 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 81,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 87, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 82,
                column: "VehicleID",
                value: 3);

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 83,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 51, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 84,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 24, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 85,
                column: "DriverID",
                value: 64);

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 86,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 15, 20 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 87,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 72, 12 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 88,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 19, 17 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 89,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 93, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 90,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 84, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 91,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 63, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 92,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 80, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 93,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 55, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 94,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 49, 14 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 95,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 42, 19 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 96,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 32, 2 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 97,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 51, 5 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 98,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 83, 7 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 99,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 13, 6 });

            migrationBuilder.UpdateData(
                table: "DriverVehicles",
                keyColumn: "ID",
                keyValue: 100,
                columns: new[] { "DriverID", "VehicleID" },
                values: new object[] { 92, 10 });

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "ID",
                keyValue: 1,
                column: "Role",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "ID",
                keyValue: 2,
                column: "Role",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Login",
                keyColumn: "ID",
                keyValue: 3,
                column: "Role",
                value: 1);
        }
    }
}
