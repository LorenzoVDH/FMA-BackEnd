using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.DapperDAL.Models;
public class MaintenanceTaskModel : Model {
    public int MaintenanceID { get; set; }
    public string Description { get; set; } 
}
