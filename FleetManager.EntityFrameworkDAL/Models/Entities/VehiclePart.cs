using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class VehiclePart : Entity {
        [StringLength(256)]
        public string Name { get; set; }
    }
}
