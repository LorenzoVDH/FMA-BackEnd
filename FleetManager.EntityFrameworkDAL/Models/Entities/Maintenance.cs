using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class Maintenance : Entity {
        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime Date { get; set; }
        public decimal? Cost { get; set; }
        public int? GarageID { get; set; }
        public Garage? Garage { get; set; }
        public List<MaintenanceTask> MaintenanceTasks { get; set; }
        [StringLength(1024)]
        public string InvoiceFilePath { get; set; } 
    }
}
