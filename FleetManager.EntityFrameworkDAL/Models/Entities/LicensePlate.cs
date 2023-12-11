using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class LicensePlate : Entity {
        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime ValidityStartDate { get; set; }
        public DateTime? ValidityEndDate { get; set; }
        public string LicensePlateNumber { get; set; }
    }
}
