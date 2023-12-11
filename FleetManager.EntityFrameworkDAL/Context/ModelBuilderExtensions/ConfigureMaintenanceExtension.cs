using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureMaintenanceExtension {
    public static void ConfigureMaintenance(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Maintenance>(entity => {
            entity.Property(m => m.Cost).HasColumnType("decimal(32,2)");
            entity.Property(m => m.Date).HasColumnType("date");
        });
        modelBuilder.Entity<Maintenance>()
            .HasOne(m => m.Vehicle)
            .WithMany(v => v.Maintenances)
            .HasForeignKey(m => m.VehicleID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Maintenance>()
            .HasOne(m => m.Garage)
            .WithMany()
            .HasForeignKey(m => m.GarageID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
