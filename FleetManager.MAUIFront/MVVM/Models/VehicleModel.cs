using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.MAUIFront.MVVM.Models {
    public class VehicleModel {
        public string Name { get; set; }
        public string ChassisNumber { get; set; }
        public string FuelType { get; set; }
        public DateTime RegistrationDate { get; set; }
        public DateTime LeasingStartDate { get; set; }
        public DateTime LeasingEndDate { get; set; }
        public string LicensePlateNumber { get; set; }
        public int MileageInKilometers { get; set; }
        public List<string> Drivers { get; set; }
        public bool ViewExpanded { get; set; }
    }
}
