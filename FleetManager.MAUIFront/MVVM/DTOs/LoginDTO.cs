using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.MAUIFront.MVVM.DTOs {
    public class LoginDTO {
        public int DriverID { get; set; } 
        public string Role { get; set; }
        public string Password { get; set; }
    }
}
