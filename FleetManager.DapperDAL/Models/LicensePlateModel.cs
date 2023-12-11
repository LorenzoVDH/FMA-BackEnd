using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.DapperDAL.Models {
    public class LicensePlateModel : Model {
        public int VehicleID { get; set; }
        public DateTime ValidityStartDate { get; set; }
        public DateTime? ValidityEndDate { get; set; }
        public string LicensePlateNumber { get; set; }
    }
}
