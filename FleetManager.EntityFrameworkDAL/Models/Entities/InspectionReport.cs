using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class InspectionReport : Entity {
        public int DriverID { get; set; }
        public Driver Driver { get; set; }
        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime Date { get; set; }
        [StringLength(1024)]
        public string InspectionReportFilePath { get; set; }
        public List<DamageReport> DamageReports { get; set; } 
    }
}
