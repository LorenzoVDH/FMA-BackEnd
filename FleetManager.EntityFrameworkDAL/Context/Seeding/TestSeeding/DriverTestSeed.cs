using System;
using FleetManager.EntityFrameworkDAL.Models.Entities;
using System.Reflection.Emit;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;

public static class DriverTestSeed {
    public static void TestSeedDriver(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<Driver>().HasData(
            new Driver() {
                ID = 1,
                LastName = "Garner",
                FirstName = "Mark",
                Active = true,
                DateOfBirth = new DateTime(1977, 03, 07),
                NationalRegistrationNumber = "77.03.07-135.32",
                AddressPostalCode = "84930",
                AddressHouseNumber = "145",
                AddressStreet = "Bryan Causeway",
                AddressCity = "South Brentview",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 2,
                LastName = "Fischer",
                FirstName = "Ann",
                Active = false,
                DateOfBirth = new DateTime(1986, 11, 29),
                NationalRegistrationNumber = "86.11.29-944.69",
                AddressPostalCode = "12644",
                AddressHouseNumber = "8307",
                AddressStreet = "Nathan Ford",
                AddressCity = "Jamesstad",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 3,
                LastName = "Wilcox",
                FirstName = "Lisa",
                Active = false,
                DateOfBirth = new DateTime(2004, 01, 16),
                NationalRegistrationNumber = "04.01.16-720.84",
                AddressPostalCode = "50566",
                AddressHouseNumber = "062",
                AddressStreet = "Samantha Glens",
                AddressCity = "Fisherchester",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 4,
                LastName = "Hoover",
                FirstName = "Jonathan",
                Active = false,
                DateOfBirth = new DateTime(1989, 09, 24),
                NationalRegistrationNumber = "89.09.24-795.29",
                AddressPostalCode = "12209",
                AddressHouseNumber = "85319",
                AddressStreet = "Garza Road",
                AddressCity = "New Ericside",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 5,
                LastName = "Mata",
                FirstName = "John",
                Active = false,
                DateOfBirth = new DateTime(2004, 03, 17),
                NationalRegistrationNumber = "04.03.17-327.73",
                AddressPostalCode = "16611",
                AddressHouseNumber = "40371",
                AddressStreet = "Patricia Ridges",
                AddressCity = "Port Russell",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 6,
                LastName = "Brock",
                FirstName = "Nicole",
                Active = true,
                DateOfBirth = new DateTime(2003, 07, 22),
                NationalRegistrationNumber = "03.07.22-266.88",
                AddressPostalCode = "68429",
                AddressHouseNumber = "87024",
                AddressStreet = "Melissa Villages",
                AddressCity = "Nicholestad",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 7,
                LastName = "Pacheco",
                FirstName = "Tristan",
                Active = false,
                DateOfBirth = new DateTime(1990, 06, 27),
                NationalRegistrationNumber = "90.06.27-389.54",
                AddressPostalCode = "97802",
                AddressHouseNumber = "1569",
                AddressStreet = "Jeffrey Place",
                AddressCity = "Andrewland",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 8,
                LastName = "Rodriguez",
                FirstName = "Ryan",
                Active = false,
                DateOfBirth = new DateTime(1976, 09, 22),
                NationalRegistrationNumber = "76.09.22-881.21",
                AddressPostalCode = "21851",
                AddressHouseNumber = "397",
                AddressStreet = "Bennett Fall",
                AddressCity = "South Julie",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 9,
                LastName = "Prince",
                FirstName = "Karen",
                Active = true,
                DateOfBirth = new DateTime(2003, 02, 28),
                NationalRegistrationNumber = "03.02.28-290.43",
                AddressPostalCode = "71873",
                AddressHouseNumber = "3937",
                AddressStreet = "Kevin Avenue",
                AddressCity = "Stewartburgh",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 10,
                LastName = "Barrett",
                FirstName = "Caroline",
                Active = false,
                DateOfBirth = new DateTime(1983, 05, 19),
                NationalRegistrationNumber = "83.05.19-896.21",
                AddressPostalCode = "67792",
                AddressHouseNumber = "70766",
                AddressStreet = "Graham Neck",
                AddressCity = "Jenkinsville",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 11,
                LastName = "Mata",
                FirstName = "Erin",
                Active = false,
                DateOfBirth = new DateTime(1980, 05, 22),
                NationalRegistrationNumber = "80.05.22-991.64",
                AddressPostalCode = "38854",
                AddressHouseNumber = "09266",
                AddressStreet = "Jennifer Square",
                AddressCity = "East Caleb",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 12,
                LastName = "Woods",
                FirstName = "Travis",
                Active = false,
                DateOfBirth = new DateTime(1995, 04, 04),
                NationalRegistrationNumber = "95.04.04-681.58",
                AddressPostalCode = "66216",
                AddressHouseNumber = "9132",
                AddressStreet = "Andrea Crossroad",
                AddressCity = "Thompsonfort",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 13,
                LastName = "Lopez",
                FirstName = "Elizabeth",
                Active = true,
                DateOfBirth = new DateTime(1984, 07, 16),
                NationalRegistrationNumber = "84.07.16-932.13",
                AddressPostalCode = "72868",
                AddressHouseNumber = "056",
                AddressStreet = "Gomez Parkway",
                AddressCity = "Lake David",
                LicenseType = Models.Enums.LicenseType.D
            },

            new Driver() {
                ID = 14,
                LastName = "Wiley",
                FirstName = "Elizabeth",
                Active = false,
                DateOfBirth = new DateTime(1990, 05, 08),
                NationalRegistrationNumber = "90.05.08-586.32",
                AddressPostalCode = "77755",
                AddressHouseNumber = "365",
                AddressStreet = "Davis Overpass",
                AddressCity = "Lake Jaimeborough",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 15,
                LastName = "Hunt",
                FirstName = "Teresa",
                Active = false,
                DateOfBirth = new DateTime(1990, 06, 06),
                NationalRegistrationNumber = "90.06.06-752.30",
                AddressPostalCode = "95966",
                AddressHouseNumber = "2887",
                AddressStreet = "Jeffrey Vista",
                AddressCity = "New Michelle",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 16,
                LastName = "Hill",
                FirstName = "Lisa",
                Active = false,
                DateOfBirth = new DateTime(2003, 05, 23),
                NationalRegistrationNumber = "03.05.23-724.71",
                AddressPostalCode = "87073",
                AddressHouseNumber = "03518",
                AddressStreet = "Kimberly Rue",
                AddressCity = "Sullivanburgh",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 17,
                LastName = "Pena",
                FirstName = "Grant",
                Active = true,
                DateOfBirth = new DateTime(1989, 06, 04),
                NationalRegistrationNumber = "89.06.04-643.81",
                AddressPostalCode = "75545",
                AddressHouseNumber = "993",
                AddressStreet = "Teresa Lights",
                AddressCity = "Jefferyborough",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 18,
                LastName = "Santana",
                FirstName = "Kevin",
                Active = true,
                DateOfBirth = new DateTime(1987, 05, 16),
                NationalRegistrationNumber = "87.05.16-447.62",
                AddressPostalCode = "17279",
                AddressHouseNumber = "828",
                AddressStreet = "Lewis Alley",
                AddressCity = "Harrisside",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 19,
                LastName = "Carpenter",
                FirstName = "Leslie",
                Active = true,
                DateOfBirth = new DateTime(2003, 11, 24),
                NationalRegistrationNumber = "03.11.24-007.24",
                AddressPostalCode = "60709",
                AddressHouseNumber = "771",
                AddressStreet = "Lopez Roads",
                AddressCity = "East Richard",
                LicenseType = Models.Enums.LicenseType.G
            },

            new Driver() {
                ID = 20,
                LastName = "Reynolds",
                FirstName = "Adam",
                Active = false,
                DateOfBirth = new DateTime(1975, 06, 09),
                NationalRegistrationNumber = "75.06.09-309.68",
                AddressPostalCode = "77686",
                AddressHouseNumber = "01447",
                AddressStreet = "Willis Village",
                AddressCity = "West Emilyborough",
                LicenseType = Models.Enums.LicenseType.G
            },

            new Driver() {
                ID = 21,
                LastName = "Clark",
                FirstName = "Anna",
                Active = false,
                DateOfBirth = new DateTime(1995, 04, 27),
                NationalRegistrationNumber = "95.04.27-110.36",
                AddressPostalCode = "63734",
                AddressHouseNumber = "6689",
                AddressStreet = "Todd Camp",
                AddressCity = "Stephanieborough",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 22,
                LastName = "Soto",
                FirstName = "Latoya",
                Active = false,
                DateOfBirth = new DateTime(1978, 03, 14),
                NationalRegistrationNumber = "78.03.14-881.67",
                AddressPostalCode = "17552",
                AddressHouseNumber = "510",
                AddressStreet = "Anna Track",
                AddressCity = "East Joshuafort",
                LicenseType = Models.Enums.LicenseType.D
            },

            new Driver() {
                ID = 23,
                LastName = "Nguyen",
                FirstName = "Brandi",
                Active = false,
                DateOfBirth = new DateTime(1984, 03, 06),
                NationalRegistrationNumber = "84.03.06-586.49",
                AddressPostalCode = "55969",
                AddressHouseNumber = "116",
                AddressStreet = "Anderson Trafficway",
                AddressCity = "West Elizabethport",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 24,
                LastName = "Potts",
                FirstName = "Claudia",
                Active = true,
                DateOfBirth = new DateTime(1982, 11, 15),
                NationalRegistrationNumber = "82.11.15-830.34",
                AddressPostalCode = "29553",
                AddressHouseNumber = "2765",
                AddressStreet = "Mckee Mount",
                AddressCity = "East Whitneytown",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 25,
                LastName = "Melendez",
                FirstName = "Nancy",
                Active = true,
                DateOfBirth = new DateTime(1984, 07, 02),
                NationalRegistrationNumber = "84.07.02-128.73",
                AddressPostalCode = "44795",
                AddressHouseNumber = "686",
                AddressStreet = "Gonzalez Ridges",
                AddressCity = "East Jennashire",
                LicenseType = Models.Enums.LicenseType.G
            },

            new Driver() {
                ID = 26,
                LastName = "Davies",
                FirstName = "Darlene",
                Active = false,
                DateOfBirth = new DateTime(1994, 04, 11),
                NationalRegistrationNumber = "94.04.11-434.74",
                AddressPostalCode = "41536",
                AddressHouseNumber = "884",
                AddressStreet = "Campbell Road",
                AddressCity = "Josephton",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 27,
                LastName = "Le",
                FirstName = "Pamela",
                Active = false,
                DateOfBirth = new DateTime(2003, 02, 05),
                NationalRegistrationNumber = "03.02.05-588.47",
                AddressPostalCode = "71882",
                AddressHouseNumber = "06009",
                AddressStreet = "Laura Spur",
                AddressCity = "North Mistyborough",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 28,
                LastName = "Larson",
                FirstName = "Allison",
                Active = false,
                DateOfBirth = new DateTime(1989, 01, 23),
                NationalRegistrationNumber = "89.01.23-910.82",
                AddressPostalCode = "88726",
                AddressHouseNumber = "81895",
                AddressStreet = "Young Course",
                AddressCity = "East Johnview",
                LicenseType = Models.Enums.LicenseType.D
            },

            new Driver() {
                ID = 29,
                LastName = "Galloway",
                FirstName = "James",
                Active = true,
                DateOfBirth = new DateTime(1979, 11, 01),
                NationalRegistrationNumber = "79.11.01-251.97",
                AddressPostalCode = "73971",
                AddressHouseNumber = "316",
                AddressStreet = "Cheyenne Junctions",
                AddressCity = "West Pamela",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 30,
                LastName = "Johnson",
                FirstName = "Emily",
                Active = true,
                DateOfBirth = new DateTime(1978, 03, 09),
                NationalRegistrationNumber = "78.03.09-454.62",
                AddressPostalCode = "64659",
                AddressHouseNumber = "719",
                AddressStreet = "Holt Park",
                AddressCity = "South Monica",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 31,
                LastName = "Grimes",
                FirstName = "Katie",
                Active = false,
                DateOfBirth = new DateTime(1989, 01, 01),
                NationalRegistrationNumber = "89.01.01-030.70",
                AddressPostalCode = "02460",
                AddressHouseNumber = "558",
                AddressStreet = "Freeman Parkways",
                AddressCity = "East Christineville",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 32,
                LastName = "Craig",
                FirstName = "Adam",
                Active = true,
                DateOfBirth = new DateTime(1988, 09, 05),
                NationalRegistrationNumber = "88.09.05-361.42",
                AddressPostalCode = "06335",
                AddressHouseNumber = "404",
                AddressStreet = "Nguyen Crest",
                AddressCity = "East Stephaniefort",
                LicenseType = Models.Enums.LicenseType.G
            },

            new Driver() {
                ID = 33,
                LastName = "Mclean",
                FirstName = "Robyn",
                Active = true,
                DateOfBirth = new DateTime(1994, 07, 26),
                NationalRegistrationNumber = "94.07.26-084.92",
                AddressPostalCode = "06598",
                AddressHouseNumber = "6482",
                AddressStreet = "Myers Forks",
                AddressCity = "North Jennifer",
                LicenseType = Models.Enums.LicenseType.D
            },

            new Driver() {
                ID = 34,
                LastName = "Fields",
                FirstName = "Teresa",
                Active = false,
                DateOfBirth = new DateTime(1987, 05, 03),
                NationalRegistrationNumber = "87.05.03-298.19",
                AddressPostalCode = "97620",
                AddressHouseNumber = "2278",
                AddressStreet = "Lynn View",
                AddressCity = "Silvaburgh",
                LicenseType = Models.Enums.LicenseType.G
            },

            new Driver() {
                ID = 35,
                LastName = "Beasley",
                FirstName = "Brenda",
                Active = true,
                DateOfBirth = new DateTime(1976, 07, 09),
                NationalRegistrationNumber = "76.07.09-194.17",
                AddressPostalCode = "69566",
                AddressHouseNumber = "140",
                AddressStreet = "Lauren Wells",
                AddressCity = "Seanbury",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 36,
                LastName = "Ward",
                FirstName = "Anthony",
                Active = false,
                DateOfBirth = new DateTime(1984, 06, 08),
                NationalRegistrationNumber = "84.06.08-883.04",
                AddressPostalCode = "26895",
                AddressHouseNumber = "934",
                AddressStreet = "Colleen Port",
                AddressCity = "Kennethfort",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 37,
                LastName = "Nash",
                FirstName = "Robert",
                Active = false,
                DateOfBirth = new DateTime(1980, 05, 25),
                NationalRegistrationNumber = "80.05.25-749.22",
                AddressPostalCode = "32375",
                AddressHouseNumber = "40137",
                AddressStreet = "Jacob Throughway",
                AddressCity = "West Josefort",
                LicenseType = Models.Enums.LicenseType.G
            },

            new Driver() {
                ID = 38,
                LastName = "Santos",
                FirstName = "Daniel",
                Active = true,
                DateOfBirth = new DateTime(1996, 04, 04),
                NationalRegistrationNumber = "96.04.04-075.06",
                AddressPostalCode = "08151",
                AddressHouseNumber = "2239",
                AddressStreet = "Perez Cove",
                AddressCity = "East Johnland",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 39,
                LastName = "Leonard",
                FirstName = "Hayden",
                Active = false,
                DateOfBirth = new DateTime(1993, 10, 23),
                NationalRegistrationNumber = "93.10.23-821.27",
                AddressPostalCode = "33430",
                AddressHouseNumber = "04207",
                AddressStreet = "Cody Village",
                AddressCity = "East Linda",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 40,
                LastName = "Doyle",
                FirstName = "William",
                Active = false,
                DateOfBirth = new DateTime(1982, 03, 27),
                NationalRegistrationNumber = "82.03.27-439.09",
                AddressPostalCode = "74547",
                AddressHouseNumber = "4921",
                AddressStreet = "Kelley Curve",
                AddressCity = "East Brianberg",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 41,
                LastName = "Levine",
                FirstName = "Joshua",
                Active = false,
                DateOfBirth = new DateTime(2005, 06, 14),
                NationalRegistrationNumber = "05.06.14-807.16",
                AddressPostalCode = "94654",
                AddressHouseNumber = "1429",
                AddressStreet = "Blankenship Knolls",
                AddressCity = "Abigailport",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 42,
                LastName = "Rogers",
                FirstName = "Chad",
                Active = true,
                DateOfBirth = new DateTime(1974, 11, 28),
                NationalRegistrationNumber = "74.11.28-449.51",
                AddressPostalCode = "79937",
                AddressHouseNumber = "34103",
                AddressStreet = "Sherri Field",
                AddressCity = "Anthonyhaven",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 43,
                LastName = "Carlson",
                FirstName = "David",
                Active = false,
                DateOfBirth = new DateTime(2001, 10, 06),
                NationalRegistrationNumber = "01.10.06-933.74",
                AddressPostalCode = "33273",
                AddressHouseNumber = "696",
                AddressStreet = "Williams Mount",
                AddressCity = "Lisatown",
                LicenseType = Models.Enums.LicenseType.D
            },

            new Driver() {
                ID = 44,
                LastName = "Acosta",
                FirstName = "Joseph",
                Active = false,
                DateOfBirth = new DateTime(1974, 02, 21),
                NationalRegistrationNumber = "74.02.21-705.39",
                AddressPostalCode = "63492",
                AddressHouseNumber = "439",
                AddressStreet = "Sandoval Spurs",
                AddressCity = "Nunezland",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 45,
                LastName = "Young",
                FirstName = "John",
                Active = false,
                DateOfBirth = new DateTime(1984, 05, 15),
                NationalRegistrationNumber = "84.05.15-413.63",
                AddressPostalCode = "78980",
                AddressHouseNumber = "408",
                AddressStreet = "Paula Wells",
                AddressCity = "Burnsview",
                LicenseType = Models.Enums.LicenseType.D
            },

            new Driver() {
                ID = 46,
                LastName = "Schneider",
                FirstName = "Daniel",
                Active = true,
                DateOfBirth = new DateTime(2004, 10, 14),
                NationalRegistrationNumber = "04.10.14-561.75",
                AddressPostalCode = "62065",
                AddressHouseNumber = "18171",
                AddressStreet = "Jenna Gardens",
                AddressCity = "Port Allison",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 47,
                LastName = "Jackson",
                FirstName = "Adrienne",
                Active = true,
                DateOfBirth = new DateTime(1982, 08, 10),
                NationalRegistrationNumber = "82.08.10-458.50",
                AddressPostalCode = "35045",
                AddressHouseNumber = "0961",
                AddressStreet = "Mcdonald Ferry",
                AddressCity = "Lake Kennethland",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 48,
                LastName = "Patterson",
                FirstName = "Jennifer",
                Active = false,
                DateOfBirth = new DateTime(1996, 09, 21),
                NationalRegistrationNumber = "96.09.21-764.06",
                AddressPostalCode = "55538",
                AddressHouseNumber = "167",
                AddressStreet = "Smith Junctions",
                AddressCity = "Kellyland",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 49,
                LastName = "Ramirez",
                FirstName = "Jodi",
                Active = true,
                DateOfBirth = new DateTime(1993, 03, 23),
                NationalRegistrationNumber = "93.03.23-050.70",
                AddressPostalCode = "44382",
                AddressHouseNumber = "5193",
                AddressStreet = "Hardy Vista",
                AddressCity = "Vincentstad",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 50,
                LastName = "Thomas",
                FirstName = "Erin",
                Active = true,
                DateOfBirth = new DateTime(1995, 08, 05),
                NationalRegistrationNumber = "95.08.05-575.65",
                AddressPostalCode = "37479",
                AddressHouseNumber = "344",
                AddressStreet = "Webb Lock",
                AddressCity = "Kimchester",
                LicenseType = Models.Enums.LicenseType.D
            },

            new Driver() {
                ID = 51,
                LastName = "Lee",
                FirstName = "Kevin",
                Active = true,
                DateOfBirth = new DateTime(2000, 09, 18),
                NationalRegistrationNumber = "00.09.18-247.81",
                AddressPostalCode = "82883",
                AddressHouseNumber = "316",
                AddressStreet = "Jennifer Alley",
                AddressCity = "East Mikaylamouth",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 52,
                LastName = "Chen",
                FirstName = "Manuel",
                Active = true,
                DateOfBirth = new DateTime(1983, 06, 16),
                NationalRegistrationNumber = "83.06.16-509.20",
                AddressPostalCode = "68312",
                AddressHouseNumber = "3166",
                AddressStreet = "Robert Courts",
                AddressCity = "Kennethfort",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 53,
                LastName = "Hughes",
                FirstName = "William",
                Active = true,
                DateOfBirth = new DateTime(1995, 05, 15),
                NationalRegistrationNumber = "95.05.15-681.26",
                AddressPostalCode = "56427",
                AddressHouseNumber = "35466",
                AddressStreet = "Rogers Stravenue",
                AddressCity = "Patriciastad",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 54,
                LastName = "King",
                FirstName = "Gabriela",
                Active = true,
                DateOfBirth = new DateTime(1975, 01, 21),
                NationalRegistrationNumber = "75.01.21-296.74",
                AddressPostalCode = "43269",
                AddressHouseNumber = "68576",
                AddressStreet = "Robinson Light",
                AddressCity = "West Debbie",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 55,
                LastName = "Mathis",
                FirstName = "Charles",
                Active = false,
                DateOfBirth = new DateTime(1996, 03, 30),
                NationalRegistrationNumber = "96.03.30-785.61",
                AddressPostalCode = "17240",
                AddressHouseNumber = "000",
                AddressStreet = "Walker Camp",
                AddressCity = "Johnsonshire",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 56,
                LastName = "Oconnell",
                FirstName = "Kyle",
                Active = false,
                DateOfBirth = new DateTime(1987, 02, 03),
                NationalRegistrationNumber = "87.02.03-321.72",
                AddressPostalCode = "69546",
                AddressHouseNumber = "5749",
                AddressStreet = "King Loaf",
                AddressCity = "Maryton",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 57,
                LastName = "Rivas",
                FirstName = "David",
                Active = true,
                DateOfBirth = new DateTime(2000, 07, 02),
                NationalRegistrationNumber = "00.07.02-901.87",
                AddressPostalCode = "42504",
                AddressHouseNumber = "9568",
                AddressStreet = "Dana Canyon",
                AddressCity = "New Brittanyfort",
                LicenseType = Models.Enums.LicenseType.G
            },

            new Driver() {
                ID = 58,
                LastName = "Taylor",
                FirstName = "Angelica",
                Active = true,
                DateOfBirth = new DateTime(1991, 10, 28),
                NationalRegistrationNumber = "91.10.28-740.13",
                AddressPostalCode = "12155",
                AddressHouseNumber = "235",
                AddressStreet = "Rodriguez Estates",
                AddressCity = "Masonchester",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 59,
                LastName = "Gonzalez",
                FirstName = "Brent",
                Active = true,
                DateOfBirth = new DateTime(1996, 01, 26),
                NationalRegistrationNumber = "96.01.26-459.08",
                AddressPostalCode = "69661",
                AddressHouseNumber = "6469",
                AddressStreet = "Lisa Way",
                AddressCity = "South Caitlin",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 60,
                LastName = "Davis",
                FirstName = "Amanda",
                Active = false,
                DateOfBirth = new DateTime(2003, 07, 10),
                NationalRegistrationNumber = "03.07.10-434.86",
                AddressPostalCode = "89449",
                AddressHouseNumber = "7892",
                AddressStreet = "Jasmine Expressway",
                AddressCity = "Lake Ryanborough",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 61,
                LastName = "Figueroa",
                FirstName = "Kristen",
                Active = true,
                DateOfBirth = new DateTime(1983, 06, 28),
                NationalRegistrationNumber = "83.06.28-968.74",
                AddressPostalCode = "07449",
                AddressHouseNumber = "187",
                AddressStreet = "Martinez Curve",
                AddressCity = "North Nicoleburgh",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 62,
                LastName = "Russell",
                FirstName = "Anthony",
                Active = false,
                DateOfBirth = new DateTime(1981, 09, 17),
                NationalRegistrationNumber = "81.09.17-411.67",
                AddressPostalCode = "82498",
                AddressHouseNumber = "834",
                AddressStreet = "Kathryn Pines",
                AddressCity = "New Deborahview",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 63,
                LastName = "Davis",
                FirstName = "April",
                Active = true,
                DateOfBirth = new DateTime(1974, 10, 13),
                NationalRegistrationNumber = "74.10.13-916.27",
                AddressPostalCode = "29591",
                AddressHouseNumber = "295",
                AddressStreet = "Butler Spring",
                AddressCity = "Ericport",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 64,
                LastName = "Compton",
                FirstName = "Ian",
                Active = false,
                DateOfBirth = new DateTime(2003, 05, 25),
                NationalRegistrationNumber = "03.05.25-031.25",
                AddressPostalCode = "72779",
                AddressHouseNumber = "180",
                AddressStreet = "Sydney Trafficway",
                AddressCity = "North Jordan",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 65,
                LastName = "Farmer",
                FirstName = "Michael",
                Active = false,
                DateOfBirth = new DateTime(1974, 10, 23),
                NationalRegistrationNumber = "74.10.23-887.47",
                AddressPostalCode = "62707",
                AddressHouseNumber = "497",
                AddressStreet = "Sabrina Groves",
                AddressCity = "Millermouth",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 66,
                LastName = "Faulkner",
                FirstName = "Alyssa",
                Active = false,
                DateOfBirth = new DateTime(1990, 07, 11),
                NationalRegistrationNumber = "90.07.11-306.42",
                AddressPostalCode = "66355",
                AddressHouseNumber = "80708",
                AddressStreet = "Margaret Track",
                AddressCity = "Lake Charles",
                LicenseType = Models.Enums.LicenseType.G
            },

            new Driver() {
                ID = 67,
                LastName = "Vargas",
                FirstName = "Cynthia",
                Active = false,
                DateOfBirth = new DateTime(1986, 11, 03),
                NationalRegistrationNumber = "86.11.03-430.05",
                AddressPostalCode = "53831",
                AddressHouseNumber = "3244",
                AddressStreet = "Sharon Curve",
                AddressCity = "North Mitchellborough",
                LicenseType = Models.Enums.LicenseType.G
            },

            new Driver() {
                ID = 68,
                LastName = "Hale",
                FirstName = "Jeremy",
                Active = true,
                DateOfBirth = new DateTime(2000, 07, 16),
                NationalRegistrationNumber = "00.07.16-011.72",
                AddressPostalCode = "52970",
                AddressHouseNumber = "053",
                AddressStreet = "Tracy Camp",
                AddressCity = "Gabrielleland",
                LicenseType = Models.Enums.LicenseType.D
            },

            new Driver() {
                ID = 69,
                LastName = "Allen",
                FirstName = "Jamie",
                Active = false,
                DateOfBirth = new DateTime(1982, 01, 13),
                NationalRegistrationNumber = "82.01.13-191.81",
                AddressPostalCode = "35664",
                AddressHouseNumber = "3079",
                AddressStreet = "Lawson Wall",
                AddressCity = "East Chadburgh",
                LicenseType = Models.Enums.LicenseType.G
            },

            new Driver() {
                ID = 70,
                LastName = "Aguirre",
                FirstName = "Jamie",
                Active = false,
                DateOfBirth = new DateTime(2000, 12, 26),
                NationalRegistrationNumber = "00.12.26-823.62",
                AddressPostalCode = "99720",
                AddressHouseNumber = "2430",
                AddressStreet = "Andrew Park",
                AddressCity = "North Troyland",
                LicenseType = Models.Enums.LicenseType.D
            },

            new Driver() {
                ID = 71,
                LastName = "Barron",
                FirstName = "Stanley",
                Active = true,
                DateOfBirth = new DateTime(1983, 01, 04),
                NationalRegistrationNumber = "83.01.04-759.95",
                AddressPostalCode = "73729",
                AddressHouseNumber = "1716",
                AddressStreet = "Tyler Islands",
                AddressCity = "Rushhaven",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 72,
                LastName = "Cruz",
                FirstName = "Elizabeth",
                Active = true,
                DateOfBirth = new DateTime(1983, 01, 07),
                NationalRegistrationNumber = "83.01.07-096.86",
                AddressPostalCode = "05799",
                AddressHouseNumber = "78601",
                AddressStreet = "Larsen Stravenue",
                AddressCity = "Lake Chelsea",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 73,
                LastName = "Lewis",
                FirstName = "Christian",
                Active = false,
                DateOfBirth = new DateTime(2004, 09, 16),
                NationalRegistrationNumber = "04.09.16-805.55",
                AddressPostalCode = "88804",
                AddressHouseNumber = "9358",
                AddressStreet = "Brandon Junctions",
                AddressCity = "North Megan",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 74,
                LastName = "Guerrero",
                FirstName = "Gregory",
                Active = true,
                DateOfBirth = new DateTime(1990, 02, 12),
                NationalRegistrationNumber = "90.02.12-941.21",
                AddressPostalCode = "18541",
                AddressHouseNumber = "13366",
                AddressStreet = "Laura Mews",
                AddressCity = "West Christophershire",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 75,
                LastName = "Osborne",
                FirstName = "Brandon",
                Active = true,
                DateOfBirth = new DateTime(1974, 02, 04),
                NationalRegistrationNumber = "74.02.04-147.40",
                AddressPostalCode = "58650",
                AddressHouseNumber = "9320",
                AddressStreet = "Olson Haven",
                AddressCity = "Andrewfurt",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 76,
                LastName = "Jones",
                FirstName = "Joseph",
                Active = true,
                DateOfBirth = new DateTime(2004, 04, 14),
                NationalRegistrationNumber = "04.04.14-621.70",
                AddressPostalCode = "73374",
                AddressHouseNumber = "599",
                AddressStreet = "Gomez Estates",
                AddressCity = "North Loretta",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 77,
                LastName = "Perez",
                FirstName = "Evelyn",
                Active = true,
                DateOfBirth = new DateTime(1986, 12, 03),
                NationalRegistrationNumber = "86.12.03-874.53",
                AddressPostalCode = "50007",
                AddressHouseNumber = "6296",
                AddressStreet = "Hicks Ports",
                AddressCity = "Lake Kristinaville",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 78,
                LastName = "Cook",
                FirstName = "Susan",
                Active = false,
                DateOfBirth = new DateTime(1990, 07, 03),
                NationalRegistrationNumber = "90.07.03-274.23",
                AddressPostalCode = "95672",
                AddressHouseNumber = "904",
                AddressStreet = "Kendra Wells",
                AddressCity = "South Jadebury",
                LicenseType = Models.Enums.LicenseType.G
            },

            new Driver() {
                ID = 79,
                LastName = "Perez",
                FirstName = "Katherine",
                Active = true,
                DateOfBirth = new DateTime(1991, 10, 26),
                NationalRegistrationNumber = "91.10.26-342.83",
                AddressPostalCode = "23171",
                AddressHouseNumber = "585",
                AddressStreet = "Dylan Drive",
                AddressCity = "Spencermouth",
                LicenseType = Models.Enums.LicenseType.D
            },

            new Driver() {
                ID = 80,
                LastName = "Valdez",
                FirstName = "Lee",
                Active = false,
                DateOfBirth = new DateTime(1981, 10, 02),
                NationalRegistrationNumber = "81.10.02-931.04",
                AddressPostalCode = "56856",
                AddressHouseNumber = "929",
                AddressStreet = "Edwin Circle",
                AddressCity = "Pettychester",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 81,
                LastName = "Miller",
                FirstName = "Darren",
                Active = false,
                DateOfBirth = new DateTime(1981, 10, 03),
                NationalRegistrationNumber = "81.10.03-693.18",
                AddressPostalCode = "06380",
                AddressHouseNumber = "91043",
                AddressStreet = "Megan Well",
                AddressCity = "Ballardmouth",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 82,
                LastName = "Solis",
                FirstName = "Carrie",
                Active = false,
                DateOfBirth = new DateTime(1976, 01, 02),
                NationalRegistrationNumber = "76.01.02-740.27",
                AddressPostalCode = "28874",
                AddressHouseNumber = "015",
                AddressStreet = "Ashley Underpass",
                AddressCity = "Cameronfurt",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 83,
                LastName = "Kelly",
                FirstName = "Nathan",
                Active = true,
                DateOfBirth = new DateTime(1999, 02, 13),
                NationalRegistrationNumber = "99.02.13-013.41",
                AddressPostalCode = "87299",
                AddressHouseNumber = "5453",
                AddressStreet = "Alyssa Knoll",
                AddressCity = "New Jonathan",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 84,
                LastName = "Dyer",
                FirstName = "Nicole",
                Active = false,
                DateOfBirth = new DateTime(2005, 03, 23),
                NationalRegistrationNumber = "05.03.23-954.63",
                AddressPostalCode = "83417",
                AddressHouseNumber = "6827",
                AddressStreet = "Tanya Squares",
                AddressCity = "North Michaelmouth",
                LicenseType = Models.Enums.LicenseType.G
            },

            new Driver() {
                ID = 85,
                LastName = "Silva",
                FirstName = "John",
                Active = true,
                DateOfBirth = new DateTime(1985, 02, 15),
                NationalRegistrationNumber = "85.02.15-191.91",
                AddressPostalCode = "97840",
                AddressHouseNumber = "13796",
                AddressStreet = "Joshua Isle",
                AddressCity = "Walkerhaven",
                LicenseType = Models.Enums.LicenseType.G
            },

            new Driver() {
                ID = 86,
                LastName = "Thomas",
                FirstName = "Michael",
                Active = false,
                DateOfBirth = new DateTime(1984, 06, 27),
                NationalRegistrationNumber = "84.06.27-551.57",
                AddressPostalCode = "77789",
                AddressHouseNumber = "04853",
                AddressStreet = "Lee Road",
                AddressCity = "Dianaport",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 87,
                LastName = "Mcgrath",
                FirstName = "Travis",
                Active = false,
                DateOfBirth = new DateTime(1977, 01, 31),
                NationalRegistrationNumber = "77.01.31-889.96",
                AddressPostalCode = "36607",
                AddressHouseNumber = "61215",
                AddressStreet = "Blake Streets",
                AddressCity = "Port Johnton",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 88,
                LastName = "Carson",
                FirstName = "Kimberly",
                Active = false,
                DateOfBirth = new DateTime(1982, 04, 26),
                NationalRegistrationNumber = "82.04.26-435.50",
                AddressPostalCode = "47333",
                AddressHouseNumber = "0609",
                AddressStreet = "Hernandez Rest",
                AddressCity = "South James",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 89,
                LastName = "Smith",
                FirstName = "Ashley",
                Active = false,
                DateOfBirth = new DateTime(2002, 12, 10),
                NationalRegistrationNumber = "02.12.10-953.66",
                AddressPostalCode = "77505",
                AddressHouseNumber = "581",
                AddressStreet = "Hill Trail",
                AddressCity = "Port Ashleyshire",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 90,
                LastName = "Morgan",
                FirstName = "Jeffrey",
                Active = true,
                DateOfBirth = new DateTime(1981, 07, 29),
                NationalRegistrationNumber = "81.07.29-185.16",
                AddressPostalCode = "39544",
                AddressHouseNumber = "8032",
                AddressStreet = "Townsend Walk",
                AddressCity = "Cunninghamside",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 91,
                LastName = "Woods",
                FirstName = "Tamara",
                Active = true,
                DateOfBirth = new DateTime(1995, 08, 04),
                NationalRegistrationNumber = "95.08.04-298.81",
                AddressPostalCode = "89265",
                AddressHouseNumber = "7332",
                AddressStreet = "Larson Brook",
                AddressCity = "New Katherineton",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 92,
                LastName = "Cortez",
                FirstName = "Alexander",
                Active = false,
                DateOfBirth = new DateTime(1977, 12, 23),
                NationalRegistrationNumber = "77.12.23-341.88",
                AddressPostalCode = "78728",
                AddressHouseNumber = "67649",
                AddressStreet = "Ruiz Streets",
                AddressCity = "West Tracyfort",
                LicenseType = Models.Enums.LicenseType.D
            },

            new Driver() {
                ID = 93,
                LastName = "Flynn",
                FirstName = "Micheal",
                Active = true,
                DateOfBirth = new DateTime(1999, 04, 22),
                NationalRegistrationNumber = "99.04.22-221.62",
                AddressPostalCode = "18789",
                AddressHouseNumber = "864",
                AddressStreet = "Daniels Union",
                AddressCity = "Port Gabriel",
                LicenseType = Models.Enums.LicenseType.G
            },

            new Driver() {
                ID = 94,
                LastName = "Hoffman",
                FirstName = "Jason",
                Active = false,
                DateOfBirth = new DateTime(1980, 07, 08),
                NationalRegistrationNumber = "80.07.08-933.71",
                AddressPostalCode = "96231",
                AddressHouseNumber = "234",
                AddressStreet = "Davis Unions",
                AddressCity = "Krauseville",
                LicenseType = Models.Enums.LicenseType.AM
            },

            new Driver() {
                ID = 95,
                LastName = "Garza",
                FirstName = "Katie",
                Active = false,
                DateOfBirth = new DateTime(1997, 02, 15),
                NationalRegistrationNumber = "97.02.15-690.38",
                AddressPostalCode = "21922",
                AddressHouseNumber = "4625",
                AddressStreet = "Hudson Flats",
                AddressCity = "Port Kristintown",
                LicenseType = Models.Enums.LicenseType.A
            },

            new Driver() {
                ID = 96,
                LastName = "Cummings",
                FirstName = "Alexandria",
                Active = true,
                DateOfBirth = new DateTime(1979, 07, 26),
                NationalRegistrationNumber = "79.07.26-916.12",
                AddressPostalCode = "05301",
                AddressHouseNumber = "5841",
                AddressStreet = "Harper Cliffs",
                AddressCity = "Johnsonfurt",
                LicenseType = Models.Enums.LicenseType.D
            },

            new Driver() {
                ID = 97,
                LastName = "Mcintyre",
                FirstName = "Andrea",
                Active = true,
                DateOfBirth = new DateTime(1987, 09, 02),
                NationalRegistrationNumber = "87.09.02-688.75",
                AddressPostalCode = "71565",
                AddressHouseNumber = "45664",
                AddressStreet = "Jerry Port",
                AddressCity = "Lake Jacob",
                LicenseType = Models.Enums.LicenseType.C
            },

            new Driver() {
                ID = 98,
                LastName = "Hill",
                FirstName = "Marc",
                Active = true,
                DateOfBirth = new DateTime(2004, 02, 01),
                NationalRegistrationNumber = "04.02.01-103.91",
                AddressPostalCode = "94137",
                AddressHouseNumber = "875",
                AddressStreet = "Lewis Cliffs",
                AddressCity = "Saraside",
                LicenseType = Models.Enums.LicenseType.B
            },

            new Driver() {
                ID = 99,
                LastName = "Clark",
                FirstName = "James",
                Active = true,
                DateOfBirth = new DateTime(1985, 01, 27),
                NationalRegistrationNumber = "85.01.27-017.92",
                AddressPostalCode = "15507",
                AddressHouseNumber = "854",
                AddressStreet = "Castro Lake",
                AddressCity = "Port Daniel",
                LicenseType = Models.Enums.LicenseType.A
            }

        );
    }
}