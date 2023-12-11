using FleetManager.DapperDAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.DapperDAL.Repositories.Interfaces;
public interface IMaintenanceRepository {
    Task CreateAsync(MaintenanceModel maintenance);
    Task<List<MaintenanceModel>> GetAllMaintenancesOfVehicleIDAsync(int vehicleId);
    Task<MaintenanceModel> GetMaintenanceByIDAsync(int maintenanceId);
    Task UpdateAsync(MaintenanceModel maintenance); 
    Task DeleteAsync(int maintenanceId); 
    //Task<List<MaintenanceTaskModel>> GetMaintenanceTasksByMaintenanceIDAsync(int maintenanceId); 
}