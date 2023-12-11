namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class Mileage : Entity {
        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime Date { get; set; }
        public float MileageInKilometers { get; set; }
    }
}

