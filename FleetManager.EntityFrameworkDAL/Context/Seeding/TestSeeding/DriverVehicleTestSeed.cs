using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class DriverVehicleTestSeed {
    public static void TestSeedDriverVehicle(this ModelBuilder modelBuilder) {
        var random = new Random();

        var driverVehicles = Enumerable.Range(1, 100).Select(i => new DriverVehicle {
            ID = i,
            DriverID = random.Next(1, 100),
            VehicleID = random.Next(1, 21)
        }).ToList();

        modelBuilder.Entity<DriverVehicle>().HasData(driverVehicles);
        modelBuilder.Entity<DriverVehicle>().HasData(new DriverVehicle() {
            ID = driverVehicles.Count+1,
            DriverID = 7,
            VehicleID = 10
        });
    }
}