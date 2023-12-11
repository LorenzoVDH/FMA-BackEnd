using Microsoft.EntityFrameworkCore;
using FleetManager.EntityFrameworkDAL.Models.Entities;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class PreferredAppointmentDateTestSeed {
    public static void TestSeedPreferredAppointmentDate(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<PreferredAppointmentDate>().HasData(
            new PreferredAppointmentDate {
                ID = 1,
                InquiryID = 1,
                PreferredDate = new DateTime(2022, 1, 19)
            }, 
            new PreferredAppointmentDate {
                ID = 2,
                InquiryID = 1,
                PreferredDate = new DateTime(2022, 1, 20)
            },

            new PreferredAppointmentDate {
                ID = 3,
                InquiryID = 2,
                PreferredDate = new DateTime(2023, 9, 19)
            },
            new PreferredAppointmentDate {
                ID = 4,
                InquiryID = 2,
                PreferredDate = new DateTime(2023, 12, 26)
            },

            new PreferredAppointmentDate {
                ID = 5,
                InquiryID = 3,
                PreferredDate = new DateTime(2023, 10, 16)
            },
            new PreferredAppointmentDate {
                ID = 6,
                InquiryID = 3,
                PreferredDate = new DateTime(2023, 10, 23)
            },

            new PreferredAppointmentDate {
                ID = 7,
                InquiryID = 4,
                PreferredDate = new DateTime(2023, 11, 15)
            },
            new PreferredAppointmentDate {
                ID = 8,
                InquiryID = 4,
                PreferredDate = new DateTime(2023, 11, 26)
            }
        );
    }
}
