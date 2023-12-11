using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.DapperDAL.Models {
    public class DriverSimplifiedModel : Model{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NationalRegistrationNumber { get; set; }
    }
}
