using MediatR;
using FleetManager.Shared.DTOs;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.BLL.Managers.Interfaces;
using AutoMapper;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;

namespace FleetManager.BLL.Mediator.Queries.DriverQueries;
public class GetDriverByIDQuery : GetByIDGeneralQuery<Driver> {
    public GetDriverByIDQuery(int id) : base(id) { }
}

public class GetDriverHandler : IRequestHandler<GetDriverByIDQuery, Driver> {
    private readonly IDriverRepository _driverRepository;
    public GetDriverHandler(IDriverRepository driverRepository) {
        _driverRepository = driverRepository;
    }
    public async Task<Driver> Handle(GetDriverByIDQuery query, CancellationToken cancellationToken) {
        return await _driverRepository.GetByIDAsync(query.ID);
    }
}
