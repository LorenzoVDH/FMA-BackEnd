using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureMileageExtension {
    public static void ConfigureMileage(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Mileage>(entity => {
            entity.Property(m => m.Date).HasColumnType("date");
            entity.Property(m => m.MileageInKilometers).HasColumnType("decimal(18,2)");
        });
        modelBuilder.Entity<Mileage>()
            .HasOne(m => m.Vehicle)
            .WithMany(v => v.Mileages)
            .HasForeignKey(m => m.VehicleID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
