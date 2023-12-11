using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FleetManager.EntityFrameworkDAL.Migrations
{
    /// <inheritdoc />
    public partial class seedingforlogins : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DamageRepairTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageRepairTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    LastName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "date", nullable: false),
                    NationalRegistrationNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false),
                    AddressPostalCode = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    AddressHouseNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: true),
                    AddressStreet = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    AddressCity = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    LicenseType = table.Column<string>(type: "nvarchar(4)", maxLength: 4, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "ExtraServices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExtraServices", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FuelCards",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelCardNumber = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    CardValidityStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    CardValidityEndDate = table.Column<DateTime>(type: "date", nullable: true),
                    PINCode = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: true),
                    AuthenticationType = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    FuelType = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelCards", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Garages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Garages", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "InquiryTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(512)", maxLength: 512, nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AppointmentNeeded = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InquiryTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "InsuranceCompanies",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReferenceNumber = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InsuranceCompanies", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleParts",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleParts", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "VehicleTypes",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VehicleTypes", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverID = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Role = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Login_Drivers_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DriverFuelCards",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverID = table.Column<int>(type: "int", nullable: false),
                    FuelCardID = table.Column<int>(type: "int", nullable: false),
                    OwnershipStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    OwnershipEndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverFuelCards", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DriverFuelCards_Drivers_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DriverFuelCards_FuelCards_FuelCardID",
                        column: x => x.FuelCardID,
                        principalTable: "FuelCards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FuelCardsExtraServices",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelCardID = table.Column<int>(type: "int", nullable: false),
                    ExtraServiceID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelCardsExtraServices", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FuelCardsExtraServices_ExtraServices_ExtraServiceID",
                        column: x => x.ExtraServiceID,
                        principalTable: "ExtraServices",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FuelCardsExtraServices_FuelCards_FuelCardID",
                        column: x => x.FuelCardID,
                        principalTable: "FuelCards",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Vehicles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    ChassisNumber = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    Active = table.Column<bool>(type: "bit", nullable: false),
                    FuelType = table.Column<string>(type: "nvarchar(64)", maxLength: 64, nullable: true),
                    VehicleTypeID = table.Column<int>(type: "int", nullable: false),
                    RegistrationDate = table.Column<DateTime>(type: "date", nullable: true),
                    LeasingStartDate = table.Column<DateTime>(type: "date", nullable: true),
                    LeasingEndDate = table.Column<DateTime>(type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vehicles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Vehicles_VehicleTypes_VehicleTypeID",
                        column: x => x.VehicleTypeID,
                        principalTable: "VehicleTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DriverVehicles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverID = table.Column<int>(type: "int", nullable: false),
                    VehicleID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DriverVehicles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DriverVehicles_Drivers_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DriverVehicles_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Inquiries",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InquiryTypeID = table.Column<int>(type: "int", nullable: false),
                    DateOfInquiry = table.Column<DateTime>(type: "datetime", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: false),
                    VehicleID = table.Column<int>(type: "int", nullable: true),
                    DriverID = table.Column<int>(type: "int", nullable: true),
                    Comment = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inquiries", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Inquiries_Drivers_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inquiries_InquiryTypes_InquiryTypeID",
                        column: x => x.InquiryTypeID,
                        principalTable: "InquiryTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inquiries_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InspectionReports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DriverID = table.Column<int>(type: "int", nullable: false),
                    VehicleID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    InspectionReportFilePath = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InspectionReports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_InspectionReports_Drivers_DriverID",
                        column: x => x.DriverID,
                        principalTable: "Drivers",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InspectionReports_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LicensePlates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleID = table.Column<int>(type: "int", nullable: false),
                    ValidityStartDate = table.Column<DateTime>(type: "date", nullable: false),
                    ValidityEndDate = table.Column<DateTime>(type: "date", nullable: true),
                    LicensePlateNumber = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LicensePlates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_LicensePlates_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Maintenances",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(32,2)", nullable: true),
                    GarageID = table.Column<int>(type: "int", nullable: true),
                    InvoiceFilePath = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Maintenances", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Maintenances_Garages_GarageID",
                        column: x => x.GarageID,
                        principalTable: "Garages",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Maintenances_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Mileages",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleID = table.Column<int>(type: "int", nullable: false),
                    Date = table.Column<DateTime>(type: "date", nullable: false),
                    MileageInKilometers = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mileages", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Mileages_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreferredAppointmentDates",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InquiryID = table.Column<int>(type: "int", nullable: false),
                    PreferredDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreferredAppointmentDates", x => x.ID);
                    table.ForeignKey(
                        name: "FK_PreferredAppointmentDates_Inquiries_InquiryID",
                        column: x => x.InquiryID,
                        principalTable: "Inquiries",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DamageReports",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InspectionReportID = table.Column<int>(type: "int", nullable: false),
                    ReportDate = table.Column<DateTime>(type: "date", nullable: false),
                    DamageDate = table.Column<DateTime>(type: "date", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(2048)", maxLength: 2048, nullable: false),
                    Cost = table.Column<decimal>(type: "decimal(16,2)", nullable: false),
                    DamageRepairTypeID = table.Column<int>(type: "int", nullable: true),
                    VehiclePartID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageReports", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DamageReports_DamageRepairTypes_DamageRepairTypeID",
                        column: x => x.DamageRepairTypeID,
                        principalTable: "DamageRepairTypes",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DamageReports_InspectionReports_InspectionReportID",
                        column: x => x.InspectionReportID,
                        principalTable: "InspectionReports",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_DamageReports_VehicleParts_VehiclePartID",
                        column: x => x.VehiclePartID,
                        principalTable: "VehicleParts",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaintenanceTasks",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaintenanceID = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaintenanceTasks", x => x.ID);
                    table.ForeignKey(
                        name: "FK_MaintenanceTasks_Maintenances_MaintenanceID",
                        column: x => x.MaintenanceID,
                        principalTable: "Maintenances",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "DamageReportPhotos",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DamageReportID = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DamageReportPhotos", x => x.ID);
                    table.ForeignKey(
                        name: "FK_DamageReportPhotos_DamageReports_DamageReportID",
                        column: x => x.DamageReportID,
                        principalTable: "DamageReports",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Repairs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VehicleID = table.Column<int>(type: "int", nullable: false),
                    RepairDate = table.Column<DateTime>(type: "date", nullable: false),
                    RepairCost = table.Column<decimal>(type: "decimal(32,2)", nullable: true),
                    PaymentDate = table.Column<DateTime>(type: "date", nullable: true),
                    DamageReportID = table.Column<int>(type: "int", nullable: true),
                    InsuranceCompanyID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Repairs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Repairs_DamageReports_DamageReportID",
                        column: x => x.DamageReportID,
                        principalTable: "DamageReports",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Repairs_InsuranceCompanies_InsuranceCompanyID",
                        column: x => x.InsuranceCompanyID,
                        principalTable: "InsuranceCompanies",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Repairs_Vehicles_VehicleID",
                        column: x => x.VehicleID,
                        principalTable: "Vehicles",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RepairFiles",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RepairID = table.Column<int>(type: "int", nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    FileType = table.Column<string>(type: "nvarchar(16)", maxLength: 16, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepairFiles", x => x.ID);
                    table.ForeignKey(
                        name: "FK_RepairFiles_Repairs_RepairID",
                        column: x => x.RepairID,
                        principalTable: "Repairs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "DamageRepairTypes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Vervangen van remblokken" },
                    { 2, "Vervangen van bougies" },
                    { 3, "Vervangen van accu" },
                    { 4, "Vervangen van oliefilter" },
                    { 5, "Vervangen van luchtfilter" },
                    { 6, "Vervangen van brandstoffilter" },
                    { 7, "Vervangen van interieurfilter" },
                    { 8, "Vervangen van ruitenwisserbladen" },
                    { 9, "Vervangen van distributieriem" },
                    { 10, "Vervangen van waterpomp" },
                    { 11, "Vervangen van multiriem" },
                    { 12, "Vervangen van dynamo" },
                    { 13, "Vervangen van startmotor" },
                    { 14, "Vervangen van koppeling" },
                    { 15, "Vervangen van drukgroep" },
                    { 16, "Vervangen van versnellingsbak" },
                    { 17, "Vervangen van koppelingskabel" },
                    { 18, "Vervangen van remschijven" },
                    { 19, "Vervangen van remblokken achter" },
                    { 20, "Vervangen van remklauwen" },
                    { 21, "Vervangen van handremkabels" },
                    { 22, "Vervangen van ABS-sensor" },
                    { 23, "Vervangen van fuseekogel" },
                    { 24, "Vervangen van draagarm" },
                    { 25, "Vervangen van stabilisatorstang" },
                    { 26, "Vervangen van schokdempers" },
                    { 27, "Vervangen van veerpootlagers" },
                    { 28, "Vervangen van aandrijfas" },
                    { 29, "Vervangen van homokineet" },
                    { 30, "Vervangen van stuurkogel" },
                    { 31, "Vervangen van fuseekogelhoes" },
                    { 32, "Vervangen van aandrijfashoes" },
                    { 33, "Vervangen van wielnaaf" },
                    { 34, "Vervangen van stuurhuis" },
                    { 35, "Vervangen van stuurbekrachtigingspomp" },
                    { 36, "Vervangen van uitlaatspruitstuk" },
                    { 37, "Vervangen van katalysator" },
                    { 38, "Vervangen van lambdasonde" },
                    { 39, "Vervangen van middendemper" },
                    { 40, "Vervangen van einddemper" },
                    { 41, "Vervangen van achterdemper" },
                    { 42, "Vervangen van radiateur" },
                    { 43, "Vervangen van thermostaat" },
                    { 44, "Vervangen van koelvloeistof" },
                    { 45, "Vervangen van waterpomp" },
                    { 46, "Vervangen van radiatorventilator" },
                    { 47, "Vervangen van elektrische motorventilator" },
                    { 48, "Vervangen van airconditioning compressor" },
                    { 49, "Vervangen van airconditioning condensor" },
                    { 50, "Vervangen van airconditioning verdamper" }
                });

            migrationBuilder.InsertData(
                table: "Drivers",
                columns: new[] { "ID", "Active", "AddressCity", "AddressHouseNumber", "AddressPostalCode", "AddressStreet", "DateOfBirth", "FirstName", "LastName", "LicenseType", "NationalRegistrationNumber" },
                values: new object[,]
                {
                    { 1, true, "South Brentview", "145", "84930", "Bryan Causeway", new DateTime(1977, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mark", "Garner", "C", "77.03.07-135.32" },
                    { 2, false, "Jamesstad", "8307", "12644", "Nathan Ford", new DateTime(1986, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ann", "Fischer", "AM", "86.11.29-944.69" },
                    { 3, false, "Fisherchester", "062", "50566", "Samantha Glens", new DateTime(2004, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisa", "Wilcox", "B", "04.01.16-720.84" },
                    { 4, false, "New Ericside", "85319", "12209", "Garza Road", new DateTime(1989, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jonathan", "Hoover", "C", "89.09.24-795.29" },
                    { 5, false, "Port Russell", "40371", "16611", "Patricia Ridges", new DateTime(2004, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Mata", "A", "04.03.17-327.73" },
                    { 6, true, "Nicholestad", "87024", "68429", "Melissa Villages", new DateTime(2003, 7, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicole", "Brock", "B", "03.07.22-266.88" },
                    { 7, false, "Andrewland", "1569", "97802", "Jeffrey Place", new DateTime(1990, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tristan", "Pacheco", "C", "90.06.27-389.54" },
                    { 8, false, "South Julie", "397", "21851", "Bennett Fall", new DateTime(1976, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ryan", "Rodriguez", "A", "76.09.22-881.21" },
                    { 9, true, "Stewartburgh", "3937", "71873", "Kevin Avenue", new DateTime(2003, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Karen", "Prince", "AM", "03.02.28-290.43" },
                    { 10, false, "Jenkinsville", "70766", "67792", "Graham Neck", new DateTime(1983, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Caroline", "Barrett", "B", "83.05.19-896.21" },
                    { 11, false, "East Caleb", "09266", "38854", "Jennifer Square", new DateTime(1980, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erin", "Mata", "C", "80.05.22-991.64" },
                    { 12, false, "Thompsonfort", "9132", "66216", "Andrea Crossroad", new DateTime(1995, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Travis", "Woods", "AM", "95.04.04-681.58" },
                    { 13, true, "Lake David", "056", "72868", "Gomez Parkway", new DateTime(1984, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elizabeth", "Lopez", "D", "84.07.16-932.13" },
                    { 14, false, "Lake Jaimeborough", "365", "77755", "Davis Overpass", new DateTime(1990, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elizabeth", "Wiley", "B", "90.05.08-586.32" },
                    { 15, false, "New Michelle", "2887", "95966", "Jeffrey Vista", new DateTime(1990, 6, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teresa", "Hunt", "C", "90.06.06-752.30" },
                    { 16, false, "Sullivanburgh", "03518", "87073", "Kimberly Rue", new DateTime(2003, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lisa", "Hill", "C", "03.05.23-724.71" },
                    { 17, true, "Jefferyborough", "993", "75545", "Teresa Lights", new DateTime(1989, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grant", "Pena", "C", "89.06.04-643.81" },
                    { 18, true, "Harrisside", "828", "17279", "Lewis Alley", new DateTime(1987, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kevin", "Santana", "A", "87.05.16-447.62" },
                    { 19, true, "East Richard", "771", "60709", "Lopez Roads", new DateTime(2003, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leslie", "Carpenter", "G", "03.11.24-007.24" },
                    { 20, false, "West Emilyborough", "01447", "77686", "Willis Village", new DateTime(1975, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", "Reynolds", "G", "75.06.09-309.68" },
                    { 21, false, "Stephanieborough", "6689", "63734", "Todd Camp", new DateTime(1995, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anna", "Clark", "B", "95.04.27-110.36" },
                    { 22, false, "East Joshuafort", "510", "17552", "Anna Track", new DateTime(1978, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Latoya", "Soto", "D", "78.03.14-881.67" },
                    { 23, false, "West Elizabethport", "116", "55969", "Anderson Trafficway", new DateTime(1984, 3, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brandi", "Nguyen", "C", "84.03.06-586.49" },
                    { 24, true, "East Whitneytown", "2765", "29553", "Mckee Mount", new DateTime(1982, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Claudia", "Potts", "C", "82.11.15-830.34" },
                    { 25, true, "East Jennashire", "686", "44795", "Gonzalez Ridges", new DateTime(1984, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nancy", "Melendez", "G", "84.07.02-128.73" },
                    { 26, false, "Josephton", "884", "41536", "Campbell Road", new DateTime(1994, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darlene", "Davies", "C", "94.04.11-434.74" },
                    { 27, false, "North Mistyborough", "06009", "71882", "Laura Spur", new DateTime(2003, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pamela", "Le", "B", "03.02.05-588.47" },
                    { 28, false, "East Johnview", "81895", "88726", "Young Course", new DateTime(1989, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Allison", "Larson", "D", "89.01.23-910.82" },
                    { 29, true, "West Pamela", "316", "73971", "Cheyenne Junctions", new DateTime(1979, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", "Galloway", "A", "79.11.01-251.97" },
                    { 30, true, "South Monica", "719", "64659", "Holt Park", new DateTime(1978, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emily", "Johnson", "C", "78.03.09-454.62" },
                    { 31, false, "East Christineville", "558", "02460", "Freeman Parkways", new DateTime(1989, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Katie", "Grimes", "AM", "89.01.01-030.70" },
                    { 32, true, "East Stephaniefort", "404", "06335", "Nguyen Crest", new DateTime(1988, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adam", "Craig", "G", "88.09.05-361.42" },
                    { 33, true, "North Jennifer", "6482", "06598", "Myers Forks", new DateTime(1994, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robyn", "Mclean", "D", "94.07.26-084.92" },
                    { 34, false, "Silvaburgh", "2278", "97620", "Lynn View", new DateTime(1987, 5, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teresa", "Fields", "G", "87.05.03-298.19" },
                    { 35, true, "Seanbury", "140", "69566", "Lauren Wells", new DateTime(1976, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brenda", "Beasley", "A", "76.07.09-194.17" },
                    { 36, false, "Kennethfort", "934", "26895", "Colleen Port", new DateTime(1984, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anthony", "Ward", "AM", "84.06.08-883.04" },
                    { 37, false, "West Josefort", "40137", "32375", "Jacob Throughway", new DateTime(1980, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Robert", "Nash", "G", "80.05.25-749.22" },
                    { 38, true, "East Johnland", "2239", "08151", "Perez Cove", new DateTime(1996, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", "Santos", "A", "96.04.04-075.06" },
                    { 39, false, "East Linda", "04207", "33430", "Cody Village", new DateTime(1993, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hayden", "Leonard", "AM", "93.10.23-821.27" },
                    { 40, false, "East Brianberg", "4921", "74547", "Kelley Curve", new DateTime(1982, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", "Doyle", "C", "82.03.27-439.09" },
                    { 41, false, "Abigailport", "1429", "94654", "Blankenship Knolls", new DateTime(2005, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joshua", "Levine", "AM", "05.06.14-807.16" },
                    { 42, true, "Anthonyhaven", "34103", "79937", "Sherri Field", new DateTime(1974, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chad", "Rogers", "C", "74.11.28-449.51" },
                    { 43, false, "Lisatown", "696", "33273", "Williams Mount", new DateTime(2001, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", "Carlson", "D", "01.10.06-933.74" },
                    { 44, false, "Nunezland", "439", "63492", "Sandoval Spurs", new DateTime(1974, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joseph", "Acosta", "A", "74.02.21-705.39" },
                    { 45, false, "Burnsview", "408", "78980", "Paula Wells", new DateTime(1984, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Young", "D", "84.05.15-413.63" },
                    { 46, true, "Port Allison", "18171", "62065", "Jenna Gardens", new DateTime(2004, 10, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daniel", "Schneider", "AM", "04.10.14-561.75" },
                    { 47, true, "Lake Kennethland", "0961", "35045", "Mcdonald Ferry", new DateTime(1982, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Adrienne", "Jackson", "AM", "82.08.10-458.50" },
                    { 48, false, "Kellyland", "167", "55538", "Smith Junctions", new DateTime(1996, 9, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jennifer", "Patterson", "A", "96.09.21-764.06" },
                    { 49, true, "Vincentstad", "5193", "44382", "Hardy Vista", new DateTime(1993, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jodi", "Ramirez", "A", "93.03.23-050.70" },
                    { 50, true, "Kimchester", "344", "37479", "Webb Lock", new DateTime(1995, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Erin", "Thomas", "D", "95.08.05-575.65" },
                    { 51, true, "East Mikaylamouth", "316", "82883", "Jennifer Alley", new DateTime(2000, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kevin", "Lee", "C", "00.09.18-247.81" },
                    { 52, true, "Kennethfort", "3166", "68312", "Robert Courts", new DateTime(1983, 6, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Manuel", "Chen", "A", "83.06.16-509.20" },
                    { 53, true, "Patriciastad", "35466", "56427", "Rogers Stravenue", new DateTime(1995, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "William", "Hughes", "B", "95.05.15-681.26" },
                    { 54, true, "West Debbie", "68576", "43269", "Robinson Light", new DateTime(1975, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gabriela", "King", "A", "75.01.21-296.74" },
                    { 55, false, "Johnsonshire", "000", "17240", "Walker Camp", new DateTime(1996, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Charles", "Mathis", "B", "96.03.30-785.61" },
                    { 56, false, "Maryton", "5749", "69546", "King Loaf", new DateTime(1987, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kyle", "Oconnell", "A", "87.02.03-321.72" },
                    { 57, true, "New Brittanyfort", "9568", "42504", "Dana Canyon", new DateTime(2000, 7, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "David", "Rivas", "G", "00.07.02-901.87" },
                    { 58, true, "Masonchester", "235", "12155", "Rodriguez Estates", new DateTime(1991, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Angelica", "Taylor", "AM", "91.10.28-740.13" },
                    { 59, true, "South Caitlin", "6469", "69661", "Lisa Way", new DateTime(1996, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brent", "Gonzalez", "AM", "96.01.26-459.08" },
                    { 60, false, "Lake Ryanborough", "7892", "89449", "Jasmine Expressway", new DateTime(2003, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amanda", "Davis", "B", "03.07.10-434.86" },
                    { 61, true, "North Nicoleburgh", "187", "07449", "Martinez Curve", new DateTime(1983, 6, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kristen", "Figueroa", "B", "83.06.28-968.74" },
                    { 62, false, "New Deborahview", "834", "82498", "Kathryn Pines", new DateTime(1981, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Anthony", "Russell", "B", "81.09.17-411.67" },
                    { 63, true, "Ericport", "295", "29591", "Butler Spring", new DateTime(1974, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "April", "Davis", "C", "74.10.13-916.27" },
                    { 64, false, "North Jordan", "180", "72779", "Sydney Trafficway", new DateTime(2003, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ian", "Compton", "C", "03.05.25-031.25" },
                    { 65, false, "Millermouth", "497", "62707", "Sabrina Groves", new DateTime(1974, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", "Farmer", "B", "74.10.23-887.47" },
                    { 66, false, "Lake Charles", "80708", "66355", "Margaret Track", new DateTime(1990, 7, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alyssa", "Faulkner", "G", "90.07.11-306.42" },
                    { 67, false, "North Mitchellborough", "3244", "53831", "Sharon Curve", new DateTime(1986, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cynthia", "Vargas", "G", "86.11.03-430.05" },
                    { 68, true, "Gabrielleland", "053", "52970", "Tracy Camp", new DateTime(2000, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeremy", "Hale", "D", "00.07.16-011.72" },
                    { 69, false, "East Chadburgh", "3079", "35664", "Lawson Wall", new DateTime(1982, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jamie", "Allen", "G", "82.01.13-191.81" },
                    { 70, false, "North Troyland", "2430", "99720", "Andrew Park", new DateTime(2000, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jamie", "Aguirre", "D", "00.12.26-823.62" },
                    { 71, true, "Rushhaven", "1716", "73729", "Tyler Islands", new DateTime(1983, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Stanley", "Barron", "A", "83.01.04-759.95" },
                    { 72, true, "Lake Chelsea", "78601", "05799", "Larsen Stravenue", new DateTime(1983, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elizabeth", "Cruz", "A", "83.01.07-096.86" },
                    { 73, false, "North Megan", "9358", "88804", "Brandon Junctions", new DateTime(2004, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Christian", "Lewis", "B", "04.09.16-805.55" },
                    { 74, true, "West Christophershire", "13366", "18541", "Laura Mews", new DateTime(1990, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gregory", "Guerrero", "B", "90.02.12-941.21" },
                    { 75, true, "Andrewfurt", "9320", "58650", "Olson Haven", new DateTime(1974, 2, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brandon", "Osborne", "A", "74.02.04-147.40" },
                    { 76, true, "North Loretta", "599", "73374", "Gomez Estates", new DateTime(2004, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Joseph", "Jones", "C", "04.04.14-621.70" },
                    { 77, true, "Lake Kristinaville", "6296", "50007", "Hicks Ports", new DateTime(1986, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Evelyn", "Perez", "AM", "86.12.03-874.53" },
                    { 78, false, "South Jadebury", "904", "95672", "Kendra Wells", new DateTime(1990, 7, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Susan", "Cook", "G", "90.07.03-274.23" },
                    { 79, true, "Spencermouth", "585", "23171", "Dylan Drive", new DateTime(1991, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Katherine", "Perez", "D", "91.10.26-342.83" },
                    { 80, false, "Pettychester", "929", "56856", "Edwin Circle", new DateTime(1981, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lee", "Valdez", "C", "81.10.02-931.04" },
                    { 81, false, "Ballardmouth", "91043", "06380", "Megan Well", new DateTime(1981, 10, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darren", "Miller", "C", "81.10.03-693.18" },
                    { 82, false, "Cameronfurt", "015", "28874", "Ashley Underpass", new DateTime(1976, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carrie", "Solis", "A", "76.01.02-740.27" },
                    { 83, true, "New Jonathan", "5453", "87299", "Alyssa Knoll", new DateTime(1999, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nathan", "Kelly", "B", "99.02.13-013.41" },
                    { 84, false, "North Michaelmouth", "6827", "83417", "Tanya Squares", new DateTime(2005, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nicole", "Dyer", "G", "05.03.23-954.63" },
                    { 85, true, "Walkerhaven", "13796", "97840", "Joshua Isle", new DateTime(1985, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "John", "Silva", "G", "85.02.15-191.91" },
                    { 86, false, "Dianaport", "04853", "77789", "Lee Road", new DateTime(1984, 6, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Michael", "Thomas", "AM", "84.06.27-551.57" },
                    { 87, false, "Port Johnton", "61215", "36607", "Blake Streets", new DateTime(1977, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Travis", "Mcgrath", "A", "77.01.31-889.96" },
                    { 88, false, "South James", "0609", "47333", "Hernandez Rest", new DateTime(1982, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kimberly", "Carson", "B", "82.04.26-435.50" },
                    { 89, false, "Port Ashleyshire", "581", "77505", "Hill Trail", new DateTime(2002, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ashley", "Smith", "A", "02.12.10-953.66" },
                    { 90, true, "Cunninghamside", "8032", "39544", "Townsend Walk", new DateTime(1981, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeffrey", "Morgan", "AM", "81.07.29-185.16" },
                    { 91, true, "New Katherineton", "7332", "89265", "Larson Brook", new DateTime(1995, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tamara", "Woods", "B", "95.08.04-298.81" },
                    { 92, false, "West Tracyfort", "67649", "78728", "Ruiz Streets", new DateTime(1977, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexander", "Cortez", "D", "77.12.23-341.88" },
                    { 93, true, "Port Gabriel", "864", "18789", "Daniels Union", new DateTime(1999, 4, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Micheal", "Flynn", "G", "99.04.22-221.62" },
                    { 94, false, "Krauseville", "234", "96231", "Davis Unions", new DateTime(1980, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jason", "Hoffman", "AM", "80.07.08-933.71" },
                    { 95, false, "Port Kristintown", "4625", "21922", "Hudson Flats", new DateTime(1997, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Katie", "Garza", "A", "97.02.15-690.38" },
                    { 96, true, "Johnsonfurt", "5841", "05301", "Harper Cliffs", new DateTime(1979, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Alexandria", "Cummings", "D", "79.07.26-916.12" },
                    { 97, true, "Lake Jacob", "45664", "71565", "Jerry Port", new DateTime(1987, 9, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andrea", "Mcintyre", "C", "87.09.02-688.75" },
                    { 98, true, "Saraside", "875", "94137", "Lewis Cliffs", new DateTime(2004, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marc", "Hill", "B", "04.02.01-103.91" },
                    { 99, true, "Port Daniel", "854", "15507", "Castro Lake", new DateTime(1985, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "James", "Clark", "A", "85.01.27-017.92" }
                });

            migrationBuilder.InsertData(
                table: "ExtraServices",
                columns: new[] { "ID", "Description" },
                values: new object[,]
                {
                    { 1, "Fuel" },
                    { 2, "Shop" },
                    { 3, "Tires" },
                    { 4, "Carwash" }
                });

            migrationBuilder.InsertData(
                table: "FuelCards",
                columns: new[] { "ID", "Active", "AuthenticationType", "CardValidityEndDate", "CardValidityStartDate", "FuelCardNumber", "FuelType", "PINCode" },
                values: new object[,]
                {
                    { 1, true, null, null, new DateTime(2018, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "38473", "PetrolE5", null },
                    { 2, true, "PINOnly", new DateTime(2023, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "38474", "PetrolE10", "8854" },
                    { 3, true, "PINAndMileageInKilometers", new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "38475", "Diesel", "3432" },
                    { 4, false, "PINOnly", new DateTime(2021, 1, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "38475", "Super98", "5986" },
                    { 5, true, "PINOnly", new DateTime(2022, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "38476", "Diesel", "7621" },
                    { 6, true, null, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "38477", "PetrolE5", null },
                    { 7, true, "PINAndMileageInKilometers", new DateTime(2024, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "38478", "Super98", "1234" },
                    { 8, true, "PINOnly", new DateTime(2024, 3, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "38479", "PetrolE10", "4321" },
                    { 9, false, "PINOnly", new DateTime(2024, 5, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "38480", "Diesel", "9876" },
                    { 10, true, null, null, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "38481", "PetrolE5", null }
                });

            migrationBuilder.InsertData(
                table: "Garages",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "De Vlaamse Garagist" },
                    { 2, "Garage 't Zwin" },
                    { 3, "Garage Van Diksmuide" },
                    { 4, "Garage 't Westhoekje" }
                });

            migrationBuilder.InsertData(
                table: "InquiryTypes",
                columns: new[] { "ID", "AppointmentNeeded", "Category", "Name" },
                values: new object[,]
                {
                    { 1, false, "General", "General Inquiry" },
                    { 2, false, "General", "Feedback" },
                    { 3, false, "General", "Complaint" },
                    { 4, false, "General", "Information Request" },
                    { 5, true, "General", "Service Inquiry" },
                    { 6, false, "General", "Billing Inquiry" },
                    { 7, true, "General", "Technical Support" },
                    { 8, false, "General", "Product Inquiry" },
                    { 9, false, "General", "Suggestion" },
                    { 10, true, "General", "Request for Assistance" },
                    { 11, false, "General", "Lost and Found" },
                    { 12, false, "General", "Change of Contact Information" },
                    { 13, false, "General", "Privacy Concern" },
                    { 14, false, "General", "Report a Bug" },
                    { 15, true, "General", "Account Closure" },
                    { 16, false, "General", "Request for Brochure" },
                    { 17, false, "General", "Refund Request" },
                    { 18, true, "General", "Cancellation Request" },
                    { 19, false, "General", "Delivery Inquiry" },
                    { 20, false, "General", "Account Activation" },
                    { 21, false, "General", "Event Participation Inquiry" },
                    { 22, false, "General", "Discount Inquiry" },
                    { 23, false, "General", "Membership Inquiry" },
                    { 24, false, "General", "Request for User Manual" },
                    { 25, false, "General", "Website Feedback" },
                    { 26, true, "General", "Emergency Assistance" },
                    { 27, true, "General", "Request for Presentation" },
                    { 28, false, "General", "Lost Item Inquiry" },
                    { 29, false, "General", "Change of Delivery Address" },
                    { 30, true, "General", "Request for Test Drive" },
                    { 31, false, "User", "Account Registration" },
                    { 32, false, "User", "Password Reset" },
                    { 33, false, "User", "Login Assistance" },
                    { 34, false, "User", "Profile Update" },
                    { 35, false, "User", "Subscription Management" },
                    { 36, true, "User", "Account Closure" },
                    { 37, false, "User", "Feedback" },
                    { 38, false, "User", "Change of Contact Information" },
                    { 39, false, "User", "Request for User Manual" },
                    { 40, false, "User", "Privacy Concern" },
                    { 41, false, "User", "Account Activation" },
                    { 42, false, "User", "Change of Email Address" },
                    { 43, false, "User", "Feedback on User Experience" },
                    { 44, false, "User", "Subscription Renewal" },
                    { 45, false, "User", "Membership Inquiry" },
                    { 46, false, "User", "Profile Photo Update" },
                    { 47, false, "User", "Account Security" },
                    { 48, false, "User", "User Authentication Issue" },
                    { 49, true, "User", "Request for Training" },
                    { 50, true, "User", "Account Termination Request" },
                    { 51, false, "User", "Deactivation of Account" },
                    { 52, false, "User", "Account Recovery" },
                    { 53, false, "User", "Account Lockout" },
                    { 54, false, "User", "Social Media Linking" },
                    { 55, false, "User", "User Data Access" },
                    { 56, false, "User", "Feedback on Account Management" },
                    { 57, false, "User", "User Privacy" },
                    { 58, true, "User", "Account Merge Request" },
                    { 59, false, "User", "Preferred Communication Method" },
                    { 60, false, "User", "User Experience Enhancement" },
                    { 61, false, "FuelCard", "Fuel Card Activation" },
                    { 62, false, "FuelCard", "Fuel Card Application" },
                    { 63, false, "FuelCard", "Lost Fuel Card" },
                    { 64, false, "FuelCard", "Fuel Card PIN Reset" },
                    { 65, false, "FuelCard", "Fuel Card Renewal" },
                    { 66, true, "FuelCard", "Fuel Card Cancellation" },
                    { 67, false, "FuelCard", "Fuel Card Usage Inquiry" },
                    { 68, false, "FuelCard", "Fuel Card Billing Inquiry" },
                    { 69, false, "FuelCard", "Fuel Card Payment Issue" },
                    { 70, false, "FuelCard", "Fuel Card Statement Request" },
                    { 71, false, "FuelCard", "Fuel Card Transaction Dispute" },
                    { 72, false, "FuelCard", "Fuel Card Usage Limit Adjustment" },
                    { 73, false, "FuelCard", "Fuel Card PIN Change" },
                    { 74, false, "FuelCard", "Fuel Card Account Update" },
                    { 75, false, "FuelCard", "Fuel Card Network Coverage Inquiry" },
                    { 76, false, "FuelCard", "Fuel Card Benefits Inquiry" },
                    { 77, false, "FuelCard", "Fuel Card Security Concern" },
                    { 78, false, "FuelCard", "Fuel Card Replacement" },
                    { 79, false, "FuelCard", "Fuel Card PIN Unlock" },
                    { 80, false, "FuelCard", "Fuel Card Balance Inquiry" },
                    { 81, false, "FuelCard", "Fuel Card Expiry Date Update" },
                    { 82, false, "FuelCard", "Fuel Card Transaction History" },
                    { 83, true, "FuelCard", "Fuel Card Account Closure" },
                    { 84, false, "FuelCard", "Fuel Card PIN Reissue" },
                    { 85, false, "FuelCard", "Fuel Card Enrollment" },
                    { 86, false, "FuelCard", "Fuel Card Discount Offers" },
                    { 87, false, "FuelCard", "Fuel Card Fraud Alert" },
                    { 88, false, "FuelCard", "Fuel Card Mobile App Support" },
                    { 89, false, "FuelCard", "Fuel Card PIN Security" },
                    { 90, false, "FuelCard", "Fuel Card Usage Tips" },
                    { 91, false, "Vehicle", "Vehicle Purchase Inquiry" },
                    { 92, true, "Vehicle", "Vehicle Service Appointment" },
                    { 93, true, "Vehicle", "Vehicle Test Drive Request" },
                    { 94, false, "Vehicle", "Vehicle Lease Inquiry" },
                    { 95, false, "Vehicle", "Vehicle Model Availability" },
                    { 96, false, "Vehicle", "Vehicle Configuration Assistance" },
                    { 97, false, "Vehicle", "Vehicle Trade-In Valuation" },
                    { 98, false, "Vehicle", "Vehicle Financing Options" },
                    { 99, false, "Vehicle", "Vehicle Warranty Information" },
                    { 100, false, "Vehicle", "Vehicle Fuel Efficiency Inquiry" },
                    { 101, false, "Vehicle", "Vehicle Maintenance Schedule" },
                    { 102, false, "Vehicle", "Vehicle Recall Information" },
                    { 103, false, "Vehicle", "Vehicle Safety Features" },
                    { 104, false, "Vehicle", "Vehicle Exterior Options" },
                    { 105, false, "Vehicle", "Vehicle Interior Features" },
                    { 106, false, "Vehicle", "Vehicle Technology Inquiry" },
                    { 107, false, "Vehicle", "Vehicle Color Options" },
                    { 108, false, "Vehicle", "Vehicle Availability Inquiry" },
                    { 109, false, "Vehicle", "Vehicle Rental Inquiry" },
                    { 110, false, "Vehicle", "Vehicle Trade-In Process" },
                    { 111, false, "Vehicle", "Vehicle Customization Inquiry" },
                    { 112, false, "Vehicle", "Vehicle Performance Specifications" },
                    { 113, false, "Vehicle", "Vehicle Price Negotiation" },
                    { 114, false, "Vehicle", "Vehicle Delivery Process" },
                    { 115, false, "Vehicle", "Vehicle Insurance Options" },
                    { 116, false, "Vehicle", "Vehicle Resale Value Inquiry" },
                    { 117, false, "Vehicle", "Vehicle Ownership Costs" },
                    { 118, false, "Vehicle", "Vehicle Financing Approval" },
                    { 119, false, "Vehicle", "Vehicle Trade-In Assessment" },
                    { 120, false, "Vehicle", "Vehicle Mileage Estimate" }
                });

            migrationBuilder.InsertData(
                table: "InsuranceCompanies",
                columns: new[] { "ID", "Name", "ReferenceNumber" },
                values: new object[,]
                {
                    { 1, "Verzekeringen Van Damme", "VD12345" },
                    { 2, "De Zekerheidsgroep", "ZKG56789" },
                    { 3, "Verzekeringsmaatschappij De Bruyn", "DB24680" },
                    { 4, "Assurantiegroep Devos", "AVS13579" },
                    { 5, "Verzekeraars Verstraeten", "VVS98765" },
                    { 6, "Verzekeringen Claesens", "CLS23456" },
                    { 7, "De Verzekeraarsgroep", "VZGRP78901" },
                    { 8, "Verzekeringen Jacobs & Partners", "JP35792" },
                    { 9, "Assurantiebedrijf Van Dyck", "VDB68024" },
                    { 10, "Verzekeraars De Vries", "DV40386" }
                });

            migrationBuilder.InsertData(
                table: "VehicleParts",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Remblok" },
                    { 2, "Bougie" },
                    { 3, "Batterij" },
                    { 4, "Oliefilter" },
                    { 5, "Luchtfilter" },
                    { 6, "Dynamo" },
                    { 7, "Radiateur" },
                    { 8, "Startmotor" },
                    { 9, "Brandstofpomp" },
                    { 10, "Ontstekingsspoel" },
                    { 11, "Band" },
                    { 12, "Ophangingsbus" },
                    { 13, "Remschijf" },
                    { 14, "Waterpomp" },
                    { 15, "Distributieriem" },
                    { 16, "Thermostaat" },
                    { 17, "Draagarm" },
                    { 18, "Stuurhuis" },
                    { 19, "Wielnaaf" },
                    { 20, "Homokineet" },
                    { 21, "Krukas" },
                    { 22, "Nokkenas" },
                    { 23, "Kleppendeksel" },
                    { 24, "Uitlaatspruitstuk" },
                    { 25, "Katalysator" },
                    { 26, "Lambda-sensor" },
                    { 27, "Stuurbekrachtigingspomp" },
                    { 28, "Brandstofinjector" },
                    { 29, "Airconditioningcompressor" },
                    { 30, "Blowermotor" },
                    { 31, "Deurvergrendelingsmotor" },
                    { 32, "Raammechanisme" },
                    { 33, "Brandstoftank" },
                    { 34, "EGR-klep" },
                    { 35, "Luchtmassameter" },
                    { 36, "Ontstekingsschakelaar" },
                    { 37, "Versnellingsbaksteun" },
                    { 38, "Motorsteun" },
                    { 39, "Multiriem" },
                    { 40, "Spanrol" },
                    { 41, "Wiellager" },
                    { 42, "Remklauw" },
                    { 43, "Hoofdremcilinder" },
                    { 44, "Brandstoffilter" },
                    { 45, "Koplampunit" },
                    { 46, "Achterlicht" },
                    { 47, "Buitenspiegel" },
                    { 48, "Voorspatbord" },
                    { 49, "Grille" },
                    { 50, "Radiateurventilator" },
                    { 51, "Gasklephuis" },
                    { 52, "Inlaatspruitstuk" },
                    { 53, "Elektrisch raambediening" },
                    { 54, "Cruise control module" },
                    { 55, "Weerstand blowermotor" },
                    { 56, "ABS-regelmodule" },
                    { 57, "Stuurwiel" },
                    { 58, "Veiligheidsgordel" },
                    { 59, "Schuifdakmotor" },
                    { 60, "Airconditioningcondensor" },
                    { 61, "Uitlaatpijp" },
                    { 62, "Ontsturingsmodule" },
                    { 63, "Gaskleppositiesensor" },
                    { 64, "Brandstofdrukregelaar" },
                    { 65, "Cabineluchtfilter" },
                    { 66, "Transmissiefilter" },
                    { 67, "Wielmoer" },
                    { 68, "Schokdemper" },
                    { 69, "Veerpoot" },
                    { 70, "Stuurkolom" },
                    { 71, "Aandrijfas" },
                    { 72, "Contactslot" },
                    { 73, "Krukaspositiesensor" },
                    { 74, "Nokkenaspositiesensor" },
                    { 75, "Stuurbekrachtigingsslang" },
                    { 76, "Brandstofvulhals" },
                    { 77, "Raammotor" },
                    { 78, "Uitlaatpakking" },
                    { 79, "Stuurknokkel" },
                    { 80, "Aslager" },
                    { 81, "Verdeelkap" },
                    { 82, "Ontstekingsrotor" },
                    { 83, "Koplamplamp" },
                    { 84, "Knipperlichtschakelaar" },
                    { 85, "Ruitenwisserblad" },
                    { 86, "Brandstoftankdop" },
                    { 87, "Startersolenoïde" },
                    { 88, "Elektrische deurvergrendelingsactuator" },
                    { 89, "EGR-buis" },
                    { 90, "Brandstofdruksensor" },
                    { 91, "Cilinderkop" },
                    { 92, "Zuigerveer" },
                    { 93, "Hoofdlagerset" },
                    { 94, "Drijfstang" },
                    { 95, "Motorpakkingset" },
                    { 96, "Motorsteun" },
                    { 97, "Distributieketting" },
                    { 98, "Brandstofniveausensor" },
                    { 99, "Stabilisatorstangkoppeling" },
                    { 100, "Transmissiebesturingsmodule" }
                });

            migrationBuilder.InsertData(
                table: "VehicleTypes",
                columns: new[] { "ID", "Name" },
                values: new object[,]
                {
                    { 1, "Multiseater/Family Car" },
                    { 2, "SUV" },
                    { 3, "Compact Car" },
                    { 4, "Sports Car" },
                    { 5, "Minivan" },
                    { 6, "Truck" },
                    { 7, "Motorcycle" },
                    { 8, "Electric Vehicle" },
                    { 9, "Luxury Car" },
                    { 10, "Convertible" }
                });

            migrationBuilder.InsertData(
                table: "DriverFuelCards",
                columns: new[] { "ID", "DriverID", "FuelCardID", "OwnershipEndDate", "OwnershipStartDate" },
                values: new object[,]
                {
                    { 1, 6, 7, null, new DateTime(2017, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 3, 8, new DateTime(2023, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 4, 3, new DateTime(2021, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2017, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 12, 1, null, new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 17, 2, new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 20, 4, new DateTime(2022, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, 8, 6, null, new DateTime(2023, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 9, 5, new DateTime(2023, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, 15, 9, new DateTime(2021, 4, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2018, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, 26, 10, null, new DateTime(2017, 8, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, 7, 3, null, new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, 13, 7, new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, 18, 8, new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, 21, 4, null, new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, 25, 1, new DateTime(2023, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "FuelCardsExtraServices",
                columns: new[] { "ID", "ExtraServiceID", "FuelCardID" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 2, 2, 1 },
                    { 3, 3, 1 },
                    { 4, 1, 2 },
                    { 5, 2, 2 },
                    { 6, 3, 2 },
                    { 7, 4, 2 },
                    { 8, 1, 3 },
                    { 9, 2, 3 },
                    { 10, 3, 3 },
                    { 11, 3, 4 },
                    { 12, 1, 5 },
                    { 13, 2, 5 },
                    { 14, 4, 5 },
                    { 15, 1, 6 },
                    { 16, 3, 6 },
                    { 17, 1, 7 },
                    { 18, 2, 7 },
                    { 19, 3, 7 },
                    { 20, 4, 7 },
                    { 21, 2, 8 },
                    { 22, 1, 9 },
                    { 23, 3, 9 },
                    { 24, 2, 10 },
                    { 25, 4, 10 }
                });

            migrationBuilder.InsertData(
                table: "Inquiries",
                columns: new[] { "ID", "Comment", "DateOfInquiry", "DriverID", "InquiryTypeID", "Status", "VehicleID" },
                values: new object[,]
                {
                    { 1, "I really want to close my account. Reason: I am leaving the company!", new DateTime(2022, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 15, "InProgress", null },
                    { 2, "I want to update my FuelCard please", new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 65, "InProgress", null },
                    { 3, "I want to rent a vehicle, the Mercedez Benz pleaz", new DateTime(2023, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 109, "InProgress", null }
                });

            migrationBuilder.InsertData(
                table: "Login",
                columns: new[] { "ID", "DriverID", "Email", "Role" },
                values: new object[,]
                {
                    { 1, 1, "markgarner@fleetman.com", 0 },
                    { 2, 2, "fishergirl337@fleetman.com", 1 },
                    { 3, 3, "xx_justlisa_xx@fleetman.com", 1 }
                });

            migrationBuilder.InsertData(
                table: "Vehicles",
                columns: new[] { "ID", "Active", "ChassisNumber", "FuelType", "LeasingEndDate", "LeasingStartDate", "Name", "RegistrationDate", "VehicleTypeID" },
                values: new object[,]
                {
                    { 1, true, "ABC123", "PetrolE5", new DateTime(2025, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Honda Civic", new DateTime(2022, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, true, "DEF456", "Diesel", new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Toyota Camry", new DateTime(2021, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, true, "GHI789", "PetrolE10", new DateTime(2026, 3, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ford Mustang", new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, true, "JKL012", "Super98", new DateTime(2025, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Chevrolet Covette", new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 5, true, "MNO345", "PetrolE5", new DateTime(2026, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "BMW 3 Series", new DateTime(2023, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 6, true, "PQR678", "Diesel", new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mercedes-Benz E-Class", new DateTime(2021, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 7, true, "STU901", "PetrolE10", new DateTime(2025, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Audi A4", new DateTime(2022, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 8, true, "VWX234", "PetrolE5", new DateTime(2026, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nissan Altima", new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 9, true, "YZA567", "Super98", new DateTime(2025, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volkswagen Golf", new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 10, true, "BCD890", "Diesel", new DateTime(2026, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Subaru Outback", new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 11, true, "EFG123", "PetrolE10", new DateTime(2025, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jeep Wrangler", new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 12, true, "HIJ456", "PetrolE5", new DateTime(2026, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hyundai Sonata", new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 13, true, "KLM789", "Diesel", new DateTime(2025, 9, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kia Soul", new DateTime(2022, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 14, true, "NOP012", "PetrolE10", new DateTime(2026, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mazda CX-5", new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 15, true, "QRS345", "Super98", new DateTime(2025, 12, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lexus RX", new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 16, true, "TUV678", "PetrolE5", new DateTime(2026, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Volvo XC60", new DateTime(2023, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 17, true, "WXY901", "Diesel", new DateTime(2025, 3, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tesla Model S", new DateTime(2022, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 18, true, "ZAB234", "PetrolE10", new DateTime(2026, 10, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Porsche 911", new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 19, true, "CDE567", "PetrolE5", new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jaguar F-Pace", new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 20, true, "FGH890", "Super98", new DateTime(2026, 1, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Land Rover Range Rover", new DateTime(2023, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 }
                });

            migrationBuilder.InsertData(
                table: "DriverVehicles",
                columns: new[] { "ID", "DriverID", "VehicleID" },
                values: new object[,]
                {
                    { 1, 17, 7 },
                    { 2, 51, 17 },
                    { 3, 14, 11 },
                    { 4, 69, 1 },
                    { 5, 7, 6 },
                    { 6, 5, 11 },
                    { 7, 5, 8 },
                    { 8, 15, 10 },
                    { 9, 10, 18 },
                    { 10, 24, 12 },
                    { 11, 67, 4 },
                    { 12, 9, 2 },
                    { 13, 51, 20 },
                    { 14, 44, 16 },
                    { 15, 11, 6 },
                    { 16, 5, 19 },
                    { 17, 52, 7 },
                    { 18, 97, 5 },
                    { 19, 49, 15 },
                    { 20, 1, 12 },
                    { 21, 22, 17 },
                    { 22, 88, 3 },
                    { 23, 19, 12 },
                    { 24, 30, 2 },
                    { 25, 50, 10 },
                    { 26, 81, 8 },
                    { 27, 68, 13 },
                    { 28, 28, 14 },
                    { 29, 54, 16 },
                    { 30, 94, 4 },
                    { 31, 26, 20 },
                    { 32, 41, 5 },
                    { 33, 33, 14 },
                    { 34, 92, 2 },
                    { 35, 28, 9 },
                    { 36, 66, 8 },
                    { 37, 43, 13 },
                    { 38, 7, 5 },
                    { 39, 66, 11 },
                    { 40, 18, 12 },
                    { 41, 55, 3 },
                    { 42, 27, 20 },
                    { 43, 91, 14 },
                    { 44, 56, 15 },
                    { 45, 57, 12 },
                    { 46, 41, 15 },
                    { 47, 39, 11 },
                    { 48, 41, 1 },
                    { 49, 91, 8 },
                    { 50, 9, 17 },
                    { 51, 87, 8 },
                    { 52, 49, 5 },
                    { 53, 46, 4 },
                    { 54, 13, 19 },
                    { 55, 41, 2 },
                    { 56, 91, 4 },
                    { 57, 8, 15 },
                    { 58, 61, 3 },
                    { 59, 53, 8 },
                    { 60, 31, 15 },
                    { 61, 73, 14 },
                    { 62, 5, 4 },
                    { 63, 27, 12 },
                    { 64, 91, 2 },
                    { 65, 70, 11 },
                    { 66, 27, 6 },
                    { 67, 73, 1 },
                    { 68, 29, 11 },
                    { 69, 21, 10 },
                    { 70, 90, 15 },
                    { 71, 75, 12 },
                    { 72, 29, 10 },
                    { 73, 3, 11 },
                    { 74, 47, 9 },
                    { 75, 64, 15 },
                    { 76, 68, 1 },
                    { 77, 8, 13 },
                    { 78, 64, 14 },
                    { 79, 95, 17 },
                    { 80, 84, 20 },
                    { 81, 87, 2 },
                    { 82, 18, 3 },
                    { 83, 51, 19 },
                    { 84, 24, 14 },
                    { 85, 64, 10 },
                    { 86, 15, 20 },
                    { 87, 72, 12 },
                    { 88, 19, 17 },
                    { 89, 93, 14 },
                    { 90, 84, 19 },
                    { 91, 63, 19 },
                    { 92, 80, 2 },
                    { 93, 55, 2 },
                    { 94, 49, 14 },
                    { 95, 42, 19 },
                    { 96, 32, 2 },
                    { 97, 51, 5 },
                    { 98, 83, 7 },
                    { 99, 13, 6 },
                    { 100, 92, 10 },
                    { 101, 7, 10 }
                });

            migrationBuilder.InsertData(
                table: "Inquiries",
                columns: new[] { "ID", "Comment", "DateOfInquiry", "DriverID", "InquiryTypeID", "Status", "VehicleID" },
                values: new object[] { 4, "The mileage of my vehicle is WAY off!", new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 120, "InProgress", 10 });

            migrationBuilder.InsertData(
                table: "InspectionReports",
                columns: new[] { "ID", "Date", "DriverID", "InspectionReportFilePath", "VehicleID" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "files/inspectionreports/insp43123.pdf", 7 },
                    { 2, new DateTime(2019, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "files/inspectionreports/insp43124.docx", 8 },
                    { 3, new DateTime(2019, 6, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "files/inspectionreports/insp43125.pdf", 9 },
                    { 4, new DateTime(2019, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "files/inspectionreports/insp43126.pdf", 10 },
                    { 5, new DateTime(2019, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "files/inspectionreports/insp43127.pdf", 11 },
                    { 6, new DateTime(2019, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "files/inspectionreports/insp43128.pdf", 12 },
                    { 7, new DateTime(2019, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "files/inspectionreports/insp43129.pdf", 13 },
                    { 8, new DateTime(2019, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "files/inspectionreports/insp43130.doc", 14 },
                    { 9, new DateTime(2019, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "files/inspectionreports/insp43131.pdf", 15 },
                    { 10, new DateTime(2019, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "files/inspectionreports/insp43132.doc", 16 },
                    { 11, new DateTime(2019, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "files/inspectionreports/insp43133.pdf", 17 },
                    { 12, new DateTime(2019, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "files/inspectionreports/insp43134.pdf", 18 },
                    { 13, new DateTime(2019, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "files/inspectionreports/insp43135.pdf", 19 },
                    { 14, new DateTime(2019, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "files/inspectionreports/insp43136.oft", 20 },
                    { 15, new DateTime(2019, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "files/inspectionreports/insp43137.doc", 1 },
                    { 16, new DateTime(2019, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "files/inspectionreports/insp43138.docx", 2 },
                    { 17, new DateTime(2019, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "files/inspectionreports/insp43139.txt", 3 },
                    { 18, new DateTime(2019, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "files/inspectionreports/insp43140.pdf", 4 },
                    { 19, new DateTime(2019, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "files/inspectionreports/insp43141.pdf", 5 },
                    { 20, new DateTime(2019, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "files/inspectionreports/insp43142.rft", 6 },
                    { 21, new DateTime(2019, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "files/inspectionreports/insp43143.txt", 7 },
                    { 22, new DateTime(2019, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "files/inspectionreports/insp43144.doc", 8 },
                    { 23, new DateTime(2019, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "files/inspectionreports/insp43145.doc", 9 },
                    { 24, new DateTime(2019, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "files/inspectionreports/insp43146.txt", 10 },
                    { 25, new DateTime(2019, 9, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "files/inspectionreports/insp43147.pdf", 11 },
                    { 26, new DateTime(2019, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "files/inspectionreports/insp43148.pdf", 12 },
                    { 27, new DateTime(2019, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "files/inspectionreports/insp43149.pdf", 13 },
                    { 28, new DateTime(2019, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "files/inspectionreports/insp43150.pdf", 14 },
                    { 29, new DateTime(2019, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "files/inspectionreports/insp43151.pdf", 15 },
                    { 30, new DateTime(2019, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "files/inspectionreports/insp43152.pdf", 16 },
                    { 31, new DateTime(2019, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "files/inspectionreports/insp43153.doc", 17 },
                    { 32, new DateTime(2019, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "files/inspectionreports/insp43154.docx", 18 },
                    { 33, new DateTime(2019, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "files/inspectionreports/insp43155.pdf", 19 },
                    { 34, new DateTime(2019, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "files/inspectionreports/insp43156.pdf", 20 },
                    { 35, new DateTime(2019, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/inspectionreports/insp43157.pdf", 1 },
                    { 36, new DateTime(2019, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/inspectionreports/insp43158.pdf", 2 },
                    { 37, new DateTime(2019, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/inspectionreports/insp43159.doc", 3 },
                    { 38, new DateTime(2019, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/inspectionreports/insp43160.pdf", 4 },
                    { 39, new DateTime(2019, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "files/inspectionreports/insp43161.pdf", 5 },
                    { 40, new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "files/inspectionreports/insp43162.pdf", 6 },
                    { 41, new DateTime(2019, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "files/inspectionreports/insp43163.pdf", 7 },
                    { 42, new DateTime(2019, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "files/inspectionreports/insp43164.doc", 8 },
                    { 43, new DateTime(2019, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "files/inspectionreports/insp43165.pdf", 9 },
                    { 44, new DateTime(2020, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "files/inspectionreports/insp43166.doc", 10 },
                    { 45, new DateTime(2020, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "files/inspectionreports/insp43167.pdf", 11 },
                    { 46, new DateTime(2020, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "files/inspectionreports/insp43168.doc", 12 },
                    { 47, new DateTime(2020, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "files/inspectionreports/insp43169.docx", 13 },
                    { 48, new DateTime(2020, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "files/inspectionreports/insp43170.doc", 14 },
                    { 49, new DateTime(2020, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "files/inspectionreports/insp43171.doc", 15 },
                    { 50, new DateTime(2020, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "files/inspectionreports/insp43172.txt", 16 },
                    { 51, new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 17, "files/inspectionreports/insp43173.pdf", 17 },
                    { 52, new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "files/inspectionreports/insp43174.docx", 18 },
                    { 53, new DateTime(2020, 2, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 19, "files/inspectionreports/insp43175.pdf", 19 },
                    { 54, new DateTime(2020, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "files/inspectionreports/insp43176.pdf", 20 },
                    { 55, new DateTime(2020, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "files/inspectionreports/insp43177.doc", 11 },
                    { 56, new DateTime(2020, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "files/inspectionreports/insp43178.pdf", 12 },
                    { 57, new DateTime(2020, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "files/inspectionreports/insp43179.pdf", 13 },
                    { 58, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "files/inspectionreports/insp43180.docx", 14 },
                    { 59, new DateTime(2020, 3, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "files/inspectionreports/insp43181.txt", 15 },
                    { 60, new DateTime(2020, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "files/inspectionreports/insp43182.doc", 16 },
                    { 61, new DateTime(2020, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "files/inspectionreports/insp43183.pdf", 17 },
                    { 62, new DateTime(2020, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "files/inspectionreports/insp43184.txt", 18 },
                    { 63, new DateTime(2020, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "files/inspectionreports/insp43185.doc", 19 },
                    { 64, new DateTime(2020, 4, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "files/inspectionreports/insp43186.pdf", 10 },
                    { 65, new DateTime(2020, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "files/inspectionreports/insp43187.txt", 11 },
                    { 66, new DateTime(2020, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "files/inspectionreports/insp43188.doc", 12 },
                    { 67, new DateTime(2020, 4, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "files/inspectionreports/insp43189.pdf", 13 },
                    { 68, new DateTime(2020, 5, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "files/inspectionreports/insp43190.txt", 14 },
                    { 69, new DateTime(2020, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "files/inspectionreports/insp43191.doc", 15 },
                    { 70, new DateTime(2020, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "files/inspectionreports/insp43192.pdf", 16 },
                    { 71, new DateTime(2020, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "files/inspectionreports/insp43193.txt", 17 },
                    { 72, new DateTime(2020, 5, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "files/inspectionreports/insp43194.doc", 18 },
                    { 73, new DateTime(2020, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "files/inspectionreports/insp43195.pdf", 19 },
                    { 74, new DateTime(2020, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "files/inspectionreports/insp43196.txt", 10 },
                    { 75, new DateTime(2020, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "files/inspectionreports/insp43197.doc", 11 },
                    { 76, new DateTime(2020, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "files/inspectionreports/insp43198.pdf", 12 },
                    { 77, new DateTime(2020, 6, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 23, "files/inspectionreports/insp43199.txt", 13 },
                    { 78, new DateTime(2020, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "files/inspectionreports/insp43200.doc", 14 },
                    { 79, new DateTime(2020, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 25, "files/inspectionreports/insp43201.pdf", 15 },
                    { 80, new DateTime(2020, 7, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 26, "files/inspectionreports/insp43202.txt", 16 },
                    { 81, new DateTime(2020, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "files/inspectionreports/insp43203.doc", 17 },
                    { 82, new DateTime(2020, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "files/inspectionreports/insp43204.pdf", 18 },
                    { 83, new DateTime(2020, 7, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "files/inspectionreports/insp43205.txt", 19 },
                    { 84, new DateTime(2020, 7, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "files/inspectionreports/insp43206.doc", 10 },
                    { 85, new DateTime(2020, 7, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "files/inspectionreports/insp43207.pdf", 11 },
                    { 86, new DateTime(2020, 8, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "files/inspectionreports/insp43208.txt", 12 },
                    { 87, new DateTime(2020, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "files/inspectionreports/insp43209.doc", 13 },
                    { 88, new DateTime(2020, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/inspectionreports/insp43210.pdf", 14 },
                    { 89, new DateTime(2020, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "files/inspectionreports/insp43211.txt", 15 },
                    { 90, new DateTime(2020, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "files/inspectionreports/insp43212.doc", 6 },
                    { 91, new DateTime(2023, 6, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "files/inspectionreports/insp43211.txt", 18 },
                    { 92, new DateTime(2023, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "files/inspectionreports/insp43212.doc", 19 },
                    { 93, new DateTime(2023, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "files/inspectionreports/insp43213.pdf", 10 },
                    { 94, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "files/inspectionreports/insp43215.doc", 10 },
                    { 95, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 29, "files/inspectionreports/insp43216.pdf", 11 },
                    { 96, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/inspectionreports/insp43218.pdf", 17 },
                    { 97, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/inspectionreports/insp43219.docx", 18 },
                    { 98, new DateTime(2023, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/inspectionreports/insp43221.doc", 18 },
                    { 99, new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/inspectionreports/insp43222.doc", 19 },
                    { 100, new DateTime(2023, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/inspectionreports/insp43223.pdf", 19 }
                });

            migrationBuilder.InsertData(
                table: "LicensePlates",
                columns: new[] { "ID", "LicensePlateNumber", "ValidityEndDate", "ValidityStartDate", "VehicleID" },
                values: new object[,]
                {
                    { 1, "ABC123", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 2, "DEF456", new DateTime(2023, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 3, "GHI789", new DateTime(2023, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 4, "JKL012", new DateTime(2023, 7, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 5, "MNO345", new DateTime(2023, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 6, "PQR678", new DateTime(2023, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 7, "STU901", new DateTime(2024, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 8, "VWX234", new DateTime(2025, 1, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6 },
                    { 9, "YZA567", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 10, "BCD890", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 11, "EFG123", new DateTime(2023, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 12, "HIJ456", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 13, "KLM789", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 14, "NOP012", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 15, "QRS345", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 16, "TUV678", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 17, "WXY901", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 18, "CDE567", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 19, "FGH890", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 20, "IJK123", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 21, "LMN456", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 22, "OPQ789", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 23, "RST234", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 24, "UVW567", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 25, "XYZ890", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 26, "ABC123", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 27, "DEF456", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 28, "GHI789", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 29, "JKL234", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 30, "MNO567", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 31, "PQR890", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 32, "STU123", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 33, "VWX456", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 34, "YZA789", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 35, "BCD234", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 36, "EFG567", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 37, "HIJ890", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 38, "KLM123", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 39, "NOP456", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 40, "QRS789", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 41, "TUV234", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 42, "WXY567", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 43, "ZAB890", new DateTime(2024, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 44, "CDE123", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 45, "FGH456", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 46, "IJK789", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 47, "LMN123", new DateTime(2022, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 48, "OPQ456", new DateTime(2023, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 49, "RST789", new DateTime(2024, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 50, "UVW012", new DateTime(2025, 12, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 51, "ZAB234", new DateTime(2022, 6, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 }
                });

            migrationBuilder.InsertData(
                table: "Maintenances",
                columns: new[] { "ID", "Cost", "Date", "GarageID", "InvoiceFilePath", "VehicleID" },
                values: new object[,]
                {
                    { 1, 700m, new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice341232.pdf", 7 },
                    { 2, 400m, new DateTime(2022, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice123456.pdf", 4 },
                    { 3, 550m, new DateTime(2022, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice789012.pdf", 1 },
                    { 4, 800m, new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice345678.pdf", 12 },
                    { 5, 250m, new DateTime(2022, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice901234.pdf", 9 },
                    { 6, 600m, new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice567890.pdf", 3 },
                    { 7, 350m, new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice123456.pdf", 17 },
                    { 8, 900m, new DateTime(2022, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice789012.pdf", 6 },
                    { 9, 500m, new DateTime(2022, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice345678.pdf", 14 },
                    { 10, 350m, new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice901234.pdf", 10 },
                    { 11, 650m, new DateTime(2022, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice567890.pdf", 5 },
                    { 12, 550m, new DateTime(2022, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice123456.pdf", 18 },
                    { 13, 700m, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice789012.pdf", 11 },
                    { 14, 450m, new DateTime(2022, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice345678.pdf", 2 },
                    { 15, 300m, new DateTime(2022, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice901234.pdf", 13 },
                    { 16, 550m, new DateTime(2022, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice567890.pdf", 8 },
                    { 17, 850m, new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice123456.pdf", 15 },
                    { 18, 400m, new DateTime(2022, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice789012.pdf", 16 },
                    { 19, 600m, new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice345678.pdf", 19 },
                    { 20, 250m, new DateTime(2022, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice901234.pdf", 7 },
                    { 21, 500m, new DateTime(2022, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice567890.pdf", 4 },
                    { 22, 350m, new DateTime(2023, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice123456.pdf", 12 },
                    { 23, 900m, new DateTime(2023, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice789012.pdf", 9 },
                    { 24, 400m, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice345678.pdf", 3 },
                    { 25, 550m, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice901234.pdf", 17 },
                    { 26, 650m, new DateTime(2023, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice567890.pdf", 5 },
                    { 27, 700m, new DateTime(2023, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice123456.pdf", 18 },
                    { 28, 450m, new DateTime(2023, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice789012.pdf", 11 },
                    { 29, 300m, new DateTime(2023, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice345678.pdf", 2 },
                    { 30, 550m, new DateTime(2023, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice901234.pdf", 13 },
                    { 31, 850m, new DateTime(2023, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice567890.pdf", 8 },
                    { 32, 400m, new DateTime(2023, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice123456.pdf", 15 },
                    { 33, 600m, new DateTime(2023, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice789012.pdf", 16 },
                    { 34, 250m, new DateTime(2023, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice345678.pdf", 19 },
                    { 35, 500m, new DateTime(2023, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice901234.pdf", 7 },
                    { 36, 350m, new DateTime(2023, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice567890.pdf", 4 },
                    { 37, 700m, new DateTime(2023, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice123456.pdf", 12 },
                    { 38, 400m, new DateTime(2023, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice789012.pdf", 9 },
                    { 39, 550m, new DateTime(2023, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice345678.pdf", 3 },
                    { 40, 800m, new DateTime(2023, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice901234.pdf", 17 },
                    { 41, 250m, new DateTime(2023, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice567890.pdf", 5 },
                    { 42, 600m, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice123456.pdf", 18 },
                    { 43, 450m, new DateTime(2023, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice789012.pdf", 11 },
                    { 44, 300m, new DateTime(2023, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice345678.pdf", 2 },
                    { 45, 550m, new DateTime(2023, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice901234.pdf", 13 },
                    { 46, 850m, new DateTime(2023, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice567890.pdf", 8 },
                    { 47, 400m, new DateTime(2023, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice123456.pdf", 15 },
                    { 48, 600m, new DateTime(2023, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice789012.pdf", 16 },
                    { 49, 250m, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice345678.pdf", 19 },
                    { 50, 500m, new DateTime(2023, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice901234.pdf", 7 },
                    { 51, 350m, new DateTime(2023, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice567890.pdf", 4 },
                    { 52, 700m, new DateTime(2023, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice123456.pdf", 12 },
                    { 53, 400m, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice789012.pdf", 9 },
                    { 54, 550m, new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice345678.pdf", 3 },
                    { 55, 800m, new DateTime(2023, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice901234.pdf", 17 },
                    { 56, 250m, new DateTime(2023, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice567890.pdf", 5 },
                    { 57, 600m, new DateTime(2023, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice123456.pdf", 18 },
                    { 58, 450m, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice789012.pdf", 11 },
                    { 59, 300m, new DateTime(2024, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice345678.pdf", 2 },
                    { 60, 550m, new DateTime(2024, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice901234.pdf", 13 },
                    { 61, 850m, new DateTime(2024, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice567890.pdf", 8 },
                    { 62, 400m, new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice123456.pdf", 15 },
                    { 63, 600m, new DateTime(2024, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice789012.pdf", 16 },
                    { 64, 250m, new DateTime(2024, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice345678.pdf", 19 },
                    { 65, 500m, new DateTime(2024, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice901234.pdf", 7 },
                    { 66, 350m, new DateTime(2024, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice567890.pdf", 4 },
                    { 67, 700m, new DateTime(2024, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice123456.pdf", 12 },
                    { 68, 400m, new DateTime(2024, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice789012.pdf", 9 },
                    { 69, 550m, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice345678.pdf", 3 },
                    { 70, 800m, new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice901234.pdf", 17 },
                    { 71, 250m, new DateTime(2024, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice567890.pdf", 5 },
                    { 72, 600m, new DateTime(2024, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice123456.pdf", 18 },
                    { 73, 450m, new DateTime(2024, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice789012.pdf", 11 },
                    { 74, 300m, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice345678.pdf", 2 },
                    { 75, 550m, new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice901234.pdf", 13 },
                    { 76, 850m, new DateTime(2024, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice567890.pdf", 8 },
                    { 77, 400m, new DateTime(2024, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice123456.pdf", 15 },
                    { 78, 600m, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice789012.pdf", 16 },
                    { 79, 250m, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice345678.pdf", 19 },
                    { 80, 500m, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice901234.pdf", 7 },
                    { 81, 350m, new DateTime(2024, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice567890.pdf", 4 },
                    { 82, 700m, new DateTime(2024, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice123456.pdf", 12 },
                    { 83, 400m, new DateTime(2024, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice789012.pdf", 9 },
                    { 84, 550m, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice345678.pdf", 3 },
                    { 85, 800m, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice901234.pdf", 17 },
                    { 86, 250m, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice567890.pdf", 5 },
                    { 87, 600m, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice123456.pdf", 18 },
                    { 88, 450m, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice789012.pdf", 11 },
                    { 89, 300m, new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice345678.pdf", 2 },
                    { 90, 550m, new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice901234.pdf", 13 },
                    { 91, 850m, new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice567890.pdf", 8 },
                    { 92, 400m, new DateTime(2024, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice123456.pdf", 15 },
                    { 93, 600m, new DateTime(2024, 12, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice789012.pdf", 16 },
                    { 94, 250m, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice345678.pdf", 19 },
                    { 95, 500m, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice901234.pdf", 7 },
                    { 96, 350m, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice567890.pdf", 4 },
                    { 97, 700m, new DateTime(2025, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "files/pdf/invoices/invoice123456.pdf", 12 },
                    { 98, 400m, new DateTime(2025, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "files/pdf/invoices/invoice789012.pdf", 9 },
                    { 99, 550m, new DateTime(2025, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "files/pdf/invoices/invoice345678.pdf", 3 },
                    { 100, 800m, new DateTime(2025, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "files/pdf/invoices/invoice901234.pdf", 17 }
                });

            migrationBuilder.InsertData(
                table: "Mileages",
                columns: new[] { "ID", "Date", "MileageInKilometers", "VehicleID" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 1 },
                    { 2, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7000m, 1 },
                    { 3, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9000m, 1 },
                    { 4, new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 11000m, 1 },
                    { 5, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 13000m, 1 },
                    { 6, new DateTime(2022, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 15000m, 1 },
                    { 7, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17000m, 1 },
                    { 8, new DateTime(2022, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 19000m, 1 },
                    { 9, new DateTime(2022, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 21000m, 1 },
                    { 10, new DateTime(2022, 10, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 23000m, 1 },
                    { 11, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000m, 2 },
                    { 12, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000m, 2 },
                    { 13, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8000m, 2 },
                    { 14, new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000m, 2 },
                    { 15, new DateTime(2022, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12000m, 2 },
                    { 16, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000m, 3 },
                    { 17, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8000m, 3 },
                    { 18, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000m, 3 },
                    { 19, new DateTime(2022, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12000m, 3 },
                    { 20, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, 4 },
                    { 21, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 4 },
                    { 22, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7000m, 4 },
                    { 23, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8000m, 5 },
                    { 24, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 10000m, 5 },
                    { 25, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 12000m, 5 },
                    { 26, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2500m, 6 },
                    { 27, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4500m, 6 },
                    { 28, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6500m, 6 },
                    { 29, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4500m, 7 },
                    { 30, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6500m, 7 },
                    { 31, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5500m, 8 },
                    { 32, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7500m, 8 },
                    { 33, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6500m, 9 },
                    { 34, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8500m, 9 },
                    { 35, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7500m, 10 },
                    { 36, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 9500m, 10 },
                    { 37, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000m, 11 },
                    { 38, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000m, 11 },
                    { 39, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000m, 12 },
                    { 40, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 8000m, 12 },
                    { 41, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 13 },
                    { 42, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 7000m, 13 },
                    { 43, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3500m, 14 },
                    { 44, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5500m, 14 },
                    { 45, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000m, 15 },
                    { 46, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 6000m, 15 },
                    { 47, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, 16 },
                    { 48, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 16 },
                    { 49, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2500m, 17 },
                    { 50, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4500m, 17 },
                    { 51, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, 18 },
                    { 52, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 18 },
                    { 53, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2000m, 19 },
                    { 54, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 4000m, 19 },
                    { 55, new DateTime(2022, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1000m, 20 },
                    { 56, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3000m, 20 },
                    { 57, new DateTime(2022, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 5000m, 20 }
                });

            migrationBuilder.InsertData(
                table: "PreferredAppointmentDates",
                columns: new[] { "ID", "InquiryID", "PreferredDate" },
                values: new object[,]
                {
                    { 1, 1, new DateTime(2022, 1, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, 1, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, 2, new DateTime(2023, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, 2, new DateTime(2023, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, 3, new DateTime(2023, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, 3, new DateTime(2023, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Repairs",
                columns: new[] { "ID", "DamageReportID", "InsuranceCompanyID", "PaymentDate", "RepairCost", "RepairDate", "VehicleID" },
                values: new object[,]
                {
                    { 1, null, 4, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 400m, new DateTime(2021, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 2, null, 7, null, 300m, new DateTime(2021, 7, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 4 },
                    { 3, null, 3, null, 800m, new DateTime(2021, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 7 },
                    { 4, null, 5, new DateTime(2021, 12, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 550m, new DateTime(2021, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 5, null, 6, new DateTime(2021, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 700m, new DateTime(2021, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 6, null, 2, new DateTime(2021, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 900m, new DateTime(2021, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 7, null, 8, null, 600m, new DateTime(2021, 8, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 8, null, 9, null, 450m, new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 9, null, 4, null, 550m, new DateTime(2021, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 10, null, 5, null, 350m, new DateTime(2021, 3, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 11, null, 10, new DateTime(2021, 5, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 500m, new DateTime(2021, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 12, null, 7, null, 650m, new DateTime(2021, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 13, null, 8, new DateTime(2021, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 400m, new DateTime(2021, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 14, null, 3, null, 800m, new DateTime(2022, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 15, null, 6, null, 550m, new DateTime(2022, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 16, null, 9, new DateTime(2022, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 700m, new DateTime(2022, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 17, null, 4, null, 450m, new DateTime(2022, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 18, null, 2, null, 600m, new DateTime(2022, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 19, null, 5, new DateTime(2022, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 550m, new DateTime(2022, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 20, null, 6, null, 350m, new DateTime(2022, 9, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 21, null, 3, null, 550m, new DateTime(2022, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 22, null, 7, new DateTime(2022, 1, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 400m, new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 23, null, 9, null, 650m, new DateTime(2022, 3, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 24, null, 10, null, 800m, new DateTime(2022, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 25, null, 2, new DateTime(2022, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 550m, new DateTime(2022, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 26, null, 6, null, 700m, new DateTime(2022, 9, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 27, null, 4, null, 450m, new DateTime(2022, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 28, null, 8, new DateTime(2022, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 600m, new DateTime(2022, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 29, null, 2, null, 550m, new DateTime(2022, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 30, null, 5, null, 350m, new DateTime(2022, 6, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 31, null, 10, new DateTime(2022, 8, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 550m, new DateTime(2022, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 32, null, 9, null, 400m, new DateTime(2023, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 33, null, 3, null, 650m, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 34, null, 7, new DateTime(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 800m, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 35, null, 8, null, 550m, new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 36, null, 4, null, 700m, new DateTime(2023, 5, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 37, null, 6, new DateTime(2023, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 450m, new DateTime(2023, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 38, null, 9, null, 600m, new DateTime(2023, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 39, null, 2, null, 550m, new DateTime(2023, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 40, null, 5, new DateTime(2023, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 350m, new DateTime(2023, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 41, null, 10, null, 550m, new DateTime(2023, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 42, null, 3, null, 400m, new DateTime(2023, 6, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 43, null, 7, new DateTime(2023, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 650m, new DateTime(2023, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 44, null, 4, null, 800m, new DateTime(2023, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 45, null, 8, null, 550m, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 46, null, 6, new DateTime(2023, 4, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 700m, new DateTime(2023, 4, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 47, null, 2, null, 450m, new DateTime(2023, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 48, null, 9, null, 600m, new DateTime(2023, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 49, null, 5, new DateTime(2023, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 550m, new DateTime(2023, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 17 },
                    { 50, null, 10, null, 350m, new DateTime(2023, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 }
                });

            migrationBuilder.InsertData(
                table: "DamageReports",
                columns: new[] { "ID", "Cost", "DamageDate", "DamageRepairTypeID", "Description", "InspectionReportID", "ReportDate", "VehiclePartID" },
                values: new object[,]
                {
                    { 1, 800m, new DateTime(2020, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Voorspatbord beschadigd bij een botsing.", 19, new DateTime(2020, 8, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 2, 500m, new DateTime(2020, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Achterruit beschadigd door vandalisme.", 46, new DateTime(2020, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 46 },
                    { 3, 1200m, new DateTime(2020, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 28, "Brandstofinjector lekt en moet worden vervangen.", 74, new DateTime(2020, 10, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 4, 950m, new DateTime(2020, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "Roestvorming aan de brandstoftank, moet worden vervangen.", 58, new DateTime(2020, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 5, 600m, new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, "Remklauw aan de voorzijde versleten, moet worden vervangen.", 82, new DateTime(2020, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 6, 1800m, new DateTime(2021, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Koelventilator montage defect, moet worden gerepareerd.", 96, new DateTime(2021, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 50 },
                    { 7, 350m, new DateTime(2021, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Bougies moeten worden vervangen voor betere ontsteking.", 13, new DateTime(2021, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2 },
                    { 8, 1300m, new DateTime(2021, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 12, "Wielophangingrubbers versleten, moeten worden vervangen.", 26, new DateTime(2021, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 12 },
                    { 9, 700m, new DateTime(2021, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 20, "CV-koppeling defect, moet worden vervangen.", 35, new DateTime(2021, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 20 },
                    { 10, 550m, new DateTime(2021, 5, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Luchtfilter verstopt, moet worden gereinigd of vervangen.", 8, new DateTime(2021, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 11, 420m, new DateTime(2021, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Krukas beschadigd, moet worden vervangen.", 22, new DateTime(2021, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 12, 950m, new DateTime(2021, 7, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 42, "Remklauw aan de achterzijde versleten, moet worden vervangen.", 73, new DateTime(2021, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 13, 1600m, new DateTime(2021, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 41, "Inlaatspruitstuk lekt, moet worden gerepareerd.", 87, new DateTime(2021, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 52 },
                    { 14, 380m, new DateTime(2021, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Accu ontladen, moet worden vervangen.", 15, new DateTime(2021, 9, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 15, 1200m, new DateTime(2021, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Remrotor aan de voorzijde versleten, moet worden vervangen.", 29, new DateTime(2021, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 16, 850m, new DateTime(2021, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 40, "Spanrol van de multiriem defect, moet worden vervangen.", 64, new DateTime(2021, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 40 },
                    { 17, 670m, new DateTime(2021, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, "Luchtfilterbehuizing beschadigd, moet worden vervangen.", 17, new DateTime(2021, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 18, 1080m, new DateTime(2022, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 31, "Schade aan de achteruitkijkspiegel, moet worden vervangen.", 51, new DateTime(2022, 1, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 31 },
                    { 19, 570m, new DateTime(2022, 2, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, "Ontstekingskabels beschadigd, moeten worden vervangen.", 76, new DateTime(2022, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 8 },
                    { 20, 950m, new DateTime(2022, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 18, "Schokdemper aan de voorzijde lekt, moet worden vervangen.", 27, new DateTime(2022, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 18 },
                    { 21, 780m, new DateTime(2022, 4, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 24, "Uitlaatspruitstuk lekt, moet worden gerepareerd.", 48, new DateTime(2022, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 24 },
                    { 22, 560m, new DateTime(2022, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Remblokken versleten, moeten worden vervangen.", 10, new DateTime(2022, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1 },
                    { 23, 990m, new DateTime(2022, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 37, "Versnellingsbaksteun beschadigd, moet worden vervangen.", 37, new DateTime(2022, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 37 },
                    { 24, 1350m, new DateTime(2022, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 50, "Wiellager aan de voorzijde defect, moet worden vervangen.", 62, new DateTime(2022, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 19 },
                    { 25, 410m, new DateTime(2022, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, "Bobine defect, moet worden vervangen.", 20, new DateTime(2022, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 10 },
                    { 26, 720m, new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 30, "Ventilatormotor defect, moet worden vervangen.", 55, new DateTime(2022, 9, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 30 },
                    { 27, 980m, new DateTime(2022, 10, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 14, "Waterpomp lekt, moet worden gerepareerd.", 34, new DateTime(2022, 10, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 14 },
                    { 28, 580m, new DateTime(2022, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 38, "Motorsteun beschadigd, moet worden vervangen.", 38, new DateTime(2022, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 38 },
                    { 29, 820m, new DateTime(2022, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, "Brandstofinjector verstopt, moet worden gereinigd.", 28, new DateTime(2022, 12, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 28 },
                    { 30, 690m, new DateTime(2023, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, "Airconditioningcompressor defect, moet worden vervangen.", 29, new DateTime(2023, 1, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 29 },
                    { 31, 670m, new DateTime(2023, 2, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 22, "Remklauw vast, moet worden gerepareerd.", 42, new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 42 },
                    { 32, 480m, new DateTime(2023, 3, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 45, "Koplamp beschadigd, moet worden vervangen.", 45, new DateTime(2023, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 45 },
                    { 33, 520m, new DateTime(2023, 4, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Batterij leeg, moet worden vervangen.", 3, new DateTime(2023, 4, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 3 },
                    { 34, 710m, new DateTime(2023, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, "Stuurkolom beschadigd, moet worden vervangen.", 70, new DateTime(2023, 5, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 70 },
                    { 35, 680m, new DateTime(2023, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 16, "Thermostaat defect, moet worden vervangen.", 16, new DateTime(2023, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 16 },
                    { 36, 940m, new DateTime(2023, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 47, "Zijspiegel beschadigd, moet worden vervangen.", 47, new DateTime(2023, 7, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 47 },
                    { 37, 890m, new DateTime(2023, 8, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Bougies versleten, moeten worden vervangen.", 5, new DateTime(2023, 8, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 5 },
                    { 38, 760m, new DateTime(2023, 10, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, "Dynamo defect, moet worden vervangen.", 9, new DateTime(2023, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 9 },
                    { 39, 530m, new DateTime(2023, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 33, "Uitlaatdemper beschadigd, moet worden vervangen.", 33, new DateTime(2023, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 33 },
                    { 40, 920m, new DateTime(2023, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 48, "Stabilisatorstang gebroken, moet worden vervangen.", 48, new DateTime(2023, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 48 },
                    { 41, 580m, new DateTime(2024, 1, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 11, "Oliedruksensor defect, moet worden vervangen.", 11, new DateTime(2024, 1, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 11 },
                    { 42, 780m, new DateTime(2024, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Achterruitwissermotor defect, moet worden vervangen.", 21, new DateTime(2024, 2, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 21 },
                    { 43, 690m, new DateTime(2024, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 43, "Uitlaatspruitstuk lekt, moet worden gerepareerd.", 43, new DateTime(2024, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 43 },
                    { 44, 940m, new DateTime(2024, 4, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), 46, "Distributieriem gebroken, moet worden vervangen.", 56, new DateTime(2024, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), 56 },
                    { 45, 530m, new DateTime(2024, 5, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 15, "Koelvloeistoflekkage, moet worden gerepareerd.", 15, new DateTime(2024, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 15 },
                    { 46, 680m, new DateTime(2024, 6, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 27, "Schokdemper lek, moet worden vervangen.", 27, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 27 },
                    { 47, 820m, new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 44, "Krukaspositiesensor defect, moet worden vervangen.", 44, new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 44 },
                    { 48, 570m, new DateTime(2024, 8, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 13, "Luchtfilter verstopt, moet worden vervangen.", 13, new DateTime(2024, 8, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), 13 },
                    { 49, 960m, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 49, "Achteruitrijlicht defect, moet worden vervangen.", 49, new DateTime(2024, 9, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 49 },
                    { 50, 740m, new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 21, "Remslang lek, moet worden vervangen.", 25, new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 25 }
                });

            migrationBuilder.InsertData(
                table: "MaintenanceTasks",
                columns: new[] { "ID", "Description", "MaintenanceID" },
                values: new object[,]
                {
                    { 1, "Replaced the tires with summer tires.", 6 },
                    { 2, "Performed oil change and filter replacement.", 2 },
                    { 3, "Inspected and adjusted the brake system.", 45 },
                    { 4, "Repaired the exhaust system.", 18 },
                    { 5, "Replaced the windshield wipers.", 34 },
                    { 6, "Performed coolant flush and refill.", 76 },
                    { 7, "Inspected and replaced spark plugs.", 89 },
                    { 8, "Checked and adjusted the wheel alignment.", 55 },
                    { 9, "Recharged the air conditioning system.", 12 },
                    { 10, "Performed battery test and replaced if necessary.", 67 },
                    { 11, "Inspected and replaced the serpentine belt.", 91 },
                    { 12, "Performed transmission fluid change.", 25 },
                    { 13, "Checked and adjusted tire pressure.", 63 },
                    { 14, "Replaced the cabin air filter.", 40 },
                    { 15, "Performed brake fluid flush and refill.", 83 },
                    { 16, "Checked and replaced the engine air filter.", 7 },
                    { 17, "Inspected and replaced worn suspension components.", 30 },
                    { 18, "Performed engine diagnostics and troubleshooting.", 95 },
                    { 19, "Replaced the fuel filter.", 52 },
                    { 20, "Checked and replaced worn drive belts.", 37 },
                    { 21, "Performed power steering fluid flush and refill.", 72 },
                    { 22, "Inspected and replaced worn brake pads.", 99 },
                    { 23, "Replaced the battery.", 14 },
                    { 24, "Performed fuel system cleaning and injector service.", 79 },
                    { 25, "Checked and replaced the timing belt.", 48 },
                    { 26, "Replaced the alternator.", 61 },
                    { 27, "Inspected and replaced worn CV joints.", 9 },
                    { 28, "Performed coolant system pressure test.", 42 },
                    { 29, "Checked and replaced worn ignition coils.", 86 },
                    { 30, "Replaced the radiator.", 19 },
                    { 31, "Performed suspension alignment.", 70 },
                    { 32, "Inspected and replaced worn wheel bearings.", 93 },
                    { 33, "Repaired the power window mechanism.", 16 },
                    { 34, "Performed emissions system check.", 82 },
                    { 35, "Checked and replaced the thermostat.", 57 },
                    { 36, "Replaced the oxygen sensor.", 32 },
                    { 37, "Inspected and replaced worn tie rod ends.", 74 },
                    { 38, "Performed electrical system check.", 97 },
                    { 39, "Checked and replaced worn sway bar links.", 23 },
                    { 40, "Repaired the power door lock system.", 64 },
                    { 41, "Performed fuel pressure test.", 44 },
                    { 42, "Checked and replaced the camshaft position sensor.", 88 },
                    { 43, "Repaired the starter motor.", 10 },
                    { 44, "Inspected and replaced worn control arm bushings.", 50 },
                    { 45, "Performed engine tune-up.", 35 },
                    { 46, "Replaced the water pump.", 77 },
                    { 47, "Inspected and replaced worn brake rotors.", 92 },
                    { 48, "Checked and replaced the mass airflow sensor.", 13 },
                    { 49, "Repaired the power steering pump.", 81 },
                    { 50, "Performed fuel injector cleaning.", 26 },
                    { 51, "Checked and replaced worn ball joints.", 68 },
                    { 52, "Repaired the power steering hose.", 3 },
                    { 53, "Inspected and replaced worn shock absorbers.", 66 },
                    { 54, "Performed fuel system pressure test.", 20 },
                    { 55, "Checked and replaced the throttle position sensor.", 85 },
                    { 56, "Replaced the ignition switch.", 21 },
                    { 57, "Inspected and replaced worn sway bar bushings.", 71 },
                    { 58, "Performed power window motor replacement.", 94 },
                    { 59, "Checked and replaced the crankshaft position sensor.", 17 },
                    { 60, "Repaired the fuel tank.", 58 },
                    { 61, "Inspected and replaced worn struts.", 31 },
                    { 62, "Performed engine vacuum leak test.", 75 },
                    { 63, "Checked and replaced the knock sensor.", 96 },
                    { 64, "Repaired the power seat mechanism.", 24 },
                    { 65, "Inspected and replaced worn control arm joints.", 65 },
                    { 66, "Performed cooling system pressure test.", 41 },
                    { 67, "Checked and replaced the fuel pressure regulator.", 87 },
                    { 68, "Repaired the alternator belt.", 11 },
                    { 69, "Inspected and replaced worn CV boots.", 49 },
                    { 70, "Performed throttle body cleaning.", 36 },
                    { 71, "Checked and replaced the fuel pump.", 78 },
                    { 72, "Repaired the power mirror.", 90 },
                    { 73, "Inspected and replaced worn bushings.", 15 },
                    { 74, "Performed ignition system check.", 80 },
                    { 75, "Checked and replaced the fuel cap.", 29 },
                    { 76, "Replaced the AC compressor.", 62 },
                    { 77, "Inspected and replaced worn control arm brackets.", 43 },
                    { 78, "Performed battery voltage test.", 89 },
                    { 79, "Repaired the power steering rack.", 9 },
                    { 80, "Checked and replaced the fuel filter.", 48 },
                    { 81, "Inspected and replaced worn stabilizer bar links.", 33 },
                    { 82, "Performed engine compression test.", 76 },
                    { 83, "Checked and replaced the fuel injectors.", 98 },
                    { 84, "Repaired the power trunk release.", 22 },
                    { 85, "Inspected and replaced worn strut mounts.", 67 },
                    { 86, "Performed radiator flush and coolant replacement.", 40 },
                    { 87, "Checked and replaced the fuel level sensor.", 93 },
                    { 88, "Repaired the power window switch.", 8 },
                    { 89, "Inspected and replaced worn bushing brackets.", 55 },
                    { 90, "Performed throttle position sensor calibration.", 34 },
                    { 91, "Checked and replaced the fuel tank cap.", 79 },
                    { 92, "Repaired the power antenna.", 91 },
                    { 93, "Inspected and replaced worn steering gear.", 14 },
                    { 94, "Performed engine oil pressure test.", 73 },
                    { 95, "Checked and replaced the fuel pressure sensor.", 95 },
                    { 96, "Repaired the power sunroof mechanism.", 25 },
                    { 97, "Inspected and replaced worn sway bar end links.", 64 },
                    { 98, "Performed throttle body replacement.", 45 },
                    { 99, "Checked and replaced the fuel pump relay.", 99 },
                    { 100, "Replaced the AC condenser.", 28 },
                    { 101, "Performed brake fluid flush and replacement.", 14 },
                    { 102, "Checked and replaced the transmission fluid filter.", 53 },
                    { 103, "Repaired the power steering pump.", 24 },
                    { 104, "Inspected and replaced worn wheel bearings.", 86 },
                    { 105, "Performed transmission fluid flush and replacement.", 41 },
                    { 106, "Replaced the power steering pressure hose.", 25 },
                    { 107, "Checked and replaced the differential fluid.", 67 },
                    { 108, "Inspected and replaced worn axle seals.", 58 },
                    { 109, "Performed engine coolant flush and replacement.", 31 },
                    { 110, "Repaired the power steering gear.", 73 },
                    { 111, "Checked and replaced the transfer case fluid.", 49 },
                    { 112, "Inspected and replaced worn CV joints.", 92 },
                    { 113, "Performed differential fluid flush and replacement.", 36 },
                    { 114, "Replaced the power steering reservoir.", 34 },
                    { 115, "Checked and replaced the brake pads.", 78 },
                    { 116, "Inspected and replaced worn wheel studs.", 45 },
                    { 117, "Performed power steering fluid flush and replacement.", 97 },
                    { 118, "Repaired the differential.", 82 },
                    { 119, "Checked and replaced the transmission mount.", 56 },
                    { 120, "Inspected and replaced worn U-joints.", 23 },
                    { 121, "Performed brake caliper rebuild.", 70 },
                    { 122, "Replaced the power steering belt.", 37 },
                    { 123, "Checked and replaced the differential gasket.", 65 },
                    { 124, "Inspected and replaced worn brake rotors.", 76 },
                    { 125, "Performed axle fluid flush and replacement.", 30 },
                    { 126, "Repaired the power steering control valve.", 91 },
                    { 127, "Checked and replaced the brake lines.", 80 },
                    { 128, "Inspected and replaced worn brake calipers.", 47 },
                    { 129, "Performed transmission cooler replacement.", 95 },
                    { 130, "Replaced the power steering pulley.", 26 },
                    { 131, "Checked and replaced the differential pinion seal.", 75 },
                    { 132, "Inspected and replaced worn brake hoses.", 46 },
                    { 133, "Performed engine mount replacement.", 12 },
                    { 134, "Repaired the power steering fluid cooler.", 89 },
                    { 135, "Checked and replaced the brake booster.", 71 },
                    { 136, "Inspected and replaced worn brake master cylinder.", 40 },
                    { 137, "Performed transmission mount replacement.", 72 },
                    { 138, "Replaced the power steering pressure switch.", 57 },
                    { 139, "Checked and replaced the engine oil pan.", 16 },
                    { 140, "Inspected and replaced worn engine mounts.", 59 },
                    { 141, "Performed transmission pan replacement.", 4 },
                    { 142, "Repaired the power steering return hose.", 93 },
                    { 143, "Checked and replaced the engine oil filter.", 51 },
                    { 144, "Inspected and replaced worn power steering lines.", 37 },
                    { 145, "Performed engine oil cooler replacement.", 20 },
                    { 146, "Replaced the power steering control module.", 9 },
                    { 147, "Checked and replaced the engine air filter.", 48 },
                    { 148, "Inspected and replaced worn engine belts.", 39 },
                    { 149, "Performed engine oil pump replacement.", 3 },
                    { 150, "Repaired the power steering reservoir cap.", 32 },
                    { 151, "Checked and replaced the engine coolant temperature sensor.", 69 },
                    { 152, "Inspected and replaced worn spark plugs.", 42 },
                    { 153, "Performed engine oil pressure switch replacement.", 33 },
                    { 154, "Replaced the power steering control arm.", 24 },
                    { 155, "Checked and replaced the engine crankshaft position sensor.", 63 },
                    { 156, "Inspected and replaced worn ignition coils.", 62 },
                    { 157, "Performed engine oil level sensor replacement.", 27 },
                    { 158, "Repaired the power steering gear box.", 54 },
                    { 159, "Checked and replaced the engine camshaft position sensor.", 95 },
                    { 160, "Inspected and replaced worn fuel injectors.", 64 },
                    { 161, "Performed engine oil filler cap replacement.", 39 },
                    { 162, "Replaced the power steering rack.", 50 },
                    { 163, "Checked and replaced the engine throttle position sensor.", 61 },
                    { 164, "Inspected and replaced worn fuel pump.", 73 },
                    { 165, "Performed engine oil drain plug replacement.", 7 },
                    { 166, "Repaired the power steering control module connector.", 68 },
                    { 167, "Checked and replaced the engine intake manifold.", 53 },
                    { 168, "Inspected and replaced worn oxygen sensor.", 84 },
                    { 169, "Performed engine oil cap replacement.", 56 },
                    { 170, "Replaced the power steering pump pulley.", 33 },
                    { 171, "Checked and replaced the engine exhaust manifold.", 49 },
                    { 172, "Inspected and replaced worn engine gaskets.", 3 },
                    { 173, "Performed engine oil cooler hose replacement.", 58 },
                    { 174, "Repaired the power steering pressure line.", 44 },
                    { 175, "Checked and replaced the engine timing chain.", 65 },
                    { 176, "Inspected and replaced worn engine sensors.", 2 },
                    { 177, "Performed engine oil pan gasket replacement.", 79 },
                    { 178, "Replaced the power steering control valve seal.", 24 },
                    { 179, "Checked and replaced the engine valve cover.", 83 },
                    { 180, "Inspected and replaced worn fuel filters.", 92 },
                    { 181, "Performed engine oil pressure relief valve replacement.", 37 },
                    { 182, "Repaired the power steering pressure regulator.", 91 },
                    { 183, "Checked and replaced the engine timing belt.", 60 },
                    { 184, "Inspected and replaced worn ignition wires.", 40 },
                    { 185, "Performed engine oil filter housing replacement.", 25 },
                    { 186, "Replaced the power steering reservoir cap.", 62 },
                    { 187, "Checked and replaced the engine valve seals.", 76 },
                    { 188, "Inspected and replaced worn fuel injectors seals.", 14 },
                    { 189, "Performed engine oil cooler gasket replacement.", 63 },
                    { 190, "Repaired the power steering pressure hose.", 82 },
                    { 191, "Checked and replaced the engine intake valve.", 44 },
                    { 192, "Inspected and replaced worn ignition coils.", 77 },
                    { 193, "Performed engine oil pump gasket replacement.", 52 },
                    { 194, "Replaced the power steering return line.", 84 },
                    { 195, "Checked and replaced the engine exhaust valve.", 85 },
                    { 196, "Inspected and replaced worn fuel pressure regulator.", 62 },
                    { 197, "Performed engine oil cooler line replacement.", 58 },
                    { 198, "Repaired the power steering pump bracket.", 23 },
                    { 199, "Checked and replaced the engine cylinder head.", 3 },
                    { 200, "Inspected and replaced worn ignition modules.", 83 },
                    { 201, "Performed engine oil filter replacement.", 95 },
                    { 202, "Replaced the power steering pump shaft.", 74 },
                    { 203, "Checked and replaced the engine serpentine belt.", 79 },
                    { 204, "Inspected and replaced worn spark plugs.", 57 },
                    { 205, "Performed engine coolant flush and refill.", 80 },
                    { 206, "Repaired the power steering pressure switch.", 61 },
                    { 207, "Checked and replaced the engine radiator.", 70 },
                    { 208, "Inspected and replaced worn ignition coils.", 68 },
                    { 209, "Performed engine air filter replacement.", 58 },
                    { 210, "Replaced the power steering pump pulley.", 63 },
                    { 211, "Checked and replaced the engine thermostat.", 62 },
                    { 212, "Inspected and replaced worn fuel injectors.", 76 },
                    { 213, "Performed engine oil drain plug replacement.", 82 },
                    { 214, "Repaired the power steering pressure line.", 72 },
                    { 215, "Checked and replaced the engine water pump.", 69 },
                    { 216, "Inspected and replaced worn oxygen sensor.", 88 },
                    { 217, "Performed engine oil cap replacement.", 64 },
                    { 218, "Replaced the power steering control module connector.", 52 },
                    { 219, "Checked and replaced the engine fuel pump.", 73 },
                    { 220, "Inspected and replaced worn engine mounts.", 78 },
                    { 221, "Performed engine oil cooler hose replacement.", 85 },
                    { 222, "Repaired the power steering pressure hose.", 77 },
                    { 223, "Checked and replaced the engine ignition control module.", 67 },
                    { 224, "Inspected and replaced worn engine sensors.", 66 },
                    { 225, "Performed engine oil pan gasket replacement.", 84 },
                    { 226, "Replaced the power steering reservoir.", 94 },
                    { 227, "Checked and replaced the engine camshaft position sensor.", 100 },
                    { 228, "Inspected and replaced worn drive belts.", 92 },
                    { 229, "Performed engine valve cover gasket replacement.", 97 },
                    { 230, "Repaired the power steering pump seal.", 86 },
                    { 231, "Checked and replaced the engine crankshaft position sensor.", 90 },
                    { 232, "Inspected and replaced worn timing belt.", 98 },
                    { 233, "Performed engine oil pressure switch replacement.", 83 },
                    { 234, "Replaced the power steering pressure sensor.", 96 },
                    { 235, "Checked and replaced the engine throttle body.", 81 },
                    { 236, "Inspected and replaced worn alternator.", 75 },
                    { 237, "Performed engine oil filter housing gasket replacement.", 71 },
                    { 238, "Repaired the power steering pump pulley.", 87 },
                    { 239, "Checked and replaced the engine oil pressure sensor.", 99 },
                    { 240, "Inspected and replaced worn serpentine belt tensioner.", 93 },
                    { 241, "Performed engine valve stem seal replacement.", 89 },
                    { 242, "Replaced the power steering pump reservoir.", 91 },
                    { 243, "Checked and replaced the engine knock sensor.", 65 },
                    { 244, "Inspected and replaced worn PCV valve.", 59 },
                    { 245, "Performed engine oil filter housing cap replacement.", 60 },
                    { 246, "Repaired the power steering pump bracket.", 55 },
                    { 247, "Checked and replaced the engine coolant temperature sensor.", 53 },
                    { 248, "Inspected and replaced worn intake manifold gasket.", 56 },
                    { 249, "Performed engine oil filler cap replacement.", 54 },
                    { 250, "Replaced the power steering pump o-ring.", 51 },
                    { 251, "Checked and replaced the engine variable valve timing solenoid.", 50 },
                    { 252, "Inspected and replaced worn exhaust manifold gasket.", 48 },
                    { 253, "Performed engine oil cooler gasket replacement.", 49 },
                    { 254, "Repaired the power steering pump shaft seal.", 46 },
                    { 255, "Checked and replaced the engine thermostat housing.", 47 },
                    { 256, "Inspected and replaced worn fuel pressure regulator.", 45 },
                    { 257, "Performed engine oil pressure relief valve replacement.", 43 },
                    { 258, "Replaced the power steering pump mounting bolt.", 42 },
                    { 259, "Checked and replaced the engine harmonic balancer.", 44 },
                    { 260, "Inspected and replaced worn engine timing chain.", 39 },
                    { 261, "Performed engine oil pump replacement.", 41 },
                    { 262, "Repaired the power steering pump bracket bolt.", 38 },
                    { 263, "Checked and replaced the engine fuel rail.", 36 },
                    { 264, "Inspected and replaced worn engine valve springs.", 35 },
                    { 265, "Performed engine oil cooler line replacement.", 33 },
                    { 266, "Replaced the power steering pump reservoir cap.", 32 },
                    { 267, "Checked and replaced the engine oil dipstick.", 40 },
                    { 268, "Inspected and replaced worn engine head gasket.", 37 },
                    { 269, "Performed engine oil filter housing seal replacement.", 31 },
                    { 270, "Repaired the power steering pump mounting bracket.", 34 },
                    { 271, "Checked and replaced the engine crankshaft seal.", 30 },
                    { 272, "Inspected and replaced worn engine piston rings.", 29 },
                    { 273, "Performed engine oil cooler thermostat replacement.", 28 },
                    { 274, "Replaced the power steering pump drive belt.", 27 },
                    { 275, "Checked and replaced the engine flywheel.", 26 },
                    { 276, "Inspected and replaced worn engine main bearings.", 25 },
                    { 277, "Performed engine oil cooler adapter replacement.", 24 },
                    { 278, "Repaired the power steering pump pulley bolt.", 23 },
                    { 279, "Checked and replaced the engine connecting rod bearings.", 22 },
                    { 280, "Inspected and replaced worn engine valve lifters.", 21 },
                    { 281, "Performed engine oil pressure gauge replacement.", 20 },
                    { 282, "Replaced the power steering pump pressure hose.", 19 },
                    { 283, "Checked and replaced the engine timing chain tensioner.", 18 },
                    { 284, "Inspected and replaced worn engine piston pins.", 17 },
                    { 285, "Performed engine oil pump drive replacement.", 16 },
                    { 286, "Repaired the power steering pump o-ring seal.", 15 },
                    { 287, "Checked and replaced the engine valve spring retainers.", 14 },
                    { 288, "Inspected and replaced worn engine crankshaft bearings.", 13 },
                    { 289, "Performed engine oil pressure relief valve spring replacement.", 12 },
                    { 290, "Replaced the power steering pump outlet hose.", 11 },
                    { 291, "Checked and replaced the engine piston rods.", 10 },
                    { 292, "Inspected and replaced worn engine camshaft bearings.", 9 },
                    { 293, "Performed engine oil pan baffle replacement.", 8 },
                    { 294, "Repaired the power steering pump inlet hose.", 7 },
                    { 295, "Checked and replaced the engine cylinder liners.", 6 },
                    { 296, "Inspected and replaced worn engine crankshaft.", 5 },
                    { 297, "Performed engine oil pump pickup tube replacement.", 4 },
                    { 298, "Replaced the power steering pump shaft seal.", 3 },
                    { 299, "Checked and replaced the engine cylinder head.", 2 },
                    { 300, "Inspected and replaced worn engine block.", 1 },
                    { 301, "Performed engine oil cooler gasket replacement.", 49 },
                    { 302, "Checked and replaced the engine harmonic balancer.", 44 },
                    { 303, "Inspected and replaced worn fuel pressure regulator.", 45 },
                    { 304, "Repaired the power steering pump shaft seal.", 46 },
                    { 305, "Checked and replaced the engine thermostat housing.", 47 },
                    { 306, "Replaced the engine variable valve timing solenoid.", 48 },
                    { 307, "Replaced the power steering pump mounting bolt.", 42 },
                    { 308, "Performed engine oil pressure relief valve replacement.", 43 },
                    { 309, "Checked and replaced the engine oil dipstick.", 40 },
                    { 310, "Performed engine oil pump replacement.", 41 },
                    { 311, "Inspected and replaced worn engine timing chain.", 39 },
                    { 312, "Repaired the power steering pump bracket bolt.", 38 },
                    { 313, "Inspected and replaced worn engine head gasket.", 37 },
                    { 314, "Checked and replaced the engine fuel rail.", 36 },
                    { 315, "Inspected and replaced worn engine valve springs.", 35 },
                    { 316, "Repaired the power steering pump mounting bracket.", 34 },
                    { 317, "Performed engine oil cooler line replacement.", 33 },
                    { 318, "Replaced the power steering pump reservoir cap.", 32 },
                    { 319, "Performed engine oil filter housing seal replacement.", 31 },
                    { 320, "Checked and replaced the engine crankshaft seal.", 30 },
                    { 321, "Inspected and replaced worn engine piston rings.", 29 },
                    { 322, "Performed engine oil cooler thermostat replacement.", 28 },
                    { 323, "Replaced the power steering pump drive belt.", 27 },
                    { 324, "Checked and replaced the engine flywheel.", 26 },
                    { 325, "Inspected and replaced worn engine main bearings.", 25 },
                    { 326, "Performed engine oil cooler adapter replacement.", 24 },
                    { 327, "Repaired the power steering pump pulley bolt.", 23 },
                    { 328, "Checked and replaced the engine connecting rod bearings.", 22 },
                    { 329, "Inspected and replaced worn engine valve lifters.", 21 },
                    { 330, "Performed engine oil pressure gauge replacement.", 20 },
                    { 331, "Replaced the power steering pump pressure hose.", 19 },
                    { 332, "Checked and replaced the engine timing chain tensioner.", 18 },
                    { 333, "Inspected and replaced worn engine piston pins.", 17 },
                    { 334, "Performed engine oil pump drive replacement.", 16 },
                    { 335, "Repaired the power steering pump o-ring seal.", 15 },
                    { 336, "Checked and replaced the engine valve spring retainers.", 14 },
                    { 337, "Inspected and replaced worn engine crankshaft bearings.", 13 },
                    { 338, "Performed engine oil pressure relief valve spring replacement.", 12 },
                    { 339, "Replaced the power steering pump outlet hose.", 11 },
                    { 340, "Checked and replaced the engine piston rods.", 10 },
                    { 341, "Inspected and replaced worn engine camshaft bearings.", 9 },
                    { 342, "Performed engine oil pan baffle replacement.", 8 },
                    { 343, "Repaired the power steering pump inlet hose.", 7 },
                    { 344, "Checked and replaced the engine cylinder liners.", 6 },
                    { 345, "Inspected and replaced worn engine crankshaft.", 5 },
                    { 346, "Performed engine oil pump pickup tube replacement.", 4 },
                    { 347, "Replaced the power steering pump shaft seal.", 3 },
                    { 348, "Checked and replaced the engine cylinder head.", 2 },
                    { 349, "Inspected and replaced worn engine block.", 1 },
                    { 350, "Performed engine oil cooler replacement.", 100 },
                    { 351, "Repaired the power steering pump mounting bracket.", 99 },
                    { 352, "Checked and replaced the engine valve cover gasket.", 98 },
                    { 353, "Inspected and replaced worn engine timing belt.", 97 },
                    { 354, "Performed engine oil pan replacement.", 96 },
                    { 355, "Replaced the power steering pump drive pulley.", 95 },
                    { 356, "Checked and replaced the engine intake manifold gasket.", 94 },
                    { 357, "Inspected and replaced worn engine valve seals.", 93 },
                    { 358, "Performed engine oil pump replacement.", 92 },
                    { 359, "Repaired the power steering pump reservoir.", 91 },
                    { 360, "Checked and replaced the engine exhaust manifold gasket.", 90 },
                    { 361, "Inspected and replaced worn engine valve lifters.", 89 },
                    { 362, "Performed engine oil filter housing replacement.", 88 },
                    { 363, "Replaced the power steering pump pressure switch.", 87 },
                    { 364, "Checked and replaced the engine camshaft position sensor.", 86 },
                    { 365, "Inspected and replaced worn engine piston rings.", 85 },
                    { 366, "Performed engine oil cooler line replacement.", 84 },
                    { 367, "Repaired the power steering pump inlet hose.", 83 },
                    { 368, "Checked and replaced the engine crankshaft position sensor.", 82 },
                    { 369, "Inspected and replaced worn engine main bearings.", 81 },
                    { 370, "Performed engine oil pump pickup tube replacement.", 80 },
                    { 371, "Replaced the power steering pump pulley bolt.", 79 },
                    { 372, "Checked and replaced the engine oil pressure sensor.", 78 },
                    { 373, "Inspected and replaced worn engine valve springs.", 77 },
                    { 374, "Performed engine oil cooler adapter replacement.", 76 },
                    { 375, "Repaired the power steering pump bracket bolt.", 75 },
                    { 376, "Checked and replaced the engine coolant temperature sensor.", 74 },
                    { 377, "Inspected and replaced worn engine piston pins.", 73 },
                    { 378, "Performed engine oil filter housing seal replacement.", 72 },
                    { 379, "Replaced the power steering pump mounting bolt.", 71 },
                    { 380, "Checked and replaced the engine oil pressure relief valve.", 70 },
                    { 381, "Inspected and replaced worn engine valve guides.", 69 },
                    { 382, "Performed engine oil cooler thermostat replacement.", 68 },
                    { 383, "Repaired the power steering pump reservoir cap.", 67 },
                    { 384, "Checked and replaced the engine variable valve timing solenoid.", 66 },
                    { 385, "Inspected and replaced worn engine piston rods.", 65 },
                    { 386, "Performed engine oil pump drive replacement.", 64 },
                    { 387, "Replaced the power steering pump pressure hose.", 63 },
                    { 388, "Checked and replaced the engine crankshaft seal.", 62 },
                    { 389, "Inspected and replaced worn engine valve lifters.", 61 },
                    { 390, "Performed engine oil pressure gauge replacement.", 60 },
                    { 391, "Repaired the power steering pump o-ring seal.", 59 },
                    { 392, "Checked and replaced the engine timing chain tensioner.", 58 },
                    { 393, "Inspected and replaced worn engine piston rings.", 57 },
                    { 394, "Performed engine oil cooler line replacement.", 56 },
                    { 395, "Replaced the power steering pump inlet hose.", 55 },
                    { 396, "Checked and replaced the engine flywheel.", 54 },
                    { 397, "Inspected and replaced worn engine main bearings.", 53 },
                    { 398, "Performed engine oil pump pickup tube replacement.", 52 },
                    { 399, "Repaired the power steering pump pulley.", 51 },
                    { 400, "Checked and replaced the engine connecting rod bearings.", 50 },
                    { 401, "Replaced the transmission fluid.", 99 },
                    { 402, "Inspected and replaced worn suspension bushings.", 98 },
                    { 403, "Performed brake fluid flush and replacement.", 97 },
                    { 404, "Replaced the fuel filter.", 96 },
                    { 405, "Checked and replaced worn spark plugs.", 95 },
                    { 406, "Inspected and replaced worn drive belts.", 94 },
                    { 407, "Performed coolant flush and replacement.", 93 },
                    { 408, "Replaced the air filter.", 92 },
                    { 409, "Checked and replaced worn wiper blades.", 91 },
                    { 410, "Inspected and replaced worn brake pads.", 90 },
                    { 411, "Performed power steering fluid flush and replacement.", 89 },
                    { 412, "Replaced the cabin air filter.", 88 },
                    { 413, "Checked and replaced worn battery.", 87 },
                    { 414, "Inspected and replaced worn brake rotors.", 86 },
                    { 415, "Performed wheel alignment and tire balancing.", 85 },
                    { 416, "Replaced the serpentine belt.", 84 },
                    { 417, "Checked and replaced worn ignition coils.", 83 },
                    { 418, "Inspected and replaced worn brake calipers.", 82 },
                    { 419, "Performed fuel system cleaning and treatment.", 81 },
                    { 420, "Replaced the thermostat.", 80 },
                    { 421, "Checked and replaced worn suspension struts.", 79 },
                    { 422, "Inspected and replaced worn wheel bearings.", 78 },
                    { 423, "Performed engine coolant temperature sensor replacement.", 77 },
                    { 424, "Replaced the oxygen sensor.", 76 },
                    { 425, "Checked and replaced worn control arm bushings.", 75 },
                    { 426, "Inspected and replaced worn tie rod ends.", 74 },
                    { 427, "Performed throttle body cleaning and service.", 73 },
                    { 428, "Replaced the fuel pump.", 72 },
                    { 429, "Checked and replaced worn ball joints.", 71 },
                    { 430, "Inspected and replaced worn sway bar links.", 70 },
                    { 431, "Performed transmission filter replacement.", 69 },
                    { 432, "Replaced the PCV valve.", 68 },
                    { 433, "Checked and replaced worn drive shafts.", 67 },
                    { 434, "Inspected and replaced worn wheel hubs.", 66 },
                    { 435, "Performed engine air intake cleaning and service.", 65 },
                    { 436, "Replaced the mass air flow sensor.", 64 },
                    { 437, "Checked and replaced worn CV joints.", 63 },
                    { 438, "Inspected and replaced worn shock absorbers.", 62 },
                    { 439, "Performed brake caliper rebuild and service.", 61 },
                    { 440, "Replaced the radiator.", 60 },
                    { 441, "Checked and replaced worn wheel studs.", 59 },
                    { 442, "Inspected and replaced worn exhaust system components.", 58 },
                    { 443, "Performed engine valve adjustment.", 57 },
                    { 444, "Replaced the alternator.", 56 },
                    { 445, "Checked and replaced worn drive belts tensioner.", 55 },
                    { 446, "Inspected and replaced worn fuel injectors.", 54 },
                    { 447, "Performed power steering rack and pinion replacement.", 53 },
                    { 448, "Replaced the timing belt.", 52 },
                    { 449, "Checked and replaced worn engine mounts.", 51 },
                    { 450, "Inspected and replaced worn brake hoses.", 50 },
                    { 451, "Performed wheel bearing replacement.", 50 },
                    { 452, "Replaced the radiator hose.", 49 },
                    { 453, "Checked and replaced worn timing chain.", 48 },
                    { 454, "Inspected and replaced worn camshaft position sensor.", 47 },
                    { 455, "Performed brake master cylinder replacement.", 46 },
                    { 456, "Replaced the throttle position sensor.", 45 },
                    { 457, "Checked and replaced worn transmission mount.", 44 },
                    { 458, "Inspected and replaced worn engine control module (ECM).", 43 },
                    { 459, "Performed differential fluid flush and replacement.", 42 },
                    { 460, "Replaced the power steering pump.", 41 },
                    { 461, "Checked and replaced worn fuel pressure regulator.", 40 },
                    { 462, "Inspected and replaced worn ignition switch.", 39 },
                    { 463, "Performed brake booster replacement.", 38 },
                    { 464, "Replaced the engine mount.", 37 },
                    { 465, "Checked and replaced worn exhaust manifold gasket.", 36 },
                    { 466, "Inspected and replaced worn intake manifold gasket.", 35 },
                    { 467, "Performed fuel injector cleaning and service.", 34 },
                    { 468, "Replaced the drive shaft.", 33 },
                    { 469, "Checked and replaced worn fuel tank.", 32 },
                    { 470, "Inspected and replaced worn steering gear box.", 31 },
                    { 471, "Performed thermostat housing replacement.", 30 },
                    { 472, "Replaced the ignition coil pack.", 29 },
                    { 473, "Checked and replaced worn valve cover gasket.", 28 },
                    { 474, "Inspected and replaced worn drive belt tensioner.", 27 },
                    { 475, "Performed brake proportioning valve replacement.", 26 },
                    { 476, "Replaced the oxygen sensor.", 25 },
                    { 477, "Checked and replaced worn serpentine belt.", 24 },
                    { 478, "Inspected and replaced worn water pump.", 23 },
                    { 479, "Performed throttle body sensor replacement.", 22 },
                    { 480, "Replaced the brake caliper.", 21 },
                    { 481, "Checked and replaced worn spark plugs.", 20 },
                    { 482, "Inspected and replaced worn fuel filter.", 19 },
                    { 483, "Performed shock absorber replacement.", 18 },
                    { 484, "Replaced the transmission mount.", 17 },
                    { 485, "Checked and replaced worn throttle body.", 16 },
                    { 486, "Inspected and replaced worn ignition module.", 15 },
                    { 487, "Performed fuel pump relay replacement.", 14 },
                    { 488, "Replaced the starter motor.", 13 },
                    { 489, "Checked and replaced worn brake pads.", 12 },
                    { 490, "Inspected and replaced worn radiator fan.", 11 },
                    { 491, "Performed alternator belt replacement.", 10 },
                    { 492, "Replaced the camshaft position sensor.", 9 },
                    { 493, "Checked and replaced worn power steering hose.", 8 },
                    { 494, "Inspected and replaced worn wheel bearing hub assembly.", 7 },
                    { 495, "Performed EGR valve replacement.", 6 },
                    { 496, "Replaced the thermostat.", 5 },
                    { 497, "Checked and replaced worn ignition spark plug wires.", 4 },
                    { 498, "Inspected and replaced worn fuel pressure sensor.", 3 },
                    { 499, "Performed brake fluid flush and replacement.", 2 },
                    { 500, "Replaced the serpentine belt tensioner.", 1 }
                });

            migrationBuilder.InsertData(
                table: "PreferredAppointmentDates",
                columns: new[] { "ID", "InquiryID", "PreferredDate" },
                values: new object[,]
                {
                    { 7, 4, new DateTime(2023, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, 4, new DateTime(2023, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "RepairFiles",
                columns: new[] { "ID", "FilePath", "FileType", "RepairID" },
                values: new object[,]
                {
                    { 1, "files/repairs/repair34123_doc1.pdf", "Document", 1 },
                    { 2, "files/repairs/repair34123_img1.png", "Image", 1 },
                    { 3, "files/repairs/repair34123_doc2.doc", "Document", 1 },
                    { 4, "files/repairs/repair34124_img1.jpg", "Image", 2 },
                    { 5, "files/repairs/repair34124_img2.png", "Image", 2 },
                    { 6, "files/repairs/repair34125_doc1.docx", "Document", 3 },
                    { 7, "files/repairs/repair34125_img1.jpg", "Image", 3 },
                    { 8, "files/repairs/repair34125_img2.jpg", "Image", 3 },
                    { 9, "files/repairs/repair34125_img3.jpg", "Image", 3 },
                    { 10, "files/repairs/repair34126_img1.png", "Image", 4 },
                    { 11, "files/repairs/repair34126_img2.png", "Image", 4 },
                    { 12, "files/repairs/repair34126_img3.png", "Image", 4 },
                    { 13, "files/repairs/repair34126_doc1.pdf", "Document", 4 },
                    { 14, "files/repairs/repair34127_img1.jpg", "Image", 5 },
                    { 15, "files/repairs/repair34127_doc1.pdf", "Document", 5 },
                    { 16, "files/repairs/repair34127_img2.jpg", "Image", 5 },
                    { 17, "files/repairs/repair34128_doc1.docx", "Document", 6 },
                    { 18, "files/repairs/repair34128_img1.png", "Image", 6 },
                    { 19, "files/repairs/repair34129_img1.jpg", "Image", 7 },
                    { 20, "files/repairs/repair34129_doc1.pdf", "Document", 7 },
                    { 21, "files/repairs/repair34130_img1.png", "Image", 8 },
                    { 22, "files/repairs/repair34130_doc1.pdf", "Document", 8 },
                    { 23, "files/repairs/repair34130_img2.jpg", "Image", 8 },
                    { 24, "files/repairs/repair34131_img1.png", "Image", 9 },
                    { 25, "files/repairs/repair34131_img2.jpg", "Image", 9 },
                    { 26, "files/repairs/repair34131_doc1.docx", "Document", 9 },
                    { 27, "files/repairs/repair34132_doc1.pdf", "Document", 10 },
                    { 28, "files/repairs/repair34132_img1.jpg", "Image", 10 },
                    { 29, "files/repairs/repair34133_img1.jpg", "Image", 11 },
                    { 30, "files/repairs/repair34133_img2.png", "Image", 11 },
                    { 31, "files/repairs/repair34134_doc1.doc", "Document", 12 },
                    { 32, "files/repairs/repair34134_img1.png", "Image", 12 },
                    { 33, "files/repairs/repair34135_img1.jpg", "Image", 13 },
                    { 34, "files/repairs/repair34135_doc1.pdf", "Document", 13 },
                    { 35, "files/repairs/repair34135_img2.jpg", "Image", 13 },
                    { 36, "files/repairs/repair34136_img1.jpg", "Image", 14 },
                    { 37, "files/repairs/repair34136_img2.png", "Image", 14 },
                    { 38, "files/repairs/repair34137_doc1.docx", "Document", 15 },
                    { 39, "files/repairs/repair34137_img1.jpg", "Image", 15 },
                    { 40, "files/repairs/repair34137_img2.jpg", "Image", 15 },
                    { 41, "files/repairs/repair34138_img1.png", "Image", 16 },
                    { 42, "files/repairs/repair34138_doc1.docx", "Document", 16 },
                    { 43, "files/repairs/repair34138_img2.jpg", "Image", 16 },
                    { 44, "files/repairs/repair34139_img1.png", "Image", 17 },
                    { 45, "files/repairs/repair34139_img2.jpg", "Image", 17 },
                    { 46, "files/repairs/repair34139_doc1.pdf", "Document", 17 },
                    { 47, "files/repairs/repair34140_doc1.doc", "Document", 18 },
                    { 48, "files/repairs/repair34140_img1.png", "Image", 18 },
                    { 49, "files/repairs/repair34141_img1.jpg", "Image", 19 },
                    { 50, "files/repairs/repair34141_img2.png", "Image", 19 },
                    { 51, "files/repairs/repair34142_doc1.docx", "Document", 20 },
                    { 52, "files/repairs/repair34142_img1.jpg", "Image", 20 },
                    { 53, "files/repairs/repair34142_img2.jpg", "Image", 20 },
                    { 54, "files/repairs/repair34143_img1.png", "Image", 21 },
                    { 55, "files/repairs/repair34143_img2.jpg", "Image", 21 },
                    { 56, "files/repairs/repair34143_doc1.pdf", "Document", 21 },
                    { 57, "files/repairs/repair34144_doc1.doc", "Document", 22 },
                    { 58, "files/repairs/repair34144_img1.png", "Image", 22 },
                    { 59, "files/repairs/repair34145_img1.jpg", "Image", 23 },
                    { 60, "files/repairs/repair34145_img2.png", "Image", 23 },
                    { 61, "files/repairs/repair34146_img1.jpg", "Image", 24 },
                    { 62, "files/repairs/repair34146_doc1.docx", "Document", 24 },
                    { 63, "files/repairs/repair34147_img1.png", "Image", 25 },
                    { 64, "files/repairs/repair34147_img2.jpg", "Image", 25 },
                    { 65, "files/repairs/repair34148_doc1.doc", "Document", 26 },
                    { 66, "files/repairs/repair34148_img1.jpg", "Image", 26 },
                    { 67, "files/repairs/repair34148_img2.jpg", "Image", 26 },
                    { 68, "files/repairs/repair34148_img3.png", "Image", 26 },
                    { 69, "files/repairs/repair34149_doc1.pdf", "Document", 27 },
                    { 70, "files/repairs/repair34149_img1.jpg", "Image", 27 },
                    { 71, "files/repairs/repair34150_img1.png", "Image", 28 },
                    { 72, "files/repairs/repair34150_doc1.docx", "Document", 28 },
                    { 73, "files/repairs/repair34150_img2.jpg", "Image", 28 },
                    { 74, "files/repairs/repair34151_img1.jpg", "Image", 29 },
                    { 75, "files/repairs/repair34151_img2.png", "Image", 29 },
                    { 76, "files/repairs/repair34151_doc1.pdf", "Document", 29 },
                    { 77, "files/repairs/repair34151_img3.jpg", "Image", 29 },
                    { 78, "files/repairs/repair34152_doc1.doc", "Document", 30 },
                    { 79, "files/repairs/repair34152_img1.jpg", "Image", 30 },
                    { 80, "files/repairs/repair34153_img1.png", "Image", 31 },
                    { 81, "files/repairs/repair34153_img2.jpg", "Image", 31 },
                    { 82, "files/repairs/repair34153_img3.png", "Image", 31 },
                    { 83, "files/repairs/repair34154_doc1.pdf", "Document", 32 },
                    { 84, "files/repairs/repair34154_img1.jpg", "Image", 32 },
                    { 85, "files/repairs/repair34155_img1.png", "Image", 33 },
                    { 86, "files/repairs/repair34155_doc1.docx", "Document", 33 },
                    { 87, "files/repairs/repair34155_img2.jpg", "Image", 33 },
                    { 88, "files/repairs/repair34156_img1.jpg", "Image", 34 },
                    { 89, "files/repairs/repair34156_img2.png", "Image", 34 },
                    { 90, "files/repairs/repair34156_doc1.pdf", "Document", 34 },
                    { 91, "files/repairs/repair34157_img1.png", "Image", 35 },
                    { 92, "files/repairs/repair34157_doc1.docx", "Document", 35 },
                    { 93, "files/repairs/repair34157_img2.jpg", "Image", 35 },
                    { 94, "files/repairs/repair34157_img3.png", "Image", 35 },
                    { 95, "files/repairs/repair34158_doc1.pdf", "Document", 36 },
                    { 96, "files/repairs/repair34158_img1.jpg", "Image", 36 },
                    { 97, "files/repairs/repair34159_img1.png", "Image", 37 },
                    { 98, "files/repairs/repair34159_doc1.docx", "Document", 37 },
                    { 99, "files/repairs/repair34159_img2.jpg", "Image", 37 },
                    { 100, "files/repairs/repair34159_img3.png", "Image", 37 },
                    { 101, "files/repairs/repair34160_img1.jpg", "Image", 38 },
                    { 102, "files/repairs/repair34160_img2.png", "Image", 38 },
                    { 103, "files/repairs/repair34160_doc1.pdf", "Document", 38 },
                    { 104, "files/repairs/repair34160_img3.jpg", "Image", 38 },
                    { 105, "files/repairs/repair34160_img4.png", "Image", 38 },
                    { 106, "files/repairs/repair34160_doc2.doc", "Document", 38 },
                    { 107, "files/repairs/repair34160_img5.jpg", "Image", 38 },
                    { 108, "files/repairs/repair34160_img6.png", "Image", 38 },
                    { 109, "files/repairs/repair34160_img7.jpg", "Image", 38 },
                    { 110, "files/repairs/repair34160_doc3.pdf", "Document", 38 },
                    { 111, "files/repairs/repair34161_img1.jpg", "Image", 39 },
                    { 112, "files/repairs/repair34161_doc1.docx", "Document", 39 },
                    { 113, "files/repairs/repair34161_img2.png", "Image", 39 },
                    { 114, "files/repairs/repair34162_img1.png", "Image", 40 },
                    { 115, "files/repairs/repair34162_doc1.pdf", "Document", 40 },
                    { 116, "files/repairs/repair34162_img2.jpg", "Image", 40 },
                    { 117, "files/repairs/repair34162_img3.png", "Image", 40 },
                    { 118, "files/repairs/repair34162_img4.jpg", "Image", 40 },
                    { 119, "files/repairs/repair34162_doc2.docx", "Document", 40 },
                    { 120, "files/repairs/repair34162_img5.png", "Image", 40 },
                    { 201, "files/repairs/repair34167_img1.png", "Image", 46 },
                    { 202, "files/repairs/repair34167_doc1.docx", "Document", 46 },
                    { 203, "files/repairs/repair34167_img2.jpg", "Image", 46 },
                    { 204, "files/repairs/repair34168_img1.png", "Image", 47 },
                    { 205, "files/repairs/repair34168_doc1.pdf", "Document", 47 },
                    { 206, "files/repairs/repair34168_img2.jpg", "Image", 47 },
                    { 207, "files/repairs/repair34169_img1.jpg", "Image", 48 },
                    { 208, "files/repairs/repair34169_doc1.docx", "Document", 48 },
                    { 209, "files/repairs/repair34170_img1.png", "Image", 49 },
                    { 210, "files/repairs/repair34170_doc1.pdf", "Document", 49 },
                    { 211, "files/repairs/repair34171_img1.jpg", "Image", 50 },
                    { 212, "files/repairs/repair34171_doc1.docx", "Document", 50 }
                });

            migrationBuilder.InsertData(
                table: "DamageReportPhotos",
                columns: new[] { "ID", "DamageReportID", "FilePath" },
                values: new object[,]
                {
                    { 1, 1, "files/damagereports/photos/damrep_34123_img1.png" },
                    { 2, 1, "files/damagereports/photos/damrep_34123_img2.png" },
                    { 3, 1, "files/damagereports/photos/damrep_34123_img3.png" },
                    { 4, 1, "files/damagereports/photos/damrep_34123_img4.jpg" },
                    { 5, 2, "files/damagereports/photos/damrep_34124_img1.png" },
                    { 6, 2, "files/damagereports/photos/damrep_34124_img2.jpg" },
                    { 7, 2, "files/damagereports/photos/damrep_34124_img3.bmp" },
                    { 8, 2, "files/damagereports/photos/damrep_34124_img3.bmp" },
                    { 9, 3, "files/damagereports/photos/damrep_34125_img1.png" },
                    { 10, 3, "files/damagereports/photos/damrep_34125_img2.png" },
                    { 11, 3, "files/damagereports/photos/damrep_34125_img3.png" },
                    { 12, 3, "files/damagereports/photos/damrep_34125_img4.jpg" },
                    { 13, 4, "files/damagereports/photos/damrep_34126_img1.png" },
                    { 14, 4, "files/damagereports/photos/damrep_34126_img2.jpg" },
                    { 15, 4, "files/damagereports/photos/damrep_34126_img3.png" },
                    { 16, 4, "files/damagereports/photos/damrep_34126_img4.jpg" },
                    { 17, 5, "files/damagereports/photos/damrep_34127_img1.jpg" },
                    { 18, 5, "files/damagereports/photos/damrep_34127_img2.png" },
                    { 19, 5, "files/damagereports/photos/damrep_34127_img3.jpg" },
                    { 20, 5, "files/damagereports/photos/damrep_34127_img4.png" },
                    { 21, 6, "files/damagereports/photos/damrep_34128_img1.png" },
                    { 22, 6, "files/damagereports/photos/damrep_34128_img2.jpg" },
                    { 23, 6, "files/damagereports/photos/damrep_34128_img3.png" },
                    { 24, 6, "files/damagereports/photos/damrep_34128_img4.jpg" },
                    { 25, 7, "files/damagereports/photos/damrep_34129_img1.jpg" },
                    { 26, 7, "files/damagereports/photos/damrep_34129_img2.png" },
                    { 27, 7, "files/damagereports/photos/damrep_34129_img3.jpg" },
                    { 28, 7, "files/damagereports/photos/damrep_34129_img4.png" },
                    { 29, 8, "files/damagereports/photos/damrep_34130_img1.jpg" },
                    { 30, 8, "files/damagereports/photos/damrep_34130_img2.png" },
                    { 31, 8, "files/damagereports/photos/damrep_34130_img3.jpg" },
                    { 32, 8, "files/damagereports/photos/damrep_34130_img4.png" },
                    { 33, 9, "files/damagereports/photos/damrep_34131_img1.jpg" },
                    { 34, 9, "files/damagereports/photos/damrep_34131_img2.png" },
                    { 35, 9, "files/damagereports/photos/damrep_34131_img3.jpg" },
                    { 36, 9, "files/damagereports/photos/damrep_34131_img4.png" },
                    { 37, 10, "files/damagereports/photos/damrep_34132_img1.png" },
                    { 38, 10, "files/damagereports/photos/damrep_34132_img2.jpg" },
                    { 39, 10, "files/damagereports/photos/damrep_34132_img3.png" },
                    { 40, 10, "files/damagereports/photos/damrep_34132_img4.jpg" },
                    { 41, 11, "files/damagereports/photos/damrep_34133_img1.jpg" },
                    { 42, 11, "files/damagereports/photos/damrep_34133_img2.png" },
                    { 43, 11, "files/damagereports/photos/damrep_34133_img3.jpg" },
                    { 44, 11, "files/damagereports/photos/damrep_34133_img4.png" },
                    { 45, 12, "files/damagereports/photos/damrep_34134_img1.png" },
                    { 46, 12, "files/damagereports/photos/damrep_34134_img2.jpg" },
                    { 47, 12, "files/damagereports/photos/damrep_34134_img3.png" },
                    { 48, 12, "files/damagereports/photos/damrep_34134_img4.jpg" },
                    { 49, 13, "files/damagereports/photos/damrep_34135_img1.png" },
                    { 50, 13, "files/damagereports/photos/damrep_34135_img2.jpg" },
                    { 51, 13, "files/damagereports/photos/damrep_34135_img3.png" },
                    { 52, 13, "files/damagereports/photos/damrep_34135_img4.jpg" },
                    { 53, 14, "files/damagereports/photos/damrep_34136_img1.jpg" },
                    { 54, 14, "files/damagereports/photos/damrep_34136_img2.png" },
                    { 55, 14, "files/damagereports/photos/damrep_34136_img3.jpg" },
                    { 56, 14, "files/damagereports/photos/damrep_34136_img4.png" },
                    { 57, 15, "files/damagereports/photos/damrep_34137_img1.jpg" },
                    { 58, 15, "files/damagereports/photos/damrep_34137_img2.png" },
                    { 59, 15, "files/damagereports/photos/damrep_34137_img3.jpg" },
                    { 60, 15, "files/damagereports/photos/damrep_34137_img4.png" },
                    { 61, 16, "files/damagereports/photos/damrep_34138_img1.png" },
                    { 62, 16, "files/damagereports/photos/damrep_34138_img2.jpg" },
                    { 63, 16, "files/damagereports/photos/damrep_34138_img3.png" },
                    { 64, 16, "files/damagereports/photos/damrep_34138_img4.jpg" },
                    { 65, 17, "files/damagereports/photos/damrep_34139_img1.jpg" },
                    { 66, 17, "files/damagereports/photos/damrep_34139_img2.png" },
                    { 67, 17, "files/damagereports/photos/damrep_34139_img3.jpg" },
                    { 68, 17, "files/damagereports/photos/damrep_34139_img4.png" },
                    { 69, 18, "files/damagereports/photos/damrep_34140_img1.jpg" },
                    { 70, 18, "files/damagereports/photos/damrep_34140_img2.png" },
                    { 71, 18, "files/damagereports/photos/damrep_34140_img3.jpg" },
                    { 72, 18, "files/damagereports/photos/damrep_34140_img4.png" },
                    { 73, 19, "files/damagereports/photos/damrep_34141_img1.jpg" },
                    { 74, 19, "files/damagereports/photos/damrep_34141_img2.png" },
                    { 75, 19, "files/damagereports/photos/damrep_34141_img3.jpg" },
                    { 76, 19, "files/damagereports/photos/damrep_34141_img4.png" },
                    { 77, 20, "files/damagereports/photos/damrep_34142_img1.png" },
                    { 78, 20, "files/damagereports/photos/damrep_34142_img2.jpg" },
                    { 79, 20, "files/damagereports/photos/damrep_34142_img3.png" },
                    { 80, 20, "files/damagereports/photos/damrep_34142_img4.jpg" },
                    { 81, 21, "files/damagereports/photos/damrep_34143_img1.jpg" },
                    { 82, 21, "files/damagereports/photos/damrep_34143_img2.png" },
                    { 83, 21, "files/damagereports/photos/damrep_34143_img3.jpg" },
                    { 84, 21, "files/damagereports/photos/damrep_34143_img4.png" },
                    { 85, 22, "files/damagereports/photos/damrep_34144_img1.png" },
                    { 86, 22, "files/damagereports/photos/damrep_34144_img2.jpg" },
                    { 87, 22, "files/damagereports/photos/damrep_34144_img3.png" },
                    { 88, 22, "files/damagereports/photos/damrep_34144_img4.jpg" },
                    { 89, 23, "files/damagereports/photos/damrep_34145_img1.jpg" },
                    { 90, 23, "files/damagereports/photos/damrep_34145_img2.png" },
                    { 91, 23, "files/damagereports/photos/damrep_34145_img3.jpg" },
                    { 92, 23, "files/damagereports/photos/damrep_34145_img4.png" },
                    { 93, 24, "files/damagereports/photos/damrep_34146_img1.png" },
                    { 94, 24, "files/damagereports/photos/damrep_34146_img2.jpg" },
                    { 95, 24, "files/damagereports/photos/damrep_34146_img3.png" },
                    { 96, 24, "files/damagereports/photos/damrep_34146_img4.jpg" },
                    { 97, 25, "files/damagereports/photos/damrep_34147_img1.jpg" },
                    { 98, 25, "files/damagereports/photos/damrep_34147_img2.png" },
                    { 99, 25, "files/damagereports/photos/damrep_34147_img3.jpg" },
                    { 100, 25, "files/damagereports/photos/damrep_34147_img4.png" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_DamageReportPhotos_DamageReportID",
                table: "DamageReportPhotos",
                column: "DamageReportID");

            migrationBuilder.CreateIndex(
                name: "IX_DamageReports_DamageRepairTypeID",
                table: "DamageReports",
                column: "DamageRepairTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_DamageReports_InspectionReportID",
                table: "DamageReports",
                column: "InspectionReportID");

            migrationBuilder.CreateIndex(
                name: "IX_DamageReports_VehiclePartID",
                table: "DamageReports",
                column: "VehiclePartID");

            migrationBuilder.CreateIndex(
                name: "IX_DriverFuelCards_DriverID",
                table: "DriverFuelCards",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_DriverFuelCards_FuelCardID",
                table: "DriverFuelCards",
                column: "FuelCardID");

            migrationBuilder.CreateIndex(
                name: "IX_DriverVehicles_DriverID",
                table: "DriverVehicles",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_DriverVehicles_VehicleID",
                table: "DriverVehicles",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_FuelCardsExtraServices_ExtraServiceID",
                table: "FuelCardsExtraServices",
                column: "ExtraServiceID");

            migrationBuilder.CreateIndex(
                name: "IX_FuelCardsExtraServices_FuelCardID",
                table: "FuelCardsExtraServices",
                column: "FuelCardID");

            migrationBuilder.CreateIndex(
                name: "IX_Inquiries_DriverID",
                table: "Inquiries",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_Inquiries_InquiryTypeID",
                table: "Inquiries",
                column: "InquiryTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_Inquiries_VehicleID",
                table: "Inquiries",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionReports_DriverID",
                table: "InspectionReports",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_InspectionReports_VehicleID",
                table: "InspectionReports",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_LicensePlates_VehicleID",
                table: "LicensePlates",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Login_DriverID",
                table: "Login",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_GarageID",
                table: "Maintenances",
                column: "GarageID");

            migrationBuilder.CreateIndex(
                name: "IX_Maintenances_VehicleID",
                table: "Maintenances",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_MaintenanceTasks_MaintenanceID",
                table: "MaintenanceTasks",
                column: "MaintenanceID");

            migrationBuilder.CreateIndex(
                name: "IX_Mileages_VehicleID",
                table: "Mileages",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_PreferredAppointmentDates_InquiryID",
                table: "PreferredAppointmentDates",
                column: "InquiryID");

            migrationBuilder.CreateIndex(
                name: "IX_RepairFiles_RepairID",
                table: "RepairFiles",
                column: "RepairID");

            migrationBuilder.CreateIndex(
                name: "IX_Repairs_DamageReportID",
                table: "Repairs",
                column: "DamageReportID",
                unique: true,
                filter: "[DamageReportID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Repairs_InsuranceCompanyID",
                table: "Repairs",
                column: "InsuranceCompanyID");

            migrationBuilder.CreateIndex(
                name: "IX_Repairs_VehicleID",
                table: "Repairs",
                column: "VehicleID");

            migrationBuilder.CreateIndex(
                name: "IX_Vehicles_VehicleTypeID",
                table: "Vehicles",
                column: "VehicleTypeID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DamageReportPhotos");

            migrationBuilder.DropTable(
                name: "DriverFuelCards");

            migrationBuilder.DropTable(
                name: "DriverVehicles");

            migrationBuilder.DropTable(
                name: "FuelCardsExtraServices");

            migrationBuilder.DropTable(
                name: "LicensePlates");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "MaintenanceTasks");

            migrationBuilder.DropTable(
                name: "Mileages");

            migrationBuilder.DropTable(
                name: "PreferredAppointmentDates");

            migrationBuilder.DropTable(
                name: "RepairFiles");

            migrationBuilder.DropTable(
                name: "ExtraServices");

            migrationBuilder.DropTable(
                name: "FuelCards");

            migrationBuilder.DropTable(
                name: "Maintenances");

            migrationBuilder.DropTable(
                name: "Inquiries");

            migrationBuilder.DropTable(
                name: "Repairs");

            migrationBuilder.DropTable(
                name: "Garages");

            migrationBuilder.DropTable(
                name: "InquiryTypes");

            migrationBuilder.DropTable(
                name: "DamageReports");

            migrationBuilder.DropTable(
                name: "InsuranceCompanies");

            migrationBuilder.DropTable(
                name: "DamageRepairTypes");

            migrationBuilder.DropTable(
                name: "InspectionReports");

            migrationBuilder.DropTable(
                name: "VehicleParts");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Vehicles");

            migrationBuilder.DropTable(
                name: "VehicleTypes");
        }
    }
}
