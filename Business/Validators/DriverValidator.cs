using FluentValidation;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using MediatR;

namespace FleetManager.BLL.Validators; 
public class DriverValidator : AbstractValidator<Driver> {
    //Inject the DriverRepository for Cross-Entity validation 
    private readonly IDriverRepository _driverRepository;

    public DriverValidator(IDriverRepository driverRepository) {
        _driverRepository = driverRepository;

        RuleFor(d => d)
            .NotNull()
                .WithMessage("A driver cannot be null")
            .MustAsync(async (driver, cancellationToken) => await NoDriverWithSameNameAndBirthDateAsync(driver.ID, driver.FirstName, driver.LastName, driver.DateOfBirth))
                .WithMessage("Another driver with the same first name, last name, and birthdate may not be added.");

        RuleFor(d => d.LastName)
            .NotNull()
                .WithMessage("The driver's last name needs to be filled in.") 
            .NotEmpty()
                .WithMessage("The driver's last name cannot be empty.");

        RuleFor(d => d.FirstName)
            .NotNull()
                .WithMessage("The driver's first name needs to be filled in.")
            .NotEmpty()
                .WithMessage("The driver's firstname cannot be empty");

        RuleFor(d => d.DateOfBirth)
            .NotNull()
                .WithMessage("The driver's birthdate cannot be null.")
            .Must(dateOfBirth => dateOfBirth != default(DateTime))
                .WithMessage("The driver's birthdate cannot be null.")
            .NotEmpty()
                .WithMessage("The driver's birthdate cannot be empty.")
            .LessThan(DateTime.Today.AddYears(-16))
                .WithMessage("The driver must be at least 16 years old.");
            
        RuleFor(d => d.NationalRegistrationNumber)
            .NotNull()
                .WithMessage("The driver's National Registration Number cannot be null.")
            .NotEmpty()
                .WithMessage("The driver's National Registration Number cannot be empty.")
            .Length(11)
                .WithMessage("The driver's National Registration Number must be 11 numbers long.")
            .Must((driver, nrn) => NationalRegistrationNumberValid(nrn, driver.DateOfBirth))
                .WithMessage("National Registration Number is invalid.")
            .MustAsync(async (driver, nrn, cancellationToken) => await NoDuplicateNationalRegistrationNumbersAsync(driver.ID, nrn))
                .WithMessage("Another record with the same National Registration Number has been found.");
    }

    private bool NationalRegistrationNumberValid(string registrationNumber, DateTime birthDate) {
        //First basic checks
        if (registrationNumber == null) { //extra null check for good measure 
            return false;
        }

        if (registrationNumber.Length != 11) { //extra length check for good measure 
            return false; 
        }

        // Birthdate matches check
        string birthYear = (birthDate.Year % 100).ToString("00");
        string birthMonth = birthDate.Month.ToString("00");
        string birthDay = birthDate.Day.ToString("00"); 
        
        string birthYearFromNrn = registrationNumber.Substring(0, 2);
        string birthMonthFromNrn = registrationNumber.Substring(2, 2);
        string birthDayFromNrn = registrationNumber.Substring(4, 2);

        if (!(birthYear == birthYearFromNrn && 
            birthMonth == birthMonthFromNrn &&
            birthDay == birthDayFromNrn)) {
            return false; 
        }

        // First get the birthdate + birthcounter 
        string firstNine = registrationNumber.Substring(0, 9);

        // Then get the checksum
        int checksum;
        if (!Int32.TryParse(registrationNumber.Substring(9, 2), out checksum)) {
            return false; 
        }

        // Check if the checksum matches the controlnumber 
        int firstNineInt;
        if (!Int32.TryParse(firstNine, out firstNineInt)) {
            return false;
        }

        if (birthDate.Year >= 2000) {
            firstNineInt += 2000000000; 
        }

        int rest = firstNineInt % 97;
        int difference = 97 - rest;

        return difference == checksum; 
    }

    private async Task<bool> NoDuplicateNationalRegistrationNumbersAsync(int ownId, string nrn) { 
        return !await _driverRepository.IsSameNationalRegistrationNumberFoundAsync(ownId, nrn);
    }

    private async Task<bool> NoDriverWithSameNameAndBirthDateAsync(int ownId, string firstName, string lastName, DateTime birthDate) {
        // Check if a driver with the same firstname, lastname and birthdate already exists 
        List<Driver>? drivers = await _driverRepository.GetByNameAndBirthDateAsync(firstName, lastName, birthDate);

        // None of the found drivers can be the driver itself 
        if (drivers != null) { 
            List<Driver>? driversWithSameNameAndBirthDate = drivers.Where(d => d.ID != ownId).ToList(); 
            return driversWithSameNameAndBirthDate.Count == 0;
        }

        return true;
    }
}
