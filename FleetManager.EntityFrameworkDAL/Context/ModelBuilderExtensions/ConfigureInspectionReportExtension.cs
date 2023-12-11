using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureInspectionReportExtension {
    public static void ConfigureInspectionReport(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<InspectionReport>(entity => {
            entity.Property(ir => ir.Date).HasColumnType("date");
        });
        modelBuilder.Entity<InspectionReport>()
            .HasOne(ir => ir.Driver)
            .WithMany(d => d.InspectionReports)
            .HasForeignKey(ir => ir.DriverID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<InspectionReport>()
            .HasOne(ir => ir.Vehicle)
            .WithMany(v => v.InspectionReports)
            .HasForeignKey(ir => ir.VehicleID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
