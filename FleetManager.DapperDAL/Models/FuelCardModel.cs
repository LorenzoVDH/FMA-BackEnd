using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.DapperDAL.Models;
public class FuelCardModel : Model {
    public string CardNumber { get; set; }
    public DateTime ValidityEndDate { get; set; }
    public string FuelType { get; set; }
    public List<string> ExtraServices { get; set; }
}