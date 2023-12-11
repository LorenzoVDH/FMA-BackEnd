using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using MediatR;
using FleetManager.BLL.Mediator.Queries.DriverQueries;
using FleetManager.Shared.DTOs.DriverDTOs;
using Microsoft.AspNetCore.Authorization; 

namespace FleetManager.ReadAPI.Controllers;

[Route("Read/[controller]")]
[ApiController]
//[Authorize]
public class DriversController : ControllerBase {
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public DriversController(IMapper mapper, IMediator mediator) {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpGet]
    public async Task<ActionResult> GetAllDrivers(int pageIndex = 0, int pageLength = 10, bool active = true) {
        IRequest<List<Driver>> driverGetListQuery = new GetAllDriversQuery() {
            PageIndex = pageIndex,
            PageLength = pageLength,
            Active = active
        };

        List<Driver> drivers = await _mediator.Send(driverGetListQuery);

        //int totalDriversCount = drivers.Count; - Keep in mind while refactoring: can't do this because it will only return the number of the drivers currently being displayed!
        int totalDriversCount = await _mediator.Send(new GetDriversTotalCountByActiveStatusQuery() { 
            Active = active
        });

        if (drivers.Count == 0) {
            return NoContent();
        }

        List<DriverReadDTO> driverDTOs = _mapper.Map<List<DriverReadDTO>>(drivers);

        return Ok(new { drivers = driverDTOs, totalCount = totalDriversCount });
    }

    [HttpGet("{id}", Name = "GetDriverByID")]
    public async Task<ActionResult> GetDriverByID(int id) {
        Driver driver = await _mediator.Send(new GetDriverByIDQuery(id));

        if (driver == null) {
            return NotFound($"The driver with ID {id} has not been found.");
        }

        DriverReadDTO driverDTO = _mapper.Map<DriverReadDTO>(driver);

        return Ok(driverDTO);
    }

    [HttpGet("GetBySearchTerm")]
    public async Task<ActionResult> GetDriversBySearchTerm(string searchTerm) {
        var query = new GetDriversBySearchTermQuery(searchTerm);
        List<Driver> driversWithSearchTerm = await _mediator.Send(query); 

        if (driversWithSearchTerm == null || driversWithSearchTerm.Count == 0) {
            return NoContent();
        }

        var driverDTOs = _mapper.Map<List<DriverReadDTO>>(driversWithSearchTerm);

        return Ok(driverDTOs);
    }

    [HttpGet("Login")]
    public async Task<ActionResult> GetDriverLoginByEmail(string email) {
        var query = new GetDriverLoginByEmailQuery(email);
        Login login = await _mediator.Send(query);

        if (login == null) {
            return NoContent();
        }

        var loginDTO = _mapper.Map<DriverLoginDTO>(login); 

        return Ok(loginDTO);
    }
}
