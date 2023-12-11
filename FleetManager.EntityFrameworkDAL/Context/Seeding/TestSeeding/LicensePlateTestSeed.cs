using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class LicensePlateTestSeed {
    public static void TestSeedLicensePlate(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<LicensePlate>().HasData(
            new LicensePlate
            {
                ID = 1,
                VehicleID = 1,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2023, 1, 31),
                LicensePlateNumber = "ABC123"
            },
            new LicensePlate
            {
                ID = 2,
                VehicleID = 2,
                ValidityStartDate = new DateTime(2022, 3, 15),
                ValidityEndDate = new DateTime(2023, 3, 14),
                LicensePlateNumber = "DEF456"
            },
            new LicensePlate
            {
                ID = 3,
                VehicleID = 3,
                ValidityStartDate = new DateTime(2022, 5, 20),
                ValidityEndDate = new DateTime(2023, 5, 19),
                LicensePlateNumber = "GHI789"
            },
            new LicensePlate
            {
                ID = 4,
                VehicleID = 4,
                ValidityStartDate = new DateTime(2022, 7, 10),
                ValidityEndDate = new DateTime(2023, 7, 9),
                LicensePlateNumber = "JKL012"
            },
            new LicensePlate
            {
                ID = 5,
                VehicleID = 5,
                ValidityStartDate = new DateTime(2022, 9, 5),
                ValidityEndDate = new DateTime(2023, 9, 4),
                LicensePlateNumber = "MNO345"
            },
            new LicensePlate
            {
                ID = 6,
                VehicleID = 6,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2023, 1, 31),
                LicensePlateNumber = "PQR678"
            },
            new LicensePlate
            {
                ID = 7,
                VehicleID = 6,
                ValidityStartDate = new DateTime(2023, 2, 1),
                ValidityEndDate = new DateTime(2024, 1, 31),
                LicensePlateNumber = "STU901"
            },
            new LicensePlate
            {
                ID = 8,
                VehicleID = 6,
                ValidityStartDate = new DateTime(2024, 2, 1),
                ValidityEndDate = new DateTime(2025, 1, 31),
                LicensePlateNumber = "VWX234"
            },
            new LicensePlate
            {
                ID = 9,
                VehicleID = 7,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2022, 6, 30),
                LicensePlateNumber = "YZA567"
            },
            new LicensePlate
            {
                ID = 10,
                VehicleID = 7,
                ValidityStartDate = new DateTime(2022, 7, 1),
                ValidityEndDate = new DateTime(2022, 12, 31),
                LicensePlateNumber = "BCD890"
            },
            new LicensePlate
            {
                ID = 11,
                VehicleID = 7,
                ValidityStartDate = new DateTime(2023, 1, 1),
                ValidityEndDate = new DateTime(2023, 6, 30),
                LicensePlateNumber = "EFG123"
            },
            new LicensePlate
            {
                ID = 12,
                VehicleID = 8,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2022, 12, 31),
                LicensePlateNumber = "HIJ456"
            },
            new LicensePlate
            {
                ID = 13,
                VehicleID = 8,
                ValidityStartDate = new DateTime(2023, 1, 1),
                ValidityEndDate = new DateTime(2023, 12, 31),
                LicensePlateNumber = "KLM789"
            },
            new LicensePlate
            {
                ID = 14,
                VehicleID = 8,
                ValidityStartDate = new DateTime(2024, 1, 1),
                ValidityEndDate = new DateTime(2024, 12, 31),
                LicensePlateNumber = "NOP012"
            },
            new LicensePlate
            {
                ID = 15,
                VehicleID = 9,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2022, 12, 31),
                LicensePlateNumber = "QRS345"
            },
            new LicensePlate
            {
                ID = 16,
                VehicleID = 9,
                ValidityStartDate = new DateTime(2023, 1, 1),
                ValidityEndDate = new DateTime(2023, 12, 31),
                LicensePlateNumber = "TUV678"
            },
            new LicensePlate
            {
                ID = 17,
                VehicleID = 9,
                ValidityStartDate = new DateTime(2024, 1, 1),
                ValidityEndDate = new DateTime(2024, 12, 31),
                LicensePlateNumber = "WXY901"
            },
            new LicensePlate
            {
                ID = 18,
                VehicleID = 10,
                ValidityStartDate = new DateTime(2023, 7, 1),
                ValidityEndDate = new DateTime(2023, 12, 31),
                LicensePlateNumber = "CDE567"
            },
            new LicensePlate
            {
                ID = 19,
                VehicleID = 10,
                ValidityStartDate = new DateTime(2024, 1, 1),
                ValidityEndDate = new DateTime(2024, 6, 30),
                LicensePlateNumber = "FGH890"
            },
            new LicensePlate
            {
                ID = 20,
                VehicleID = 11,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2022, 12, 31),
                LicensePlateNumber = "IJK123"
            },
            new LicensePlate
            {
                ID = 21,
                VehicleID = 11,
                ValidityStartDate = new DateTime(2023, 1, 1),
                ValidityEndDate = new DateTime(2023, 12, 31),
                LicensePlateNumber = "LMN456"
            },
            new LicensePlate
            {
                ID = 22,
                VehicleID = 11,
                ValidityStartDate = new DateTime(2024, 1, 1),
                ValidityEndDate = new DateTime(2024, 12, 31),
                LicensePlateNumber = "OPQ789"
            },
            new LicensePlate
            {
                ID = 23,
                VehicleID = 12,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2022, 6, 30),
                LicensePlateNumber = "RST234"
            },
            new LicensePlate
            {
                ID = 24,
                VehicleID = 12,
                ValidityStartDate = new DateTime(2023, 7, 1),
                ValidityEndDate = new DateTime(2023, 12, 31),
                LicensePlateNumber = "UVW567"
            },
            new LicensePlate
            {
                ID = 25,
                VehicleID = 12,
                ValidityStartDate = new DateTime(2024, 1, 1),
                ValidityEndDate = new DateTime(2024, 6, 30),
                LicensePlateNumber = "XYZ890"
            },
            new LicensePlate
            {
                ID = 26,
                VehicleID = 13,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2022, 12, 31),
                LicensePlateNumber = "ABC123"
            },
            new LicensePlate
            {
                ID = 27,
                VehicleID = 13,
                ValidityStartDate = new DateTime(2023, 1, 1),
                ValidityEndDate = new DateTime(2023, 12, 31),
                LicensePlateNumber = "DEF456"
            },
            new LicensePlate
            {
                ID = 28,
                VehicleID = 13,
                ValidityStartDate = new DateTime(2024, 1, 1),
                ValidityEndDate = new DateTime(2024, 12, 31),
                LicensePlateNumber = "GHI789"
            },
            new LicensePlate
            {
                ID = 29,
                VehicleID = 14,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2022, 6, 30),
                LicensePlateNumber = "JKL234"
            },
            new LicensePlate
            {
                ID = 30,
                VehicleID = 14,
                ValidityStartDate = new DateTime(2023, 7, 1),
                ValidityEndDate = new DateTime(2023, 12, 31),
                LicensePlateNumber = "MNO567"
            },
            new LicensePlate
            {
                ID = 31,
                VehicleID = 14,
                ValidityStartDate = new DateTime(2024, 1, 1),
                ValidityEndDate = new DateTime(2024, 6, 30),
                LicensePlateNumber = "PQR890"
            },
            new LicensePlate
            {
                ID = 32,
                VehicleID = 15,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2022, 12, 31),
                LicensePlateNumber = "STU123"
            },
            new LicensePlate
            {
                ID = 33,
                VehicleID = 15,
                ValidityStartDate = new DateTime(2023, 1, 1),
                ValidityEndDate = new DateTime(2023, 12, 31),
                LicensePlateNumber = "VWX456"
            },
            new LicensePlate
            {
                ID = 34,
                VehicleID = 15,
                ValidityStartDate = new DateTime(2024, 1, 1),
                ValidityEndDate = new DateTime(2024, 12, 31),
                LicensePlateNumber = "YZA789"
            },
            new LicensePlate
            {
                ID = 35,
                VehicleID = 16,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2022, 6, 30),
                LicensePlateNumber = "BCD234"
            },
            new LicensePlate
            {
                ID = 36,
                VehicleID = 16,
                ValidityStartDate = new DateTime(2023, 7, 1),
                ValidityEndDate = new DateTime(2023, 12, 31),
                LicensePlateNumber = "EFG567"
            },
            new LicensePlate
            {
                ID = 37,
                VehicleID = 16,
                ValidityStartDate = new DateTime(2024, 1, 1),
                ValidityEndDate = new DateTime(2024, 6, 30),
                LicensePlateNumber = "HIJ890"
            },
            new LicensePlate
            {
                ID = 38,
                VehicleID = 17,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2022, 12, 31),
                LicensePlateNumber = "KLM123"
            },
            new LicensePlate
            {
                ID = 39,
                VehicleID = 17,
                ValidityStartDate = new DateTime(2023, 1, 1),
                ValidityEndDate = new DateTime(2023, 12, 31),
                LicensePlateNumber = "NOP456"
            },
            new LicensePlate
            {
                ID = 40,
                VehicleID = 17,
                ValidityStartDate = new DateTime(2024, 1, 1),
                ValidityEndDate = new DateTime(2024, 12, 31),
                LicensePlateNumber = "QRS789"
            },
            new LicensePlate
            {
                ID = 41,
                VehicleID = 18,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2022, 6, 30),
                LicensePlateNumber = "TUV234"
            },
            new LicensePlate
            {
                ID = 42,
                VehicleID = 18,
                ValidityStartDate = new DateTime(2023, 7, 1),
                ValidityEndDate = new DateTime(2023, 12, 31),
                LicensePlateNumber = "WXY567"
            },
            new LicensePlate
            {
                ID = 43,
                VehicleID = 18,
                ValidityStartDate = new DateTime(2024, 1, 1),
                ValidityEndDate = new DateTime(2024, 6, 30),
                LicensePlateNumber = "ZAB890"
            },
            new LicensePlate
            {
                ID = 44,
                VehicleID = 19,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2022, 12, 31),
                LicensePlateNumber = "CDE123"
            },
            new LicensePlate
            {
                ID = 45,
                VehicleID = 19,
                ValidityStartDate = new DateTime(2023, 1, 1),
                ValidityEndDate = new DateTime(2023, 12, 31),
                LicensePlateNumber = "FGH456"
            },
            new LicensePlate
            {
                ID = 46,
                VehicleID = 19,
                ValidityStartDate = new DateTime(2024, 1, 1),
                ValidityEndDate = new DateTime(2024, 12, 31),
                LicensePlateNumber = "IJK789"
            },
            new LicensePlate
            {
                ID = 47,
                VehicleID = 20,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2022, 12, 31),
                LicensePlateNumber = "LMN123"
            },
            new LicensePlate
            {
                ID = 48,
                VehicleID = 20,
                ValidityStartDate = new DateTime(2023, 1, 1),
                ValidityEndDate = new DateTime(2023, 12, 31),
                LicensePlateNumber = "OPQ456"
            },
            new LicensePlate
            {
                ID = 49,
                VehicleID = 20,
                ValidityStartDate = new DateTime(2024, 1, 1),
                ValidityEndDate = new DateTime(2024, 12, 31),
                LicensePlateNumber = "RST789"
            },
            new LicensePlate
            {
                ID = 50,
                VehicleID = 20,
                ValidityStartDate = new DateTime(2025, 1, 1),
                ValidityEndDate = new DateTime(2025, 12, 31),
                LicensePlateNumber = "UVW012"
            },
            new LicensePlate
            {
                ID = 51,
                VehicleID = 10,
                ValidityStartDate = new DateTime(2022, 1, 1),
                ValidityEndDate = new DateTime(2022, 6, 30),
                LicensePlateNumber = "ZAB234"
            }
        );
    }
}