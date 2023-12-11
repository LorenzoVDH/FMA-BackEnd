#nullable enable
using FleetManager.EntityFrameworkDAL.Models.Entities;

namespace FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
public interface IDriverRepository : IRepository<Driver> {
    Task<List<Driver>> GetDriversWithVehiclesAsync(int pageIndex, int pageLength, bool active);
    Task<Driver> GetByNationalRegistrationNumberAsync(string nrn);
    Task<List<Driver>> GetByNameAsync(string? firstName, string? lastName);
    Task<Boolean> IsSameNationalRegistrationNumberFoundAsync(int id, string nrn);
    Task<List<Driver>> GetByNameAndBirthDateAsync(string firstName, string lastName, DateTime dateOfBirth);
    Task<int> GetDriversCountByActiveStatusAsync(bool active);
    Task AddVehicleAssociationToDriver(int driverId, int vehicleId); 
    Task RemoveVehicleAssociationFromDriver(int driverId, int vehicleId);
    Task<List<Driver>> GetDriversBySearchTermAsync(string query);
    Task<Login> GetDriverLoginByEmailAsync(string email);
}
