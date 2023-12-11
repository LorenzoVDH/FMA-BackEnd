using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class GarageTestSeed {
    public static void TestSeedGarage(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Garage>().HasData(
            new Garage() { ID = 1, Name = "De Vlaamse Garagist" },
            new Garage() { ID = 2, Name = "Garage 't Zwin" },
            new Garage() { ID = 3, Name = "Garage Van Diksmuide" },
            new Garage() { ID = 4, Name = "Garage 't Westhoekje" }
        );
    }
}