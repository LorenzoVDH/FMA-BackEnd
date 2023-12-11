using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class DamageReportTestSeed
{
    public static void TestSeedDamageReport(this ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DamageReport>().HasData(
            new DamageReport()
            {
                ID = 1,
                Cost = 800m,
                DamageDate = new DateTime(2020, 8, 24),
                ReportDate = new DateTime(2020, 8, 25),
                DamageRepairTypeID = 7,
                Description = "Voorspatbord beschadigd bij een botsing.",
                InspectionReportID = 19,
                VehiclePartID = 48
            },
            new DamageReport()
            {
                ID = 2,
                Cost = 500m,
                DamageDate = new DateTime(2020, 9, 10),
                ReportDate = new DateTime(2020, 9, 11),
                DamageRepairTypeID = 15,
                Description = "Achterruit beschadigd door vandalisme.",
                InspectionReportID = 46,
                VehiclePartID = 46
            },
            new DamageReport()
            {
                ID = 3,
                Cost = 1200m,
                DamageDate = new DateTime(2020, 10, 5),
                ReportDate = new DateTime(2020, 10, 6),
                DamageRepairTypeID = 28,
                Description = "Brandstofinjector lekt en moet worden vervangen.",
                InspectionReportID = 74,
                VehiclePartID = 28
            },
            new DamageReport()
            {
                ID = 4,
                Cost = 950m,
                DamageDate = new DateTime(2020, 11, 20),
                ReportDate = new DateTime(2020, 11, 21),
                DamageRepairTypeID = 33,
                Description = "Roestvorming aan de brandstoftank, moet worden vervangen.",
                InspectionReportID = 58,
                VehiclePartID = 33
            },
            new DamageReport()
            {
                ID = 5,
                Cost = 600m,
                DamageDate = new DateTime(2020, 12, 12),
                ReportDate = new DateTime(2020, 12, 13),
                DamageRepairTypeID = 41,
                Description = "Remklauw aan de voorzijde versleten, moet worden vervangen.",
                InspectionReportID = 82,
                VehiclePartID = 42
            },
            new DamageReport()
            {
                ID = 6,
                Cost = 1800m,
                DamageDate = new DateTime(2021, 1, 5),
                ReportDate = new DateTime(2021, 1, 6),
                DamageRepairTypeID = 50,
                Description = "Koelventilator montage defect, moet worden gerepareerd.",
                InspectionReportID = 96,
                VehiclePartID = 50
            },
            new DamageReport()
            {
                ID = 7,
                Cost = 350m,
                DamageDate = new DateTime(2021, 2, 18),
                ReportDate = new DateTime(2021, 2, 19),
                DamageRepairTypeID = 2,
                Description = "Bougies moeten worden vervangen voor betere ontsteking.",
                InspectionReportID = 13,
                VehiclePartID = 2
            },
            new DamageReport()
            {
                ID = 8,
                Cost = 1300m,
                DamageDate = new DateTime(2021, 3, 25),
                ReportDate = new DateTime(2021, 3, 26),
                DamageRepairTypeID = 12,
                Description = "Wielophangingrubbers versleten, moeten worden vervangen.",
                InspectionReportID = 26,
                VehiclePartID = 12
            },
            new DamageReport()
            {
                ID = 9,
                Cost = 700m,
                DamageDate = new DateTime(2021, 4, 8),
                ReportDate = new DateTime(2021, 4, 9),
                DamageRepairTypeID = 20,
                Description = "CV-koppeling defect, moet worden vervangen.",
                InspectionReportID = 35,
                VehiclePartID = 20
            },
            new DamageReport()
            {
                ID = 10,
                Cost = 550m,
                DamageDate = new DateTime(2021, 5, 14),
                ReportDate = new DateTime(2021, 5, 15),
                DamageRepairTypeID = 5,
                Description = "Luchtfilter verstopt, moet worden gereinigd of vervangen.",
                InspectionReportID = 8,
                VehiclePartID = 5
            },
            new DamageReport()
            {
                ID = 11,
                Cost = 420m,
                DamageDate = new DateTime(2021, 6, 20),
                ReportDate = new DateTime(2021, 6, 21),
                DamageRepairTypeID = 21,
                Description = "Krukas beschadigd, moet worden vervangen.",
                InspectionReportID = 22,
                VehiclePartID = 21
            },
            new DamageReport()
            {
                ID = 12,
                Cost = 950m,
                DamageDate = new DateTime(2021, 7, 12),
                ReportDate = new DateTime(2021, 7, 13),
                DamageRepairTypeID = 42,
                Description = "Remklauw aan de achterzijde versleten, moet worden vervangen.",
                InspectionReportID = 73,
                VehiclePartID = 42
            },
            new DamageReport()
            {
                ID = 13,
                Cost = 1600m,
                DamageDate = new DateTime(2021, 8, 5),
                ReportDate = new DateTime(2021, 8, 6),
                DamageRepairTypeID = 41,
                Description = "Inlaatspruitstuk lekt, moet worden gerepareerd.",
                InspectionReportID = 87,
                VehiclePartID = 52
            },
            new DamageReport()
            {
                ID = 14,
                Cost = 380m,
                DamageDate = new DateTime(2021, 9, 18),
                ReportDate = new DateTime(2021, 9, 19),
                DamageRepairTypeID = 3,
                Description = "Accu ontladen, moet worden vervangen.",
                InspectionReportID = 15,
                VehiclePartID = 3
            },
            new DamageReport()
            {
                ID = 15,
                Cost = 1200m,
                DamageDate = new DateTime(2021, 10, 25),
                ReportDate = new DateTime(2021, 10, 26),
                DamageRepairTypeID = 13,
                Description = "Remrotor aan de voorzijde versleten, moet worden vervangen.",
                InspectionReportID = 29,
                VehiclePartID = 13
            },
            new DamageReport()
            {
                ID = 16,
                Cost = 850m,
                DamageDate = new DateTime(2021, 11, 8),
                ReportDate = new DateTime(2021, 11, 9),
                DamageRepairTypeID = 40,
                Description = "Spanrol van de multiriem defect, moet worden vervangen.",
                InspectionReportID = 64,
                VehiclePartID = 40
            },
            new DamageReport()
            {
                ID = 17,
                Cost = 670m,
                DamageDate = new DateTime(2021, 12, 14),
                ReportDate = new DateTime(2021, 12, 15),
                DamageRepairTypeID = 6,
                Description = "Luchtfilterbehuizing beschadigd, moet worden vervangen.",
                InspectionReportID = 17,
                VehiclePartID = 5
            },
            new DamageReport()
            {
                ID = 18,
                Cost = 1080m,
                DamageDate = new DateTime(2022, 1, 20),
                ReportDate = new DateTime(2022, 1, 21),
                DamageRepairTypeID = 31,
                Description = "Schade aan de achteruitkijkspiegel, moet worden vervangen.",
                InspectionReportID = 51,
                VehiclePartID = 31
            },
            new DamageReport()
            {
                ID = 19,
                Cost = 570m,
                DamageDate = new DateTime(2022, 2, 12),
                ReportDate = new DateTime(2022, 2, 13),
                DamageRepairTypeID = 8,
                Description = "Ontstekingskabels beschadigd, moeten worden vervangen.",
                InspectionReportID = 76,
                VehiclePartID = 8
            },
            new DamageReport()
            {
                ID = 20,
                Cost = 950m,
                DamageDate = new DateTime(2022, 3, 25),
                ReportDate = new DateTime(2022, 3, 26),
                DamageRepairTypeID = 18,
                Description = "Schokdemper aan de voorzijde lekt, moet worden vervangen.",
                InspectionReportID = 27,
                VehiclePartID = 18
            },
            new DamageReport()
            {
                ID = 21,
                Cost = 780m,
                DamageDate = new DateTime(2022, 4, 10),
                ReportDate = new DateTime(2022, 4, 11),
                DamageRepairTypeID = 24,
                Description = "Uitlaatspruitstuk lekt, moet worden gerepareerd.",
                InspectionReportID = 48,
                VehiclePartID = 24
            },
            new DamageReport()
            {
                ID = 22,
                Cost = 560m,
                DamageDate = new DateTime(2022, 5, 15),
                ReportDate = new DateTime(2022, 5, 16),
                DamageRepairTypeID = 1,
                Description = "Remblokken versleten, moeten worden vervangen.",
                InspectionReportID = 10,
                VehiclePartID = 1
            },
            new DamageReport()
            {
                ID = 23,
                Cost = 990m,
                DamageDate = new DateTime(2022, 6, 20),
                ReportDate = new DateTime(2022, 6, 21),
                DamageRepairTypeID = 37,
                Description = "Versnellingsbaksteun beschadigd, moet worden vervangen.",
                InspectionReportID = 37,
                VehiclePartID = 37
            },
            new DamageReport()
            {
                ID = 24,
                Cost = 1350m,
                DamageDate = new DateTime(2022, 7, 25),
                ReportDate = new DateTime(2022, 7, 26),
                DamageRepairTypeID = 50,
                Description = "Wiellager aan de voorzijde defect, moet worden vervangen.",
                InspectionReportID = 62,
                VehiclePartID = 19
            },
            new DamageReport()
            {
                ID = 25,
                Cost = 410m,
                DamageDate = new DateTime(2022, 8, 30),
                ReportDate = new DateTime(2022, 8, 31),
                DamageRepairTypeID = 10,
                Description = "Bobine defect, moet worden vervangen.",
                InspectionReportID = 20,
                VehiclePartID = 10
            },
            new DamageReport()
            {
                ID = 26,
                Cost = 720m,
                DamageDate = new DateTime(2022, 9, 5),
                ReportDate = new DateTime(2022, 9, 6),
                DamageRepairTypeID = 30,
                Description = "Ventilatormotor defect, moet worden vervangen.",
                InspectionReportID = 55,
                VehiclePartID = 30
            },
            new DamageReport()
            {
                ID = 27,
                Cost = 980m,
                DamageDate = new DateTime(2022, 10, 10),
                ReportDate = new DateTime(2022, 10, 11),
                DamageRepairTypeID = 14,
                Description = "Waterpomp lekt, moet worden gerepareerd.",
                InspectionReportID = 34,
                VehiclePartID = 14
            },
            new DamageReport()
            {
                ID = 28,
                Cost = 580m,
                DamageDate = new DateTime(2022, 11, 15),
                ReportDate = new DateTime(2022, 11, 16),
                DamageRepairTypeID = 38,
                Description = "Motorsteun beschadigd, moet worden vervangen.",
                InspectionReportID = 38,
                VehiclePartID = 38
            },
            new DamageReport()
            {
                ID = 29,
                Cost = 820m,
                DamageDate = new DateTime(2022, 12, 20),
                ReportDate = new DateTime(2022, 12, 21),
                DamageRepairTypeID = 49,
                Description = "Brandstofinjector verstopt, moet worden gereinigd.",
                InspectionReportID = 28,
                VehiclePartID = 28
            },
            new DamageReport()
            {
                ID = 30,
                Cost = 690m,
                DamageDate = new DateTime(2023, 1, 25),
                ReportDate = new DateTime(2023, 1, 26),
                DamageRepairTypeID = 49,
                Description = "Airconditioningcompressor defect, moet worden vervangen.",
                InspectionReportID = 29,
                VehiclePartID = 29
            },
            new DamageReport()
            {
                ID = 31,
                Cost = 670m,
                DamageDate = new DateTime(2023, 2, 28),
                ReportDate = new DateTime(2023, 3, 1),
                DamageRepairTypeID = 22,
                Description = "Remklauw vast, moet worden gerepareerd.",
                InspectionReportID = 42,
                VehiclePartID = 42
            },
            new DamageReport()
            {
                ID = 32,
                Cost = 480m,
                DamageDate = new DateTime(2023, 3, 7),
                ReportDate = new DateTime(2023, 3, 8),
                DamageRepairTypeID = 45,
                Description = "Koplamp beschadigd, moet worden vervangen.",
                InspectionReportID = 45,
                VehiclePartID = 45
            },
            new DamageReport()
            {
                ID = 33,
                Cost = 520m,
                DamageDate = new DateTime(2023, 4, 11),
                ReportDate = new DateTime(2023, 4, 12),
                DamageRepairTypeID = 3,
                Description = "Batterij leeg, moet worden vervangen.",
                InspectionReportID = 3,
                VehiclePartID = 3
            },
            new DamageReport()
            {
                ID = 34,
                Cost = 710m,
                DamageDate = new DateTime(2023, 5, 16),
                ReportDate = new DateTime(2023, 5, 17),
                DamageRepairTypeID = 7,
                Description = "Stuurkolom beschadigd, moet worden vervangen.",
                InspectionReportID = 70,
                VehiclePartID = 70
            },
            new DamageReport()
            {
                ID = 35,
                Cost = 680m,
                DamageDate = new DateTime(2023, 6, 20),
                ReportDate = new DateTime(2023, 6, 21),
                DamageRepairTypeID = 16,
                Description = "Thermostaat defect, moet worden vervangen.",
                InspectionReportID = 16,
                VehiclePartID = 16
            },
            new DamageReport()
            {
                ID = 36,
                Cost = 940m,
                DamageDate = new DateTime(2023, 7, 25),
                ReportDate = new DateTime(2023, 7, 26),
                DamageRepairTypeID = 47,
                Description = "Zijspiegel beschadigd, moet worden vervangen.",
                InspectionReportID = 47,
                VehiclePartID = 47
            },
            new DamageReport()
            {
                ID = 37,
                Cost = 890m,
                DamageDate = new DateTime(2023, 8, 30),
                ReportDate = new DateTime(2023, 8, 31),
                DamageRepairTypeID = 5,
                Description = "Bougies versleten, moeten worden vervangen.",
                InspectionReportID = 5,
                VehiclePartID = 5
            },
            new DamageReport()
            {
                ID = 38,
                Cost = 760m,
                DamageDate = new DateTime(2023, 10, 4),
                ReportDate = new DateTime(2023, 10, 5),
                DamageRepairTypeID = 9,
                Description = "Dynamo defect, moet worden vervangen.",
                InspectionReportID = 9,
                VehiclePartID = 9
            },
            new DamageReport()
            {
                ID = 39,
                Cost = 530m,
                DamageDate = new DateTime(2023, 11, 8),
                ReportDate = new DateTime(2023, 11, 9),
                DamageRepairTypeID = 33,
                Description = "Uitlaatdemper beschadigd, moet worden vervangen.",
                InspectionReportID = 33,
                VehiclePartID = 33
            },
            new DamageReport()
            {
                ID = 40,
                Cost = 920m,
                DamageDate = new DateTime(2023, 12, 13),
                ReportDate = new DateTime(2023, 12, 14),
                DamageRepairTypeID = 48,
                Description = "Stabilisatorstang gebroken, moet worden vervangen.",
                InspectionReportID = 48,
                VehiclePartID = 48
            },
            new DamageReport()
            {
                ID = 41,
                Cost = 580m,
                DamageDate = new DateTime(2024, 1, 17),
                ReportDate = new DateTime(2024, 1, 18),
                DamageRepairTypeID = 11,
                Description = "Oliedruksensor defect, moet worden vervangen.",
                InspectionReportID = 11,
                VehiclePartID = 11
            },
            new DamageReport()
            {
                ID = 42,
                Cost = 780m,
                DamageDate = new DateTime(2024, 2, 21),
                ReportDate = new DateTime(2024, 2, 22),
                DamageRepairTypeID = 21,
                Description = "Achterruitwissermotor defect, moet worden vervangen.",
                InspectionReportID = 21,
                VehiclePartID = 21
            },
            new DamageReport()
            {
                ID = 43,
                Cost = 690m,
                DamageDate = new DateTime(2024, 3, 27),
                ReportDate = new DateTime(2024, 3, 28),
                DamageRepairTypeID = 43,
                Description = "Uitlaatspruitstuk lekt, moet worden gerepareerd.",
                InspectionReportID = 43,
                VehiclePartID = 43
            },
            new DamageReport()
            {
                ID = 44,
                Cost = 940m,
                DamageDate = new DateTime(2024, 4, 3),
                ReportDate = new DateTime(2024, 4, 4),
                DamageRepairTypeID = 46,
                Description = "Distributieriem gebroken, moet worden vervangen.",
                InspectionReportID = 56,
                VehiclePartID = 56
            },
            new DamageReport()
            {
                ID = 45,
                Cost = 530m,
                DamageDate = new DateTime(2024, 5, 8),
                ReportDate = new DateTime(2024, 5, 9),
                DamageRepairTypeID = 15,
                Description = "Koelvloeistoflekkage, moet worden gerepareerd.",
                InspectionReportID = 15,
                VehiclePartID = 15
            },
            new DamageReport()
            {
                ID = 46,
                Cost = 680m,
                DamageDate = new DateTime(2024, 6, 12),
                ReportDate = new DateTime(2024, 6, 13),
                DamageRepairTypeID = 27,
                Description = "Schokdemper lek, moet worden vervangen.",
                InspectionReportID = 27,
                VehiclePartID = 27
            },
            new DamageReport()
            {
                ID = 47,
                Cost = 820m,
                DamageDate = new DateTime(2024, 7, 17),
                ReportDate = new DateTime(2024, 7, 18),
                DamageRepairTypeID = 44,
                Description = "Krukaspositiesensor defect, moet worden vervangen.",
                InspectionReportID = 44,
                VehiclePartID = 44
            },
            new DamageReport()
            {
                ID = 48,
                Cost = 570m,
                DamageDate = new DateTime(2024, 8, 21),
                ReportDate = new DateTime(2024, 8, 22),
                DamageRepairTypeID = 13,
                Description = "Luchtfilter verstopt, moet worden vervangen.",
                InspectionReportID = 13,
                VehiclePartID = 13
            },
            new DamageReport()
            {
                ID = 49,
                Cost = 960m,
                DamageDate = new DateTime(2024, 9, 25),
                ReportDate = new DateTime(2024, 9, 26),
                DamageRepairTypeID = 49,
                Description = "Achteruitrijlicht defect, moet worden vervangen.",
                InspectionReportID = 49,
                VehiclePartID = 49
            },
            new DamageReport()
            {
                ID = 50,
                Cost = 740m,
                DamageDate = new DateTime(2024, 10, 30),
                ReportDate = new DateTime(2024, 10, 31),
                DamageRepairTypeID = 21,
                Description = "Remslang lek, moet worden vervangen.",
                InspectionReportID = 25,
                VehiclePartID = 25
            }
        );
    }
}