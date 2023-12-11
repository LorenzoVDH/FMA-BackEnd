using AutoMapper;
using FleetManager.BLL.Utilities;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using FluentValidation;
using MediatR;

namespace FleetManager.BLL.Mediator.Commands.DriverCommands;
public class UpdateDriverCommand : IRequest
{
    public Driver Driver { get; set; }
    public UpdateDriverCommand(Driver driver)
    {
        Driver = driver;
    }
}

public class UpdateDriverHandler : IRequestHandler<UpdateDriverCommand>
{
    private readonly IDriverRepository _driverRepository;
    private readonly IValidator<Driver> _driverValidator;

    public UpdateDriverHandler(IDriverRepository driverRepository, IValidator<Driver> driverValidator)
    {
        _driverRepository = driverRepository;
        _driverValidator = driverValidator;
    }

    public async Task Handle(UpdateDriverCommand command, CancellationToken cancellationToken)
    {
        Driver? driver = command.Driver;

        //Truncate the non-numeric characters from the NationalRegistrationNumber input 
        if (driver.NationalRegistrationNumber != null)
        {
            driver.NationalRegistrationNumber = StringUtility.RemoveNonNumericCharacters(driver.NationalRegistrationNumber);
        }

        //Validation 
        await _driverValidator.ValidateAndThrowAsync(driver);
        await _driverRepository.UpdateAsync(driver);

        /*
        //Mapping of the dirty driver to the old driver in the database
        //to prevent updating problems where two drivers with the same
        //ID are kept in memory, 

        var dbDriver = await _driverRepository.GetByIDAsync(driver.ID);

        var config = new MapperConfiguration(cfg => { cfg.CreateMap<Driver, Driver>(); });
        var map = config.CreateMapper();
        map.Map(driver, dbDriver);

        await _driverRepository.SaveChangesAsync();
        */

    }
}
