namespace FleetManager.DapperDAL.Models {
    public class MileageModel : Model {
        public int VehicleID { get; set; }
        public DateTime Date { get; set; }
        public float MileageInKilometers { get; set; }
    }
}
