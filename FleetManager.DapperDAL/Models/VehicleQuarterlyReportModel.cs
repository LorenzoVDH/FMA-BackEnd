using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.DapperDAL.Models;
public class VehicleQuarterlyReportModel : Model {
    public int Year { get; set; }
    public int Quarter { get; set; }
    public int DamageReports { get; set; }
    public int Maintenances { get; set; }
    public int Repairs { get; set; } 
}
