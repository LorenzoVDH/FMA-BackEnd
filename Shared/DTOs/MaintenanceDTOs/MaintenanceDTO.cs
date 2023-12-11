using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.Shared.DTOs.MaintenanceDTOs;
public class MaintenanceDTO : GenericDTO {
    public int VehicleID { get; set; }
    public DateTime Date { get; set; }
    public decimal? Cost { get; set; }
    public int? GarageID { get; set; }
    public string? GarageName { get; set; }
    public string? InvoiceFilePath { get; set; }
}
