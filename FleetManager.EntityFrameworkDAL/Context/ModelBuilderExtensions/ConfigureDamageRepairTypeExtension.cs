using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureDamageRepairTypeExtension {
    public static void ConfigureDamageRepairType(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<DamageRepairType>(entity => {
            entity.Property(drt => drt.Name).IsRequired();
        });
    }
}
