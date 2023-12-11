using AutoMapper;
using FleetManager.BLL.Mediator.Queries.FuelCardQueries;
using FleetManager.BLL.Mediator.Queries.InquiryQueries;
using FleetManager.BLL.Mediator.Queries.VehicleQueries;
using FleetManager.DapperDAL.Models;
using FleetManager.Shared.DTOs.FuelCardDTOs;
using FleetManager.Shared.DTOs.InquiryDTOs;
using FleetManager.Shared.DTOs.VehicleDTOs;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FleetManager.ReadAPI.Controllers
{
    [Route("Read/[controller]")]
    [ApiController]
    public class InquiryController : ControllerBase {
        private readonly IMapper _mapper;
        private readonly IMediator _mediator;

        public InquiryController(IMapper mapper, IMediator mediator) {
            _mapper = mapper;
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetAllInquiries(int pageIndex = 0, int pageLength = 10) {
            IRequest<List<InquiryModel>> inquiryGetQuery = new GetAllInquiriesQuery() {
                PageIndex = pageIndex,
                PageLength = pageLength
            };

            List<InquiryModel> inquiries = await _mediator.Send(inquiryGetQuery);

            int totalInquiriesCount = await _mediator.Send(new GetInquiriesTotalCountQuery());

            if (inquiries.Count == 0) {
                return NoContent();
            }

            List<InquiryOverviewReadDTO> inquiryDTOs = _mapper.Map<List<InquiryOverviewReadDTO>>(inquiries);
            return Ok(new { inquiries = inquiryDTOs, totalCount = totalInquiriesCount });
        }

        [HttpGet("Driver/{driverID}", Name = "GetInquiriesByDriverID")]
        public async Task<ActionResult> GetInquiriesByDriverID(int driverID) {
            var query = new GetInquiriesByDriverIDQuery(driverID);
            List<InquiryModel> inquiries = await _mediator.Send(query);

            if (inquiries == null || inquiries.Count == 0) {
                return NoContent();
            }

            var inquiryDTOs = _mapper.Map<List<InquiryDTO>>(inquiries);

            return Ok(inquiryDTOs);
        }

        [HttpGet("Types/{categoryName}", Name = "GetInquiryTypesByCategoryName")]
        public async Task<ActionResult> GetInquiryTypesByCategoryName(string categoryName) {
            var query = new GetInquiryTypesByCategoryNameQuery(categoryName);
            List<InquiryTypeModel> inquiryTypes = await _mediator.Send(query); 

            if (inquiryTypes == null || inquiryTypes.Count == 0) {
                return NoContent();
            }

            var inquiryTypeDTOs = _mapper.Map<List<InquiryTypeDTO>>(inquiryTypes);

            return Ok(inquiryTypeDTOs); 
        }
    }
}
