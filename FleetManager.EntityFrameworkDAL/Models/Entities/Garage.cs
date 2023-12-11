using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class Garage : Entity {
        [StringLength(64)]
        public string Name { get; set; }
    }
}
