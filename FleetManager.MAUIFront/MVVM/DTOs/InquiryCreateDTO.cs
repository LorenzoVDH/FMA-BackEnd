using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.MAUIFront.MVVM.DTOs;
public class InquiryCreateDTO {
    public int DriverID { get; set; }
    public int InquiryTypeID { get; set; }
    public DateTime? PreferredDate { get; set; }
    public DateTime? PreferredDateBackup { get; set; }
    public string Comment { get; set; }
    public int? VehicleID { get; set; }
}
