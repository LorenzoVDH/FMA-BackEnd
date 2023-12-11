using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class DamageReport : Entity {
        public int InspectionReportID { get; set; } 
        public InspectionReport InspectionReport { get; set; }
        public Repair? Repair { get; set; } 
        public DateTime ReportDate { get; set; }
        public DateTime? DamageDate { get; set; }
        [StringLength(2048)]
        public string Description { get; set; }
        public decimal Cost { get; set; }
        public int? DamageRepairTypeID { get; set; }
        public DamageRepairType? DamageRepairType { get; set; }
        public int VehiclePartID { get; set; }
        public VehiclePart VehiclePart { get; set; }
        public List<DamageReportPhoto> DamageReportPhotos { get; set; } 
    }
}
