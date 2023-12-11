using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Queries.MaintenanceQueries {
    public class GetAllMaintenancesOfVehicleQuery : IRequest<List<MaintenanceModel>> {
        public int VehicleID { get; set; }

        public GetAllMaintenancesOfVehicleQuery(int vehicleID) {
            VehicleID = vehicleID;
        }
    }

    public class GetAllMaintenancesOfVehicleHandler : IRequestHandler<GetAllMaintenancesOfVehicleQuery, List<MaintenanceModel>> {
        private readonly IMaintenanceRepository _maintenanceRepository;

        public GetAllMaintenancesOfVehicleHandler(IMaintenanceRepository maintenanceRepository) {
            _maintenanceRepository = maintenanceRepository;
        }

        public async Task<List<MaintenanceModel>> Handle(GetAllMaintenancesOfVehicleQuery query, CancellationToken cancellationToken) {
            return await _maintenanceRepository.GetAllMaintenancesOfVehicleIDAsync(query.VehicleID);
        }
    }
}
