using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureRepairExtension {
    public static void ConfigureRepair(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Repair>(entity => {
            entity.Property(r => r.RepairDate).HasColumnType("date");
            entity.Property(r => r.RepairCost).HasColumnType("decimal(32,2)");
            entity.Property(r => r.PaymentDate).HasColumnType("date");
        });
        modelBuilder.Entity<Repair>()
            .HasOne(r => r.Vehicle)
            .WithMany(v => v.Repairs)
            .HasForeignKey(r => r.VehicleID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Repair>()
            .HasOne(r => r.InsuranceCompany)
            .WithMany()
            .HasForeignKey(r => r.InsuranceCompanyID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}