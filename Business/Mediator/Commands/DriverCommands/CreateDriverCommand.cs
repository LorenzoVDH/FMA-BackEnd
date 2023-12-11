using FleetManager.BLL.Utilities;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using FluentValidation;
using MediatR;
using System.Diagnostics;

namespace FleetManager.BLL.Mediator.Commands.DriverCommands;
public class CreateDriverCommand : IRequest
{
    public Driver? Driver { get; set; }
    public CreateDriverCommand(Driver? driver)
    {
        Driver = driver;
    }
}

public class CreateDriverHandler : IRequestHandler<CreateDriverCommand>
{
    private readonly IDriverRepository _driverRepository;
    private readonly IValidator<Driver> _driverValidator;

    public CreateDriverHandler(IDriverRepository driverRepository, IValidator<Driver> driverValidator)
    {
        _driverRepository = driverRepository;
        _driverValidator = driverValidator;
    }

    public async Task Handle(CreateDriverCommand command, CancellationToken cancellationToken)
    {
        Driver driver = command.Driver;

        //Truncate the non-numeric characters from the NationalRegistrationNumber input 
        if (driver.NationalRegistrationNumber != null)
        {
            driver.NationalRegistrationNumber = StringUtility.RemoveNonNumericCharacters(driver.NationalRegistrationNumber);
        }

        //Validation 
        await _driverValidator.ValidateAndThrowAsync(driver);

        //Creation 
        await _driverRepository.CreateAsync(driver);
    }
}

