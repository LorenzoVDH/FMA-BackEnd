using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.BLL.Mediator.Queries.VehicleQueries;
public class GetSimplifiedVehiclesBySearchTermQuery : IRequest<List<VehicleSimplifiedModel>> {
    public string SearchTerm { get; set; }
    public GetSimplifiedVehiclesBySearchTermQuery(string searchTerm) {
        SearchTerm = searchTerm; 
    }
}

public class GetSimplifiedVehicleBySearchTermHandler : IRequestHandler<GetSimplifiedVehiclesBySearchTermQuery, List<VehicleSimplifiedModel>> {
    private readonly IVehicleRepository _vehicleRepository;
    public GetSimplifiedVehicleBySearchTermHandler(IVehicleRepository vehicleRepository) {
        _vehicleRepository = vehicleRepository;
    }
    public async Task<List<VehicleSimplifiedModel>> Handle(GetSimplifiedVehiclesBySearchTermQuery query, CancellationToken cancellationToken) {
        return await _vehicleRepository.GetSimplifiedVehiclesBySearchTermAsync(query.SearchTerm);
    }
}
