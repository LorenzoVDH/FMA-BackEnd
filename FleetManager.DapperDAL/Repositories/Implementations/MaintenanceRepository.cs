using Dapper;
using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.DapperDAL.Repositories.Implementations;
public class MaintenanceRepository : IMaintenanceRepository {
    private string _connectionString;

    public MaintenanceRepository(string connectionString) {
        _connectionString = connectionString;
    }

    public async Task CreateAsync(MaintenanceModel maintenance) {
        string insertMaintenanceQuery = @"
        INSERT INTO Maintenances (VehicleID, Date, Cost, GarageID, InvoiceFilePath)
        VALUES (@VehicleID, @Date, @Cost, @GarageID, @InvoiceFilePath);
        SELECT CAST(SCOPE_IDENTITY() as int);";

        using (var connection = new SqlConnection(_connectionString)) {
            var maintenanceId = await connection.ExecuteScalarAsync<int>(insertMaintenanceQuery, new {
                maintenance.VehicleID,
                maintenance.Date,
                maintenance.Cost,
                maintenance.GarageID,
                maintenance.InvoiceFilePath
            });

            maintenance.ID = maintenanceId;
        }
    }

    public async Task DeleteAsync(int maintenanceId) {
        string deleteMaintenanceQuery = @"
        DELETE FROM Maintenances 
        WHERE ID = @MaintenanceID;";

        using (var connection = new SqlConnection(_connectionString)) {
            await connection.ExecuteAsync(deleteMaintenanceQuery, new {
                MaintenanceID = maintenanceId
            });
        }
    }

    public async Task<List<MaintenanceModel>> GetAllMaintenancesOfVehicleIDAsync(int vehicleId) {
        string getMaintenancesOfVehicleQuery = $@"
            SELECT m.ID, m.VehicleID, m.Date, m.Cost, m.GarageID, (SELECT g.Name FROM Garages g WHERE g.ID = m.GarageID) as GarageName, m.InvoiceFilePath
            FROM Maintenances m
            WHERE M.VehicleID = @VehicleID
            ORDER BY Date;" ;

        string getMaintenanceTasksOfMaintenanceQuery = $@"
            SELECT * 
            FROM MaintenanceTasks mt 
            WHERE mt.MaintenanceID = @MaintenanceID
            ORDER BY mt.ID
        ";


        using (var connection = new SqlConnection(_connectionString)) {
            List<MaintenanceModel> maintenances = (await connection.QueryAsync<MaintenanceModel>(getMaintenancesOfVehicleQuery, new {
                VehicleID = vehicleId
            })).ToList();

            foreach (var maintenance in maintenances) {
                List<MaintenanceTaskModel> tasks = (await connection.QueryAsync<MaintenanceTaskModel>(getMaintenanceTasksOfMaintenanceQuery, new {
                    MaintenanceID = maintenance.ID
                })).ToList();
                maintenance.Tasks = tasks;
            }

            return maintenances;
        }
    }

    public async Task<MaintenanceModel> GetMaintenanceByIDAsync(int maintenanceId) {
        MaintenanceModel maintenance;

        string getMaintenancebyIDQuery = $@"
            SELECT m.ID, m.VehicleID, m.Date, m.Cost, m.GarageID, (SELECT g.Name FROM Garages g WHERE g.ID = m.GarageID) as GarageName, m.InvoiceFilePath
            FROM Maintenances m
            WHERE ID = @MaintenanceID;";

        string getMaintenanceTasksOfMaintenanceQuery = $@"
            SELECT * 
            FROM MaintenanceTasks mt 
            WHERE mt.MaintenanceID = @MaintenanceID
            ORDER BY mt.ID
        ";

        using (var connection = new SqlConnection(_connectionString)) {
            maintenance = (await connection.QueryFirstAsync<MaintenanceModel>(getMaintenancebyIDQuery, new {
                MaintenanceID = maintenanceId
            }));

            maintenance.Tasks = (await connection.QueryAsync<MaintenanceTaskModel>(getMaintenanceTasksOfMaintenanceQuery, new {
                MaintenanceID = maintenanceId
            })).ToList(); 
        }

        return maintenance;

    }

    public async Task UpdateAsync(MaintenanceModel maintenance) {
        string updateMaintenanceQuery = @"
        UPDATE Maintenances 
        SET VehicleID = @VehicleID,
            Date = @Date,
            Cost = @Cost,
            GarageID = @GarageID,
            InvoiceFilePath = @InvoiceFilePath
        WHERE ID = @MaintenanceID;";

        using (var connection = new SqlConnection(_connectionString)) {
            await connection.ExecuteAsync(updateMaintenanceQuery, new {
                VehicleID = maintenance.VehicleID,
                Date = maintenance.Date,
                Cost = maintenance.Cost,
                GarageID = maintenance.GarageID,
                InvoiceFilePath = maintenance.InvoiceFilePath,
                MaintenanceID = maintenance.ID
            });
        }
    }

    public async Task<List<MaintenanceTaskModel>> GetMaintenanceTasksByMaintenanceIDAsync(int maintenanceId) {
        List<MaintenanceTaskModel> maintenanceTasks;

        string getMaintenanceTasksQuery = @"
            SELECT *
            FROM MaintenanceTasks mt
            WHERE mt.MaintenanceID = @MaintenanceID; 
        ";

        using (var connection = new SqlConnection(_connectionString)) {
            maintenanceTasks = (await connection.QueryAsync<MaintenanceTaskModel>(getMaintenanceTasksQuery, new {
                MaintenanceID = maintenanceId
            })).ToList();
        }

        return maintenanceTasks;
    }

    
}