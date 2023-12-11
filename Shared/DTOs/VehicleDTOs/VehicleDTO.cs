using System.ComponentModel.DataAnnotations;

namespace FleetManager.Shared.DTOs.VehicleDTOs;
public class VehicleDTO : GenericDTO {
    [StringLength(64)]
    public string Name { get; set; }
    [StringLength(32)]
    public string ChassisNumber { get; set; }
    public string FuelType { get; set; }
    public int VehicleTypeID { get; set; }
    public DateTime? RegistrationDate { get; set; }
    public DateTime? LeasingStartDate { get; set; }
    public DateTime? LeasingEndDate { get; set; }
    public DateTime LicensePlateStartDate { get; set; }
    public string CurrentLicensePlateNumber { get; set; }
    public string? PendingLicensePlateNumber { get; set; }
    public DateTime? PendingLicensePlateStartDate { get; set; }
    public decimal Mileage { get; set; }
}
