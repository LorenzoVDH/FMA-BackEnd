using FleetManager.EntityFrameworkDAL.Models.Enums;
using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class Inquiry : Entity {
        public int InquiryTypeID { get; set; }
        public InquiryType InquiryType { get; set; }
        public List<PreferredAppointmentDate> PreferredAppointmentDates { get; set; }
        public DateTime DateOfInquiry { get; set; }
        public InquiryStatus Status { get; set; }
        public int? VehicleID { get; set; }
        public Vehicle? Vehicle { get; set; }
        public int? DriverID { get; set; }
        public Driver? Driver { get; set; }
        [StringLength(1024)]
        public string Comment { get; set; }
    }
}

