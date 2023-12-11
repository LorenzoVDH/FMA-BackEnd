using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Queries.DriverQueries;
public class GetDriversTotalCountByActiveStatusQuery : IRequest<int>
{
    public bool Active { get; set; }
}

public class GetDriversTotalCountByActiveStatusHandler : IRequestHandler<GetDriversTotalCountByActiveStatusQuery, int>
{
    private readonly IDriverRepository _driverRepository;
    public GetDriversTotalCountByActiveStatusHandler(IDriverRepository driverRepository)
    {
        _driverRepository = driverRepository;
    }
    public async Task<int> Handle(GetDriversTotalCountByActiveStatusQuery request, CancellationToken cancellationToken)
    {
        return await _driverRepository.GetDriversCountByActiveStatusAsync(request.Active);
    }
}
