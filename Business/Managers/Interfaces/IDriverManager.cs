using FleetManager.EntityFrameworkDAL.Models.Entities;
namespace FleetManager.BLL.Managers.Interfaces;
public interface IDriverManager {
    Task<int> CreateAsync(Driver driver);
    Task<List<Driver>> GetAllAsync();
    Task<Driver> GetByIDAsync(int id);
    Task UpdateAsync(Driver driver); 
    Task DeleteAsync(int id);
}
