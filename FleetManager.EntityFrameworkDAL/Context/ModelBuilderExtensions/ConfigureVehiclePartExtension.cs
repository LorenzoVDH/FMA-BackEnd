using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureVehiclePartExtension {
    public static void ConfigureVehiclePart(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<VehiclePart>(entity => {
            entity.Property(vp => vp.Name).IsRequired();
        });
    }
}
