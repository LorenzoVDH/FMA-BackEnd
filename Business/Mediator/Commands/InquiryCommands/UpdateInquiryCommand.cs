using FleetManager.DapperDAL.Models;
using FleetManager.DapperDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Mediator.Commands.InquiryCommands;
public class UpdateInquiryCommand : IRequest {
    public InquiryModel Inquiry { get; set; }

    public UpdateInquiryCommand(InquiryModel inquiry) {
        Inquiry = inquiry;
    }
}

public class UpdateInquiryHandler : IRequestHandler<UpdateInquiryCommand> {
    private readonly IInquiryRepository _inquiryRepository;

    public UpdateInquiryHandler(IInquiryRepository inquiryRepository) {
        _inquiryRepository = inquiryRepository;
    }

    public async Task Handle(UpdateInquiryCommand command, CancellationToken cancellationToken) {
        await _inquiryRepository.UpdateAsync(command.Inquiry);
    }
}