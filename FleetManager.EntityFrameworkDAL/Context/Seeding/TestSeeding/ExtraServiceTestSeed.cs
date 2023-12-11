using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class ExtraServiceTestSeed {
    public static void TestSeedExtraService(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<ExtraService>().HasData(
            new ExtraService() { ID = 1, Description = "Fuel" },
            new ExtraService() { ID = 2, Description = "Shop" },
            new ExtraService() { ID = 3, Description = "Tires" },
            new ExtraService() { ID = 4, Description = "Carwash" }
        );
    }
}