using Microsoft.EntityFrameworkCore;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
using FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions;
using FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtension;

namespace FleetManager.EntityFrameworkDAL.Context;
public class FleetManagerContext : DbContext {
    public FleetManagerContext() { }
    public FleetManagerContext(DbContextOptions<FleetManagerContext> options) : base(options) { }
    public DbSet<DamageReport> DamageReports { get; set; }
    public DbSet<DamageReportPhoto> DamageReportPhotos { get; set; }
    public DbSet<Driver> Drivers { get; set; }
    public DbSet<Login> Logins { get; set; }
    public DbSet<DriverVehicle> DriverVehicles { get; set; }
    public DbSet<DriverFuelCard> DriverFuelCards { get; set; }
    public DbSet<ExtraService> ExtraServices { get; set; }
    public DbSet<FuelCard> FuelCards { get; set; }
    public DbSet<Garage> Garages { get; set; }
    public DbSet<Inquiry> Inquiries { get; set; }
    public DbSet<InquiryType> InquiryTypes { get; set; }
    public DbSet<InspectionReport> InspectionReports { get; set; }
    public DbSet<InsuranceCompany> InsuranceCompanies { get; set; }
    public DbSet<LicensePlate> LicensePlates { get; set; }
    public DbSet<Maintenance> Maintenances { get; set; }
    public DbSet<MaintenanceTask> MaintenanceTasks { get; set; }
    public DbSet<Mileage> Mileages { get; set; }
    public DbSet<PreferredAppointmentDate> PreferredAppointmentDates { get; set; }
    public DbSet<Repair> Repairs { get; set; }
    public DbSet<RepairFile> RepairFiles { get; set; }
    public DbSet<DamageRepairType> DamageRepairTypes { get; set; }
    public DbSet<Vehicle> Vehicles { get; set; }
    public DbSet<VehiclePart> VehicleParts { get; set; }
    public DbSet<VehicleType> VehicleTypes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
        base.OnConfiguring(optionsBuilder);
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        ConfigureTableAttributes(modelBuilder);
        SeedTestData(modelBuilder);

        base.OnModelCreating(modelBuilder);
    }

    private void SeedTestData(ModelBuilder modelBuilder) {
        modelBuilder.TestSeedDriver();
        modelBuilder.TestSeedLogin();
        modelBuilder.TestSeedInquiryType();
        modelBuilder.TestSeedInquiry();
        modelBuilder.TestSeedPreferredAppointmentDate();
        modelBuilder.TestSeedVehicle();

        modelBuilder.TestSeedLicensePlate();
        modelBuilder.TestSeedVehicleType();
        modelBuilder.TestSeedMileage();
        modelBuilder.TestSeedMaintenance();
        modelBuilder.TestSeedMaintenanceTask();

        modelBuilder.TestSeedGarage();
        modelBuilder.TestSeedRepair();
        modelBuilder.TestSeedInsuranceCompany();
        modelBuilder.TestSeedRepairFile();
        modelBuilder.TestSeedVehiclePart();

        modelBuilder.TestSeedDamageReport();
        modelBuilder.TestSeedDamageRepairType();
        modelBuilder.TestSeedDamageReportPhoto();
        modelBuilder.TestSeedInspectionReport();
        modelBuilder.TestSeedFuelCard();

        modelBuilder.TestSeedDriverFuelCard();
        modelBuilder.TestSeedDriverVehicle ();
        modelBuilder.TestSeedFuelCardExtraService();
        modelBuilder.TestSeedExtraService();
    }

    private void ConfigureTableAttributes(ModelBuilder modelBuilder) {
        modelBuilder.ConfigureDriver();
        modelBuilder.ConfigureLogin();
        modelBuilder.ConfigureInquiryType();
        modelBuilder.ConfigureInquiry();
        modelBuilder.ConfigurePreferredAppointmentDate();
        modelBuilder.ConfigureVehicle();
                     
        modelBuilder.ConfigureLicensePlate();
        modelBuilder.ConfigureVehicleType();
        modelBuilder.ConfigureMileage();
        modelBuilder.ConfigureMaintenance();
        modelBuilder.ConfigureMaintenanceTask();
                     
        modelBuilder.ConfigureGarage();
        modelBuilder.ConfigureRepair();
        modelBuilder.ConfigureInsuranceCompany();
        modelBuilder.ConfigureRepairFile();
        modelBuilder.ConfigureVehiclePart();
                     
        modelBuilder.ConfigureDamageReport();
        modelBuilder.ConfigureDamageRepairType();
        modelBuilder.ConfigureDamageReportPhoto();
        modelBuilder.ConfigureInspectionReport();
        modelBuilder.ConfigureFuelCard();
                     
        modelBuilder.ConfigureDriverFuelCard();
        modelBuilder.ConfigureDriverVehicle(); 
        modelBuilder.ConfigureFuelCardExtraService();
        modelBuilder.ConfigureExtraService();

    }
}
