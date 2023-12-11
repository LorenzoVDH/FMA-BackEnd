﻿using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class MileageTestSeed {
    public static void TestSeedMileage(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Mileage>().HasData(
            new Mileage { ID = 1, VehicleID = 1, Date = new DateTime(2022, 1, 1), MileageInKilometers = 5000 },
            new Mileage { ID = 2, VehicleID = 1, Date = new DateTime(2022, 2, 1), MileageInKilometers = 7000 },
            new Mileage { ID = 3, VehicleID = 1, Date = new DateTime(2022, 3, 1), MileageInKilometers = 9000 },
            new Mileage { ID = 4, VehicleID = 1, Date = new DateTime(2022, 4, 1), MileageInKilometers = 11000 },
            new Mileage { ID = 5, VehicleID = 1, Date = new DateTime(2022, 5, 1), MileageInKilometers = 13000 },
            new Mileage { ID = 6, VehicleID = 1, Date = new DateTime(2022, 6, 1), MileageInKilometers = 15000 },
            new Mileage { ID = 7, VehicleID = 1, Date = new DateTime(2022, 7, 1), MileageInKilometers = 17000 },
            new Mileage { ID = 8, VehicleID = 1, Date = new DateTime(2022, 8, 1), MileageInKilometers = 19000 },
            new Mileage { ID = 9, VehicleID = 1, Date = new DateTime(2022, 9, 1), MileageInKilometers = 21000 },
            new Mileage { ID = 10, VehicleID = 1, Date = new DateTime(2022, 10, 1), MileageInKilometers = 23000 },
            new Mileage { ID = 11, VehicleID = 2, Date = new DateTime(2022, 1, 1), MileageInKilometers = 4000 },
            new Mileage { ID = 12, VehicleID = 2, Date = new DateTime(2022, 2, 1), MileageInKilometers = 6000 },
            new Mileage { ID = 13, VehicleID = 2, Date = new DateTime(2022, 3, 1), MileageInKilometers = 8000 },
            new Mileage { ID = 14, VehicleID = 2, Date = new DateTime(2022, 4, 1), MileageInKilometers = 10000 },
            new Mileage { ID = 15, VehicleID = 2, Date = new DateTime(2022, 5, 1), MileageInKilometers = 12000 },
            new Mileage { ID = 16, VehicleID = 3, Date = new DateTime(2022, 1, 1), MileageInKilometers = 6000 },
            new Mileage { ID = 17, VehicleID = 3, Date = new DateTime(2022, 2, 1), MileageInKilometers = 8000 },
            new Mileage { ID = 18, VehicleID = 3, Date = new DateTime(2022, 3, 1), MileageInKilometers = 10000 },
            new Mileage { ID = 19, VehicleID = 3, Date = new DateTime(2022, 4, 1), MileageInKilometers = 12000 },
            new Mileage { ID = 20, VehicleID = 4, Date = new DateTime(2022, 1, 1), MileageInKilometers = 3000 },
            new Mileage { ID = 21, VehicleID = 4, Date = new DateTime(2022, 2, 1), MileageInKilometers = 5000 },
            new Mileage { ID = 22, VehicleID = 4, Date = new DateTime(2022, 3, 1), MileageInKilometers = 7000 },
            new Mileage { ID = 23, VehicleID = 5, Date = new DateTime(2022, 1, 1), MileageInKilometers = 8000 },
            new Mileage { ID = 24, VehicleID = 5, Date = new DateTime(2022, 2, 1), MileageInKilometers = 10000 },
            new Mileage { ID = 25, VehicleID = 5, Date = new DateTime(2022, 3, 1), MileageInKilometers = 12000 },
            new Mileage { ID = 26, VehicleID = 6, Date = new DateTime(2022, 1, 1), MileageInKilometers = 2500 },
            new Mileage { ID = 27, VehicleID = 6, Date = new DateTime(2022, 2, 1), MileageInKilometers = 4500 },
            new Mileage { ID = 28, VehicleID = 6, Date = new DateTime(2022, 3, 1), MileageInKilometers = 6500 },
            new Mileage { ID = 29, VehicleID = 7, Date = new DateTime(2022, 1, 1), MileageInKilometers = 4500 },
            new Mileage { ID = 30, VehicleID = 7, Date = new DateTime(2022, 2, 1), MileageInKilometers = 6500 },
            new Mileage { ID = 31, VehicleID = 8, Date = new DateTime(2022, 1, 1), MileageInKilometers = 5500 },
            new Mileage { ID = 32, VehicleID = 8, Date = new DateTime(2022, 2, 1), MileageInKilometers = 7500 },
            new Mileage { ID = 33, VehicleID = 9, Date = new DateTime(2022, 1, 1), MileageInKilometers = 6500 },
            new Mileage { ID = 34, VehicleID = 9, Date = new DateTime(2022, 2, 1), MileageInKilometers = 8500 },
            new Mileage { ID = 35, VehicleID = 10, Date = new DateTime(2022, 1, 1), MileageInKilometers = 7500 },
            new Mileage { ID = 36, VehicleID = 10, Date = new DateTime(2022, 2, 1), MileageInKilometers = 9500 },
            new Mileage { ID = 37, VehicleID = 11, Date = new DateTime(2022, 1, 1), MileageInKilometers = 4000 },
            new Mileage { ID = 38, VehicleID = 11, Date = new DateTime(2022, 2, 1), MileageInKilometers = 6000 },
            new Mileage { ID = 39, VehicleID = 12, Date = new DateTime(2022, 1, 1), MileageInKilometers = 6000 },
            new Mileage { ID = 40, VehicleID = 12, Date = new DateTime(2022, 2, 1), MileageInKilometers = 8000 },
            new Mileage { ID = 41, VehicleID = 13, Date = new DateTime(2022, 1, 1), MileageInKilometers = 5000 },
            new Mileage { ID = 42, VehicleID = 13, Date = new DateTime(2022, 2, 1), MileageInKilometers = 7000 },
            new Mileage { ID = 43, VehicleID = 14, Date = new DateTime(2022, 1, 1), MileageInKilometers = 3500 },
            new Mileage { ID = 44, VehicleID = 14, Date = new DateTime(2022, 2, 1), MileageInKilometers = 5500 },
            new Mileage { ID = 45, VehicleID = 15, Date = new DateTime(2022, 1, 1), MileageInKilometers = 4000 },
            new Mileage { ID = 46, VehicleID = 15, Date = new DateTime(2022, 2, 1), MileageInKilometers = 6000 },
            new Mileage { ID = 47, VehicleID = 16, Date = new DateTime(2022, 1, 1), MileageInKilometers = 3000 },
            new Mileage { ID = 48, VehicleID = 16, Date = new DateTime(2022, 2, 1), MileageInKilometers = 5000 },
            new Mileage { ID = 49, VehicleID = 17, Date = new DateTime(2022, 1, 1), MileageInKilometers = 2500 },
            new Mileage { ID = 50, VehicleID = 17, Date = new DateTime(2022, 2, 1), MileageInKilometers = 4500 },
            new Mileage { ID = 51, VehicleID = 18, Date = new DateTime(2022, 1, 1), MileageInKilometers = 3000 },
            new Mileage { ID = 52, VehicleID = 18, Date = new DateTime(2022, 2, 1), MileageInKilometers = 5000 },
            new Mileage { ID = 53, VehicleID = 19, Date = new DateTime(2022, 1, 1), MileageInKilometers = 2000 },
            new Mileage { ID = 54, VehicleID = 19, Date = new DateTime(2022, 2, 1), MileageInKilometers = 4000 },
            new Mileage { ID = 55, VehicleID = 20, Date = new DateTime(2022, 1, 1), MileageInKilometers = 1000 },
            new Mileage { ID = 56, VehicleID = 20, Date = new DateTime(2022, 2, 1), MileageInKilometers = 3000 },
            new Mileage { ID = 57, VehicleID = 20, Date = new DateTime(2022, 3, 1), MileageInKilometers = 5000 }
        );
    }
}