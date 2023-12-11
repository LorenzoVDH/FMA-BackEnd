using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Queries.VehicleQueries;
public class GetVehicleDriversByVehicleIDQuery : IRequest<List<DriverSimplifiedModel>>{
    public int VehicleID { get; set; }
    public GetVehicleDriversByVehicleIDQuery(int vehicleID) {
        VehicleID = vehicleID;
    }
}
public class GetVehicleDriversByVehicleIDHandler : IRequestHandler<GetVehicleDriversByVehicleIDQuery, List<DriverSimplifiedModel>> {
    private readonly IVehicleRepository _vehicleRepository; 
    public GetVehicleDriversByVehicleIDHandler(IVehicleRepository vehicleRepository) {
        _vehicleRepository = vehicleRepository;
    }
    public async Task<List<DriverSimplifiedModel>> Handle(GetVehicleDriversByVehicleIDQuery query, CancellationToken cancellationToken) {
        return await _vehicleRepository.GetVehicleDriversByVehicleID(query.VehicleID);
    }
}
