using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.DapperDAL.Models;
public class DriverVehicleAssociationModel {
    public int DriverID { get; set; }
    public int VehicleID { get; set; } 
    public string ChassisNumber { get; set; }
    public string LicensePlateNumber { get; set; } 
}
