using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.MAUIFront.MVVM.DTOs;
public class InquiryTypeDTO {
    public int ID { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public bool AppointmentNeeded { get; set; } 
}
