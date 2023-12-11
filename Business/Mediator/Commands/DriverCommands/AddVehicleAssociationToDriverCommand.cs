using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using FluentValidation;
using MediatR;

namespace FleetManager.BLL.Mediator.Commands.DriverCommands;
public class AddVehicleAssociationToDriverCommand : IRequest {
    public int DriverID { get; set; }
    public int VehicleID { get; set; }

    public AddVehicleAssociationToDriverCommand(int driverId, int vehicleId) {
        DriverID = driverId;
        VehicleID = vehicleId;
    }
}

public class AddVehicleAssociationToDriverHandler : IRequestHandler<AddVehicleAssociationToDriverCommand> {
    private readonly IDriverRepository _driverRepository;
    private readonly IValidator<Driver> _driverValidator;

    public AddVehicleAssociationToDriverHandler(IDriverRepository driverRepository, IValidator<Driver> driverValidator) {
        _driverRepository = driverRepository;
        _driverValidator = driverValidator;
    }

    public async Task Handle(AddVehicleAssociationToDriverCommand command, CancellationToken cancellationToken) {
        await _driverRepository.AddVehicleAssociationToDriver(command.DriverID, command.VehicleID);
    }
}
