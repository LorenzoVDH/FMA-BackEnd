using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Queries.DriverQueries;
public class GetDriversBySearchTermQuery : IRequest<List<Driver>> {
    public string SearchTerm { get; set; }

    public GetDriversBySearchTermQuery(string searchTerm) {
        SearchTerm = searchTerm;
    }
}

public class GetDriversBySearchTermHandler : IRequestHandler<GetDriversBySearchTermQuery, List<Driver>> {
    private readonly IDriverRepository _driverRepository;
    public GetDriversBySearchTermHandler(IDriverRepository driverRepository) {
        _driverRepository = driverRepository;
    }

    public async Task<List<Driver>> Handle(GetDriversBySearchTermQuery query, CancellationToken cancellationToken) {
        return await _driverRepository.GetDriversBySearchTermAsync(query.SearchTerm);
    }
}
