using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.DapperDAL.Models; 
public class InquiryModel : Model {
    public DateTime InquiryDate { get; set; }
    public string? InquiryCategory { get; set; }
    public int InquiryTypeID { get; set; }
    public string? InquiryTypeName { get; set; }
    public int? DriverID { get; set; }
    public string? DriverFirstName { get; set; }
    public string? DriverLastName { get; set; }
    public int? VehicleID { get; set; }
    public string? VehicleName { get; set; }
    public string? Comment { get; set; }
    public string? Status { get; set; }
    public DateTime? PreferredDate { get; set; }
    public DateTime? PreferredDateBackup { get; set; }
}