using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtension;
public static class ConfigurePreferredAppointmentDateExtension {
    public static void ConfigurePreferredAppointmentDate(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<PreferredAppointmentDate>(entity => {
            entity.Property(pad => pad.PreferredDate).HasColumnType("date");
        });
    }
}