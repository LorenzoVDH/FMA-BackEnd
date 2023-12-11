using System.ComponentModel.DataAnnotations;

namespace FleetManager.Shared.DTOs.VehicleDTOs; 
public class VehicleOverviewReadDTO : GenericDTO {
    public string Name { get; set; }
    [StringLength(32)]
    public string ChassisNumber { get; set; }
    public string FuelType { get; set; }
    public string VehicleTypeName { get; set; }
    public DateTime? RegistrationDate { get; set; }
    public DateTime? LeasingStartDate { get; set; }
    public DateTime? LeasingEndDate { get; set; }
    public string CurrentLicensePlate { get; set; }
    public string? PendingLicensePlateNumber { get; set; }
    public DateTime? PendingLicensePlateStartDate { get; set; }
    public decimal CurrentMileageInKilometers { get; set; }

}