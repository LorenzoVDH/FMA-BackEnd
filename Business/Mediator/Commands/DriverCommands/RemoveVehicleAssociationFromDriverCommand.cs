using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using FluentValidation;
using MediatR;

namespace FleetManager.BLL.Mediator.Commands.DriverCommands;
public class RemoveVehicleAssociationFromDriverCommand : IRequest {
    public int DriverID { get; set; }
    public int VehicleID { get; set; }

    public RemoveVehicleAssociationFromDriverCommand(int driverId, int vehicleId) {
        DriverID = driverId;
        VehicleID = vehicleId; 
    }
}

public class RemoveVehicleAssociationFromDriverHandler : IRequestHandler<RemoveVehicleAssociationFromDriverCommand> {
    private readonly IDriverRepository _driverRepository;
    private readonly IValidator<Driver> _driverValidator;

    public RemoveVehicleAssociationFromDriverHandler(IDriverRepository driverRepository, IValidator<Driver> driverValidator) {
        _driverRepository = driverRepository;
        _driverValidator = driverValidator;
    }

    public async Task Handle(RemoveVehicleAssociationFromDriverCommand command, CancellationToken cancellationToken) {
        await _driverRepository.RemoveVehicleAssociationFromDriver(command.DriverID, command.VehicleID);
    }
}
