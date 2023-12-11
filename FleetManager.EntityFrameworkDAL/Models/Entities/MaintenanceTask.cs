using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class MaintenanceTask : Entity {
        public int MaintenanceID { get; set; }
        public Maintenance Maintenance { get; set; }
        [StringLength(1024)]
        public string Description { get; set; }
    }
}
 