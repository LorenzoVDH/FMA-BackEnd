using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class VehicleTypeTestSeed {
    public static void TestSeedVehicleType(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<VehicleType>().HasData(
            new VehicleType { ID = 1, Name = "Multiseater/Family Car" },
            new VehicleType { ID = 2, Name = "SUV" },
            new VehicleType { ID = 3, Name = "Compact Car" },
            new VehicleType { ID = 4, Name = "Sports Car" },
            new VehicleType { ID = 5, Name = "Minivan" },
            new VehicleType { ID = 6, Name = "Truck" },
            new VehicleType { ID = 7, Name = "Motorcycle" },
            new VehicleType { ID = 8, Name = "Electric Vehicle" },
            new VehicleType { ID = 9, Name = "Luxury Car" },
            new VehicleType { ID = 10, Name = "Convertible" }
        );
    }
}
