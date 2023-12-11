using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using FluentValidation;
using MediatR;

namespace FleetManager.BLL.Mediator.Commands.DriverCommands;
public class DeleteDriverCommand : IRequest
{
    public int ID { get; set; }
    public DeleteDriverCommand(int id)
    {
        ID = id;
    }
}

public class DeleteDriverHandler : IRequestHandler<DeleteDriverCommand>
{
    private readonly IDriverRepository _driverRepository;
    public DeleteDriverHandler(IDriverRepository driverRepository)
    {
        _driverRepository = driverRepository;
    }
    public async Task Handle(DeleteDriverCommand command, CancellationToken cancellationToken)
    {
        Driver? driver = await _driverRepository.GetByIDAsync(command.ID);
        if (driver == null)
        {
            throw new ValidationException("A Driver with the provided ID does not exist and therefore cannot be deleted.");
        }

        await _driverRepository.DeleteAsync(command.ID);
    }
}
