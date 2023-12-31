﻿using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace FleetManager.EntityFrameworkDAL.Context.Seeding.TestSeeding;
public static class DamageRepairTypeTestSeed {
    public static void TestSeedDamageRepairType(this ModelBuilder modelBuilder) {
        modelBuilder.Entity<DamageRepairType>().HasData(
            new DamageRepairType() { ID = 1, Name = "Vervangen van remblokken" },
            new DamageRepairType() { ID = 2, Name = "Vervangen van bougies" },
            new DamageRepairType() { ID = 3, Name = "Vervangen van accu" },
            new DamageRepairType() { ID = 4, Name = "Vervangen van oliefilter" },
            new DamageRepairType() { ID = 5, Name = "Vervangen van luchtfilter" },
            new DamageRepairType() { ID = 6, Name = "Vervangen van brandstoffilter" },
            new DamageRepairType() { ID = 7, Name = "Vervangen van interieurfilter" },
            new DamageRepairType() { ID = 8, Name = "Vervangen van ruitenwisserbladen" },
            new DamageRepairType() { ID = 9, Name = "Vervangen van distributieriem" },
            new DamageRepairType() { ID = 10, Name = "Vervangen van waterpomp" },
            new DamageRepairType() { ID = 11, Name = "Vervangen van multiriem" },
            new DamageRepairType() { ID = 12, Name = "Vervangen van dynamo" },
            new DamageRepairType() { ID = 13, Name = "Vervangen van startmotor" },
            new DamageRepairType() { ID = 14, Name = "Vervangen van koppeling" },
            new DamageRepairType() { ID = 15, Name = "Vervangen van drukgroep" },
            new DamageRepairType() { ID = 16, Name = "Vervangen van versnellingsbak" },
            new DamageRepairType() { ID = 17, Name = "Vervangen van koppelingskabel" },
            new DamageRepairType() { ID = 18, Name = "Vervangen van remschijven" },
            new DamageRepairType() { ID = 19, Name = "Vervangen van remblokken achter" },
            new DamageRepairType() { ID = 20, Name = "Vervangen van remklauwen" },
            new DamageRepairType() { ID = 21, Name = "Vervangen van handremkabels" },
            new DamageRepairType() { ID = 22, Name = "Vervangen van ABS-sensor" },
            new DamageRepairType() { ID = 23, Name = "Vervangen van fuseekogel" },
            new DamageRepairType() { ID = 24, Name = "Vervangen van draagarm" },
            new DamageRepairType() { ID = 25, Name = "Vervangen van stabilisatorstang" },
            new DamageRepairType() { ID = 26, Name = "Vervangen van schokdempers" },
            new DamageRepairType() { ID = 27, Name = "Vervangen van veerpootlagers" },
            new DamageRepairType() { ID = 28, Name = "Vervangen van aandrijfas" },
            new DamageRepairType() { ID = 29, Name = "Vervangen van homokineet" },
            new DamageRepairType() { ID = 30, Name = "Vervangen van stuurkogel" },
            new DamageRepairType() { ID = 31, Name = "Vervangen van fuseekogelhoes" },
            new DamageRepairType() { ID = 32, Name = "Vervangen van aandrijfashoes" },
            new DamageRepairType() { ID = 33, Name = "Vervangen van wielnaaf" },
            new DamageRepairType() { ID = 34, Name = "Vervangen van stuurhuis" },
            new DamageRepairType() { ID = 35, Name = "Vervangen van stuurbekrachtigingspomp" },
            new DamageRepairType() { ID = 36, Name = "Vervangen van uitlaatspruitstuk" },
            new DamageRepairType() { ID = 37, Name = "Vervangen van katalysator" },
            new DamageRepairType() { ID = 38, Name = "Vervangen van lambdasonde" },
            new DamageRepairType() { ID = 39, Name = "Vervangen van middendemper" },
            new DamageRepairType() { ID = 40, Name = "Vervangen van einddemper" },
            new DamageRepairType() { ID = 41, Name = "Vervangen van achterdemper" },
            new DamageRepairType() { ID = 42, Name = "Vervangen van radiateur" },
            new DamageRepairType() { ID = 43, Name = "Vervangen van thermostaat" },
            new DamageRepairType() { ID = 44, Name = "Vervangen van koelvloeistof" },
            new DamageRepairType() { ID = 45, Name = "Vervangen van waterpomp" },
            new DamageRepairType() { ID = 46, Name = "Vervangen van radiatorventilator" },
            new DamageRepairType() { ID = 47, Name = "Vervangen van elektrische motorventilator" },
            new DamageRepairType() { ID = 48, Name = "Vervangen van airconditioning compressor" },
            new DamageRepairType() { ID = 49, Name = "Vervangen van airconditioning condensor" },
            new DamageRepairType() { ID = 50, Name = "Vervangen van airconditioning verdamper" }
        );
    }
}