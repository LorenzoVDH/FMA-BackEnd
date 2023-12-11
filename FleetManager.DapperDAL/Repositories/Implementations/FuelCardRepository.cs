using Dapper;
using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace FleetManager.DapperDAL.Repositories.Implementations;
public class FuelCardRepository : IFuelCardRepository {
    private string _connectionString;

    public FuelCardRepository(string connectionString) {
        _connectionString = connectionString;
    }
    public async Task<List<FuelCardModel>> GetFuelCardsByDriverIDAsync(int driverID) {
        List<FuelCardModel> fuelcards;

        string query = $@"
            SELECT 	fc.ID as ID,
		            fc.FuelCardNumber as CardNumber, 
		            fc.CardValidityEndDate as ValidityEndDate, 
		            fc.FuelType as FuelType
            FROM DriverFuelCards dfc 
            LEFT JOIN FuelCards fc ON dfc.FuelCardID = fc.ID 
            WHERE dfc.DriverID = @DriverID
	            AND ((GETDATE() BETWEEN dfc.OwnershipStartDate AND dfc.OwnershipEndDate) OR 
	            dfc.OwnershipEndDate IS NULL); 
        ";
        string servicesQuery = $@"
            SELECT es.ID as ID,
                   es.Description as Description
            FROM FuelCardsExtraServices fces 
            LEFT JOIN ExtraServices es ON fces.ExtraServiceID = es.ID 
            WHERE fces.FuelCardID = @FuelCardID;
        ";

        using (var connection = new SqlConnection(_connectionString)) {
            fuelcards = (await connection.QueryAsync<FuelCardModel>(query, new {
                DriverID = driverID
            })).ToList(); 

            foreach (FuelCardModel fuelcard in fuelcards) {
                fuelcard.ExtraServices = (await connection.QueryAsync<ExtraServiceModel>(servicesQuery, new {
                    FuelCardID = fuelcard.ID
                })).Select(es => es.Description).ToList();
            }
        }

        return fuelcards;
    }
}
