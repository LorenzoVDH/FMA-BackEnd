using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.BLL.Mediator.Queries.FuelCardQueries;
public class GetFuelCardsByDriverIDQuery : IRequest<List<FuelCardModel>>{
    public int DriverID { get; set; }
    public GetFuelCardsByDriverIDQuery(int driverID) {
        DriverID = driverID;
    }
}

public class GetFuelCardsByDriverIDHandler : IRequestHandler<GetFuelCardsByDriverIDQuery, List<FuelCardModel>> {
    private readonly IFuelCardRepository _fuelCardRepository; 
    public GetFuelCardsByDriverIDHandler(IFuelCardRepository fuelCardRepository) {
        _fuelCardRepository = fuelCardRepository; 
    }
    public Task<List<FuelCardModel>> Handle(GetFuelCardsByDriverIDQuery request, CancellationToken cancellationToken) {
        return _fuelCardRepository.GetFuelCardsByDriverIDAsync(request.DriverID); 
    }
}