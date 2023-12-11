using AutoMapper;
using FleetManager.BLL.Mediator.Queries.VehicleQueries;
using FleetManager.DapperDAL.Models;
using FleetManager.Shared.DTOs.DriverDTOs;
using FleetManager.Shared.DTOs.LicensePlateDTOs;
using FleetManager.Shared.DTOs.VehicleDTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FleetManager.ReadAPI.Controllers;
[Route("Read/[controller]")]
[ApiController]
//[Authorize]
public class VehiclesController : ControllerBase {
    public readonly IMapper _mapper;
    public readonly IMediator _mediator;

    public VehiclesController(IMapper mapper, IMediator mediator) {
        _mapper = mapper;
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetVehicleByID(int id) {
        IRequest<VehicleModel> vehicleQuery = new GetVehicleByIDQuery(id);

        VehicleModel vehicle = await _mediator.Send(vehicleQuery);

        if (vehicle == null) {
            return NoContent();
        }

        VehicleDTO vehicleDTO = _mapper.Map<VehicleDTO>(vehicle);
        return Ok(vehicleDTO);
    }

    [HttpGet]
    public async Task<ActionResult> GetAllVehicles(int pageIndex = 0, int pageLength = 10) {
        IRequest<List<VehicleOverviewModel>> vehicleGetlistQuery = new GetAllVehiclesQuery() {
            PageIndex = pageIndex,
            PageLength = pageLength
        };

        List<VehicleOverviewModel> vehicles = await _mediator.Send(vehicleGetlistQuery);

        int totalVehiclesCount = await _mediator.Send(new GetVehiclesTotalCountQuery());

        if (vehicles.Count == 0) {
            return NoContent();
        }

        List<VehicleOverviewReadDTO> vehicleDTOs = _mapper.Map<List<VehicleOverviewReadDTO>>(vehicles);
        return Ok(new { vehicles = vehicleDTOs, totalCount = totalVehiclesCount });
    }

    [HttpGet("{id}/Drivers")]
    public async Task<ActionResult> GetVehicleDriversByVehicleID(int id) {
        IRequest<List<DriverSimplifiedModel>> vehicleDriversByVehicleIdQuery = new GetVehicleDriversByVehicleIDQuery(id);

        List<DriverSimplifiedModel> drivers = await _mediator.Send(vehicleDriversByVehicleIdQuery);

        List<DriverSimplifiedDTO> driverDTOs = _mapper.Map<List<DriverSimplifiedDTO>>(drivers);
        return Ok(driverDTOs);
    }

    [HttpGet("{id}/Reports")]
    public async Task<ActionResult> GetVehicleQuarterlyReportByVehicleID(int id) {
        IRequest<List<VehicleQuarterlyReportModel>> vehicleQuarterlyReportQuery = new GetVehicleQuarterlyReportQuery() {
            ID = id
        };

        List<VehicleQuarterlyReportModel> vehicleQuarterlyReports = await _mediator.Send(vehicleQuarterlyReportQuery);

        if (vehicleQuarterlyReports == null || vehicleQuarterlyReports.Count == 0) {
            return NoContent();
        }

        List<VehicleQuarterlyReportDTO> vehicleQuarterlyReportDTOs = _mapper.Map<List<VehicleQuarterlyReportDTO>>(vehicleQuarterlyReports);
        return Ok(vehicleQuarterlyReportDTOs);
    }

    [HttpGet("Types")]
    public async Task<ActionResult> GetVehicleTypes() {
        IRequest<List<VehicleTypeModel>> vehicleTypesQuery = new GetAllVehicleTypesQuery();

        List<VehicleTypeModel> vehicleTypesList = await _mediator.Send(vehicleTypesQuery);

        if (vehicleTypesList.Count == 0) {
            return NoContent();
        }

        List<VehicleTypeDTO> vehicleTypeDTOs = _mapper.Map<List<VehicleTypeDTO>>(vehicleTypesList);
        return Ok(vehicleTypeDTOs);
    }

    [HttpGet("GetBySearchTerm")]
    public async Task<ActionResult> GetVehiclesBySearchTerm(string searchTerm) {
        var query = new GetSimplifiedVehiclesBySearchTermQuery(searchTerm);
        List<VehicleSimplifiedModel> vehiclesWithSearchTerm = await _mediator.Send(query);

        if (vehiclesWithSearchTerm == null || vehiclesWithSearchTerm.Count == 0) {
            return NoContent();
        }

        var vehicleDTOs = _mapper.Map<List<VehicleSimplifiedDTO>>(vehiclesWithSearchTerm);

        return Ok(vehicleDTOs);
    }

    [HttpGet("{id}/LicensePlateHistory")]
    public async Task<ActionResult> GetLicensePlateHistory(int id) {
        var query = new GetLicensePlatesHistoryQuery(id);
        List<LicensePlateModel> licenseplates = await _mediator.Send(query); 

        if (licenseplates == null || licenseplates.Count == 0) {
            return NoContent();
        }

        var licenseplatesDTOs = _mapper.Map<List<LicensePlateDTO>>(licenseplates);
        
        return Ok(licenseplatesDTOs);
    }
}
