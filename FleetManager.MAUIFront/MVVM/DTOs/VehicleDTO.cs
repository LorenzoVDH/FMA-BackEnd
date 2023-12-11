using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FleetManager.MAUIFront.MVVM.DTOs;
public class VehicleDTO {
    public int ID { get; set; }
    public string Name { get; set; } 
    public string ChassisNumber { get; set; } 
    public string FuelType { get; set; }
    public int VehicleTypeID { get; set; }
    public DateTime RegistrationDate { get; set; } 
    public DateTime LeasingStartDate { get; set; } 
    public DateTime LeasingEndDate { get; set; }
    public DateTime LicensePlateStartDate { get; set; }
    public string CurrentLicensePlateNumber { get; set; }
    public DateTime PendingLicensePlateStartDate { get; set; }
    public decimal Mileage { get; set; }
}
