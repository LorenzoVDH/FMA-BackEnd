using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class ExtraService : Entity {
        [StringLength(32)]
        public string Description { get; set; }
        public List<FuelCardExtraService> FuelCardExtraServices { get; set; }
    }
}
