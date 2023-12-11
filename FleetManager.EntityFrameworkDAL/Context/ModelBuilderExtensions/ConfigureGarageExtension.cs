using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions; 
public static class ConfigureGarageExtension {
    public static void ConfigureGarage(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Garage>()
            .ToTable("Garages");
    }
}
