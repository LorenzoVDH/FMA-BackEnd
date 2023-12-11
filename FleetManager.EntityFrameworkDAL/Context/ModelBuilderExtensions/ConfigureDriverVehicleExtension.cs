using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureDriverVehicleExtension {
    public static void ConfigureDriverVehicle(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<DriverVehicle>()
            .HasOne(dv => dv.Driver)
            .WithMany(d => d.DriverVehicles)
            .HasForeignKey(dv => dv.DriverID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<DriverVehicle>()
            .HasOne(dv => dv.Vehicle)
            .WithMany(v => v.DriverVehicles)
            .HasForeignKey(dv => dv.VehicleID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
