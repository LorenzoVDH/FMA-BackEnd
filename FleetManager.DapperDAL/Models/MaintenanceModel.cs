using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.DapperDAL.Models;
public class MaintenanceModel : Model {
    public int VehicleID { get; set; }
    public DateTime Date { get; set; }
    public decimal? Cost { get; set; }  
    public int? GarageID { get; set; }
    public string? GarageName { get; set; }
    public string? InvoiceFilePath { get; set; }
    public List<MaintenanceTaskModel>? Tasks { get; set; } 
}
