using MediatR;
using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;

namespace FleetManager.BLL.Mediator.Queries.VehicleQueries;
public class GetLicensePlatesHistoryQuery : IRequest<List<LicensePlateModel>> { 
    public int VehicleID { get; set; }
    public GetLicensePlatesHistoryQuery(int vehicleID) {
        VehicleID = vehicleID;
    }
}

public class GetLicensePlatesHistoryHandler : IRequestHandler<GetLicensePlatesHistoryQuery, List<LicensePlateModel>> {
    private readonly IVehicleRepository _vehicleRepository;
    public GetLicensePlatesHistoryHandler(IVehicleRepository vehicleRepository) {
        _vehicleRepository = vehicleRepository;
    }
    public async Task<List<LicensePlateModel>> Handle(GetLicensePlatesHistoryQuery query, CancellationToken cancellationToken) {
        return await _vehicleRepository.GetLicensePlateHistoryAsync(query.VehicleID);
    }
}
