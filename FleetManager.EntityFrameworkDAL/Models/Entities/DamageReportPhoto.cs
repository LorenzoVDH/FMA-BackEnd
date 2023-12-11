using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class DamageReportPhoto : Entity {
        public int DamageReportID { get; set; }
        public DamageReport DamageReport { get; set; }
        [StringLength(1024)]
        public string FilePath { get; set; }
    }
}
