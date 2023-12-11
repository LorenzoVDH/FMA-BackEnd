using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Commands.MaintenanceCommands {
    public class UpdateMaintenanceCommand : IRequest {
        public MaintenanceModel Maintenance { get; set; }

        public UpdateMaintenanceCommand(MaintenanceModel maintenance) {
            Maintenance = maintenance;
        }
    }

    public class UpdateMaintenanceHandler : IRequestHandler<UpdateMaintenanceCommand> {
        private readonly IMaintenanceRepository _maintenanceRepository;

        public UpdateMaintenanceHandler(IMaintenanceRepository maintenanceRepository) {
            _maintenanceRepository = maintenanceRepository;
        }

        public async Task Handle(UpdateMaintenanceCommand command, CancellationToken cancellationToken) {
            await _maintenanceRepository.UpdateAsync(command.Maintenance);
        }
    }
}
