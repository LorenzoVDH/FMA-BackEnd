using Microsoft.EntityFrameworkCore;
using FleetManager.EntityFrameworkDAL.Models.Entities;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class InquiryTestSeed {
    public static void TestSeedInquiry(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Inquiry>().HasData(
            new Inquiry {
                ID = 1,
                InquiryTypeID = 15,
                DateOfInquiry = new DateTime(2022, 1, 15),
                Status = Models.Enums.InquiryStatus.InProgress,
                Comment = "I really want to close my account. Reason: I am leaving the company!",
                DriverID = 1
            },
            new Inquiry {
                ID = 2,
                InquiryTypeID = 65,
                DateOfInquiry = new DateTime(2023, 9, 15),
                Status = Models.Enums.InquiryStatus.InProgress,
                Comment = "I want to update my FuelCard please",
                DriverID = 4
            },
            new Inquiry {
                ID = 3,
                InquiryTypeID = 109,
                DateOfInquiry = new DateTime(2023, 10, 9),
                Status = Models.Enums.InquiryStatus.InProgress,
                Comment = "I want to rent a vehicle, the Mercedez Benz pleaz",
                DriverID = 4 
            },
            new Inquiry {
                ID = 4,
                InquiryTypeID = 120,
                DateOfInquiry = new DateTime(2023, 11, 9),
                Status = Models.Enums.InquiryStatus.InProgress,
                Comment = "The mileage of my vehicle is WAY off!",
                DriverID = 7,
                VehicleID = 10
            }
        );
    }
}
