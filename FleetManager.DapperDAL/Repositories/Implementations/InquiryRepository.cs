using Dapper;
using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using Microsoft.Data.SqlClient;

namespace FleetManager.DapperDAL.Repositories.Implementations;
public class InquiryRepository : IInquiryRepository {
    private string _connectionString;
    public InquiryRepository(string connectionString) {
        _connectionString = connectionString;
    }

    public async Task UpdateAsync(InquiryModel inquiry) {
        string updateInquiryQuery = @"
        UPDATE Inquiries
        SET 
            DateOfInquiry=@DateOfInquiry, 
            Status=@Status, 
            VehicleID=@VehicleID, 
            Comment=@Comment
        WHERE ID=@ID;";

        using (var connection = new SqlConnection(_connectionString)) {
            await connection.ExecuteAsync(updateInquiryQuery, new {
                ID = inquiry.ID,
                DateOfInquiry = inquiry.InquiryDate,
                Status = inquiry.Status,
                VehicleID = inquiry.VehicleID,
                Comment = inquiry.Comment
            });
        }
    }

    public async Task<List<InquiryModel>> GetInquiriesWithPaginationAsync(int pageIndex, int pageLength) {
        List<InquiryModel> inquiries;

        string query = $@"
             SELECT 	
	            i.ID as ID,
	            i.DateOfInquiry as InquiryDate,
	            it.Category as InquiryCategory,
	            it.Name as InquiryTypeName,
	            d.ID as DriverID,
	            d.FirstName as DriverFirstName,
	            d.LastName as DriverLastName,
	            i.VehicleID as VehicleID,
	            v.Name as VehicleName,
	            i.Comment as Comment,
	            i.Status as Status,
	            MAX (pd.PreferredDate) as PreferredDate,
	            MIN (pd.PreferredDate) as PreferredDateBackup
            FROM Inquiries i
            LEFT JOIN InquiryTypes as it ON it.ID = i.InquiryTypeID
            LEFT JOIN Vehicles v ON i.VehicleID = v.ID 
            LEFT JOIN Drivers d ON i.DriverID = d.ID 
            LEFT JOIN PreferredAppointmentDates pd ON i.ID = pd.InquiryID 
            GROUP BY it.Category, it.Name, i.ID, i.DateOfInquiry, it.Name, d.ID, d.FirstName, d.LastName, i.VehicleID, v.Name, i.Comment, i.Status 
            ORDER BY InquiryDate DESC
            OFFSET @Offset ROWS FETCH NEXT @PageLength ROWS ONLY
        ";

        using (var connection = new SqlConnection(_connectionString)) {
            inquiries = (await connection.QueryAsync<InquiryModel>(query, new {
                Offset = pageIndex * pageLength,
                PageLength = pageLength,
            })).ToList();
        }

        return inquiries;
    }

    public async Task<List<InquiryModel>> GetInquiriesByDriverIDAsync(int driverID) {
        List<InquiryModel> inquiries;

        string query = $@"
             SELECT 	i.ID as ID,
		            i.DateOfInquiry as InquiryDate,
		            i.InquiryTypeID as InquiryTypeID,
		            it.Name as InquiryTypeName,
		            MIN(pd.PreferredDate) as PreferredDate,
		            MAX(pd.PreferredDate) as PreferredDateBackup,
		            i.Status as Status,
		            i.Comment as Comment,
		            i.VehicleID as VehicleID,
		            v.Name as VehicleName
            FROM Inquiries i
            LEFT JOIN InquiryTypes as it ON it.ID = i.InquiryTypeID
            LEFT JOIN PreferredAppointmentDates pd ON i.ID = pd.InquiryID
            LEFT JOIN Vehicles v ON i.VehicleID = v.ID
            WHERE i.DriverID = @DriverID
            GROUP BY i.ID, i.DateOfInquiry, i.InquiryTypeID, it.Name, i.Status, i.Comment, i.VehicleID, v.Name
            ORDER BY InquiryDate DESC
        ";

        using (var connection = new SqlConnection(_connectionString)) {
            inquiries = (await connection.QueryAsync<InquiryModel>(query, new {
                DriverID = driverID
            })).ToList();
        }

        return inquiries;
    }

    public async Task<List<InquiryTypeModel>> GetInquiryTypesByCategoryNameAsync(string categoryName) {
        List<InquiryTypeModel> inquiryTypes;

        using (var connection = new SqlConnection(_connectionString)) {
            inquiryTypes = (await connection.QueryAsync<InquiryTypeModel>("SELECT * FROM InquiryTypes it WHERE Category = @Category;", new {
                Category = categoryName
            })).ToList();
        }

        return inquiryTypes; 
    }

    public async Task CreateAsync(InquiryModel inquiry) {
        string inquiryQuery = $@"
            INSERT INTO Inquiries (DriverID, Comment, DateOfInquiry, InquiryTypeID, Status, VehicleID)
            VALUES (@DriverID, @Comment, @DateOfInquiry, @InquiryTypeID, @Status, @VehicleID);
            SELECT SCOPE_IDENTITY();
        ";

        string datesQuery = $@"
            INSERT INTO PreferredAppointmentDates (InquiryID, PreferredDate)
            VALUES (@InquiryID, @PreferredDate); 
        ";

        using (var connection = new SqlConnection(_connectionString)) {
            await connection.OpenAsync(); 

            using (var transaction = connection.BeginTransaction()) { 
                try {
                    var inquiryId = await connection.ExecuteScalarAsync<int>(inquiryQuery, new {
                        DriverID = inquiry.DriverID,
                        Comment = inquiry.Comment,
                        DateOfInquiry = DateTime.Now,
                        InquiryTypeID = inquiry.InquiryTypeID,
                        Status = "New",
                        VehicleID = inquiry.VehicleID
                    }, transaction);

                    if (inquiryId == 0) {
                        throw new ArgumentException("The new inquiryID has not been set to something.");
                    }

                    inquiry.ID = inquiryId;

                    if (inquiry.PreferredDate != null) { 
                        await connection.ExecuteAsync(datesQuery, new {
                            InquiryID = inquiryId,
                            PreferredDate = inquiry.PreferredDate
                        }, transaction);

                        if (inquiry.PreferredDateBackup != null) { 
                            await connection.ExecuteAsync(datesQuery, new {
                                InquiryID = inquiryId,
                                PreferredDate = inquiry.PreferredDateBackup
                            }, transaction);
                        }
                    }

                    await transaction.CommitAsync();
                } catch {
                    transaction.Rollback();
                    throw;
                }
            }
        }
    }

    public async Task<int> GetInquiryCountAsync() {
        using (var connection = new SqlConnection(_connectionString)) {
            string query = "SELECT COUNT(*) FROM Inquiries";
            int count = await connection.QueryFirstOrDefaultAsync<int>(query);
            return count;
        }
    }
}
