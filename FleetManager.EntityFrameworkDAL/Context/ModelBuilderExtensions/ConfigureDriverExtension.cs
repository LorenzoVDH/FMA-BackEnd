using FleetManager.EntityFrameworkDAL.Models;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureDriverExtension {
    public static void ConfigureDriver(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Driver>(entity => {
            entity.Property(d => d.LastName).IsRequired();
            entity.Property(d => d.FirstName).IsRequired();
            entity.Property(d => d.DateOfBirth).HasColumnType("date");
            entity.Property(d => d.NationalRegistrationNumber).IsRequired();
            entity.Property(d => d.AddressPostalCode);
            entity.Property(d => d.AddressHouseNumber);
            entity.Property(d => d.AddressStreet);
            entity.Property(d => d.AddressCity);
            entity.Property(d => d.LicenseType).HasConversion<string>().HasMaxLength(4);
        });
    }
}
