using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.MAUIFront.MVVM.Models {
    public class FuelCardModel {
        public string Cardnumber { get; set; } 
        public DateTime ValidityEndDate { get; set; }
        public string FuelType { get; set; }
        public List<string> ExtraServices { get; set; }
    }
}
