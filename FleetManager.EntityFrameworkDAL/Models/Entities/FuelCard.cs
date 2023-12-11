using FleetManager.EntityFrameworkDAL.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class FuelCard : Entity {
        [StringLength(64)]
        public string FuelCardNumber { get; set; }
        public bool Active { get; set; }
        public DateTime CardValidityStartDate { get; set; }
        public DateTime? CardValidityEndDate { get; set; }
        [StringLength(8)]
        public string PINCode { get; set; }
        public AuthenticationType? AuthenticationType { get; set; }
        public FuelType? FuelType { get; set; }
        public List<DriverFuelCard> DriverFuelCards { get; set; }
        public List<FuelCardExtraService> FuelCardExtraServices { get; set; }
    }
}
