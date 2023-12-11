using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.MAUIFront.MVVM.Models;
public class InquiryModel {
    public int DriverID { get; set; }
    public DateTime InquiryDate { get; set; }
    public int InquiryTypeID { get; set; }
    public string? InquiryTypeName { get; set; } 

    public DateTime? PreferredDate { get; set; }
    public DateTime? PreferredDateBackup { get; set; }
    public string? Status { get; set; }
    public string? Comment { get; set; }
    public int? VehicleID { get; set; } 
    public string? VehicleName { get; set; }

    public override string ToString() {
        return $"DriverID: {DriverID}\n" +
               $"InquiryDate: {InquiryDate}\n" +
               $"InquiryTypeID: {InquiryTypeID}\n" +
               $"InquiryTypeName: {InquiryTypeName ?? "N/A"}\n" +
               $"PreferredDate: {PreferredDate?.ToString() ?? "N/A"}\n" +
               $"PreferredDateBackup: {PreferredDateBackup?.ToString() ?? "N/A"}\n" +
               $"Status: {Status ?? "N/A"}\n" +
               $"Comment: {Comment ?? "N/A"}\n" +
               $"VehicleID: {VehicleID?.ToString() ?? "N/A"}\n" +
               $"VehicleName: {VehicleName ?? "N/A"}";
    }
}

