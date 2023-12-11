using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.Shared.DTOs.MaintenanceDTOs;
public class MaintenanceTaskDTO : GenericDTO {
    public int MaintenanceID { get; set; } 
    public string Description { get; set; } 
}
