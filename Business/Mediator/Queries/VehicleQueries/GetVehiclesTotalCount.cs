using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Queries.VehicleQueries;
public class GetVehiclesTotalCountQuery : IRequest<int> { }

public class GetVehiclesTotalCountHandler : IRequestHandler<GetVehiclesTotalCountQuery, int> { 
    private readonly IVehicleRepository _vehicleRepository;
    public GetVehiclesTotalCountHandler(IVehicleRepository vehicleRepository) {
        _vehicleRepository = vehicleRepository;
    }
    public async Task<int> Handle(GetVehiclesTotalCountQuery request, CancellationToken cancellationToken) {
        return await _vehicleRepository.GetVehicleCountAsync(); 
    }
}