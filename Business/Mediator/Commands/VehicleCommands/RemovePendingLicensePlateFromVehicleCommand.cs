using FleetManager.DapperDAL.Repositories.Interfaces;
using FluentValidation;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.BLL.Mediator.Commands.VehicleCommands {
    public class RemovePendingLicensePlateFromVehicleCommand : IRequest {
        public int VehicleID { get; set; }
        public RemovePendingLicensePlateFromVehicleCommand(int vehicleId) {
            VehicleID = vehicleId;
        }
    }

    public class RemovePendingLicensePlateFromVehicleHandler : IRequestHandler<RemovePendingLicensePlateFromVehicleCommand> {
        private readonly IVehicleRepository _vehicleRepository;

        public RemovePendingLicensePlateFromVehicleHandler(IVehicleRepository vehicleRepository) {
            _vehicleRepository = vehicleRepository;
        }

        public async Task Handle(RemovePendingLicensePlateFromVehicleCommand command, CancellationToken cancellationToken) {
            await _vehicleRepository.RemovePendingLicensePlateFromVehicleByIDAsync(command.VehicleID);
        }
    }
}
