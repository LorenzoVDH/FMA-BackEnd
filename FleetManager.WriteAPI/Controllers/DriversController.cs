using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using MediatR;
using FleetManager.BLL.Mediator.Commands.DriverCommands;
using FleetManager.Shared.DTOs.DriverDTOs;
using Microsoft.AspNetCore.Authorization;
using FleetManager.BLL.Mediator.Commands.VehicleCommands;

namespace FleetManager.TestAPI.Controllers;

[Route("Write/[controller]")]
[ApiController]
//[Authorize]
public class DriversController : ControllerBase {
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public DriversController(IMapper mapper, IMediator mediator) {
        _mapper = mapper;
        _mediator = mediator;
    }

    //CREATE
    [HttpPost]
    public async Task<ActionResult> CreateDriver([FromBody] DriverCreateDTO driverDTO) {
        try {
            Driver driver = _mapper.Map<Driver>(driverDTO);
            await _mediator.Send(new CreateDriverCommand(driver));

            //CreateAsync will produce a new ID of the newly added Driver,
            //so mapping will have to be done again in order to retrieve
            //the right ID 
            driverDTO = _mapper.Map<DriverCreateDTO>(driver);

            return Created($"Read/Drivers/{driverDTO.ID}", driverDTO);
        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    //UPDATE
    [HttpPut]
    public async Task<ActionResult> UpdateDriver([FromBody] DriverCreateDTO driverDTO) {
        try {
            Driver driver = _mapper.Map<Driver>(driverDTO);

            await _mediator.Send(new UpdateDriverCommand(driver));

            return Ok(driverDTO);
        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("AddVehicleAssociation")]
    public async Task<ActionResult> AddVehicleAssociationToDriverByID(int driverId, int vehicleId) {
        try {
            await _mediator.Send(new AddVehicleAssociationToDriverCommand(driverId, vehicleId));

            return Ok();
        } catch (Exception ex) {
            return BadRequest(ex.Message); 
        }
    }

    //DELETE 
    [HttpDelete("RemoveVehicleAssociation")]
    public async Task<ActionResult> RemoveVehicleAssociationFromDriverByID(int driverId, int vehicleId) {
        try {
            await _mediator.Send(new RemoveVehicleAssociationFromDriverCommand(driverId, vehicleId));

            return Ok();
        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
