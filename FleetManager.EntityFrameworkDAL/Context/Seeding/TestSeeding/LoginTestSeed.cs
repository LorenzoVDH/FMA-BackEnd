using FleetManager.EntityFrameworkDAL.Models.Entities;
using FleetManager.EntityFrameworkDAL.Models.Enums;
using Microsoft.EntityFrameworkCore;
using BCrypt.Net;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class LoginTestSeed {
    public static void TestSeedLogin(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Login>().HasData(
            new Login() { 
                ID = 1,
                DriverID = 1,
                Email = "markgarner@fleetman.com",
                Role = Role.Admin,
                Password = BCrypt.Net.BCrypt.HashPassword("ThisIsMyPassword1234")
            }
        );
        modelBuilder.Entity<Login>().HasData(
            new Login() {
                ID = 2,
                DriverID = 2,
                Email = "fishergirl337@fleetman.com",
                Role = Role.User,
                Password = BCrypt.Net.BCrypt.HashPassword("ilikepancakes2000")
            }
        );
        modelBuilder.Entity<Login>().HasData(
            new Login() {
                ID = 3,
                DriverID = 3,
                Email = "xx_justlisa_xx@fleetman.com",
                Role = Role.User,
                Password = BCrypt.Net.BCrypt.HashPassword("abcABC123")
            }
        );
    }
}