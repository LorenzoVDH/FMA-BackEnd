using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;

public static class InsuranceCompanyTestSeed {
    public static void TestSeedInsuranceCompany(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<InsuranceCompany>().HasData(
            new InsuranceCompany() { ID = 1, Name = "Verzekeringen Van Damme", ReferenceNumber = "VD12345" },
            new InsuranceCompany() { ID = 2, Name = "De Zekerheidsgroep", ReferenceNumber = "ZKG56789" },
            new InsuranceCompany() { ID = 3, Name = "Verzekeringsmaatschappij De Bruyn", ReferenceNumber = "DB24680" },
            new InsuranceCompany() { ID = 4, Name = "Assurantiegroep Devos", ReferenceNumber = "AVS13579" },
            new InsuranceCompany() { ID = 5, Name = "Verzekeraars Verstraeten", ReferenceNumber = "VVS98765" },
            new InsuranceCompany() { ID = 6, Name = "Verzekeringen Claesens", ReferenceNumber = "CLS23456" },
            new InsuranceCompany() { ID = 7, Name = "De Verzekeraarsgroep", ReferenceNumber = "VZGRP78901" },
            new InsuranceCompany() { ID = 8, Name = "Verzekeringen Jacobs & Partners", ReferenceNumber = "JP35792" },
            new InsuranceCompany() { ID = 9, Name = "Assurantiebedrijf Van Dyck", ReferenceNumber = "VDB68024" },
            new InsuranceCompany() { ID = 10, Name = "Verzekeraars De Vries", ReferenceNumber = "DV40386" }
        );
    }
}
