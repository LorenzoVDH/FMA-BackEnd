using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class VehicleType : Entity {
        [StringLength(128)]
        public string Name { get; set; }
    }
}
