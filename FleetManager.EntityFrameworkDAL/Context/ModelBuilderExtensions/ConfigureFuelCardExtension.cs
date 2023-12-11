using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions; 
public static class ConfigureFuelCardExtension {
    public static void ConfigureFuelCard(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<FuelCard>(entity => {
            entity.Property(fc => fc.FuelCardNumber).IsRequired();
            entity.Property(fc => fc.CardValidityStartDate).HasColumnType("date");
            entity.Property(fc => fc.CardValidityEndDate).HasColumnType("date");
            entity.Property(fc => fc.AuthenticationType).HasConversion<string>().HasMaxLength(32);
            entity.Property(fc => fc.FuelType).HasConversion<string>().HasMaxLength(32);
        });
    }
}
