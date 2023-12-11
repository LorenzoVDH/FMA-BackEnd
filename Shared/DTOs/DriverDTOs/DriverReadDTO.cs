using FleetManager.Shared.DTOs.VehicleDTOs;
using System.ComponentModel.DataAnnotations;

namespace FleetManager.Shared.DTOs.DriverDTOs;
public class DriverReadDTO : GenericDTO {
    [StringLength(128)]
    public string LastName { get; set; }
    [StringLength(128)]
    public string FirstName { get; set; }
    public bool Active { get; set; }
    public DateTime DateOfBirth { get; set; }
    [StringLength(16)]
    public string NationalRegistrationNumber { get; set; }
    [StringLength(16)]
    public string? AddressPostalCode { get; set; }
    [StringLength(16)]
    public string? AddressHouseNumber { get; set; }
    [StringLength(128)]
    public string? AddressStreet { get; set; }
    [StringLength(128)]
    public string? AddressCity { get; set; }
    public string? LicenseType { get; set; }
    public List<VehicleSimplifiedDTO> Vehicles { get; set; }
}
