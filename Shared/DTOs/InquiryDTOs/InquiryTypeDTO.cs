using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.Shared.DTOs.InquiryDTOs;
public class InquiryTypeDTO : GenericDTO {
    public string Name { get; set; }
    public string Category { get; set; } 
    public bool AppointmentNeeded { get; set; } 
}
