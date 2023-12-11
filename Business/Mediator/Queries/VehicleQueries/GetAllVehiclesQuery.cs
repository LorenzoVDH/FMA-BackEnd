using MediatR;
using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;

namespace FleetManager.BLL.Mediator.Queries.VehicleQueries; 
public class GetAllVehiclesQuery : GetAllGeneralQuery<VehicleOverviewModel> { }

public class GetAllVehiclesHandler : IRequestHandler<GetAllVehiclesQuery, List<VehicleOverviewModel>> {
    private readonly IVehicleRepository _vehicleRepository;
    public GetAllVehiclesHandler(IVehicleRepository vehicleRepository) {
        _vehicleRepository = vehicleRepository;
    }
    public async Task<List<VehicleOverviewModel>> Handle(GetAllVehiclesQuery query, CancellationToken cancellationToken) {
        return await _vehicleRepository.GetAllAsync(query.PageIndex, query.PageLength);
    }
}