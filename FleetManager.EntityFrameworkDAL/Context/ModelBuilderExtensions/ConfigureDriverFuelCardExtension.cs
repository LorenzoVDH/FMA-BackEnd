using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureDriverFuelCardExtension {
    public static void ConfigureDriverFuelCard(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<DriverFuelCard>(entity => {
            entity.Property(dfc => dfc.OwnershipStartDate).HasColumnType("date");
            entity.Property(dfc => dfc.OwnershipEndDate).HasColumnType("date");
        });
        modelBuilder.Entity<DriverFuelCard>()
            .HasOne(dfc => dfc.Driver)
            .WithMany(d => d.DriverFuelCards)
            .HasForeignKey(dfc => dfc.DriverID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<DriverFuelCard>()
            .HasOne(dfc => dfc.FuelCard)
            .WithMany(fc => fc.DriverFuelCards)
            .HasForeignKey(dfc => dfc.FuelCardID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
