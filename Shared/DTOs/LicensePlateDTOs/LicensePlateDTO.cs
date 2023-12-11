namespace FleetManager.Shared.DTOs.LicensePlateDTOs;
public class LicensePlateDTO : GenericDTO {
    public int VehicleID { get; set; }
    public DateTime ValidityStartDate { get; set; }
    public DateTime? ValidityEndDate { get; set; }
    public string LicensePlateNumber { get; set; }
}
