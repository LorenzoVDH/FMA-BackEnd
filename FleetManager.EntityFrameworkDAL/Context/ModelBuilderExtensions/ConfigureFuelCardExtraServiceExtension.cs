using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureFuelCardExtraServiceExtension {
    public static void ConfigureFuelCardExtraService(this ModelBuilder modelBuilder) {
        //FuelCardExtraService
        modelBuilder.Entity<FuelCardExtraService>()
            .ToTable("FuelCardsExtraServices");
        modelBuilder.Entity<FuelCardExtraService>()
            .HasOne(fces => fces.FuelCard)
            .WithMany(fc => fc.FuelCardExtraServices)
            .HasForeignKey(fces => fces.FuelCardID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<FuelCardExtraService>()
            .HasOne(fces => fces.ExtraService)
            .WithMany(es => es.FuelCardExtraServices)
            .HasForeignKey(fces => fces.ExtraServiceID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}