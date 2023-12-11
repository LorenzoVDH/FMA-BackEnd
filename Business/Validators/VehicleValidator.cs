using FluentValidation;
using FleetManager.DapperDAL.Repositories.Interfaces;
using FleetManager.DapperDAL.Models;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using System.Security.Cryptography;

namespace FleetManager.BLL.Validators;
public class VehicleValidator : AbstractValidator<VehicleModel> {
    //Inject the VehicleRepository for Cross-Entity validation 
    private readonly IVehicleRepository _vehicleRepository;
    public VehicleValidator(IVehicleRepository vehicleRepository) {
        _vehicleRepository = vehicleRepository;

        RuleFor(v => v)
            .NotNull()
                .WithMessage("A Vehicle cannot be Null")
            .MustAsync(async (vehicle, cancellationToken) => await CheckNoLicensePlateExistsAsync(vehicle.ID, vehicle.CurrentLicensePlateNumber))
                .WithMessage("The licenseplate already exists!")
            .MustAsync(async (vehicle, cancellationToken) => await CheckNoChassisNumberExistsAsync(vehicle.ID, vehicle.ChassisNumber))
                .WithMessage("The chassisnumber already exists!");

        RuleFor(v => v.ChassisNumber)
            .NotNull()
                .WithMessage("A vehicle needs a chassisnumber")
            .NotEmpty()
                .WithMessage("A chassisnumber cannot be empty");

        RuleFor(v => v.CurrentLicensePlateNumber)
            .NotNull()
                .WithMessage("A vehicle needs a licenseplate")
            .NotEmpty()
                .WithMessage("A licenseplate cannot be empty");

        RuleFor(v => v.LicensePlateStartDate)
            .GreaterThanOrEqualTo(DateTime.Today)
            .NotNull(); 

        RuleFor(v => v.LeasingStartDate)
            .Must(leasingStartDate => leasingStartDate != default(DateTime));

        RuleFor(v => v.LeasingEndDate)
            .GreaterThanOrEqualTo(v => v.LeasingStartDate)
            .WithMessage("The leasing end date must be after the leasing start date");

        RuleFor(v => v.Mileage)
            .GreaterThanOrEqualTo(0)
            .WithMessage("Mileage cannot be lower than 0"); 

    }

    private async Task<bool> CheckNoLicensePlateExistsAsync(int vehicleID, string licenseplate) {
        return !await _vehicleRepository.CheckLicensePlateExistsAsync(vehicleID, licenseplate);
    }

    private async Task<bool> CheckNoChassisNumberExistsAsync(int vehicleID, string chassisnumber) {
        return !await _vehicleRepository.CheckChassisNumberExistsAsync(vehicleID, chassisnumber); 
    }
}
