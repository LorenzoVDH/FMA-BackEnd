using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Commands.MaintenanceCommands {
    public class DeleteMaintenanceCommand : IRequest {
        public int MaintenanceID { get; set; }

        public DeleteMaintenanceCommand(int maintenanceID) {
            MaintenanceID = maintenanceID;
        }
    }

    public class DeleteMaintenanceHandler : IRequestHandler<DeleteMaintenanceCommand> {
        private readonly IMaintenanceRepository _maintenanceRepository;

        public DeleteMaintenanceHandler(IMaintenanceRepository maintenanceRepository) {
            _maintenanceRepository = maintenanceRepository;
        }

        public async Task Handle(DeleteMaintenanceCommand command, CancellationToken cancellationToken) {
            await _maintenanceRepository.DeleteAsync(command.MaintenanceID);
        }
    }
}
 