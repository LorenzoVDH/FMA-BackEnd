using MediatR;

using FleetManager.DapperDAL.Repositories.Interfaces;
using FleetManager.DapperDAL.Models;

namespace FleetManager.BLL.Mediator.Commands.InquiryCommands;
public class CreateInquiryCommand : IRequest {
    public InquiryModel Inquiry { get; set; } 
    public CreateInquiryCommand(InquiryModel inquiry) {
        Inquiry = inquiry;
    }
}

public class CreateInquiryHandler : IRequestHandler<CreateInquiryCommand> {
    private readonly IInquiryRepository _repository;
    public CreateInquiryHandler(IInquiryRepository repository) {
        _repository = repository;
    }

    public Task Handle(CreateInquiryCommand request, CancellationToken cancellationToken) {
        return _repository.CreateAsync(request.Inquiry); 
    }
}
