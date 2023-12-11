using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.EntityFrameworkDAL.Models.Entities {
    public class FuelCardExtraService : Entity {
        public int FuelCardID { get; set; }
        public FuelCard FuelCard { get; set; }
        public int ExtraServiceID { get; set; }
        public ExtraService ExtraService { get; set; } 
    }
}
