using FleetManager.EntityFrameworkDAL.Context;
using FleetManager.EntityFrameworkDAL.Repositories.Implementations;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using FleetManager.DapperDAL.Repositories.Implementations;
using FleetManager.DapperDAL.Repositories.Interfaces; 
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace FleetManager.BLL;
public static class SetupExtensions {
    public static void SetupRepositories(this IServiceCollection services, string connectionString) {
        services.AddScoped<IDriverRepository, DriverRepository>();
        services.AddScoped<IVehicleRepository>(x => new VehicleRepository(connectionString));
        services.AddScoped<IMaintenanceRepository>(x => new MaintenanceRepository(connectionString));
        services.AddScoped<IFuelCardRepository>(x => new FuelCardRepository(connectionString)); 
        services.AddScoped<IInquiryRepository>(x => new InquiryRepository(connectionString)); 
    }

    public static void SetupContext(this IServiceCollection services, string connectionString, QueryTrackingBehavior qtb) {
        services.AddDbContext<FleetManagerContext>( 
            options => options.UseSqlServer(connectionString)
                              .UseQueryTrackingBehavior(qtb) 
        ); 
    }
}
