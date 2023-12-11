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
public class SetVehicleActiveStatusCommand : IRequest {
    public int VehicleID { get; set; } 
    public bool ActiveStatus { get; set; }
    public SetVehicleActiveStatusCommand(int vehicleID, bool activeStatus) {
        VehicleID = vehicleID;
        ActiveStatus = activeStatus;
    }
}

public class SetVehicleActiveStatusHandler : IRequestHandler<SetVehicleActiveStatusCommand> {
    private readonly IVehicleRepository _vehicleRepository;

    public SetVehicleActiveStatusHandler(IVehicleRepository vehicleRepository) {
        _vehicleRepository = vehicleRepository;
    }

    public async Task Handle(SetVehicleActiveStatusCommand command, CancellationToken cancellationToken) {
        //Updating 
        await _vehicleRepository.SetVehicleActiveAsync(command.VehicleID, command.ActiveStatus);
    }
}
