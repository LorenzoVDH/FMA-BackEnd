using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions; 
public static class ConfigureDamageReportExtension {
    public static void ConfigureDamageReport(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<DamageReport>(entity => {
            entity.Property(dr => dr.Cost).HasColumnType("decimal(16,2)");
            entity.Property(dr => dr.ReportDate).HasColumnType("date");
            entity.Property(dr => dr.DamageDate).HasColumnType("date");
            entity.Property(dr => dr.Description).IsRequired();
        });
        modelBuilder.Entity<DamageReport>()
            .HasOne(dr => dr.InspectionReport)
            .WithMany(ir => ir.DamageReports)
            .HasForeignKey(dr => dr.InspectionReportID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<DamageReport>()
            .HasOne(dr => dr.DamageRepairType)
            .WithMany()
            .HasForeignKey(dr => dr.DamageRepairTypeID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<DamageReport>()
            .HasOne(dr => dr.VehiclePart)
            .WithMany()
            .HasForeignKey(dr => dr.VehiclePartID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<DamageReport>()
            .HasOne(dr => dr.Repair)
            .WithOne(r => r.DamageReport)
            .HasForeignKey<Repair>(r => r.DamageReportID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
