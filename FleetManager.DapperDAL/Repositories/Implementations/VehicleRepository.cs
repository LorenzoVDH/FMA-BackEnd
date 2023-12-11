using Dapper;
using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using Microsoft.Data.SqlClient;
using System.Transactions;

namespace FleetManager.DapperDAL.Repositories.Implementations;
public class VehicleRepository : IVehicleRepository {
    //Commonly used SQLQueries 
    string _removeLicenseplatePending =
    $@" DELETE FROM LicensePlates
        WHERE ValidityStartDate > @Today AND VehicleID = @VehicleID;
    ";

    private string _connectionString;

    public VehicleRepository(string connectionString) {
        _connectionString = connectionString;
    }

    public async Task CreateAsync(VehicleModel entity) {
        string newVehicleRecordQuery = @"
            INSERT INTO Vehicles (Name, Active, ChassisNumber, FuelType, VehicleTypeID, RegistrationDate, LeasingStartDate, LeasingEndDate)
            VALUES (@Name, 1, @ChassisNumber, @FuelType, @VehicleTypeID, @RegistrationDate, @LeasingStartDate, @LeasingEndDate);
            SELECT SCOPE_IDENTITY();";

        string newLicensePlateQuery = @"
            INSERT INTO LicensePlates (ValidityStartDate, ValidityEndDate, LicensePlateNumber, VehicleID)
            VALUES (@LicensePlateStartDate, NULL, @CurrentLicensePlateNumber, @VehicleID);
        ";

        string updateOldLicensePlateQuery = @"
            UPDATE LicensePlates 
            SET ValidityEndDate = @Today 
            WHERE ValidityEndDate IS NULL AND VehicleID = @VehicleID;
        ";

        string updateMileageQuery = @"
            INSERT INTO Mileages (VehicleID, Date, MileageInKilometers)
            VALUES (@VehicleID, @Date, @MileageInKilometers);
        ";


        using (var connection = new SqlConnection(_connectionString)) {
            await connection.OpenAsync(); //Open the connection 

            using (var transaction = connection.BeginTransaction()) { //Use the connection and begin the transaction 
                try {
                    DateTime today = DateTime.Today;

                    int newVehicleId = await connection.ExecuteScalarAsync<int>(newVehicleRecordQuery, new {
                        //Use ExecuteScalar to retrieve the first column (id) 
                        entity.Name,
                        entity.ChassisNumber,
                        entity.FuelType,
                        entity.VehicleTypeID,
                        entity.RegistrationDate,
                        entity.LeasingStartDate,
                        entity.LeasingEndDate
                    }, transaction);

                    if (newVehicleId == 0) {
                        throw new ArgumentException("The new VehicleID has not been set to something.");
                    }

                    //Update the entity's ID 
                    entity.ID = newVehicleId;

                    await connection.ExecuteAsync(updateOldLicensePlateQuery, new {
                        //Set all the LicensePlates where the enddate is null to today (making sure there are no active ones)
                        Today = today,
                        VehicleID = newVehicleId
                    }, transaction);

                    await connection.ExecuteAsync(newLicensePlateQuery, new {
                        //Execute the INSERT of the LicensePlate 
                        LicensePlateStartDate = entity.LicensePlateStartDate,
                        CurrentLicensePlateNumber = entity.CurrentLicensePlateNumber,
                        VehicleID = newVehicleId
                    }, transaction);

                    await connection.ExecuteAsync(updateMileageQuery, new {
                        //Set the new mileage
                        VehicleID = newVehicleId,
                        Date = today,
                        MileageInKilometers = entity.Mileage
                    }, transaction);

                    await transaction.CommitAsync();
                } catch {
                    //In case either one of the two commands fails, roll the transaction back, so that incomplete actions will not remain
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }

    public async Task DeleteAsync(int id) {
        throw new NotImplementedException();
    }

    public async Task<List<VehicleOverviewModel>> GetAllAsync(int pageIndex, int pageLength) {
        List<VehicleOverviewModel> vehicles;

        string query = $@"
            SELECT
                V.ID,
                V.Name, 
                V.ChassisNumber,
                V.FuelType,
                VT.Name AS VehicleTypeName,
                V.RegistrationDate,
                V.LeasingStartDate,
                V.LeasingEndDate,
                (SELECT TOP 1 MileageInKilometers 
                 FROM Mileages 
                 WHERE VehicleID = V.ID 
                 ORDER BY Date DESC) AS currentMileageInKilometers,
                (SELECT TOP 1 LicensePlateNumber 
                 FROM LicensePlates 
                 WHERE VehicleID = V.ID AND (@Today >= ValidityStartDate AND (@Today <= ValidityEndDate OR ValidityEndDate IS NULL))
                 ORDER BY 
                    CASE
                        WHEN ValidityEndDate IS NULL THEN 0 -- A ValidityEndDate of NULL should be prioritized over one that is set to today
                        WHEN ValidityEndDate = @Today THEN 1
                    END) AS currentLicensePlate,
                (SELECT TOP 1 LicensePlateNumber
                FROM LicensePlates
                WHERE VehicleID = V.ID AND ValidityStartDate > @Today
                ORDER BY ValidityStartDate) AS PendingLicensePlateNumber,
                (SELECT TOP 1 ValidityStartDate
                FROM LicensePlates
                WHERE VehicleID = V.ID AND ValidityStartDate > @Today
                ORDER BY ValidityStartDate) AS PendingLicensePlateStartDate
            FROM
                Vehicles V
            JOIN
                VehicleTypes VT ON V.VehicleTypeID = VT.ID
            WHERE 
                V.Active = 1
            ORDER BY (SELECT NULL)
            OFFSET @Offset ROWS
            FETCH NEXT @PageLength ROWS ONLY";

        using (var connection = new SqlConnection(_connectionString)) {
            vehicles = (await connection.QueryAsync<VehicleOverviewModel>(query, new {
                Offset = pageIndex * pageLength,
                PageLength = pageLength,
                Today = DateTime.Today,
            })).ToList();
        }

        return vehicles;
    }

    public async Task<VehicleModel?> GetByIDAsync(int id) {
        VehicleModel? vehicle;

        string queryVehicle = $@"
            SELECT 
                V.ID, 
                V.ChassisNumber, 
                V.FuelType, 
                V.VehicleTypeID, 
                V.RegistrationDate, 
                V.LeasingStartDate, 
                V.LeasingEndDate, 
                V.Name AS Name, 
                VT.ID AS VehicleTypeID, 
                (SELECT TOP 1 MileageInKilometers 
                 FROM Mileages 
                 WHERE VehicleID = V.ID 
                 ORDER BY Date DESC) AS mileage,
                (SELECT TOP 1 LicensePlateNumber 
                 FROM LicensePlates 
                 WHERE VehicleID = V.ID AND (@Today >= ValidityStartDate AND (@Today <= ValidityEndDate OR ValidityEndDate IS NULL))
                 ORDER BY 
                    CASE
                        WHEN ValidityEndDate IS NULL THEN 0 -- A ValidityEndDate of NULL should be prioritized over one that is set to today
                        WHEN ValidityEndDate = @Today THEN 1
                    END) AS currentLicensePlateNumber,
                 (SELECT TOP 1 ValidityStartDate 
                 FROM LicensePlates 
                 WHERE VehicleID = V.ID AND (@Today >= ValidityStartDate AND (@Today <= ValidityEndDate OR ValidityEndDate IS NULL))
                 ORDER BY 
                    CASE
                        WHEN ValidityEndDate IS NULL THEN 0 
                        WHEN ValidityEndDate = @Today THEN 1
                    END) AS licensePlateStartDate,
                (SELECT TOP 1 LicensePlateNumber
                FROM LicensePlates
                WHERE VehicleID = V.ID AND ValidityStartDate > @Today
                ORDER BY ValidityStartDate) AS PendingLicensePlateNumber,
                (SELECT TOP 1 ValidityStartDate
                FROM LicensePlates
                WHERE VehicleID = V.ID AND ValidityStartDate > @Today
                ORDER BY ValidityStartDate) AS PendingLicensePlateStartDate
            FROM Vehicles V 
            LEFT JOIN VehicleTypes VT ON VT.ID = V.VehicleTypeID 
            WHERE V.ID = @VehicleID AND V.Active = 1;";

        using (var connection = new SqlConnection(_connectionString)) {
            DateTime today = DateTime.Today;

            vehicle = (await connection.QueryAsync<VehicleModel>(queryVehicle, new {
                VehicleID = id,
                Today = today
            })).FirstOrDefault();

        }

        return vehicle;
    }

    public async Task<List<DriverSimplifiedModel>> GetVehicleDriversByVehicleID(int vehicleId) {
        List<DriverSimplifiedModel> drivers;

        string queryDriversOfVehicle = $@"
            SELECT D.FirstName AS FirstName, D.LastName AS LastName, D.NationalRegistrationNumber AS NationalRegistrationNumber, D.ID AS ID
            FROM Vehicles V 
            LEFT JOIN DriverVehicles DV ON V.ID = DV.VehicleID
            LEFT JOIN Drivers D ON D.ID = DV.DriverID
            WHERE V.ID = @VehicleID and V.Active = 1
            ORDER BY ID;";

        using (var connection = new SqlConnection(_connectionString)) {
            drivers = (await connection.QueryAsync<DriverSimplifiedModel>(queryDriversOfVehicle, new {
                VehicleID = vehicleId
            })).ToList();
        }

        return drivers;
    }

    public async Task RemovePendingLicensePlateFromVehicleByIDAsync(int vehicleId) {
        using (var connection = new SqlConnection(_connectionString)) {
            await connection.OpenAsync();

            using (var transaction = connection.BeginTransaction()) {
                try {
                    DateTime today = DateTime.Today;

                    await connection.ExecuteAsync(_removeLicenseplatePending, new {
                        VehicleID = vehicleId,
                        Today = today
                    }, transaction);

                    transaction.Commit();
                } catch {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }

    public async Task UpdateAsync(VehicleModel vehicle) {
        if (vehicle == null) {
            throw new ArgumentNullException(nameof(vehicle));
        }

        string vehicleQuery =
            $@" UPDATE Vehicles
                SET ChassisNumber=@ChassisNumber, FuelType=@FuelType, VehicleTypeID=@VehicleTypeID, RegistrationDate=@RegistrationDate, LeasingStartDate=@LeasingStartDate, LeasingEndDate=@LeasingEndDate, Name=@Name
                WHERE ID=@ID;";

        string licenseplateUpdateEndDates =
            $@" UPDATE LicensePlates
                SET ValidityEndDate = @OldLicensePlateEndDate
                WHERE VehicleID=@VehicleID AND (ValidityEndDate IS NULL OR ValidityEndDate > @Today);
            ";

        string addLicenseplate =
            $@" INSERT INTO LicensePlates (VehicleID, ValidityStartDate, LicensePlateNumber)
                VALUES (@VehicleID, @ValidityStartDate, @LicensePlateNumber)  
            ";

        string updateMileageQuery =
            @"  INSERT INTO Mileages (VehicleID, Date, MileageInKilometers)
                VALUES (@VehicleID, @Date, @MileageInKilometers);
            ";

        using (var connection = new SqlConnection(_connectionString)) {
            await connection.OpenAsync();

            using (var transaction = connection.BeginTransaction()) {
                try {
                    DateTime today = DateTime.Today;
                    //CHANGE THE VEHICLE  
                    await connection.ExecuteAsync(vehicleQuery, new {
                        ID = vehicle.ID,
                        ChassisNumber = vehicle.ChassisNumber,
                        FuelType = vehicle.FuelType,
                        VehicleTypeID = vehicle.VehicleTypeID,
                        RegistrationDate = vehicle.RegistrationDate,
                        LeasingStartDate = vehicle.LeasingStartDate,
                        LeasingEndDate = vehicle.LeasingEndDate,
                        Name = vehicle.Name
                    }, transaction);

                    //UPDATE THE LICENSEPLATE 
                    //Ignore if the current LicensePlate matches the vehicle's LicensePlate 

                    bool licensePlateChanged = false;
                    decimal maximumMileage = 0;

                    // Check if the LicensePlate has changed    
                    var currentLicensePlateRecord = await connection.QueryFirstOrDefaultAsync<dynamic>($@"
                        SELECT LicensePlateNumber
                        FROM LicensePlates
                        WHERE VehicleID = @VehicleID AND @Today BETWEEN ValidityStartDate AND ValidityEndDate",
                        new { VehicleID = vehicle.ID, Today = today }, transaction);

                    if (currentLicensePlateRecord == null) {
                        //In case no LicensePlateRecord for the vehicle was found, then it has also changed 
                        licensePlateChanged = true;
                    } else {
                        licensePlateChanged = currentLicensePlateRecord.LicensePlateNumber != vehicle.CurrentLicensePlateNumber;
                    }

                    if (licensePlateChanged) {
                        // Check if the new LicensePlate already exists in the past
                        var existingLicensePlateRecord = await connection.QueryFirstOrDefaultAsync<dynamic>($@"
                            SELECT LicensePlateNumber
                            FROM LicensePlates
                            WHERE LicensePlateNumber = @LicensePlateNumber AND ValidityEndDate < @Today",
                            new { LicensePlateNumber = vehicle.CurrentLicensePlateNumber, Today = today }, transaction);

                        if (existingLicensePlateRecord != null) {
                            throw new InvalidOperationException("This License Plate had already been added in the past.");
                        }

                        //If there is a pending licenseplate - one with its ValidityStartDate in the future, remove it  
                        await connection.ExecuteAsync(_removeLicenseplatePending, new {
                            VehicleID = vehicle.ID,
                            Today = today
                        }, transaction);

                        //End the current LicensePlate ValidityPeriod, also makes sure there are no active LicensePlates anymore
                        await connection.ExecuteAsync(licenseplateUpdateEndDates, new {
                            VehicleID = vehicle.ID,
                            Today = today,
                            OldLicensePlateEndDate = vehicle.LicensePlateStartDate == null ? today : vehicle.LicensePlateStartDate,
                        }, transaction);

                        //Add the new LicensePlate 
                        await connection.ExecuteAsync(addLicenseplate, new {
                            VehicleID = vehicle.ID,
                            ValidityStartDate = vehicle.LicensePlateStartDate == null ? today : vehicle.LicensePlateStartDate,
                            LicensePlateNumber = vehicle.CurrentLicensePlateNumber
                        }, transaction);
                    }

                    //UPDATE THE MILEAGE  
                    maximumMileage = await connection.ExecuteScalarAsync<decimal>(
                        $@"SELECT MAX(MileageInKilometers)
                        FROM Mileages
                        WHERE VehicleID = @VehicleID",
                        new { VehicleID = vehicle.ID }, transaction);

                    bool mileageChanged = (vehicle.Mileage != maximumMileage);
                    if (mileageChanged) {

                        if (vehicle.Mileage < maximumMileage) {
                            throw new InvalidOperationException("The mileage of a vehicle cannot be lowered.");
                        }


                        await connection.ExecuteAsync(updateMileageQuery, new {
                            //Set the new mileage
                            VehicleID = vehicle.ID,
                            Date = today,
                            MileageInKilometers = vehicle.Mileage
                        }, transaction);
                    }

                    await transaction.CommitAsync();

                } catch {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }

    public async Task SaveChangesAsync() {
        throw new NotImplementedException();
    }

    public async Task<int> GetVehicleCountAsync() {
        using (var connection = new SqlConnection(_connectionString)) {
            string query = "SELECT COUNT(*) FROM Vehicles WHERE Active = 1";
            int count = await connection.QueryFirstOrDefaultAsync<int>(query);
            return count;
        }
    }

    public async Task<List<VehicleQuarterlyReportModel>> GetQuarterlyReportsAsync(int vehicleId) {
        List<VehicleQuarterlyReportModel> reports;

        string query = $@"
            SELECT ROW_NUMBER() OVER (ORDER BY Year, Quarter) AS ID, Year, Quarter, SUM(Repairs) AS Repairs, SUM(Maintenances) AS Maintenances, SUM(DamageCount) AS DamageReports
            FROM (
                SELECT YEAR(RepairDate) AS Year, DATEPART(QUARTER, RepairDate) AS Quarter, COUNT(*) AS Repairs, 0 AS Maintenances, 0 AS DamageCount
                FROM Repairs
                WHERE VehicleID = @VehicleId
                GROUP BY DATEPART(QUARTER, RepairDate), YEAR(RepairDate)

                UNION ALL

                SELECT YEAR(Date) AS Year, DATEPART(QUARTER, Date) AS Quarter, 0 AS Repairs, COUNT(*) AS Maintenances, 0 AS DamageCount
                FROM Maintenances
                WHERE VehicleID = @VehicleId
                GROUP BY DATEPART(QUARTER, Date), YEAR(Date)

                UNION ALL

                SELECT YEAR(DR.ReportDate) AS Year, DATEPART(QUARTER, DR.ReportDate) AS Quarter, 0 AS Repairs, 0 AS Maintenances, COUNT(*) AS DamageCount
                FROM DamageReports DR
                INNER JOIN InspectionReports IR ON DR.InspectionReportID = IR.ID
                WHERE IR.VehicleID = @VehicleId
                GROUP BY DATEPART(QUARTER, DR.ReportDate), YEAR(DR.ReportDate)
            ) AS CombinedData
            GROUP BY Year, Quarter";

        using (var connection = new SqlConnection(_connectionString)) {
            reports = (await connection.QueryAsync<VehicleQuarterlyReportModel>(query, new { VehicleId = vehicleId })).ToList();
        }

        return reports;
    }

    public async Task<List<VehicleTypeModel>> GetVehicleTypesAsync() {
        List<VehicleTypeModel> vehicleTypes;

        string query = $@"SELECT ID, Name FROM VehicleTypes;";

        using (var connection = new SqlConnection(_connectionString)) {
            vehicleTypes = (await connection.QueryAsync<VehicleTypeModel>(query)).ToList();
        }

        return vehicleTypes;
    }

    public async Task<List<VehicleSimplifiedModel>> GetSimplifiedVehiclesBySearchTermAsync(string query) {
        //The vehicles inside of the Vehicles table should be searchable by Name, ChassisNumber and LicensePlateNumber.
        //Keep in mind that LicensePlateNumber only exists in the LicensePlates table, of which each record contains a FK VehicleID. 
        //The licenseplates also have a ValidityStartDate and ValidityEndDate. Only pick the LicensePlateNumber of the LicensePlate of 
        //which the current date is equal to or lies between ValidityStartDate and ValidityEndDate, or of which the current date is later 
        //than ValidityStartDate and the ValidityEndDate is NULL. 
        List<VehicleSimplifiedModel> vehicles;

        string getSimplifiedVehiclesBySearchTermQuery = $@"
        SELECT DISTINCT v.Name, v.ChassisNumber, v.ID as ID, lp.LicensePlateNumber as CurrentLicensePlateNumber
        FROM Vehicles v
        LEFT JOIN LicensePlates lp ON lp.VehicleID = v.ID
        WHERE (v.Name LIKE '%' + @SearchTerm + '%'
        OR v.ChassisNumber LIKE '%' + @SearchTerm + '%'
        OR lp.LicensePlateNumber LIKE '%' + @SearchTerm + '%')
        AND (GETDATE() BETWEEN lp.ValidityStartDate AND lp.ValidityEndDate OR lp.ValidityEndDate IS NULL);";

        using (var connection = new SqlConnection(_connectionString)) {
            vehicles = (await connection.QueryAsync<VehicleSimplifiedModel>(getSimplifiedVehiclesBySearchTermQuery, new {
                SearchTerm = query,
                Today = DateTime.Today
            })).ToList(); 
        }

        return vehicles; 
    }

    public async Task<bool> CheckLicensePlateExistsAsync(int vehicleID, string licenseplatenumber) {
        //Exception: do not check for the currently active licenseplate of the vehicle 
        string getLicensePlatesQuery = @"
            SELECT TOP 1 1 FROM LicensePlates WHERE LicensePlateNumber = @LicensePlateNumber 
                AND NOT (VehicleID = @VehicleID AND @Today >= ValidityStartDate AND (@Today <= ValidityEndDate OR ValidityEndDate IS NULL));
        ";

        using (var connection = new SqlConnection(_connectionString)) {
            var result = await connection.ExecuteScalarAsync<int>(getLicensePlatesQuery, new {
                LicensePlateNumber = licenseplatenumber, 
                VehicleID = vehicleID,
                Today = DateTime.Today
            });

            return result == 1;
        }
    }

    public async Task<bool> CheckChassisNumberExistsAsync(int vehicleID, string chassisnumber) {
        string getChassisnumbersQuery = $@"
            SELECT TOP 1 1 FROM Vehicles WHERE ChassisNumber = @ChassisNumber AND ID != @VehicleID; 
        ";
            
        using (var connection = new SqlConnection(_connectionString)) {
            var result = await connection.ExecuteScalarAsync<int>(getChassisnumbersQuery, new {
                ChassisNumber = chassisnumber,
                VehicleID = vehicleID
            });

            return result == 1;
        }
    }

    public async Task SetVehicleActiveAsync(int vehicleID, bool activeStatus) {
        string setVehicleActiveQuery = $@"
            UPDATE Vehicles
            SET Active=@Active
            WHERE ID=@ID;
        ";

        using (var connection = new SqlConnection(_connectionString)) {
            await connection.ExecuteAsync(setVehicleActiveQuery, new {
                Active = activeStatus,
                ID = vehicleID
            });
        }
    }

    public async Task<List<LicensePlateModel>> GetLicensePlateHistoryAsync(int vehicleID) {
        List<LicensePlateModel> licensePlates = new(); 
        
        string getLicensePlateHistoryQuery = $@"
            SELECT * 
            FROM LicensePlates lp
            WHERE VehicleID = @VehicleID
            ORDER BY ValidityStartDate
        ";

        using (var connection = new SqlConnection(_connectionString)) {
            licensePlates = (await connection.QueryAsync<LicensePlateModel>(getLicensePlateHistoryQuery, new {
                VehicleID = vehicleID
            })).ToList(); 
        }

        return licensePlates;
    }
}

