namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class Repair : Entity {
        public int VehicleID { get; set; }
        public Vehicle Vehicle { get; set; }
        public DateTime RepairDate { get; set; }
        public decimal? RepairCost { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? DamageReportID { get; set; } 
        public DamageReport? DamageReport { get; set; } 
        public int InsuranceCompanyID { get; set; }
        public InsuranceCompany InsuranceCompany { get; set; }
        public List<RepairFile> RepairFiles { get; set; } 
    }
}
