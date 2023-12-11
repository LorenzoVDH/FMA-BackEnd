using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.EntityFrameworkDAL.Models.Entities;
public class DriverVehicle : Entity {
    public int DriverID { get; set; }
    public Driver Driver { get; set; }
    public int VehicleID { get; set; } 
    public Vehicle Vehicle { get; set; } 
}
