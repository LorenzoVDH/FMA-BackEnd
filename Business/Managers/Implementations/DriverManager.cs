using FleetManager.BLL.Exceptions;
using FleetManager.BLL.Managers.Interfaces;
using FleetManager.BLL.Validators;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using FluentValidation;
using FluentValidation.Results;
using Microsoft.Data.SqlClient;


namespace FleetManager.BLL.Managers.Implementations;
public class DriverManager : IDriverManager {
    //This driver manager can be ignored. This was created before making use of MediatR. We were told not to remove it though. 

    private readonly IDriverRepository _driverRepository;
    private readonly IValidator<Driver> _validator;

    public DriverManager(IDriverRepository driverRepository, IValidator<Driver> driverValidator) {
        _driverRepository = driverRepository;
        _validator = driverValidator;
    }

    public async Task<int> CreateAsync(Driver driver) {
        driver.NationalRegistrationNumber = driver.NationalRegistrationNumber.Replace("-", "").Replace(".", "").Replace(" ", "");

        //Check if this driver already exists 
        Driver existingDriver = await _driverRepository.GetByNationalRegistrationNumberAsync(driver.NationalRegistrationNumber);
        
        if (existingDriver != null) {
            throw new ArgumentException("A driver with the same National Registration Number already exists."); 
        }

        //Validation 
        await ValidateDriverAsync(driver);

        //Creation 
        return await _driverRepository.CreateAsync(driver);
    }

    public async Task<List<Driver>> GetAllAsync(int pageIndex, int pageLength ) {
        return await _driverRepository.GetAllAsync(pageIndex, pageLength);
    }

    public async Task<Driver> GetByIDAsync(int id) {
        return await _driverRepository.GetByIDAsync(id);
    }

    public async Task UpdateAsync(Driver driver) {
        driver.NationalRegistrationNumber = driver.NationalRegistrationNumber.Replace("-", "").Replace(".", "").Replace(" ", "");
        await ValidateDriverAsync(driver);
        await _driverRepository.UpdateAsync(driver);
    }

    public async Task DeleteAsync(int id) {
        try {
            await _driverRepository.DeleteAsync(id);
        } catch (SqlException ex) when (ex.Number == 547) {
            throw new AssociatedRecordException("Cannot delete the driver because it has associated records in other tables.", ex);
        }
    }

    private async Task ValidateDriverAsync(Driver driver) {
        ValidationResult validationResult = await _validator.ValidateAsync(new ValidationContext<Driver>(driver));

        if (!validationResult.IsValid) {
            var errorMessages = validationResult.Errors
                .Select(error => error.ErrorMessage)
                .ToList();

            string errorMessage = string.Join(Environment.NewLine, errorMessages);

            throw new ValidationException(errorMessage);
        }
    }

    public Task<List<Driver>> GetAllAsync() {
        throw new NotImplementedException();
    }
}
