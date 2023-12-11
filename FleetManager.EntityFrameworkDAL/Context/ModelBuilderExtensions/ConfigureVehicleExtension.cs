using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureVehicleExtension {
    public static void ConfigureVehicle(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Vehicle>(entity => {
            entity.Property(v => v.ChassisNumber).IsRequired();
            entity.Property(v => v.Active).IsRequired();
            entity.Property(v => v.FuelType).HasConversion<string>().HasMaxLength(64);
            entity.Property(v => v.RegistrationDate).HasColumnType("date");
            entity.Property(v => v.LeasingStartDate).HasColumnType("date");
            entity.Property(v => v.LeasingEndDate).HasColumnType("date");
        });
        modelBuilder.Entity<Vehicle>()
            .HasOne(v => v.VehicleType)
            .WithMany()
            .HasForeignKey(v => v.VehicleTypeID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}