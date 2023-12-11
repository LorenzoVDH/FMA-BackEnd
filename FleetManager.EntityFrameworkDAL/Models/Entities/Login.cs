using FleetManager.EntityFrameworkDAL.Models.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.EntityFrameworkDAL.Models.Entities;
public class Login : Entity {
    public int DriverID { get; set; }
    public Driver Driver { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public Role Role { get; set; }    
}

