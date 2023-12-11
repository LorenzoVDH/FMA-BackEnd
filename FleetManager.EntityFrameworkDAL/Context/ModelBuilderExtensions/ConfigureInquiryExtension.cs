using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions; 
public static class ConfigureInquiryExtension {
    public static void ConfigureInquiry(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Inquiry>(entity => {
            entity.Property(i => i.DateOfInquiry).HasColumnType("datetime");
            entity.Property(i => i.Status).HasConversion<string>().HasMaxLength(32);
        });

        modelBuilder.Entity<Inquiry>()
            .HasOne(i => i.InquiryType)
            .WithMany()
            .HasForeignKey(i => i.InquiryTypeID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Inquiry>()
            .HasMany(i => i.PreferredAppointmentDates)
            .WithOne(pad => pad.Inquiry)
            .HasForeignKey(pad => pad.InquiryID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Inquiry>()
            .HasOne(i => i.Vehicle)
            .WithMany(v => v.Inquiries)
            .HasForeignKey(i => i.VehicleID)
            .OnDelete(DeleteBehavior.Restrict);
        modelBuilder.Entity<Inquiry>()
            .HasOne(i => i.Driver)
            .WithMany(d => d.Inquiries)
            .HasForeignKey(i => i.DriverID)
            .OnDelete(DeleteBehavior.Restrict);
    }
}
