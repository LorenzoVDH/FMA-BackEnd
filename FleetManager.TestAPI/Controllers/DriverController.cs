using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using MediatR;
using FleetManager.BLL.Mediator.Queries.DriverQueries;
using FleetManager.BLL.Mediator.Commands.DriverCommands;
using FleetManager.Shared.DTOs.DriverDTOs;

namespace FleetManager.TestAPI.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DriverController : ControllerBase {
    private readonly IMapper _mapper;
    private readonly IMediator _mediator; 

    public DriverController(IMapper mapper, IMediator mediator) {
        _mapper = mapper; 
        _mediator = mediator; 
    }

    //CREATE
    [HttpPost]
    public async Task<ActionResult> CreateDriver([FromBody] DriverCreateDTO driverDTO) {
        try {
            //Map the DTO to the Driver Entity that will be stored in the database 
            Driver driver = _mapper.Map<Driver>(driverDTO);

            //Execute the CreateAsync method 
            await _mediator.Send(new CreateDriverCommand(driver));

            //CreateAsync will produce a new ID of the newly added Driver,
            //so mapping will have to be done again in order to retrieve
            //the right ID 
            driverDTO = _mapper.Map<DriverCreateDTO>(driver);

            //Retrieve the newly added object 
            return CreatedAtRoute("GetByID", new { id = driverDTO.ID }, driverDTO);
        } catch (Exception ex) {
            return BadRequest(ex.Message); 
        }
    }

    //READ
    [HttpGet]
    public async Task<ActionResult> GetAllDrivers() {
        List<Driver> drivers = await _mediator.Send(new GetAllDriversQuery());

        if (drivers.Count == 0) {
            return NoContent();
        }

        List<DriverReadDTO> driverDTOs = _mapper.Map<List<DriverReadDTO>>(drivers);

        return Ok(driverDTOs);
    }

    [HttpGet("{id}", Name = "GetByID")]
    public async Task<ActionResult> GetDriverByID(int id) {
        Driver driver = await _mediator.Send(new GetDriverByIDQuery(id));

        if (driver == null) {
            return NotFound($"The driver with ID {id} has not been found.");
        }

        DriverReadDTO driverDTO = _mapper.Map<DriverReadDTO>(driver);

        return Ok(driverDTO);        
    }

    [HttpGet("GetByName")]
    public async Task<ActionResult> GetDriversByName([FromQuery] string firstName, [FromQuery] string lastName) {
        var query = new GetDriversByNameQuery(firstName, lastName);
        List<Driver> driversWithName = await _mediator.Send(query);

        if (driversWithName == null || driversWithName.Count == 0) {
            return NotFound($"Driver {firstName} {lastName} has not been found.");
        }

        var driversWithNameDTO = _mapper.Map<List<DriverReadDTO>>(driversWithName);
        return Ok(driversWithNameDTO);
    }

    //UPDATE
    [HttpPut]
    public async Task<ActionResult> UpdateDriverByID([FromBody] DriverCreateDTO driverDTO) {
        try {
            Driver driver = _mapper.Map<Driver>(driverDTO);
            await _mediator.Send(new UpdateDriverCommand(driver)); 
            return Ok();
        } catch (Exception ex) {
            return BadRequest(ex.Message); 
        }
    }

    //DELETE 
    [HttpDelete("{id}")]
    public async Task<ActionResult> DeleteDriverByID(int id) {
        try { 
            await _mediator.Send(new DeleteDriverCommand(id));
            return NoContent();
        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
