using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureExtraServiceExtension {
    public static void ConfigureExtraService(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<ExtraService>().Property(es => es.Description);
    }
}
