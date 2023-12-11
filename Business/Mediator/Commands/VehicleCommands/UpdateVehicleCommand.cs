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
public class UpdateVehicleCommand : IRequest {
    public VehicleModel? Vehicle { get; set; }
    public UpdateVehicleCommand(VehicleModel? vehicle) {
        Vehicle = vehicle;
    }
}

public class UpdateVehicleHandler : IRequestHandler<UpdateVehicleCommand> {
    private readonly IVehicleRepository _vehicleRepository;
    private readonly IValidator<VehicleModel> _vehicleValidator;

    public UpdateVehicleHandler(IVehicleRepository vehicleRepository, IValidator<VehicleModel> vehicleValidator) {
        _vehicleRepository = vehicleRepository;
        _vehicleValidator = vehicleValidator;
    }

    public async Task Handle(UpdateVehicleCommand command, CancellationToken cancellationToken) {
        VehicleModel vehicle = command.Vehicle;

        //Validation 
        await _vehicleValidator.ValidateAndThrowAsync(vehicle);

        //Updating 
        await _vehicleRepository.UpdateAsync(vehicle);
    }
}
