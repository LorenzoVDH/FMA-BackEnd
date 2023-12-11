using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureRepairFileExtension {
    public static void ConfigureRepairFile(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<RepairFile>(entity => {
            entity.Property(rf => rf.FilePath).IsRequired();
            entity.Property(rf => rf.FileType).HasConversion<string>().HasMaxLength(16);
        });
        modelBuilder.Entity<RepairFile>()
            .HasOne(rf => rf.Repair)
            .WithMany(r => r.RepairFiles)
            .HasForeignKey(rf => rf.RepairID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}