using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
public static class ConfigureInsuranceCompanyExtension {
    public static void ConfigureInsuranceCompany(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<InsuranceCompany>(entity => {
            entity.Property(ic => ic.ReferenceNumber).IsRequired();
            entity.Property(ic => ic.Name).IsRequired();
        });
    }
}
