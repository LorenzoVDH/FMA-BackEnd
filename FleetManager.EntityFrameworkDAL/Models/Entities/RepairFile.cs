using FleetManager.EntityFrameworkDAL.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class RepairFile : Entity {
        public int RepairID { get; set; }
        public Repair Repair { get; set; }
        [StringLength(1024)]
        public string FilePath { get; set; }
        public RepairFileType FileType { get; set; }
    }
}
