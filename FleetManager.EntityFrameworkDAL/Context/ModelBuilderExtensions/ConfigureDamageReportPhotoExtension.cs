using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureDamageReportPhotoExtension {
    public static void ConfigureDamageReportPhoto(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<DamageReportPhoto>(entity => {
            entity.Property(drp => drp.FilePath).IsRequired();
        });
        modelBuilder.Entity<DamageReportPhoto>()
            .HasOne(drp => drp.DamageReport)
            .WithMany(dr => dr.DamageReportPhotos)
            .HasForeignKey(dr => dr.DamageReportID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}