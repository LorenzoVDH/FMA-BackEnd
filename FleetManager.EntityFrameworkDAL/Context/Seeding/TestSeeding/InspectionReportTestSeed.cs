using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class InspectionReportTestSeed {
    public static void TestSeedInspectionReport(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<InspectionReport>().HasData(
            new InspectionReport()
            {
                ID = 1,
                Date = new DateTime(2019, 5, 30),
                DriverID = 7,
                InspectionReportFilePath = "files/inspectionreports/insp43123.pdf",
                VehicleID = 7
            },
            new InspectionReport()
            {
                ID = 2,
                Date = new DateTime(2019, 6, 5),
                DriverID = 8,
                InspectionReportFilePath = "files/inspectionreports/insp43124.docx",
                VehicleID = 8
            },
            new InspectionReport()
            {
                ID = 3,
                Date = new DateTime(2019, 6, 10),
                DriverID = 9,
                InspectionReportFilePath = "files/inspectionreports/insp43125.pdf",
                VehicleID = 9
            },
            new InspectionReport()
            {
                ID = 4,
                Date = new DateTime(2019, 6, 15),
                DriverID = 10,
                InspectionReportFilePath = "files/inspectionreports/insp43126.pdf",
                VehicleID = 10
            },
            new InspectionReport()
            {
                ID = 5,
                Date = new DateTime(2019, 6, 20),
                DriverID = 11,
                InspectionReportFilePath = "files/inspectionreports/insp43127.pdf",
                VehicleID = 11
            },
            new InspectionReport()
            {
                ID = 6,
                Date = new DateTime(2019, 6, 25),
                DriverID = 12,
                InspectionReportFilePath = "files/inspectionreports/insp43128.pdf",
                VehicleID = 12
            },
            new InspectionReport()
            {
                ID = 7,
                Date = new DateTime(2019, 6, 30),
                DriverID = 13,
                InspectionReportFilePath = "files/inspectionreports/insp43129.pdf",
                VehicleID = 13
            },
            new InspectionReport()
            {
                ID = 8,
                Date = new DateTime(2019, 7, 5),
                DriverID = 14,
                InspectionReportFilePath = "files/inspectionreports/insp43130.doc",
                VehicleID = 14
            },
            new InspectionReport()
            {
                ID = 9,
                Date = new DateTime(2019, 7, 10),
                DriverID = 15,
                InspectionReportFilePath = "files/inspectionreports/insp43131.pdf",
                VehicleID = 15
            },
            new InspectionReport()
            {
                ID = 10,
                Date = new DateTime(2019, 7, 15),
                DriverID = 16,
                InspectionReportFilePath = "files/inspectionreports/insp43132.doc",
                VehicleID = 16
            },
            new InspectionReport()
            {
                ID = 11,
                Date = new DateTime(2019, 7, 20),
                DriverID = 17,
                InspectionReportFilePath = "files/inspectionreports/insp43133.pdf",
                VehicleID = 17
            },
            new InspectionReport()
            {
                ID = 12,
                Date = new DateTime(2019, 7, 25),
                DriverID = 18,
                InspectionReportFilePath = "files/inspectionreports/insp43134.pdf",
                VehicleID = 18
            },
            new InspectionReport()
            {
                ID = 13,
                Date = new DateTime(2019, 7, 30),
                DriverID = 19,
                InspectionReportFilePath = "files/inspectionreports/insp43135.pdf",
                VehicleID = 19
            },
            new InspectionReport()
            {
                ID = 14,
                Date = new DateTime(2019, 8, 5),
                DriverID = 20,
                InspectionReportFilePath = "files/inspectionreports/insp43136.oft",
                VehicleID = 20
            },
            new InspectionReport()
            {
                ID = 15,
                Date = new DateTime(2019, 8, 10),
                DriverID = 21,
                InspectionReportFilePath = "files/inspectionreports/insp43137.doc",
                VehicleID = 1
            },
            new InspectionReport()
            {
                ID = 16,
                Date = new DateTime(2019, 8, 15),
                DriverID = 22,
                InspectionReportFilePath = "files/inspectionreports/insp43138.docx",
                VehicleID = 2
            },
            new InspectionReport()
            {
                ID = 17,
                Date = new DateTime(2019, 8, 20),
                DriverID = 23,
                InspectionReportFilePath = "files/inspectionreports/insp43139.txt",
                VehicleID = 3
            },
            new InspectionReport()
            {
                ID = 18,
                Date = new DateTime(2019, 8, 25),
                DriverID = 24,
                InspectionReportFilePath = "files/inspectionreports/insp43140.pdf",
                VehicleID = 4
            },
            new InspectionReport()
            {
                ID = 19,
                Date = new DateTime(2019, 8, 30),
                DriverID = 25,
                InspectionReportFilePath = "files/inspectionreports/insp43141.pdf",
                VehicleID = 5
            },
            new InspectionReport()
            {
                ID = 20,
                Date = new DateTime(2019, 9, 5),
                DriverID = 26,
                InspectionReportFilePath = "files/inspectionreports/insp43142.rft",
                VehicleID = 6
            },
            new InspectionReport()
            {
                ID = 21,
                Date = new DateTime(2019, 9, 10),
                DriverID = 27,
                InspectionReportFilePath = "files/inspectionreports/insp43143.txt",
                VehicleID = 7
            },
            new InspectionReport()
            {
                ID = 22,
                Date = new DateTime(2019, 9, 15),
                DriverID = 28,
                InspectionReportFilePath = "files/inspectionreports/insp43144.doc",
                VehicleID = 8
            },
            new InspectionReport()
            {
                ID = 23,
                Date = new DateTime(2019, 9, 20),
                DriverID = 29,
                InspectionReportFilePath = "files/inspectionreports/insp43145.doc",
                VehicleID = 9
            },
            new InspectionReport()
            {
                ID = 24,
                Date = new DateTime(2019, 9, 25),
                DriverID = 30,
                InspectionReportFilePath = "files/inspectionreports/insp43146.txt",
                VehicleID = 10
            },
            new InspectionReport()
            {
                ID = 25,
                Date = new DateTime(2019, 9, 30),
                DriverID = 21,
                InspectionReportFilePath = "files/inspectionreports/insp43147.pdf",
                VehicleID = 11
            },
            new InspectionReport()
            {
                ID = 26,
                Date = new DateTime(2019, 10, 5),
                DriverID = 22,
                InspectionReportFilePath = "files/inspectionreports/insp43148.pdf",
                VehicleID = 12
            },
            new InspectionReport()
            {
                ID = 27,
                Date = new DateTime(2019, 10, 10),
                DriverID = 23,
                InspectionReportFilePath = "files/inspectionreports/insp43149.pdf",
                VehicleID = 13
            },
            new InspectionReport()
            {
                ID = 28,
                Date = new DateTime(2019, 10, 15),
                DriverID = 24,
                InspectionReportFilePath = "files/inspectionreports/insp43150.pdf",
                VehicleID = 14
            },
            new InspectionReport()
            {
                ID = 29,
                Date = new DateTime(2019, 10, 20),
                DriverID = 25,
                InspectionReportFilePath = "files/inspectionreports/insp43151.pdf",
                VehicleID = 15
            },
            new InspectionReport()
            {
                ID = 30,
                Date = new DateTime(2019, 10, 25),
                DriverID = 26,
                InspectionReportFilePath = "files/inspectionreports/insp43152.pdf",
                VehicleID = 16
            },
            new InspectionReport()
            {
                ID = 31,
                Date = new DateTime(2019, 10, 30),
                DriverID = 27,
                InspectionReportFilePath = "files/inspectionreports/insp43153.doc",
                VehicleID = 17
            },
            new InspectionReport()
            {
                ID = 32,
                Date = new DateTime(2019, 11, 5),
                DriverID = 28,
                InspectionReportFilePath = "files/inspectionreports/insp43154.docx",
                VehicleID = 18
            },
            new InspectionReport()
            {
                ID = 33,
                Date = new DateTime(2019, 11, 10),
                DriverID = 29,
                InspectionReportFilePath = "files/inspectionreports/insp43155.pdf",
                VehicleID = 19
            },
            new InspectionReport()
            {
                ID = 34,
                Date = new DateTime(2019, 11, 15),
                DriverID = 20,
                InspectionReportFilePath = "files/inspectionreports/insp43156.pdf",
                VehicleID = 20
            },
            new InspectionReport()
            {
                ID = 35,
                Date = new DateTime(2019, 11, 20),
                DriverID = 1,
                InspectionReportFilePath = "files/inspectionreports/insp43157.pdf",
                VehicleID = 1
            },
            new InspectionReport()
            {
                ID = 36,
                Date = new DateTime(2019, 11, 25),
                DriverID = 2,
                InspectionReportFilePath = "files/inspectionreports/insp43158.pdf",
                VehicleID = 2
            },
            new InspectionReport()
            {
                ID = 37,
                Date = new DateTime(2019, 11, 30),
                DriverID = 3,
                InspectionReportFilePath = "files/inspectionreports/insp43159.doc",
                VehicleID = 3
            },
            new InspectionReport()
            {
                ID = 38,
                Date = new DateTime(2019, 12, 5),
                DriverID = 4,
                InspectionReportFilePath = "files/inspectionreports/insp43160.pdf",
                VehicleID = 4
            },
            new InspectionReport()
            {
                ID = 39,
                Date = new DateTime(2019, 12, 10),
                DriverID = 5,
                InspectionReportFilePath = "files/inspectionreports/insp43161.pdf",
                VehicleID = 5
            },
            new InspectionReport()
            {
                ID = 40,
                Date = new DateTime(2019, 12, 15),
                DriverID = 6,
                InspectionReportFilePath = "files/inspectionreports/insp43162.pdf",
                VehicleID = 6
            },
            new InspectionReport()
            {
                ID = 41,
                Date = new DateTime(2019, 12, 20),
                DriverID = 7,
                InspectionReportFilePath = "files/inspectionreports/insp43163.pdf",
                VehicleID = 7
            },
            new InspectionReport()
            {
                ID = 42,
                Date = new DateTime(2019, 12, 25),
                DriverID = 8,
                InspectionReportFilePath = "files/inspectionreports/insp43164.doc",
                VehicleID = 8
            },
            new InspectionReport()
            {
                ID = 43,
                Date = new DateTime(2019, 12, 30),
                DriverID = 9,
                InspectionReportFilePath = "files/inspectionreports/insp43165.pdf",
                VehicleID = 9
            },
            new InspectionReport()
            {
                ID = 44,
                Date = new DateTime(2020, 1, 5),
                DriverID = 10,
                InspectionReportFilePath = "files/inspectionreports/insp43166.doc",
                VehicleID = 10
            },
            new InspectionReport()
            {
                ID = 45,
                Date = new DateTime(2020, 1, 10),
                DriverID = 11,
                InspectionReportFilePath = "files/inspectionreports/insp43167.pdf",
                VehicleID = 11
            },
            new InspectionReport()
            {
                ID = 46,
                Date = new DateTime(2020, 1, 15),
                DriverID = 12,
                InspectionReportFilePath = "files/inspectionreports/insp43168.doc",
                VehicleID = 12
            },
            new InspectionReport()
            {
                ID = 47,
                Date = new DateTime(2020, 1, 20),
                DriverID = 13,
                InspectionReportFilePath = "files/inspectionreports/insp43169.docx",
                VehicleID = 13
            },
            new InspectionReport()
            {
                ID = 48,
                Date = new DateTime(2020, 1, 25),
                DriverID = 14,
                InspectionReportFilePath = "files/inspectionreports/insp43170.doc",
                VehicleID = 14
            },
            new InspectionReport()
            {
                ID = 49,
                Date = new DateTime(2020, 1, 30),
                DriverID = 15,
                InspectionReportFilePath = "files/inspectionreports/insp43171.doc",
                VehicleID = 15
            },
            new InspectionReport()
            {
                ID = 50,
                Date = new DateTime(2020, 2, 5),
                DriverID = 16,
                InspectionReportFilePath = "files/inspectionreports/insp43172.txt",
                VehicleID = 16
            },
            new InspectionReport()
            {
                ID = 51,
                Date = new DateTime(2020, 2, 10),
                DriverID = 17,
                InspectionReportFilePath = "files/inspectionreports/insp43173.pdf",
                VehicleID = 17
            },
            new InspectionReport()
            {
                ID = 52,
                Date = new DateTime(2020, 2, 15),
                DriverID = 18,
                InspectionReportFilePath = "files/inspectionreports/insp43174.docx",
                VehicleID = 18
            },
            new InspectionReport()
            {
                ID = 53,
                Date = new DateTime(2020, 2, 20),
                DriverID = 19,
                InspectionReportFilePath = "files/inspectionreports/insp43175.pdf",
                VehicleID = 19
            },
            new InspectionReport()
            {
                ID = 54,
                Date = new DateTime(2020, 2, 25),
                DriverID = 20,
                InspectionReportFilePath = "files/inspectionreports/insp43176.pdf",
                VehicleID = 20
            },
            new InspectionReport()
            {
                ID = 55,
                Date = new DateTime(2020, 3, 1),
                DriverID = 21,
                InspectionReportFilePath = "files/inspectionreports/insp43177.doc",
                VehicleID = 11
            },
            new InspectionReport()
            {
                ID = 56,
                Date = new DateTime(2020, 3, 5),
                DriverID = 22,
                InspectionReportFilePath = "files/inspectionreports/insp43178.pdf",
                VehicleID = 12
            },
            new InspectionReport()
            {
                ID = 57,
                Date = new DateTime(2020, 3, 10),
                DriverID = 23,
                InspectionReportFilePath = "files/inspectionreports/insp43179.pdf",
                VehicleID = 13
            },
            new InspectionReport()
            {
                ID = 58,
                Date = new DateTime(2020, 3, 15),
                DriverID = 24,
                InspectionReportFilePath = "files/inspectionreports/insp43180.docx",
                VehicleID = 14
            },
            new InspectionReport()
            {
                ID = 59,
                Date = new DateTime(2020, 3, 20),
                DriverID = 25,
                InspectionReportFilePath = "files/inspectionreports/insp43181.txt",
                VehicleID = 15
            },
            new InspectionReport()
            {
                ID = 60,
                Date = new DateTime(2020, 3, 25),
                DriverID = 26,
                InspectionReportFilePath = "files/inspectionreports/insp43182.doc",
                VehicleID = 16
            },
            new InspectionReport()
            {
                ID = 61,
                Date = new DateTime(2020, 3, 30),
                DriverID = 27,
                InspectionReportFilePath = "files/inspectionreports/insp43183.pdf",
                VehicleID = 17
            },
            new InspectionReport()
            {
                ID = 62,
                Date = new DateTime(2020, 4, 4),
                DriverID = 28,
                InspectionReportFilePath = "files/inspectionreports/insp43184.txt",
                VehicleID = 18
            },
            new InspectionReport()
            {
                ID = 63,
                Date = new DateTime(2020, 4, 9),
                DriverID = 29,
                InspectionReportFilePath = "files/inspectionreports/insp43185.doc",
                VehicleID = 19
            },
            new InspectionReport()
            {
                ID = 64,
                Date = new DateTime(2020, 4, 14),
                DriverID = 30,
                InspectionReportFilePath = "files/inspectionreports/insp43186.pdf",
                VehicleID = 10
            },

            new InspectionReport()
            {
                ID = 91,
                Date = new DateTime(2023, 6, 4),
                DriverID = 28,
                InspectionReportFilePath = "files/inspectionreports/insp43211.txt",
                VehicleID = 18
            },
            new InspectionReport()
            {
                ID = 92,
                Date = new DateTime(2023, 6, 9),
                DriverID = 29,
                InspectionReportFilePath = "files/inspectionreports/insp43212.doc",
                VehicleID = 19
            },
            new InspectionReport()
            {
                ID = 93,
                Date = new DateTime(2023, 6, 14),
                DriverID = 30,
                InspectionReportFilePath = "files/inspectionreports/insp43213.pdf",
                VehicleID = 10
            },
            new InspectionReport()
            {
                ID = 94,
                Date = new DateTime(2023, 6, 20),
                DriverID = 30,
                InspectionReportFilePath = "files/inspectionreports/insp43215.doc",
                VehicleID = 10
            },
            new InspectionReport()
            {
                ID = 95,
                Date = new DateTime(2023, 6, 25),
                DriverID = 29,
                InspectionReportFilePath = "files/inspectionreports/insp43216.pdf",
                VehicleID = 11
            },
            new InspectionReport()
            {
                ID = 96,
                Date = new DateTime(2023, 7, 1),
                DriverID = 1,
                InspectionReportFilePath = "files/inspectionreports/insp43218.pdf",
                VehicleID = 17
            },
            new InspectionReport()
            {
                ID = 97,
                Date = new DateTime(2023, 7, 5),
                DriverID = 2,
                InspectionReportFilePath = "files/inspectionreports/insp43219.docx",
                VehicleID = 18
            },
            new InspectionReport()
            {
                ID = 98,
                Date = new DateTime(2023, 7, 12),
                DriverID = 2,
                InspectionReportFilePath = "files/inspectionreports/insp43221.doc",
                VehicleID = 18
            },
            new InspectionReport()
            {
                ID = 99,
                Date = new DateTime(2023, 7, 15),
                DriverID = 3,
                InspectionReportFilePath = "files/inspectionreports/insp43222.doc",
                VehicleID = 19
            },
            new InspectionReport()
            {
                ID = 100,
                Date = new DateTime(2023, 7, 17),
                DriverID = 3,
                InspectionReportFilePath = "files/inspectionreports/insp43223.pdf",
                VehicleID = 19
            },
            new InspectionReport()
            {
                ID = 65,
                Date = new DateTime(2020, 4, 19),
                DriverID = 21,
                InspectionReportFilePath = "files/inspectionreports/insp43187.txt",
                VehicleID = 11
            },
            new InspectionReport()
            {
                ID = 66,
                Date = new DateTime(2020, 4, 24),
                DriverID = 22,
                InspectionReportFilePath = "files/inspectionreports/insp43188.doc",
                VehicleID = 12
            },
            new InspectionReport()
            {
                ID = 67,
                Date = new DateTime(2020, 4, 29),
                DriverID = 23,
                InspectionReportFilePath = "files/inspectionreports/insp43189.pdf",
                VehicleID = 13
            },
            new InspectionReport()
            {
                ID = 68,
                Date = new DateTime(2020, 5, 4),
                DriverID = 24,
                InspectionReportFilePath = "files/inspectionreports/insp43190.txt",
                VehicleID = 14
            },
            new InspectionReport()
            {
                ID = 69,
                Date = new DateTime(2020, 5, 9),
                DriverID = 25,
                InspectionReportFilePath = "files/inspectionreports/insp43191.doc",
                VehicleID = 15
            },
            new InspectionReport()
            {
                ID = 70,
                Date = new DateTime(2020, 5, 14),
                DriverID = 26,
                InspectionReportFilePath = "files/inspectionreports/insp43192.pdf",
                VehicleID = 16
            },
            new InspectionReport()
            {
                ID = 71,
                Date = new DateTime(2020, 5, 19),
                DriverID = 27,
                InspectionReportFilePath = "files/inspectionreports/insp43193.txt",
                VehicleID = 17
            },
            new InspectionReport()
            {
                ID = 72,
                Date = new DateTime(2020, 5, 24),
                DriverID = 28,
                InspectionReportFilePath = "files/inspectionreports/insp43194.doc",
                VehicleID = 18
            },
            new InspectionReport()
            {
                ID = 73,
                Date = new DateTime(2020, 5, 29),
                DriverID = 29,
                InspectionReportFilePath = "files/inspectionreports/insp43195.pdf",
                VehicleID = 19
            },
            new InspectionReport()
            {
                ID = 74,
                Date = new DateTime(2020, 6, 4),
                DriverID = 20,
                InspectionReportFilePath = "files/inspectionreports/insp43196.txt",
                VehicleID = 10
            },
            new InspectionReport()
            {
                ID = 75,
                Date = new DateTime(2020, 6, 9),
                DriverID = 21,
                InspectionReportFilePath = "files/inspectionreports/insp43197.doc",
                VehicleID = 11
            },
            new InspectionReport()
            {
                ID = 76,
                Date = new DateTime(2020, 6, 14),
                DriverID = 22,
                InspectionReportFilePath = "files/inspectionreports/insp43198.pdf",
                VehicleID = 12
            },
            new InspectionReport()
            {
                ID = 77,
                Date = new DateTime(2020, 6, 19),
                DriverID = 23,
                InspectionReportFilePath = "files/inspectionreports/insp43199.txt",
                VehicleID = 13
            },
            new InspectionReport()
            {
                ID = 78,
                Date = new DateTime(2020, 6, 24),
                DriverID = 24,
                InspectionReportFilePath = "files/inspectionreports/insp43200.doc",
                VehicleID = 14
            },
            new InspectionReport()
            {
                ID = 79,
                Date = new DateTime(2020, 6, 29),
                DriverID = 25,
                InspectionReportFilePath = "files/inspectionreports/insp43201.pdf",
                VehicleID = 15
            },
            new InspectionReport()
            {
                ID = 80,
                Date = new DateTime(2020, 7, 4),
                DriverID = 26,
                InspectionReportFilePath = "files/inspectionreports/insp43202.txt",
                VehicleID = 16
            },
            new InspectionReport()
            {
                ID = 81,
                Date = new DateTime(2020, 7, 9),
                DriverID = 27,
                InspectionReportFilePath = "files/inspectionreports/insp43203.doc",
                VehicleID = 17
            },
            new InspectionReport()
            {
                ID = 82,
                Date = new DateTime(2020, 7, 14),
                DriverID = 28,
                InspectionReportFilePath = "files/inspectionreports/insp43204.pdf",
                VehicleID = 18
            },
            new InspectionReport()
            {
                ID = 83,
                Date = new DateTime(2020, 7, 19),
                DriverID = 29,
                InspectionReportFilePath = "files/inspectionreports/insp43205.txt",
                VehicleID = 19
            },
            new InspectionReport()
            {
                ID = 84,
                Date = new DateTime(2020, 7, 24),
                DriverID = 20,
                InspectionReportFilePath = "files/inspectionreports/insp43206.doc",
                VehicleID = 10
            },
            new InspectionReport()
            {
                ID = 85,
                Date = new DateTime(2020, 7, 29),
                DriverID = 21,
                InspectionReportFilePath = "files/inspectionreports/insp43207.pdf",
                VehicleID = 11
            },
            new InspectionReport()
            {
                ID = 86,
                Date = new DateTime(2020, 8, 4),
                DriverID = 22,
                InspectionReportFilePath = "files/inspectionreports/insp43208.txt",
                VehicleID = 12
            },
            new InspectionReport()
            {
                ID = 87,
                Date = new DateTime(2020, 8, 9),
                DriverID = 13,
                InspectionReportFilePath = "files/inspectionreports/insp43209.doc",
                VehicleID = 13
            },
            new InspectionReport()
            {
                ID = 88,
                Date = new DateTime(2020, 8, 14),
                DriverID = 4,
                InspectionReportFilePath = "files/inspectionreports/insp43210.pdf",
                VehicleID = 14
            },
            new InspectionReport()
            {
                ID = 89,
                Date = new DateTime(2020, 8, 19),
                DriverID = 15,
                InspectionReportFilePath = "files/inspectionreports/insp43211.txt",
                VehicleID = 15
            },
            new InspectionReport()
            {
                ID = 90,
                Date = new DateTime(2020, 8, 24),
                DriverID = 15,
                InspectionReportFilePath = "files/inspectionreports/insp43212.doc",
                VehicleID = 6
            }
        );
    }
}