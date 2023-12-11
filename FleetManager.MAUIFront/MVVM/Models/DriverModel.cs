using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.MAUIFront.MVVM.Models;
public class DriverModel {
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string FullAddress { get; set; }
    public string NationalRegistrationNumber { get; set; }
    public string License { get; set; }
}
