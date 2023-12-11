using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Queries.InquiryQueries {
    public class GetAllInquiriesQuery : GetAllGeneralQuery<InquiryModel> { }

    public class GetAllInquiriesHandler : IRequestHandler<GetAllInquiriesQuery, List<InquiryModel>> {
        private readonly IInquiryRepository _inquiryRepository;
        public GetAllInquiriesHandler(IInquiryRepository inquiryRepository) {
            _inquiryRepository = inquiryRepository;
        }
        public async Task<List<InquiryModel>> Handle(GetAllInquiriesQuery query, CancellationToken cancellationToken) {
            return await _inquiryRepository.GetInquiriesWithPaginationAsync(query.PageIndex, query.PageLength);
        }
    }
}
