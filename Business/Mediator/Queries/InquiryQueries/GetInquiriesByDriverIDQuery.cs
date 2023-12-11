using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.BLL.Mediator.Queries.InquiryQueries;
public class GetInquiriesByDriverIDQuery : IRequest<List<InquiryModel>>{
    public int DriverID { get; set; }

    public GetInquiriesByDriverIDQuery(int driverID) {
        DriverID = driverID;
    }
}

public class GetInquiriesByDriverIDHandler : IRequestHandler<GetInquiriesByDriverIDQuery, List<InquiryModel>> {
    private readonly IInquiryRepository _inquiryRepository;
    public GetInquiriesByDriverIDHandler(IInquiryRepository inquiryRepository) {
        _inquiryRepository = inquiryRepository; 
    }
    public Task<List<InquiryModel>> Handle(GetInquiriesByDriverIDQuery request, CancellationToken cancellationToken) {
        return _inquiryRepository.GetInquiriesByDriverIDAsync(request.DriverID);
    }
}
