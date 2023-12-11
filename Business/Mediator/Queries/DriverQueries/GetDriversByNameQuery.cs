using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Queries.DriverQueries;
public class GetDriversByNameQuery : IRequest<List<Driver>>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public GetDriversByNameQuery(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }
}

public class GetDriversByNameHandler : IRequestHandler<GetDriversByNameQuery, List<Driver>>
{
    private readonly IDriverRepository _driverRepository;
    public GetDriversByNameHandler(IDriverRepository driverRepository)
    {
        _driverRepository = driverRepository;
    }

    public async Task<List<Driver>> Handle(GetDriversByNameQuery query, CancellationToken cancellationToken)
    {
        return await _driverRepository.GetByNameAsync(query.FirstName, query.LastName);
    }
}

