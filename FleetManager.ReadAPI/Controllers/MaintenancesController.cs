using AutoMapper;
using FleetManager.BLL.Mediator.Queries.MaintenanceQueries;
using FleetManager.DapperDAL.Models;
using FleetManager.Shared.DTOs.MaintenanceDTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FleetManager.ReadAPI.Controllers;

[Route("Read/[controller]")]
[ApiController]
public class MaintenancesController : ControllerBase {
    private readonly IMapper _mapper;
    private readonly IMediator _mediator; 

    public MaintenancesController(IMediator mediator, IMapper mapper) {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpGet("{id}", Name = "GetMaintenanceByID")]
    public async Task<ActionResult> GetMaintenanceByID(int id) {
        IRequest<MaintenanceModel> getMaintenanceByIDQuery = new GetMaintenanceByIDQuery(id);

        MaintenanceModel maintenance = await _mediator.Send(getMaintenanceByIDQuery);

        if (maintenance == null) {
            return NoContent();
        }

        MaintenanceReadDTO maintenanceDTO = _mapper.Map<MaintenanceReadDTO>(maintenance);
        return Ok(maintenanceDTO);
    }

    [HttpGet("Vehicle/{vehicleId}", Name = "GetMaintenancesByVehicleID")]
    public async Task<ActionResult> GetAllVehicleMaintenancesByVehicleID(int vehicleId) {
        IRequest<List<MaintenanceModel>> getAllVehicleMaintencesQuery = new GetAllMaintenancesOfVehicleQuery(vehicleId);

        List<MaintenanceModel> maintenances = await _mediator.Send(getAllVehicleMaintencesQuery);

        if (maintenances == null || maintenances.Count == 0) {
            return NoContent();
        }

        List<MaintenanceReadDTO> maintenanceDTOs = _mapper.Map<List<MaintenanceReadDTO>>(maintenances);
        return Ok(maintenanceDTOs);
    }
}
