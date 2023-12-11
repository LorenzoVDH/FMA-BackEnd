using FleetManager.BLL.Utilities;
using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Implementations;
using FleetManager.DapperDAL.Repositories.Interfaces;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using FluentValidation;
using MediatR;
using System.Diagnostics;

namespace FleetManager.BLL.Mediator.Commands.VehicleCommands;
public class CreateVehicleCommand : IRequest {
    public VehicleModel? Vehicle { get; set; }
    public CreateVehicleCommand(VehicleModel? vehicle) {
        Vehicle = vehicle;
    }
}

public class CreateVehicleHandler : IRequestHandler<CreateVehicleCommand> {
    private readonly IVehicleRepository _vehicleRepository;
    private readonly IValidator<VehicleModel> _vehicleValidator;

    public CreateVehicleHandler(IVehicleRepository vehicleRepository, IValidator<VehicleModel> vehicleValidator) {
        _vehicleRepository = vehicleRepository;
        _vehicleValidator = vehicleValidator;
    }

    public async Task Handle(CreateVehicleCommand command, CancellationToken cancellationToken) {
        VehicleModel vehicle = command.Vehicle;

        //Validation 
        await _vehicleValidator.ValidateAndThrowAsync(vehicle);

        //Creation 
        await _vehicleRepository.CreateAsync(vehicle);
    }
}

