namespace FleetManager.Shared.DTOs.InquiryDTOs;
public class InquiryCreateDTO {
    public int DriverID { get; set; }
    public int InquiryTypeID { get; set; }
    public DateTime? PreferredDate { get; set; }
    public DateTime? PreferredDateBackup { get; set; }
    public string? Comment { get; set; }
    public int? VehicleID { get; set; }
}
