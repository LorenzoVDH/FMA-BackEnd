namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class DriverFuelCard : Entity {
        public int DriverID { get; set; }
        public Driver Driver { get; set; }
        public int FuelCardID { get; set; }
        public FuelCard FuelCard { get; set; }
        public DateTime OwnershipStartDate { get; set; }
        public DateTime? OwnershipEndDate { get; set; }
    }
}
