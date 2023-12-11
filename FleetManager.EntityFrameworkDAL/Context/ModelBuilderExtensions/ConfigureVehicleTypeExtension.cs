using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions; 
public static class ConfigureVehicleTypeExtension {
    public static void ConfigureVehicleType(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<VehicleType>(entity => {
            entity.Property(vt => vt.Name).IsRequired();
        });
    }
}
