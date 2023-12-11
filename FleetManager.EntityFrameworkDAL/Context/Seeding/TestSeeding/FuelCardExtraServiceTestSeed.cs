using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class FuelCardExtraServiceTestSeed {
    public static void TestSeedFuelCardExtraService(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<FuelCardExtraService>().HasData(
            new FuelCardExtraService() { ID = 1, FuelCardID = 1, ExtraServiceID = 1 },
            new FuelCardExtraService() { ID = 2, FuelCardID = 1, ExtraServiceID = 2 },
            new FuelCardExtraService() { ID = 3, FuelCardID = 1, ExtraServiceID = 3 },
            new FuelCardExtraService() { ID = 4, FuelCardID = 2, ExtraServiceID = 1 },
            new FuelCardExtraService() { ID = 5, FuelCardID = 2, ExtraServiceID = 2 },
            new FuelCardExtraService() { ID = 6, FuelCardID = 2, ExtraServiceID = 3 },
            new FuelCardExtraService() { ID = 7, FuelCardID = 2, ExtraServiceID = 4 },
            new FuelCardExtraService() { ID = 8, FuelCardID = 3, ExtraServiceID = 1 },
            new FuelCardExtraService() { ID = 9, FuelCardID = 3, ExtraServiceID = 2 },
            new FuelCardExtraService() { ID = 10, FuelCardID = 3, ExtraServiceID = 3 },
            new FuelCardExtraService() { ID = 11, FuelCardID = 4, ExtraServiceID = 3 },
            new FuelCardExtraService() { ID = 12, FuelCardID = 5, ExtraServiceID = 1 },
            new FuelCardExtraService() { ID = 13, FuelCardID = 5, ExtraServiceID = 2 },
            new FuelCardExtraService() { ID = 14, FuelCardID = 5, ExtraServiceID = 4 },
            new FuelCardExtraService() { ID = 15, FuelCardID = 6, ExtraServiceID = 1 },
            new FuelCardExtraService() { ID = 16, FuelCardID = 6, ExtraServiceID = 3 },
            new FuelCardExtraService() { ID = 17, FuelCardID = 7, ExtraServiceID = 1 },
            new FuelCardExtraService() { ID = 18, FuelCardID = 7, ExtraServiceID = 2 },
            new FuelCardExtraService() { ID = 19, FuelCardID = 7, ExtraServiceID = 3 },
            new FuelCardExtraService() { ID = 20, FuelCardID = 7, ExtraServiceID = 4 },
            new FuelCardExtraService() { ID = 21, FuelCardID = 8, ExtraServiceID = 2 },
            new FuelCardExtraService() { ID = 22, FuelCardID = 9, ExtraServiceID = 1 },
            new FuelCardExtraService() { ID = 23, FuelCardID = 9, ExtraServiceID = 3 },
            new FuelCardExtraService() { ID = 24, FuelCardID = 10, ExtraServiceID = 2 },
            new FuelCardExtraService() { ID = 25, FuelCardID = 10, ExtraServiceID = 4 }
        );
    }
}
