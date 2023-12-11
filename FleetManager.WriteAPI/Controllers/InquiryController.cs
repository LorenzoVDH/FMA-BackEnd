using AutoMapper;
using FleetManager.BLL.Mediator.Commands.DriverCommands;
using FleetManager.BLL.Mediator.Commands.InquiryCommands;
using FleetManager.BLL.Mediator.Commands.VehicleCommands;
using FleetManager.DapperDAL.Models;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.Shared.DTOs.DriverDTOs;
using FleetManager.Shared.DTOs.InquiryDTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FleetManager.WriteAPI.Controllers;
[Route("Write/[controller]")]
[ApiController]
public class InquiryController : ControllerBase {
    private readonly IMapper _mapper;
    private readonly IMediator _mediator;
    public InquiryController(IMapper mapper, IMediator mediator) {
        _mapper = mapper;
        _mediator = mediator;
    }

    //CREATE
    [HttpPost]
    public async Task<ActionResult> CreateInquiry([FromBody] InquiryCreateDTO inquiryDTO) {
        try {
            InquiryModel inquiry = _mapper.Map<InquiryModel>(inquiryDTO);
            await _mediator.Send(new CreateInquiryCommand(inquiry));

            inquiryDTO = _mapper.Map<InquiryCreateDTO>(inquiry);

            //TODO: Create a Read Inquiry action 
            return Ok();//Created($"Read/Inquiry/{inquiryDTO.ID}", inquiryDTO);
        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }

    //UPDATE
    [HttpPut]
    public async Task<ActionResult> UpdateInquiry([FromBody] InquiryDTO inquiryDTO) {
        try {
            InquiryModel inquiry = _mapper.Map<InquiryModel>(inquiryDTO);

            await _mediator.Send(new UpdateInquiryCommand(inquiry));

            return Ok(inquiryDTO);
        } catch (Exception ex) {
            return BadRequest(ex.Message);
        }
    }
}
