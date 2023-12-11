using FleetManager.EntityFrameworkDAL.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities {
    public class Driver : Entity {
        [StringLength(128)]
        public string LastName { get; set; }
        [StringLength(128)]
        public string FirstName { get; set; }
        public bool Active { get; set; }
        public DateTime DateOfBirth { get; set; }
        [StringLength(16)]
        public string NationalRegistrationNumber { get; set; }
        [StringLength(16)]
        public string? AddressPostalCode { get; set; }
        [StringLength(16)]
        public string? AddressHouseNumber { get; set; }
        [StringLength(128)]
        public string? AddressStreet { get; set; }
        [StringLength(128)]
        public string? AddressCity { get; set; }
        public LicenseType? LicenseType { get; set; }
        public List<DriverFuelCard> DriverFuelCards { get; set; }
        public List<Inquiry> Inquiries { get; set; }
        public List<InspectionReport> InspectionReports { get; set; } 
        public List<DriverVehicle> DriverVehicles { get; set; }
    }
}
