using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Models.Enums;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class VehicleTestSeed {
    public static void TestSeedVehicle(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Vehicle>().HasData(
            new Vehicle
            {
                ID = 1,
                Active = true, 
                Name = "Honda Civic",
                ChassisNumber = "ABC123",
                FuelType = FuelType.PetrolE5,
                VehicleTypeID = 1,
                RegistrationDate = new DateTime(2022, 5, 10),
                LeasingStartDate = new DateTime(2022, 5, 15),
                LeasingEndDate = new DateTime(2025, 5, 14)
            },
            new Vehicle
            {
                ID = 2,
                Active = true,
                Name = "Toyota Camry",
                ChassisNumber = "DEF456",
                FuelType = FuelType.Diesel,
                VehicleTypeID = 2,
                RegistrationDate = new DateTime(2021, 9, 20),
                LeasingStartDate = new DateTime(2021, 9, 25),
                LeasingEndDate = new DateTime(2024, 9, 24)
            },
            new Vehicle
            {
                ID = 3,
                Active = true,
                Name = "Ford Mustang", 
                ChassisNumber = "GHI789",
                FuelType = FuelType.PetrolE10,
                VehicleTypeID = 3,
                RegistrationDate = new DateTime(2023, 3, 5),
                LeasingStartDate = new DateTime(2023, 3, 10),
                LeasingEndDate = new DateTime(2026, 3, 9)
            },
            new Vehicle
            {
                ID = 4,
                Active = true,
                Name = "Chevrolet Covette",
                ChassisNumber = "JKL012",
                FuelType = FuelType.Super98,
                VehicleTypeID = 1,
                RegistrationDate = new DateTime(2022, 8, 15),
                LeasingStartDate = new DateTime(2022, 8, 20),
                LeasingEndDate = new DateTime(2025, 8, 19)
            },
            new Vehicle
            {
                ID = 5,
                Active = true,
                Name = "BMW 3 Series",
                ChassisNumber = "MNO345",
                FuelType = FuelType.PetrolE5,
                VehicleTypeID = 2,
                RegistrationDate = new DateTime(2023, 1, 3),
                LeasingStartDate = new DateTime(2023, 1, 8),
                LeasingEndDate = new DateTime(2026, 1, 7)
            },
            new Vehicle
            {
                ID = 6,
                Active = true,
                Name = "Mercedes-Benz E-Class",
                ChassisNumber = "PQR678",
                FuelType = FuelType.Diesel,
                VehicleTypeID = 3,
                RegistrationDate = new DateTime(2021, 12, 10),
                LeasingStartDate = new DateTime(2021, 12, 15),
                LeasingEndDate = new DateTime(2024, 12, 14)
            },
            new Vehicle
            {
                ID = 7,
                Active = true,
                Name = "Audi A4", 
                ChassisNumber = "STU901",
                FuelType = FuelType.PetrolE10,
                VehicleTypeID = 1,
                RegistrationDate = new DateTime(2022, 7, 20),
                LeasingStartDate = new DateTime(2022, 7, 25),
                LeasingEndDate = new DateTime(2025, 7, 24)
            },
            new Vehicle
            {
                ID = 8,
                Active = true,
                Name = "Nissan Altima",
                ChassisNumber = "VWX234",
                FuelType = FuelType.PetrolE5,
                VehicleTypeID = 2,
                RegistrationDate = new DateTime(2023, 2, 15),
                LeasingStartDate = new DateTime(2023, 2, 20),
                LeasingEndDate = new DateTime(2026, 2, 19)
            },
            new Vehicle
            {
                ID = 9,
                Active = true,
                Name = "Volkswagen Golf",
                ChassisNumber = "YZA567",
                FuelType = FuelType.Super98,
                VehicleTypeID = 3,
                RegistrationDate = new DateTime(2022, 10, 5),
                LeasingStartDate = new DateTime(2022, 10, 10),
                LeasingEndDate = new DateTime(2025, 10, 9)
            },
            new Vehicle
            {
                ID = 10,
                Active = true,
                Name = "Subaru Outback", 
                ChassisNumber = "BCD890",
                FuelType = FuelType.Diesel,
                VehicleTypeID = 1,
                RegistrationDate = new DateTime(2023, 6, 20),
                LeasingStartDate = new DateTime(2023, 6, 25),
                LeasingEndDate = new DateTime(2026, 6, 24)
            },
            new Vehicle
            {
                ID = 11,
                Active = true,
                Name = "Jeep Wrangler", 
                ChassisNumber = "EFG123",
                FuelType = FuelType.PetrolE10,
                VehicleTypeID = 2,
                RegistrationDate = new DateTime(2022, 11, 15),
                LeasingStartDate = new DateTime(2022, 11, 20),
                LeasingEndDate = new DateTime(2025, 11, 19)
            },
            new Vehicle
            {
                ID = 12,
                Active = true,
                Name = "Hyundai Sonata", 
                ChassisNumber = "HIJ456",
                FuelType = FuelType.PetrolE5,
                VehicleTypeID = 3,
                RegistrationDate = new DateTime(2023, 4, 5),
                LeasingStartDate = new DateTime(2023, 4, 10),
                LeasingEndDate = new DateTime(2026, 4, 9)
            },
            new Vehicle
            {
                ID = 13,
                Active = true,
                Name = "Kia Soul",
                ChassisNumber = "KLM789",
                FuelType = FuelType.Diesel,
                VehicleTypeID = 1,
                RegistrationDate = new DateTime(2022, 9, 10),
                LeasingStartDate = new DateTime(2022, 9, 15),
                LeasingEndDate = new DateTime(2025, 9, 14)
            },
            new Vehicle
            {
                ID = 14,
                Active = true,
                Name = "Mazda CX-5",
                ChassisNumber = "NOP012",
                FuelType = FuelType.PetrolE10,
                VehicleTypeID = 2,
                RegistrationDate = new DateTime(2023, 5, 20),
                LeasingStartDate = new DateTime(2023, 5, 25),
                LeasingEndDate = new DateTime(2026, 5, 24)
            },
            new Vehicle
            {
                ID = 15,
                Active = true,
                Name = "Lexus RX",
                ChassisNumber = "QRS345",
                FuelType = FuelType.Super98,
                VehicleTypeID = 3,
                RegistrationDate = new DateTime(2022, 12, 15),
                LeasingStartDate = new DateTime(2022, 12, 20),
                LeasingEndDate = new DateTime(2025, 12, 19)
            },
            new Vehicle
            {
                ID = 16,
                Active = true,
                Name = "Volvo XC60", 
                ChassisNumber = "TUV678",
                FuelType = FuelType.PetrolE5,
                VehicleTypeID = 1,
                RegistrationDate = new DateTime(2023, 8, 10),
                LeasingStartDate = new DateTime(2023, 8, 15),
                LeasingEndDate = new DateTime(2026, 8, 14)
            },
            new Vehicle
            {
                ID = 17,
                Active = true,
                Name = "Tesla Model S", 
                ChassisNumber = "WXY901",
                FuelType = FuelType.Diesel,
                VehicleTypeID = 2,
                RegistrationDate = new DateTime(2022, 3, 20),
                LeasingStartDate = new DateTime(2022, 3, 25),
                LeasingEndDate = new DateTime(2025, 3, 24)
            },
            new Vehicle
            {
                ID = 18,
                Active = true,
                Name = "Porsche 911", 
                ChassisNumber = "ZAB234",
                FuelType = FuelType.PetrolE10,
                VehicleTypeID = 3,
                RegistrationDate = new DateTime(2023, 10, 5),
                LeasingStartDate = new DateTime(2023, 10, 10),
                LeasingEndDate = new DateTime(2026, 10, 9)
            },
            new Vehicle
            {
                ID = 19,
                Active = true,
                Name = "Jaguar F-Pace", 
                ChassisNumber = "CDE567",
                FuelType = FuelType.PetrolE5,
                VehicleTypeID = 1,
                RegistrationDate = new DateTime(2022, 5, 15),
                LeasingStartDate = new DateTime(2022, 5, 20),
                LeasingEndDate = new DateTime(2025, 5, 19)
            },
            new Vehicle
            {
                ID = 20,
                Active = true,
                Name = "Land Rover Range Rover", 
                ChassisNumber = "FGH890",
                FuelType = FuelType.Super98,
                VehicleTypeID = 2,
                RegistrationDate = new DateTime(2023, 1, 10),
                LeasingStartDate = new DateTime(2023, 1, 15),
                LeasingEndDate = new DateTime(2026, 1, 14)
            }
        );
    }
}