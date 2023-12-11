using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Commands.MaintenanceCommands {
    public class CreateMaintenanceCommand : IRequest {
        public MaintenanceModel Maintenance { get; set; }

        public CreateMaintenanceCommand(MaintenanceModel maintenance) {
            Maintenance = maintenance;
        }
    }

    public class CreateMaintenanceHandler : IRequestHandler<CreateMaintenanceCommand> {
        private readonly IMaintenanceRepository _maintenanceRepository;

        public CreateMaintenanceHandler(IMaintenanceRepository maintenanceRepository) {
            _maintenanceRepository = maintenanceRepository;
        }

        public async Task Handle(CreateMaintenanceCommand command, CancellationToken cancellationToken) {
            await _maintenanceRepository.CreateAsync(command.Maintenance);
        }
    }
}

