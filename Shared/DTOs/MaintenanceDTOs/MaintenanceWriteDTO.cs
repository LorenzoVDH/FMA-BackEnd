namespace FleetManager.Shared.DTOs.MaintenanceDTOs;
public class MaintenanceWriteDTO : GenericDTO {
    public int VehicleID { get; set; }
    public DateTime Date { get; set; }
    public decimal? Cost { get; set; }
    public int? GarageID { get; set; }
    public string? InvoiceFilePath { get; set; }
    public List<string>? TaskDescriptions { get; set; }
}
