using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureMaintenanceTaskExtension {
    public static void ConfigureMaintenanceTask(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<MaintenanceTask>()
            .HasOne(mt => mt.Maintenance)
            .WithMany(m => m.MaintenanceTasks)
            .HasForeignKey(m => m.MaintenanceID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
