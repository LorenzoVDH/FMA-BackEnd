using Moq;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using FleetManager.BLL.Validators;
using FluentValidation;
using FleetManager.Shared.HelperClasses;
using System.Diagnostics;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.BLL.Mediator.Commands.DriverCommands;
using FleetManager.BLL.Mediator.Queries.DriverQueries;

namespace FleetManager.Tests.UnitTests;

[TestClass]
public class DriverUnitTests {
    private Mock<IDriverRepository> _repositoryMock;
    private GetAllDriversQuery _getAllDriversQuery;
    private GetAllDriversHandler _getAllDriversHandler;
    private GetDriverHandler _getDriverHandler;
    private GetDriversByNameHandler _getDriversByNameHandler; 
    private CreateDriverHandler _createDriverHandler;
    private UpdateDriverHandler _updateDriverHandler;
    private DeleteDriverHandler _deleteDriverHandler;

    private List<Driver> _mockDrivers = new() {
        new Driver(){
            ID = 0,
            LastName = "Stewart",
            FirstName = "Leslie",
            DateOfBirth = new DateTime(1992,08,04),
            NationalRegistrationNumber = "92.08.04-221.95",
            AddressPostalCode = "09123",
            AddressHouseNumber = "034",
            AddressStreet = "Gregory Corners",
            AddressCity = "East Kelly",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.AM
        },

        new Driver(){
            ID = 1,
            LastName = "Rosario",
            FirstName = "Kyle",
            DateOfBirth = new DateTime(2002,11,10),
            NationalRegistrationNumber = "02.11.10-489.09",
            AddressPostalCode = "54024",
            AddressHouseNumber = "0391",
            AddressStreet = "Katie Center",
            AddressCity = "New Joyfort",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.C
        },

        new Driver(){
            ID = 2,
            LastName = "Crawford",
            FirstName = "Robert",
            DateOfBirth = new DateTime(1972,01,15),
            NationalRegistrationNumber = "72.01.15-203.90",
            AddressPostalCode = "36018",
            AddressHouseNumber = "48035",
            AddressStreet = "Church Haven",
            AddressCity = "Ellisfort",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.C
        },

        new Driver(){
            ID = 3,
            LastName = "Smith",
            FirstName = "Cynthia",
            DateOfBirth = new DateTime(1931,10,11),
            NationalRegistrationNumber = "31.10.11-376.15",
            AddressPostalCode = "15262",
            AddressHouseNumber = "305",
            AddressStreet = "Bryant Meadows",
            AddressCity = "Adamsside",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.D
        },

        new Driver(){
            ID = 4,
            LastName = "Gibson",
            FirstName = "Jacqueline",
            DateOfBirth = new DateTime(1952,03,15),
            NationalRegistrationNumber = "52.03.15-044.37",
            AddressPostalCode = "85474",
            AddressHouseNumber = "417",
            AddressStreet = "Rebecca Junctions",
            AddressCity = "West Judy",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.D
        },

        new Driver(){
            ID = 5,
            LastName = "Bates",
            FirstName = "Sarah",
            DateOfBirth = new DateTime(1986,12,11),
            NationalRegistrationNumber = "86.12.11-080.25",
            AddressPostalCode = "67165",
            AddressHouseNumber = "836",
            AddressStreet = "Rodriguez Summit",
            AddressCity = "Caitlinfurt",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.D
        },

        new Driver(){
            ID = 6,
            LastName = "Hernandez",
            FirstName = "Matthew",
            DateOfBirth = new DateTime(1930,08,12),
            NationalRegistrationNumber = "30.08.12-053.79",
            AddressPostalCode = "90182",
            AddressHouseNumber = "85631",
            AddressStreet = "Tara Causeway",
            AddressCity = "Nicoleburgh",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.B
        },

        new Driver(){
            ID = 7,
            LastName = "Watson",
            FirstName = "Jennifer",
            DateOfBirth = new DateTime(1965,12,30),
            NationalRegistrationNumber = "65.12.30-340.15",
            AddressPostalCode = "17719",
            AddressHouseNumber = "677",
            AddressStreet = "Monica Greens",
            AddressCity = "South Jillstad",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.C
        },

        new Driver(){
            ID = 8,
            LastName = "Smith",
            FirstName = "Ricky",
            DateOfBirth = new DateTime(1955,03,21),
            NationalRegistrationNumber = "55.03.21-667.73",
            AddressPostalCode = "07546",
            AddressHouseNumber = "609",
            AddressStreet = "Lisa Drive",
            AddressCity = "East Angelastad",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.C
        },

        new Driver(){
            ID = 9,
            LastName = "Burgess",
            FirstName = "Leah",
            DateOfBirth = new DateTime(1967,05,15),
            NationalRegistrationNumber = "67.05.15-818.77",
            AddressPostalCode = "83153",
            AddressHouseNumber = "350",
            AddressStreet = "Jennifer Knolls",
            AddressCity = "North Kristinville",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.A
        }
    };
    private DriverValidator _driverValidator; 

    [TestInitialize]
    public void Initialize()
    {
        //Create a new mock before every TestMethod 
        _repositoryMock = new Mock<IDriverRepository>();
        _driverValidator = new DriverValidator(_repositoryMock.Object); 
        _getAllDriversQuery = new GetAllDriversQuery() { Active = true, PageIndex = 0, PageLength = 10 }; //Specified here because it doesn't have any parameters and always stays the same
        _getAllDriversHandler = new GetAllDriversHandler(_repositoryMock.Object);
        _getDriversByNameHandler = new GetDriversByNameHandler(_repositoryMock.Object); 
        _getDriverHandler = new GetDriverHandler(_repositoryMock.Object); 
        _createDriverHandler = new CreateDriverHandler(_repositoryMock.Object, _driverValidator);
        _updateDriverHandler = new UpdateDriverHandler(_repositoryMock.Object, _driverValidator);
        _deleteDriverHandler = new DeleteDriverHandler(_repositoryMock.Object);
    }

    //CREATE 

    [TestMethod]
    public async Task CreateDriverHandler_Should_Not_Create_Driver_With_Invalid_NationalRegistrationNumber() {
        // Setup
        Driver driverWithInvalidNrn = new()
        {
            ID = 0,
            LastName = "Thompson",
            FirstName = "Charlene",
            DateOfBirth = new DateTime(1934, 03, 30),
            NationalRegistrationNumber = "34.07.10-798.08", // Invalid NRN format
            AddressPostalCode = "37400",
            AddressHouseNumber = "268",
            AddressStreet = "Gabriel Cliffs",
            AddressCity = "Kennethville",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.D
        };

        // Act and Assert
        await Assert.ThrowsExceptionAsync<ValidationException>(() =>
            _createDriverHandler.Handle(new CreateDriverCommand(driverWithInvalidNrn), CancellationToken.None));

        // Verify that the CreateAsync method for the repository is never called
        _repositoryMock.Verify(repo => repo.CreateAsync(It.IsAny<Driver>()), Times.Never);
    }

    [TestMethod]
    public async Task CreateDriverHandler_Should_Not_Create_Driver_With_Duplicate_NationalRegistrationNumber() {
        // Setup 
        Driver existingDriver = new Driver()
        {
            ID = 1,
            LastName = "Mason",
            FirstName = "Amy",
            DateOfBirth = new DateTime(1943, 04, 17),
            NationalRegistrationNumber = "43.04.17-776.33",
            AddressPostalCode = "85400",
            AddressHouseNumber = "2221",
            AddressStreet = "Delgado Isle",
            AddressCity = "Padillabury",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.A
        };

        Driver newDriver = new Driver()
        {
            ID = 2,
            LastName = "Moore",
            FirstName = "Dawn",
            DateOfBirth = new DateTime(1943, 04, 17),
            NationalRegistrationNumber = "43.04.17-776.33",
            AddressPostalCode = "73414",
            AddressHouseNumber = "5734",
            AddressStreet = "Donna Ports",
            AddressCity = "West Logan",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.C
        };

        //Whenever IsSameNationalRegistrationNumberFoundAsync is called in the repository, return true to simulate a duplicate nrn existing in the db 
        _repositoryMock.Setup(repo => repo.IsSameNationalRegistrationNumberFoundAsync(It.IsAny<int>(),It.IsAny<string>())).ReturnsAsync(true);

        // Act and Assert, using the CreateDriverCommand should yield an Exception because
        // the newDriver's NRN and existingDriver's NRN are the same 
        await Assert.ThrowsExceptionAsync<ValidationException>(() => //Is ArgumentException the right Exception to use?
            _createDriverHandler.Handle(new CreateDriverCommand(newDriver), CancellationToken.None));

        // Verify that the CreateAsync method for the repository is never called
        _repositoryMock.Verify(repo => repo.CreateAsync(It.IsAny<Driver>()), Times.Never);
    }

    [TestMethod]
    public async Task CreateDriverHandler_Should_Not_Create_Driver_Without_NationalRegistrationNumber() {
        //Setup 
        Driver driverWithEmptyNrn = new()
        {
            LastName = "Lopez",
            FirstName = "Diane",
            DateOfBirth = new DateTime(1978, 11, 13),
            NationalRegistrationNumber = "",
            AddressPostalCode = "66459",
            AddressHouseNumber = "348",
            AddressStreet = "Jennifer Islands",
            AddressCity = "New Edwardview",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.B
        };

        Driver driverWithoutNrn = new()
        {
            ID = 0,
            LastName = "Anderson",
            FirstName = "Kenneth",
            DateOfBirth = new DateTime(1994, 08, 09),
            AddressPostalCode = "58642",
            AddressHouseNumber = "80237",
            AddressStreet = "Miller Ways",
            AddressCity = "Smithton",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.AM
        };

        //Assert, ValidationException for the empty NRN and ArgumentNullException for the null NRN 
        await Assert.ThrowsExceptionAsync<ValidationException>(() =>
            _createDriverHandler.Handle(new CreateDriverCommand(driverWithEmptyNrn), CancellationToken.None));
        await Assert.ThrowsExceptionAsync<ValidationException>(() =>
            _createDriverHandler.Handle(new CreateDriverCommand(driverWithoutNrn), CancellationToken.None));

        //Verify - check if the CreateAsync() method has been called (which it shouldn't have)
        _repositoryMock.Verify(repo => repo.CreateAsync(It.IsAny<Driver>()), Times.Never());
    }

    [TestMethod]
    public async Task CreateDriverHandler_Should_Not_Create_Driver_Without_First_Or_Last_Name() {
        // Setup
        Driver driverWithoutFirstName = new()
        {
            ID = 1,
            LastName = "Thomas",
            FirstName = "",
            DateOfBirth = new DateTime(1992, 03, 30),
            NationalRegistrationNumber = "92.03.30-450.21",
            AddressPostalCode = "64545",
            AddressHouseNumber = "4095",
            AddressStreet = "Fernandez Knoll",
            AddressCity = "Port Charlesborough",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.B
        };
        Driver driverWithoutLastName = new()
        {
            ID = 2,
            LastName = "",
            FirstName = "Theresa",
            DateOfBirth = new DateTime(1992, 03, 30),
            NationalRegistrationNumber = "92.03.30-450.21",
            AddressPostalCode = "64545",
            AddressHouseNumber = "4095",
            AddressStreet = "Fernandez Knoll",
            AddressCity = "Port Charlesborough",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.B
        };
        Driver driverWithoutFirstAndLastName = new()
        {
            ID = 3,
            LastName = "Thomas",
            FirstName = "",
            DateOfBirth = new DateTime(1992, 03, 30),
            NationalRegistrationNumber = "92.03.30-450.21",
            AddressPostalCode = "64545",
            AddressHouseNumber = "4095",
            AddressStreet = "Fernandez Knoll",
            AddressCity = "Port Charlesborough",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.B
        };

        // Act and Assert
        await Assert.ThrowsExceptionAsync<ValidationException>(() =>
            _createDriverHandler.Handle(new CreateDriverCommand(driverWithoutFirstName), CancellationToken.None));
        await Assert.ThrowsExceptionAsync<ValidationException>(() =>
            _createDriverHandler.Handle(new CreateDriverCommand(driverWithoutLastName), CancellationToken.None));
        await Assert.ThrowsExceptionAsync<ValidationException>(() =>
            _createDriverHandler.Handle(new CreateDriverCommand(driverWithoutFirstAndLastName), CancellationToken.None));

        // Verify that the CreateAsync method for the repository is never called
        _repositoryMock.Verify(repo => repo.CreateAsync(It.IsAny<Driver>()), Times.Never);
    }

    [TestMethod]
    public async Task CreateDriverHandler_Should_Not_Create_Driver_Without_BirthDate() {
        //Setup 
        Driver driverWithoutBirthDate = new()
        {
            ID = 1,
            LastName = "Nichols",
            FirstName = "Aaron",
            NationalRegistrationNumber = "25.01.05-873.91",
            AddressPostalCode = "45452",
            AddressHouseNumber = "371",
            AddressStreet = "Michele Stravenue",
            AddressCity = "Davidside",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.AM
        };

        //Assert 
        await Assert.ThrowsExceptionAsync<ValidationException>(() =>
            _createDriverHandler.Handle(new CreateDriverCommand(driverWithoutBirthDate), CancellationToken.None));

        //Verify - check if the CreateAsync() method has been called (which it shouldn't have)
        _repositoryMock.Verify(repo => repo.CreateAsync(It.IsAny<Driver>()), Times.Never());
    }

    [TestMethod]
    public async Task CreateDriverHandler_Should_Not_Create_Driver_Below_Age_16() {
        //Setup 

        DateTime dateOfBirthYoungerThan16 = new(DateTime.Now.Year - 15, 7, 11);
        string nationalRegistrationNumberYoungerThan16 =
            Generate.NationalRegistrationNumberFromBirthDate(dateOfBirthYoungerThan16, true);

        Driver driverYoungerThan16 = new Driver()
        {
            ID = 0,
            LastName = "Johnson",
            FirstName = "Cristina",
            DateOfBirth = dateOfBirthYoungerThan16,
            NationalRegistrationNumber = nationalRegistrationNumberYoungerThan16,
            AddressPostalCode = "26782",
            AddressHouseNumber = "69818",
            AddressStreet = "Pearson Ramp",
            AddressCity = "Mortonfort",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.C
        };

        Debug.WriteLine($"Date of Birth of the Driver younger than 16: {dateOfBirthYoungerThan16} \n" +
                        $"National Registration Number of the Driver younger than 16: {nationalRegistrationNumberYoungerThan16}");


        //Assert 
        await Assert.ThrowsExceptionAsync<ValidationException>(() => _createDriverHandler.Handle(new CreateDriverCommand(driverYoungerThan16), CancellationToken.None));

        //Verify 
        _repositoryMock.Verify(repo => repo.CreateAsync(It.IsAny<Driver>()), Times.Never());
    }

    [TestMethod]
    public async Task CreateDriverHandler_Should_Not_Create_Driver_With_Same_Name_And_BirthDate() {
        // Setup 
        Driver existingDriver = new Driver()
        {
            ID = 1,
            LastName = "Lee",
            FirstName = "Natalie",
            DateOfBirth = new DateTime(1989, 12, 08),
            NationalRegistrationNumber = "89.12.08-440.12",
            AddressPostalCode = "67296",
            AddressHouseNumber = "1730",
            AddressStreet = "Robert Coves",
            AddressCity = "Lake Thomasborough",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.D
        };

        Driver newDriver = new Driver()
        {
            ID = 2,
            LastName = "Lee",
            FirstName = "Natalie",
            DateOfBirth = new DateTime(1989, 12, 08),
            NationalRegistrationNumber = "89.12.08-444.08",
            AddressPostalCode = "03937",
            AddressHouseNumber = "3464",
            AddressStreet = "Christina Haven",
            AddressCity = "Nelsonfurt",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.B
        };
        // Wherever GetByNameAndBirthDateAsync gets called, it returns a list containing the existingDriver
        // replicating the behaviour that would occur whenever the database contains a driver with the same 
        // firstname, lastname and birthdate 
        _repositoryMock.Setup(repo => repo.GetByNameAndBirthDateAsync(It.IsAny<string>(),
                                                                        It.IsAny<string>(),
                                                                        It.IsAny<DateTime>())).ReturnsAsync(
                                                                            new List<Driver> {
                                                                                existingDriver
                                                                            });

        // Act and Assert 
        await Assert.ThrowsExceptionAsync<ValidationException>(() =>
            _createDriverHandler.Handle(new CreateDriverCommand(newDriver), CancellationToken.None));

        // Verify that the CreateAsync method for the repository is never called
        _repositoryMock.Verify(repo => repo.CreateAsync(It.IsAny<Driver>()), Times.Never);
    }

    //READ
    [TestMethod]
    public async Task GetAllDriversQueryHandler_Should_Return_All_Drivers() {
        // Setup
        List<Driver> mockDrivers = _mockDrivers;
        _repositoryMock.Setup(repo => repo.GetDriversWithVehiclesAsync(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<bool>())).ReturnsAsync(mockDrivers);

        // Act
        List<Driver> resultingListOfDrivers = await _getAllDriversHandler.Handle(_getAllDriversQuery, CancellationToken.None);

        // Assert
        Assert.AreEqual(mockDrivers, resultingListOfDrivers);
    }

    [TestMethod]
    public async Task GetAllDriversHandler_Should_Return_Empty_List_When_No_Drivers_Exist() {
        // Arrange
        var emptyDriverList = new List<Driver>(); 
        //      Whenever GetAllAsync gets called, the empty Driver List gets returned 
        _repositoryMock.Setup(repo => repo.GetDriversWithVehiclesAsync(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<bool>())).ReturnsAsync(emptyDriverList);

        // Act
        var result = await _getAllDriversHandler.Handle(_getAllDriversQuery, CancellationToken.None);

        // Assert
        Assert.IsNotNull(result);
        Assert.AreEqual(0, result.Count);

        // Verify that the GetAllAsync method for the repository is called once
        _repositoryMock.Verify(repo => repo.GetDriversWithVehiclesAsync(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<bool>()), Times.Once);
    }

    [TestMethod]
    public async Task GetDriversByNameHandler_Should_Return_Matching_Drivers() {
        // Arrange
        string firstName = "John";
        string lastName = "Doe";
        var query = new GetDriversByNameQuery(firstName, lastName);
        var expectedDrivers = new List<Driver> {
            new Driver { FirstName = firstName, LastName = lastName },
            new Driver { FirstName = firstName, LastName = lastName },
        };

        _repositoryMock.Setup(repo => repo.GetByNameAsync(firstName, lastName)).ReturnsAsync(expectedDrivers);

        // Act
        List<Driver> actualDrivers = await _getDriversByNameHandler.Handle(query, CancellationToken.None);

        // Assert
        CollectionAssert.AreEqual(expectedDrivers, actualDrivers);
    }

    [TestMethod]
    public async Task GetDriverHandler_Should_Return_Null_With_Invalid_Id() {
        // Arrange
        int invalidDriverId = int.MaxValue;
        _repositoryMock.Setup(repo => repo.GetByIDAsync(invalidDriverId)).ReturnsAsync((Driver?) null);

        // Act
        var result = await _getDriverHandler.Handle(new GetDriverByIDQuery(invalidDriverId), CancellationToken.None);

        // Assert
        Assert.IsNull(result);
    }


    [TestMethod]
    public async Task GetDriversByNameHandler_Should_Return_Empty_List_When_No_Matching_Drivers() {
        // Arrange
        string firstName = "John";
        string lastName = "Doe";
        var query = new GetDriversByNameQuery(firstName, lastName);
        var expectedDrivers = new List<Driver>(); // Empty list

        // Mock the repository and set up the expected behavior
        _repositoryMock.Setup(repo => repo.GetByNameAsync(firstName, lastName)).ReturnsAsync(expectedDrivers);

        // Act
        List<Driver> actualDrivers = await _getDriversByNameHandler.Handle(query, CancellationToken.None);

        // Assert
        Assert.AreEqual(expectedDrivers.Count, actualDrivers.Count);
    }

    [TestMethod]
    public async Task GetDriverQueryHandler_Should_Return_The_Correct_Driver() {
        //Setup 
        Driver driver = new Driver() {
            ID = 1,
            LastName = "Patton",
            FirstName = "Yolanda",
            DateOfBirth = new DateTime(1980, 06, 03),
            NationalRegistrationNumber = "80.06.03-348.23",
            AddressPostalCode = "48663",
            AddressHouseNumber = "67546",
            AddressStreet = "Holloway Shoal",
            AddressCity = "Shaneberg",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.B
        };
        _repositoryMock.Setup(repo => repo.GetByIDAsync(driver.ID)).ReturnsAsync(driver); 

        //Act And Assert 
        Driver resultingDriver = await _getDriverHandler.Handle(new GetDriverByIDQuery(driver.ID), CancellationToken.None);

        //Verify 
        Assert.AreEqual(driver, resultingDriver); 
    }

    [TestMethod]
    public async Task GetDriverHandler_Should_Return_Null_When_Driver_ID_Does_Not_Exist() {
        // Act  
        Driver? driver = await _getDriverHandler.Handle(new GetDriverByIDQuery(1), CancellationToken.None);

        // Assert
        Assert.IsNull(driver); 
    }

    //UPDATE
    [TestMethod]
    public async Task UpdateDriverHandler_Should_Update_Driver() {
        // Setup 
        Driver driver = new() {
            ID = 0,
            LastName = "Dunn",
            FirstName = "Joshua",
            DateOfBirth = new DateTime(1953, 02, 11),
            NationalRegistrationNumber = "53.02.11-133.82",
            AddressPostalCode = "21441",
            AddressHouseNumber = "34280",
            AddressStreet = "Robert Summit",
            AddressCity = "Port Anthonymouth",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.B
        }; 

        // Act
        await _updateDriverHandler.Handle(new UpdateDriverCommand(driver), CancellationToken.None);

        // Verify if the UpdateAsync method has been called and if no other calls have been made 
        _repositoryMock.Verify(repo => repo.UpdateAsync(driver), Times.Once);
    }

    [TestMethod]
    public async Task UpdateDriverHandler_Should_Not_Update_Driver_With_Invalid_NationalRegistrationNumber() {
        // Setup 
        Driver driver = new() {
            ID = 0,
            LastName = "Little",
            FirstName = "Alexis",
            DateOfBirth = new DateTime(1966, 01, 15),
            NationalRegistrationNumber = "66.01.15-899.48",
            AddressPostalCode = "97927",
            AddressHouseNumber = "5738",
            AddressStreet = "Christine Flat",
            AddressCity = "Crystalside",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.G
        };

        // Act 
        await Assert.ThrowsExceptionAsync<ValidationException>(() => _updateDriverHandler.Handle(new UpdateDriverCommand(driver), CancellationToken.None));

        // Verify 
        _repositoryMock.Verify(repo => repo.UpdateAsync(driver), Times.Never); 
    }

    [TestMethod]
    public async Task UpdateDriverHandler_Should_Not_Update_Driver_With_No_Name() {
        // Setup 
        Driver driver = new() {
            ID = 0,
            DateOfBirth = new DateTime(1961, 05, 04),
            NationalRegistrationNumber = "61.05.04-221.05",
            AddressPostalCode = "53553",
            AddressHouseNumber = "339",
            AddressStreet = "Dawn Park",
            AddressCity = "Matthewfurt",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.G
        };

        // Act 
        await Assert.ThrowsExceptionAsync<ValidationException>(() => _updateDriverHandler.Handle(new UpdateDriverCommand(driver), CancellationToken.None));

        // Verify 
        _repositoryMock.Verify(repo => repo.UpdateAsync(driver), Times.Never);
    }

    [TestMethod]
    public async Task UpdateDriverHandler_Should_Not_Update_Driver_When_NationalRegistrationNumber_Exists_In_Database() {
        // Setup 
        Driver driver = new() {
            ID = 0,
            LastName = "Ellis",
            FirstName = "Brian",
            DateOfBirth = new DateTime(1957, 05, 07),
            NationalRegistrationNumber = "57.05.07-929.93",
            AddressPostalCode = "84070",
            AddressHouseNumber = "470",
            AddressStreet = "Linda Forest",
            AddressCity = "Gonzalezton",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.D
        };

        //In this case the same NationalRegistrationNumber is found in the repository 
        _repositoryMock.Setup(repo => repo.IsSameNationalRegistrationNumberFoundAsync(It.IsAny<int>(), It.IsAny<string>())).ReturnsAsync(true);

        // Act 
        await Assert.ThrowsExceptionAsync<ValidationException>(() => _updateDriverHandler.Handle(new UpdateDriverCommand(driver), CancellationToken.None));

        // Verify 
        _repositoryMock.Verify(repo => repo.Equals(driver), Times.Never); 
    }

    // DELETE 
    [TestMethod]
    public async Task DeleteDriverHandler_Should_Delete_Existing_Driver() {
        // Setup
        int driverId = 42;
        Driver driverToBeDeleted = new() {
            ID = 42,
            LastName = "Lee",
            FirstName = "Jeremy",
            DateOfBirth = new DateTime(1957, 04, 05),
            NationalRegistrationNumber = "57.04.05-997.78",
            AddressPostalCode = "90857",
            AddressHouseNumber = "4588",
            AddressStreet = "Michael Glens",
            AddressCity = "South Samantha",
            LicenseType = EntityFrameworkDAL.Models.Enums.LicenseType.G
        }; 

        _repositoryMock.Setup(repo => repo.GetByIDAsync(driverId)).ReturnsAsync(driverToBeDeleted); 

        // Act
        await _deleteDriverHandler.Handle(new DeleteDriverCommand(driverId), CancellationToken.None);

        // Verify that the DeleteAsync method for the repository is called once with the correct driver ID
        _repositoryMock.Verify(repo => repo.DeleteAsync(driverId), Times.Once);
    }

    [TestMethod]
    public async Task DeleteDriverHandler_Should_Throw_Exception_When_Deleting_Nonexistent_Driver() {
        // Setup
        int nonExistentDriverID = int.MaxValue; 

        // Act And Assert
        await Assert.ThrowsExceptionAsync<ValidationException>(
            () => _deleteDriverHandler.Handle(new DeleteDriverCommand(nonExistentDriverID), CancellationToken.None));
    }
}
