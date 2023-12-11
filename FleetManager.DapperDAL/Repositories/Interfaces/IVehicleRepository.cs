using FleetManager.DapperDAL.Models;

namespace FleetManager.DapperDAL.Repositories.Interfaces;
public interface IVehicleRepository {
    Task CreateAsync(VehicleModel vehicle);
    Task<List<VehicleOverviewModel>> GetAllAsync(int pageIndex, int pageLength);
    Task<VehicleModel?> GetByIDAsync(int id);
    Task UpdateAsync(VehicleModel vehicle);
    Task DeleteAsync(int id);
    Task SaveChangesAsync();
    Task<int> GetVehicleCountAsync();
    Task<List<VehicleQuarterlyReportModel>> GetQuarterlyReportsAsync(int vehicleId);
    Task<List<VehicleTypeModel>> GetVehicleTypesAsync();
    Task RemovePendingLicensePlateFromVehicleByIDAsync(int vehicleId);
    Task<List<DriverSimplifiedModel>> GetVehicleDriversByVehicleID(int vehicleId);
    Task<List<VehicleSimplifiedModel>> GetSimplifiedVehiclesBySearchTermAsync(string searchTerm); 
    Task<bool> CheckLicensePlateExistsAsync(int vehicleID, string licenseplate);
    Task<bool> CheckChassisNumberExistsAsync(int vehicleID, string chassisnumber); 
    Task SetVehicleActiveAsync(int vehicleID, bool activeStatus);
    Task<List<LicensePlateModel>> GetLicensePlateHistoryAsync(int vehicleID);
}
