using MediatR;
using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;

namespace FleetManager.BLL.Mediator.Queries.VehicleQueries;
public class GetAllVehicleTypesQuery : IRequest<List<VehicleTypeModel>> { }

public class GetAllVehicleTypesHandler : IRequestHandler<GetAllVehicleTypesQuery, List<VehicleTypeModel>> {
    private readonly IVehicleRepository _vehicleRepository;
    public GetAllVehicleTypesHandler(IVehicleRepository vehicleRepository) {
        _vehicleRepository = vehicleRepository;
    }
    public async Task<List<VehicleTypeModel>> Handle(GetAllVehicleTypesQuery query, CancellationToken cancellationToken) {
        return await _vehicleRepository.GetVehicleTypesAsync(); 
    }
}
