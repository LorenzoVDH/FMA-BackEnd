using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class RepairTestSeed {
    public static void TestSeedRepair(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Repair>().HasData(
            new Repair()
            {
                ID = 1,
                InsuranceCompanyID = 4,
                RepairDate = new DateTime(2021, 3, 30),
                PaymentDate = new DateTime(2021, 4, 8),
                RepairCost = 400m,
                VehicleID = 7
            },
            new Repair()
            {
                ID = 2,
                InsuranceCompanyID = 7,
                RepairDate = new DateTime(2021, 7, 16),
                PaymentDate = null,
                RepairCost = 300m,
                VehicleID = 4
            },
            new Repair()
            {
                ID = 3,
                InsuranceCompanyID = 3,
                RepairDate = new DateTime(2021, 9, 4),
                PaymentDate = null,
                RepairCost = 800m,
                VehicleID = 7
            },
            new Repair()
            {
                ID = 4,
                InsuranceCompanyID = 5,
                RepairDate = new DateTime(2021, 12, 18),
                PaymentDate = new DateTime(2021, 12, 23),
                RepairCost = 550m,
                VehicleID = 12
            },
            new Repair()
            {
                ID = 5,
                InsuranceCompanyID = 6,
                RepairDate = new DateTime(2021, 2, 5),
                PaymentDate = new DateTime(2021, 2, 10),
                RepairCost = 700m,
                VehicleID = 10
            },
            new Repair()
            {
                ID = 6,
                InsuranceCompanyID = 2,
                RepairDate = new DateTime(2021, 5, 17),
                PaymentDate = new DateTime(2021, 5, 22),
                RepairCost = 900m,
                VehicleID = 17
            },
            new Repair()
            {
                ID = 7,
                InsuranceCompanyID = 8,
                RepairDate = new DateTime(2021, 8, 9),
                PaymentDate = null,
                RepairCost = 600m,
                VehicleID = 19
            },
            new Repair()
            {
                ID = 8,
                InsuranceCompanyID = 9,
                RepairDate = new DateTime(2021, 11, 21),
                PaymentDate = null,
                RepairCost = 450m,
                VehicleID = 8
            },
            new Repair()
            {
                ID = 9,
                InsuranceCompanyID = 4,
                RepairDate = new DateTime(2021, 1, 3),
                PaymentDate = null,
                RepairCost = 550m,
                VehicleID = 11
            },
            new Repair()
            {
                ID = 10,
                InsuranceCompanyID = 5,
                RepairDate = new DateTime(2021, 3, 14),
                PaymentDate = null,
                RepairCost = 350m,
                VehicleID = 18
            },
            new Repair()
            {
                ID = 11,
                InsuranceCompanyID = 10,
                RepairDate = new DateTime(2021, 4, 26),
                PaymentDate = new DateTime(2021, 5, 2),
                RepairCost = 500m,
                VehicleID = 13
            },
            new Repair()
            {
                ID = 12,
                InsuranceCompanyID = 7,
                RepairDate = new DateTime(2021, 6, 9),
                PaymentDate = null,
                RepairCost = 650m,
                VehicleID = 9
            },
            new Repair()
            {
                ID = 13,
                InsuranceCompanyID = 8,
                RepairDate = new DateTime(2021, 8, 21),
                PaymentDate = new DateTime(2021, 8, 28),
                RepairCost = 400m,
                VehicleID = 16
            },
            new Repair()
            {
                ID = 14,
                InsuranceCompanyID = 3,
                RepairDate = new DateTime(2022, 10, 2),
                PaymentDate = null,
                RepairCost = 800m,
                VehicleID = 15
            },
            new Repair()
            {
                ID = 15,
                InsuranceCompanyID = 6,
                RepairDate = new DateTime(2022, 12, 14),
                PaymentDate = null,
                RepairCost = 550m,
                VehicleID = 12
            },
            new Repair()
            {
                ID = 16,
                InsuranceCompanyID = 9,
                RepairDate = new DateTime(2022, 1, 26),
                PaymentDate = new DateTime(2022, 2, 1),
                RepairCost = 700m,
                VehicleID = 11
            },
            new Repair()
            {
                ID = 17,
                InsuranceCompanyID = 4,
                RepairDate = new DateTime(2022, 3, 8),
                PaymentDate = null,
                RepairCost = 450m,
                VehicleID = 14
            },
            new Repair()
            {
                ID = 18,
                InsuranceCompanyID = 2,
                RepairDate = new DateTime(2022, 5, 20),
                PaymentDate = null,
                RepairCost = 600m,
                VehicleID = 19
            },
            new Repair()
            {
                ID = 19,
                InsuranceCompanyID = 5,
                RepairDate = new DateTime(2022, 7, 1),
                PaymentDate = new DateTime(2022, 7, 7),
                RepairCost = 550m,
                VehicleID = 17
            },
            new Repair()
            {
                ID = 20,
                InsuranceCompanyID = 6,
                RepairDate = new DateTime(2022, 9, 12),
                PaymentDate = null,
                RepairCost = 350m,
                VehicleID = 18
            },
            new Repair()
            {
                ID = 21,
                InsuranceCompanyID = 3,
                RepairDate = new DateTime(2022, 11, 24),
                PaymentDate = null,
                RepairCost = 550m,
                VehicleID = 8
            },
            new Repair()
            {
                ID = 22,
                InsuranceCompanyID = 7,
                RepairDate = new DateTime(2022, 1, 5),
                PaymentDate = new DateTime(2022, 1, 11),
                RepairCost = 400m,
                VehicleID = 13
            },
            new Repair()
            {
                ID = 23,
                InsuranceCompanyID = 9,
                RepairDate = new DateTime(2022, 3, 17),
                PaymentDate = null,
                RepairCost = 650m,
                VehicleID = 16
            },
            new Repair()
            {
                ID = 24,
                InsuranceCompanyID = 10,
                RepairDate = new DateTime(2022, 5, 29),
                PaymentDate = null,
                RepairCost = 800m,
                VehicleID = 9
            },
            new Repair()
            {
                ID = 25,
                InsuranceCompanyID = 2,
                RepairDate = new DateTime(2022, 8, 10),
                PaymentDate = new DateTime(2022, 8, 16),
                RepairCost = 550m,
                VehicleID = 12
            },
            new Repair()
            {
                ID = 26,
                InsuranceCompanyID = 6,
                RepairDate = new DateTime(2022, 9, 22),
                PaymentDate = null,
                RepairCost = 700m,
                VehicleID = 11
            },
            new Repair()
            {
                ID = 27,
                InsuranceCompanyID = 4,
                RepairDate = new DateTime(2022, 11, 4),
                PaymentDate = null,
                RepairCost = 450m,
                VehicleID = 14
            },
            new Repair()
            {
                ID = 28,
                InsuranceCompanyID = 8,
                RepairDate = new DateTime(2022, 1, 16),
                PaymentDate = new DateTime(2022, 1, 23),
                RepairCost = 600m,
                VehicleID = 19
            },
            new Repair()
            {
                ID = 29,
                InsuranceCompanyID = 2,
                RepairDate = new DateTime(2022, 3, 28),
                PaymentDate = null,
                RepairCost = 550m,
                VehicleID = 17
            },
            new Repair()
            {
                ID = 30,
                InsuranceCompanyID = 5,
                RepairDate = new DateTime(2022, 6, 9),
                PaymentDate = null,
                RepairCost = 350m,
                VehicleID = 18
            },
            new Repair()
            {
                ID = 31,
                InsuranceCompanyID = 10,
                RepairDate = new DateTime(2022, 8, 21),
                PaymentDate = new DateTime(2022, 8, 28),
                RepairCost = 550m,
                VehicleID = 8
            },
            new Repair()
            {
                ID = 32,
                InsuranceCompanyID = 9,
                RepairDate = new DateTime(2023, 10, 2),
                PaymentDate = null,
                RepairCost = 400m,
                VehicleID = 13
            },
            new Repair()
            {
                ID = 33,
                InsuranceCompanyID = 3,
                RepairDate = new DateTime(2023, 12, 14),
                PaymentDate = null,
                RepairCost = 650m,
                VehicleID = 9
            },
            new Repair()
            {
                ID = 34,
                InsuranceCompanyID = 7,
                RepairDate = new DateTime(2023, 1, 26),
                PaymentDate = new DateTime(2023, 2, 1),
                RepairCost = 800m,
                VehicleID = 16
            },
            new Repair()
            {
                ID = 35,
                InsuranceCompanyID = 8,
                RepairDate = new DateTime(2023, 3, 8),
                PaymentDate = null,
                RepairCost = 550m,
                VehicleID = 12
            },
            new Repair()
            {
                ID = 36,
                InsuranceCompanyID = 4,
                RepairDate = new DateTime(2023, 5, 20),
                PaymentDate = null,
                RepairCost = 700m,
                VehicleID = 11
            },
            new Repair()
            {
                ID = 37,
                InsuranceCompanyID = 6,
                RepairDate = new DateTime(2023, 7, 1),
                PaymentDate = new DateTime(2023, 7, 7),
                RepairCost = 450m,
                VehicleID = 14
            },
            new Repair()
            {
                ID = 38,
                InsuranceCompanyID = 9,
                RepairDate = new DateTime(2023, 9, 13),
                PaymentDate = null,
                RepairCost = 600m,
                VehicleID = 19
            },
            new Repair()
            {
                ID = 39,
                InsuranceCompanyID = 2,
                RepairDate = new DateTime(2023, 11, 25),
                PaymentDate = null,
                RepairCost = 550m,
                VehicleID = 17
            },
            new Repair()
            {
                ID = 40,
                InsuranceCompanyID = 5,
                RepairDate = new DateTime(2023, 2, 6),
                PaymentDate = new DateTime(2023, 2, 13),
                RepairCost = 350m,
                VehicleID = 18
            },
            new Repair()
            {
                ID = 41,
                InsuranceCompanyID = 10,
                RepairDate = new DateTime(2023, 4, 18),
                PaymentDate = null,
                RepairCost = 550m,
                VehicleID = 8
            },
            new Repair()
            {
                ID = 42,
                InsuranceCompanyID = 3,
                RepairDate = new DateTime(2023, 6, 3),
                PaymentDate = null,
                RepairCost = 400m,
                VehicleID = 13
            },
            new Repair()
            {
                ID = 43,
                InsuranceCompanyID = 7,
                RepairDate = new DateTime(2023, 9, 11),
                PaymentDate = new DateTime(2023, 9, 18),
                RepairCost = 650m,
                VehicleID = 9
            },
            new Repair()
            {
                ID = 44,
                InsuranceCompanyID = 4,
                RepairDate = new DateTime(2023, 11, 23),
                PaymentDate = null,
                RepairCost = 800m,
                VehicleID = 16
            },
            new Repair()
            {
                ID = 45,
                InsuranceCompanyID = 8,
                RepairDate = new DateTime(2023, 2, 5),
                PaymentDate = null,
                RepairCost = 550m,
                VehicleID = 12
            },
            new Repair()
            {
                ID = 46,
                InsuranceCompanyID = 6,
                RepairDate = new DateTime(2023, 4, 17),
                PaymentDate = new DateTime(2023, 4, 24),
                RepairCost = 700m,
                VehicleID = 11
            },
            new Repair()
            {
                ID = 47,
                InsuranceCompanyID = 2,
                RepairDate = new DateTime(2023, 6, 29),
                PaymentDate = null,
                RepairCost = 450m,
                VehicleID = 14
            },
            new Repair()
            {
                ID = 48,
                InsuranceCompanyID = 9,
                RepairDate = new DateTime(2023, 9, 10),
                PaymentDate = null,
                RepairCost = 600m,
                VehicleID = 19
            },
            new Repair()
            {
                ID = 49,
                InsuranceCompanyID = 5,
                RepairDate = new DateTime(2023, 11, 22),
                PaymentDate = new DateTime(2023, 11, 29),
                RepairCost = 550m,
                VehicleID = 17
            },
            new Repair()
            {
                ID = 50,
                InsuranceCompanyID = 10,
                RepairDate = new DateTime(2023, 2, 3),
                PaymentDate = null,
                RepairCost = 350m,
                VehicleID = 18
            }
        );
    }
}