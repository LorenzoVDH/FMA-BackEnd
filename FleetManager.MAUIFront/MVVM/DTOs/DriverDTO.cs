using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.MAUIFront.MVVM.DTOs {
    public class DriverDTO {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool Active { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string NationalRegistrationNumber { get; set; }
        public string? AddressPostalCode { get; set; }
        public string? AddressHouseNumber { get; set; }
        public string? AddressStreet { get; set; }
        public string? AddressCity { get; set; }
        public string? LicenseType { get; set; }
        public List<VehicleDTO> Vehicles { get; set; }

    }
}
