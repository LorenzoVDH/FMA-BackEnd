using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.BLL.Mediator.Queries.InquiryQueries;
public class GetInquiriesTotalCountQuery : IRequest<int> { }

public class GetInquiriesTotalCountHandler : IRequestHandler<GetInquiriesTotalCountQuery, int> {
    private readonly IInquiryRepository _inquiryRepository;
    public GetInquiriesTotalCountHandler(IInquiryRepository inquiryRepository)
    {
        _inquiryRepository = inquiryRepository;
    }
    public async Task<int> Handle(GetInquiriesTotalCountQuery request, CancellationToken cancellationToken)
    {
        return await _inquiryRepository.GetInquiryCountAsync();
    }
}
