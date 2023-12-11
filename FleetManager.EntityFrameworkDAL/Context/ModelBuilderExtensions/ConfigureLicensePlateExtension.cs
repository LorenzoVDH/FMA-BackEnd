using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureLicensePlateExtension {
    public static void ConfigureLicensePlate(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<LicensePlate>(entity => {
            entity.Property(lp => lp.LicensePlateNumber).HasConversion<string>().IsRequired().HasMaxLength(16);
            entity.Property(lp => lp.ValidityStartDate).HasColumnType("date");
            entity.Property(lp => lp.ValidityEndDate).HasColumnType("date");
        });
        modelBuilder.Entity<LicensePlate>()
            .HasOne(lp => lp.Vehicle)
            .WithMany(v => v.LicensePlates)
            .HasForeignKey(lp => lp.VehicleID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
