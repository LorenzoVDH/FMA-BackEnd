using AutoMapper;
using FleetManager.BLL.Mediator.Queries.DriverQueries;
using FleetManager.BLL.Mediator.Queries.FuelCardQueries;
using FleetManager.DapperDAL.Models;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.Shared.DTOs.FuelCardDTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FleetManager.ReadAPI.Controllers; 
[Route("Read/[controller]")]
[ApiController]
public class FuelCardController : ControllerBase {
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public FuelCardController(IMapper mapper, IMediator mediator) {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpGet("Driver/{driverID}", Name = "GetFuelCardsByDriverID")]
    public async Task<ActionResult> GetFuelCardsByDriverID(int driverID) {
        var query = new GetFuelCardsByDriverIDQuery(driverID);
        List<FuelCardModel> fuelcards = await _mediator.Send(query);

        if (fuelcards == null || fuelcards.Count == 0) {
            return NoContent();
        }

        var fuelcardDTOs = _mapper.Map<List<FuelCardDTO>>(fuelcards);

        return Ok(fuelcardDTOs);
    }
}
