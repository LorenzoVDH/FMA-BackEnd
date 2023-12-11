using FleetManager.EntityFrameworkDAL.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class InquiryType : Entity {
        [StringLength(512)]
        public string Name { get; set; }
        public InquiryCategory Category { get; set; }
        public bool AppointmentNeeded { get; set; } 
    }
}
