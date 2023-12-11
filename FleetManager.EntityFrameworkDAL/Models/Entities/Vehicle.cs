using FleetManager.EntityFrameworkDAL.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class Vehicle : Entity {
        [StringLength(64)]
        public string Name { get; set; } 
        [StringLength(32)]
        public string ChassisNumber { get; set; }
        public bool Active { get; set; }
        public FuelType? FuelType { get; set; }
        public int VehicleTypeID { get; set; }
        public VehicleType VehicleType { get; set; }
        public DateTime? RegistrationDate { get; set; }
        public DateTime? LeasingStartDate { get; set; }
        public DateTime? LeasingEndDate { get; set; }
        public List<LicensePlate> LicensePlates { get; set; }
        public List<Maintenance> Maintenances { get; set; }
        public List<Inquiry> Inquiries { get; set; } 
        public List<InspectionReport> InspectionReports { get; set; } 
        public List<Repair> Repairs { get; set; } 
        public List<Mileage> Mileages { get; set; } 
        public List<DriverVehicle> DriverVehicles { get; set; }
    }
}
