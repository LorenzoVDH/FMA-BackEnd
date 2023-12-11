using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureInquiryTypeExtension {
    public static void ConfigureInquiryType(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<InquiryType>(entity => {
            entity.Property(it => it.Name).IsRequired();
            entity.Property(it => it.Category).HasConversion<string>()
                                              .IsRequired();
            entity.Property(it => it.AppointmentNeeded).IsRequired();
        });
    }
}
