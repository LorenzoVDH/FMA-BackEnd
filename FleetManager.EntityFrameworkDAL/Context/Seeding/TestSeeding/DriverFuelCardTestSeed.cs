using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class DriverFuelCardTestSeed {
    public static void TestSeedDriverFuelCard(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<DriverFuelCard>().HasData(
            new DriverFuelCard()
            {
                ID = 1,
                DriverID = 6,
                FuelCardID = 7,
                OwnershipStartDate = new DateTime(2017, 7, 24),
                OwnershipEndDate = null
            },
            new DriverFuelCard()
            {
                ID = 2,
                DriverID = 3,
                FuelCardID = 8,
                OwnershipStartDate = new DateTime(2019, 5, 21),
                OwnershipEndDate = new DateTime(2023, 1, 7)
            },
            new DriverFuelCard()
            {
                ID = 3,
                DriverID = 4,
                FuelCardID = 3,
                OwnershipStartDate = new DateTime(2017, 7, 24),
                OwnershipEndDate = new DateTime(2021, 3, 8)
            },
            new DriverFuelCard()
            {
                ID = 4,
                DriverID = 12,
                FuelCardID = 1,
                OwnershipStartDate = new DateTime(2022, 6, 15),
                OwnershipEndDate = null
            },
            new DriverFuelCard()
            {
                ID = 5,
                DriverID = 17,
                FuelCardID = 2,
                OwnershipStartDate = new DateTime(2021, 9, 1),
                OwnershipEndDate = new DateTime(2023, 3, 14)
            },
            new DriverFuelCard()
            {
                ID = 6,
                DriverID = 20,
                FuelCardID = 4,
                OwnershipStartDate = new DateTime(2019, 12, 10),
                OwnershipEndDate = new DateTime(2022, 5, 2)
            },
            new DriverFuelCard()
            {
                ID = 7,
                DriverID = 8,
                FuelCardID = 6,
                OwnershipStartDate = new DateTime(2023, 2, 18),
                OwnershipEndDate = null
            },
            new DriverFuelCard()
            {
                ID = 8,
                DriverID = 9,
                FuelCardID = 5,
                OwnershipStartDate = new DateTime(2020, 3, 5),
                OwnershipEndDate = new DateTime(2023, 8, 21)
            },
            new DriverFuelCard()
            {
                ID = 9,
                DriverID = 15,
                FuelCardID = 9,
                OwnershipStartDate = new DateTime(2018, 11, 20),
                OwnershipEndDate = new DateTime(2021, 4, 30)
            },
            new DriverFuelCard()
            {
                ID = 10,
                DriverID = 26,
                FuelCardID = 10,
                OwnershipStartDate = new DateTime(2017, 8, 2),
                OwnershipEndDate = null
            },
            new DriverFuelCard()
            {
                ID = 11,
                DriverID = 7,
                FuelCardID = 3,
                OwnershipStartDate = new DateTime(2023, 4, 10),
                OwnershipEndDate = null
            },
            new DriverFuelCard()
            {
                ID = 12,
                DriverID = 13,
                FuelCardID = 7,
                OwnershipStartDate = new DateTime(2022, 1, 1),
                OwnershipEndDate = new DateTime(2023, 6, 30)
            },
            new DriverFuelCard()
            {
                ID = 13,
                DriverID = 18,
                FuelCardID = 8,
                OwnershipStartDate = new DateTime(2020, 6, 25),
                OwnershipEndDate = new DateTime(2022, 12, 15)
            },
            new DriverFuelCard()
            {
                ID = 14,
                DriverID = 21,
                FuelCardID = 4,
                OwnershipStartDate = new DateTime(2023, 1, 1),
                OwnershipEndDate = null
            },
            new DriverFuelCard()
            {
                ID = 15,
                DriverID = 25,
                FuelCardID = 1,
                OwnershipStartDate = new DateTime(2022, 3, 14),
                OwnershipEndDate = new DateTime(2023, 9, 30)
            }
        );
    }
}