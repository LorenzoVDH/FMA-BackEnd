using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.BLL.Mediator.Queries.InquiryQueries;
public class GetInquiryTypesByCategoryNameQuery : IRequest<List<InquiryTypeModel>> {
    public string CategoryName { get; set; }
    public GetInquiryTypesByCategoryNameQuery(string categoryName) {
        CategoryName = categoryName; 
    }
}

public class GetInquiryTypesByCategoryNameHandler : IRequestHandler<GetInquiryTypesByCategoryNameQuery, List<InquiryTypeModel>> {
    private readonly IInquiryRepository _repository; 

    public GetInquiryTypesByCategoryNameHandler(IInquiryRepository repository) {
        _repository = repository; 
    }

    public Task<List<InquiryTypeModel>> Handle(GetInquiryTypesByCategoryNameQuery request, CancellationToken cancellationToken) {
        return _repository.GetInquiryTypesByCategoryNameAsync(request.CategoryName);
    }
}
