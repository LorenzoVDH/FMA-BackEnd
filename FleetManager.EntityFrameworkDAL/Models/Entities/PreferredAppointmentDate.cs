namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class PreferredAppointmentDate : Entity {
        public int InquiryID { get; set; }
        public Inquiry Inquiry { get; set; }
        public DateTime PreferredDate { get; set; }
    }
}
