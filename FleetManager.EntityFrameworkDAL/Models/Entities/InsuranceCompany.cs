using System.ComponentModel.DataAnnotations;

namespace FleetManager.EntityFrameworkDAL.Models.Entities
{
    public class InsuranceCompany : Entity {
        [StringLength(64)]
        public string ReferenceNumber { get; set; }
        [StringLength(64)]
        public string Name { get; set; }
    }
}
