using FleetManager.BLL.Managers.Interfaces;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Queries.DriverQueries;
public class GetAllDriversQuery : GetAllGeneralQuery<Driver> {
    public bool Active { get; set; }
}

public class GetAllDriversHandler : IRequestHandler<GetAllDriversQuery, List<Driver>>
{
    private readonly IDriverRepository _driverRepository;
    public GetAllDriversHandler(IDriverRepository driverRepository)
    {
        _driverRepository = driverRepository;
    }
    public async Task<List<Driver>> Handle(GetAllDriversQuery query, CancellationToken cancellationToken)
    {
        return await _driverRepository.GetDriversWithVehiclesAsync(query.PageIndex, query.PageLength, query.Active);
    }
}
