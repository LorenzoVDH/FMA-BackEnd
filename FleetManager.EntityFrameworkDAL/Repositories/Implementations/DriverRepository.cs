using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Repositories.Interfaces;
using FleetManager.EntityFrameworkDAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace FleetManager.EntityFrameworkDAL.Repositories.Implementations;
//Add authorization
public class DriverRepository : Repository<Driver>, IDriverRepository {
    public DriverRepository(FleetManagerContext context) : base(context) { }
    public async Task<Driver> GetByNationalRegistrationNumberAsync(string nrn) {
        return await _context.Drivers.Where(d => d.NationalRegistrationNumber == nrn).FirstOrDefaultAsync();
    }
    public async Task<List<Driver>> GetByNameAsync(string firstName, string lastName) {
        //This method returns a list of all the drivers with the
        //given first and last name in case there are duplicate
        //entries that might need to be deleted 
        return await _context.Drivers.Where(d => d.FirstName == firstName && 
                                                 d.LastName == lastName).ToListAsync();
    }

    public async Task<bool> IsSameNationalRegistrationNumberFoundAsync(int id, string nrn) {
        //Check if there are other records in the database that contain the same NRN which don't have the same ID
        return await _context.Drivers.AnyAsync(d => d.ID != id && d.NationalRegistrationNumber == nrn);
    }

    public async Task<List<Driver>> GetByNameAndBirthDateAsync(string firstName, string lastName, DateTime dateOfBirth) {
        return await _context.Drivers.Where(d => d.FirstName == firstName && 
                                                 d.LastName == lastName && 
                                                 d.DateOfBirth == dateOfBirth).ToListAsync(); 
    }

    public async Task<List<Driver>> GetDriversWithVehiclesAsync(int pageIndex, int pageLength, bool active) {
        var drivers = await _context.Drivers
            .Where(d => d.Active == active)
            .OrderBy(d => d.ID)
            .Skip(pageIndex * pageLength)
            .Take(pageLength)
            .Select(d => new Driver {
                ID = d.ID,
                LastName = d.LastName,
                FirstName = d.FirstName,
                DateOfBirth = d.DateOfBirth,
                NationalRegistrationNumber = d.NationalRegistrationNumber,
                LicenseType = d.LicenseType,
                DriverVehicles = d.DriverVehicles
                    .Where(dv => dv.Vehicle.Active)
                    .Select(dv => new DriverVehicle {
                    Vehicle = new Vehicle {
                        ID = dv.Vehicle.ID,
                        Name = dv.Vehicle.Name,
                        LicensePlates = dv.Vehicle.LicensePlates
                            .Where(lp => lp.VehicleID == dv.Vehicle.ID &&
                                         lp.ValidityStartDate <= DateTime.Now &&
                                         (lp.ValidityEndDate >= DateTime.Now || lp.ValidityEndDate == null))
                            .Select(lp => new LicensePlate {
                                LicensePlateNumber = lp.LicensePlateNumber
                            })
                            .ToList()
                    }
                }).ToList()
            }).ToListAsync();

        return drivers;
    }

    public async Task<int> GetDriversCountByActiveStatusAsync(bool active) {
        return await _context.Drivers.Where(d => d.Active == active).CountAsync(); 
    }

    public override async Task<Driver?> GetByIDAsync(int id) {
        return await _context.Drivers
                             .Where(d => d.ID == id)
                             .Select(d => new Driver {
                                 ID = d.ID,
                                 LastName = d.LastName,
                                 FirstName = d.FirstName,
                                 DateOfBirth = d.DateOfBirth,
                                 NationalRegistrationNumber = d.NationalRegistrationNumber,
                                 AddressPostalCode = d.AddressPostalCode,
                                 AddressHouseNumber = d.AddressHouseNumber,
                                 AddressCity = d.AddressCity,
                                 AddressStreet = d.AddressStreet,
                                 LicenseType = d.LicenseType,
                                 DriverVehicles = d.DriverVehicles
                                    .Where(dv => dv.Vehicle.Active)
                                    .Select(dv => new DriverVehicle {
                                     Vehicle = new Vehicle {
                                         ID = dv.Vehicle.ID,
                                         Name = dv.Vehicle.Name,
                                         LicensePlates = dv.Vehicle.LicensePlates
                                        .Where(lp => lp.VehicleID == dv.Vehicle.ID &&
                                                     lp.ValidityStartDate <= DateTime.Now &&
                                                     (lp.ValidityEndDate >= DateTime.Now || lp.ValidityEndDate == null))
                                        .Select(lp => new LicensePlate {
                                            LicensePlateNumber = lp.LicensePlateNumber
                                        })
                                        .ToList()
                                     }
                                 }).ToList()
                             }).FirstOrDefaultAsync();
    }

    public async Task AddVehicleAssociationToDriver(int driverId, int vehicleId) {
        var existingAssociation = await _context.DriverVehicles.Where(dv => dv.DriverID == driverId && dv.VehicleID == vehicleId).FirstOrDefaultAsync();
        
        if (existingAssociation != null) {
            throw new InvalidOperationException("This Vehicle-Driver association already exists!");
        }

        bool driverActive = await _context.Drivers.Where(d => d.ID == driverId).Select(d => d.Active).FirstOrDefaultAsync();
        bool vehicleActive = await _context.Vehicles.Where(v => v.ID == vehicleId).Select(v => v.Active).FirstOrDefaultAsync(); 

        if (!driverActive || !vehicleActive) {
            throw new InvalidOperationException("The driver and vehicle need to be active before the association can be made!");
        }

        await _context.DriverVehicles.AddAsync(
            new DriverVehicle() { 
                DriverID = driverId, 
                VehicleID = vehicleId 
            });
        await SaveChangesAsync();
    }

    public async Task RemoveVehicleAssociationFromDriver(int driverId, int vehicleId) {
        await _context.Set<DriverVehicle>().Where(dv => dv.DriverID == driverId && dv.VehicleID == vehicleId).ExecuteDeleteAsync();
    }

    public async Task<List<Driver>> GetDriversBySearchTermAsync(string query) {
        query.Replace(",", "").Replace(".", "").Replace("-", "");
        return await _context.Drivers.Where(d => d.LastName.Contains(query) || d.FirstName.Contains(query) || d.NationalRegistrationNumber.Contains(query)).Take(10).ToListAsync();
    }

    public async Task<Login> GetDriverLoginByEmailAsync(string email) {
        return await _context.Logins.Where(l => l.Email == email).FirstOrDefaultAsync();
    }
}
