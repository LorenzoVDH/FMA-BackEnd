using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Queries.VehicleQueries;
public class GetVehicleQuarterlyReportQuery : IRequest<List<VehicleQuarterlyReportModel>>{
    public int ID { get; set; }
}

public class GetVehicleQuarterlyReportHandler : IRequestHandler<GetVehicleQuarterlyReportQuery, List<VehicleQuarterlyReportModel>> {
    private readonly IVehicleRepository _vehicleRepository;
    public GetVehicleQuarterlyReportHandler(IVehicleRepository vehicleRepository) {
        _vehicleRepository = vehicleRepository;
    }
    public async Task<List<VehicleQuarterlyReportModel>> Handle(GetVehicleQuarterlyReportQuery query, CancellationToken cancellationToken) {
        return await _vehicleRepository.GetQuarterlyReportsAsync(query.ID);
    }
}
