using AutoMapper;
using FleetManager.BLL.Mediator.Commands.DriverCommands;
using FleetManager.BLL.Mediator.Commands.VehicleCommands;
using FleetManager.DapperDAL.Models;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.Shared.DTOs.VehicleDTOs;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FleetManager.WriteAPI.Controllers;

[Route("Write/[controller]")]
[ApiController]
//[Authorize]
public class VehiclesController : ControllerBase {
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;

    public VehiclesController(IMapper mapper, IMediator mediator) {
        _mapper = mapper;
        _mediator = mediator;
    }

    //CREATE
    [HttpPost]
    public async Task<ActionResult> CreateVehicle([FromBody] VehicleDTO vehicleDTO) {
        try {
            VehicleModel vehicle = _mapper.Map<VehicleModel>(vehicleDTO);
            
            await _mediator.Send(new CreateVehicleCommand(vehicle));

            vehicleDTO = _mapper.Map<VehicleDTO>(vehicle);

            //Retrieve the newly added object 
            return Created($"Read/Vehicles/{vehicleDTO.ID}", vehicleDTO);
        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    //UPDATE
    [HttpPut]
    public async Task<ActionResult> UpdateVehicle([FromBody] VehicleDTO vehicleDTO) {
        try {
            VehicleModel vehicle = _mapper.Map<VehicleModel>(vehicleDTO);

            await _mediator.Send(new UpdateVehicleCommand(vehicle));

            return Ok(vehicleDTO);
        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    //DELETE 
    [HttpDelete("RemovePendingLicensePlate")]
    public async Task<ActionResult> RemovePendingLicensePlateFromVehicleByID(int vehicleId) {
        try {
            await _mediator.Send(new RemovePendingLicensePlateFromVehicleCommand(vehicleId));

            return Ok();
        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    [HttpPut("Deactivate/{id}")]
    public async Task<ActionResult> DeactivateVehicleByID(int id) {
        try {
            await _mediator.Send(new SetVehicleActiveStatusCommand(id, false));

            return Ok(); 
        } catch (Exception ex) {
            return BadRequest(ex.Message); 
        }
    }
}
