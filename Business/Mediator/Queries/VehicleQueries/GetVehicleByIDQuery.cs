using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Queries.VehicleQueries;
public class GetVehicleByIDQuery : GetByIDGeneralQuery<VehicleModel> {
    public GetVehicleByIDQuery(int id) : base(id) { }
}

public class GetVehicleByIDHandler : IRequestHandler<GetVehicleByIDQuery, VehicleModel> {
    private readonly IVehicleRepository _vehicleRepository;
    public GetVehicleByIDHandler(IVehicleRepository vehicleRepository) {
        _vehicleRepository = vehicleRepository;
    }
    public async Task<VehicleModel> Handle(GetVehicleByIDQuery query, CancellationToken cancellationToken) {
        return await _vehicleRepository.GetByIDAsync(query.ID);
    }
}
