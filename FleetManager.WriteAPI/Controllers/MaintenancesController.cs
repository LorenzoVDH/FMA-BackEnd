using AutoMapper;
using FleetManager.BLL.Mediator.Commands.DriverCommands;
using FleetManager.BLL.Mediator.Commands.MaintenanceCommands;
using FleetManager.DapperDAL.Models;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.Shared.DTOs.DriverDTOs;
using FleetManager.Shared.DTOs.MaintenanceDTOs;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FleetManager.WriteAPI.Controllers;

[Route("Write/[controller]")]
[ApiController]
//[Authorize]
public class MaintenancesController : ControllerBase {
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;

    public MaintenancesController(IMediator mediator, IMapper mapper) {
        _mediator = mediator;
        _mapper = mapper;
    }

    //CREATE
    [HttpPost]
    public async Task<ActionResult> CreateMaintenance([FromBody] MaintenanceDTO maintenanceDTO) {
        try {
            MaintenanceModel maintenance = _mapper.Map<MaintenanceModel>(maintenanceDTO);

            //Execute the CreateAsync method 
            await _mediator.Send(new CreateMaintenanceCommand(maintenance));

            //CreateAsync will produce a new ID of the newly added Driver,
            //so mapping will have to be done again in order to retrieve
            //the right ID 
            maintenanceDTO = _mapper.Map<MaintenanceDTO>(maintenance);

            //Retrieve the newly added object 
            return Created($"Read/Maintenances/{maintenanceDTO.ID}", maintenanceDTO);
        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    //UPDATE
    [HttpPut]
    public async Task<ActionResult> UpdateMaintenance([FromBody] MaintenanceDTO maintenanceDTO) {
        try {
            MaintenanceModel maintenance = _mapper.Map<MaintenanceModel>(maintenanceDTO);

            await _mediator.Send(new UpdateMaintenanceCommand(maintenance));

            return Ok(maintenanceDTO);
        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}