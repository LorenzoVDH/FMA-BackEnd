using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.DapperDAL.Models;
public class VehicleSimplifiedModel : Model {
    public string Name { get; set; }
    public string CurrentLicensePlateNumber { get; set; }
    public string ChassisNumber { get; set; } 
}
