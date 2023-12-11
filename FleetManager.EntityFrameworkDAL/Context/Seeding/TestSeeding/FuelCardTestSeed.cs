using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using FleetManager.EntityFrameworkDAL.Models.Enums;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class FuelCardTestSeed {
    public static void TestSeedFuelCard(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<FuelCard>().HasData(
            new FuelCard()
            {
                ID = 1,
                FuelCardNumber = "38473",
                FuelType = FuelType.PetrolE5,
                PINCode = null,
                Active = true,
                AuthenticationType = null,
                CardValidityStartDate = new DateTime(2018, 4, 23),
                CardValidityEndDate = null,
            },
            new FuelCard()
            {
                ID = 2,
                FuelCardNumber = "38474",
                FuelType = FuelType.PetrolE10,
                PINCode = "8854",
                Active = true,
                AuthenticationType = AuthenticationType.PINOnly,
                CardValidityStartDate = new DateTime(2022, 4, 23),
                CardValidityEndDate = new DateTime(2023, 1, 16)
            },
            new FuelCard()
            {
                ID = 3,
                FuelCardNumber = "38475",
                FuelType = FuelType.Diesel,
                PINCode = "3432",
                Active = true,
                AuthenticationType = AuthenticationType.PINAndMileageInKilometers,
                CardValidityStartDate = new DateTime(2020, 3, 23),
                CardValidityEndDate = new DateTime(2022, 1, 16)
            },
            new FuelCard()
            {
                ID = 4,
                FuelCardNumber = "38475",
                FuelType = FuelType.Super98,
                PINCode = "5986",
                Active = false,
                AuthenticationType = AuthenticationType.PINOnly,
                CardValidityStartDate = new DateTime(2019, 4, 23),
                CardValidityEndDate = new DateTime(2021, 1, 13)
            },
            new FuelCard()
            {
                ID = 5,
                FuelCardNumber = "38476",
                FuelType = FuelType.Diesel,
                PINCode = "7621",
                Active = true,
                AuthenticationType = AuthenticationType.PINOnly,
                CardValidityStartDate = new DateTime(2021, 6, 1),
                CardValidityEndDate = new DateTime(2022, 5, 31)
            },
            new FuelCard()
            {
                ID = 6,
                FuelCardNumber = "38477",
                FuelType = FuelType.PetrolE5,
                PINCode = null,
                Active = true,
                AuthenticationType = null,
                CardValidityStartDate = new DateTime(2023, 1, 1),
                CardValidityEndDate = null
            },
            new FuelCard()
            {
                ID = 7,
                FuelCardNumber = "38478",
                FuelType = FuelType.Super98,
                PINCode = "1234",
                Active = true,
                AuthenticationType = AuthenticationType.PINAndMileageInKilometers,
                CardValidityStartDate = new DateTime(2023, 2, 15),
                CardValidityEndDate = new DateTime(2024, 2, 14)
            },
            new FuelCard()
            {
                ID = 8,
                FuelCardNumber = "38479",
                FuelType = FuelType.PetrolE10,
                PINCode = "4321",
                Active = true,
                AuthenticationType = AuthenticationType.PINOnly,
                CardValidityStartDate = new DateTime(2023, 4, 1),
                CardValidityEndDate = new DateTime(2024, 3, 31)
            },
            new FuelCard()
            {
                ID = 9,
                FuelCardNumber = "38480",
                FuelType = FuelType.Diesel,
                PINCode = "9876",
                Active = false,
                AuthenticationType = AuthenticationType.PINOnly,
                CardValidityStartDate = new DateTime(2023, 6, 1),
                CardValidityEndDate = new DateTime(2024, 5, 31)
            },
            new FuelCard()
            {
                ID = 10,
                FuelCardNumber = "38481",
                FuelType = FuelType.PetrolE5,
                PINCode = null,
                Active = true,
                AuthenticationType = null,
                CardValidityStartDate = new DateTime(2023, 7, 1),
                CardValidityEndDate = null
            }
        );
    }
}