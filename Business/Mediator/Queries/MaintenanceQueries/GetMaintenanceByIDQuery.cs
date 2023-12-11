using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Queries.MaintenanceQueries {
    public class GetMaintenanceByIDQuery : IRequest<MaintenanceModel> {
        public int MaintenanceID { get; set; }

        public GetMaintenanceByIDQuery(int maintenanceID) {
            MaintenanceID = maintenanceID;
        }
    }

    public class GetMaintenanceByIDHandler : IRequestHandler<GetMaintenanceByIDQuery, MaintenanceModel> {
        private readonly IMaintenanceRepository _maintenanceRepository;

        public GetMaintenanceByIDHandler(IMaintenanceRepository maintenanceRepository) {
            _maintenanceRepository = maintenanceRepository;
        }

        public async Task<MaintenanceModel> Handle(GetMaintenanceByIDQuery query, CancellationToken cancellationToken) {
            return await _maintenanceRepository.GetMaintenanceByIDAsync(query.MaintenanceID);
        }
    }
}
