using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.Shared.DTOs.DriverDTOs;
public class DriverSimplifiedDTO : GenericDTO {
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string NationalRegistrationNumber { get; set; } 
}
