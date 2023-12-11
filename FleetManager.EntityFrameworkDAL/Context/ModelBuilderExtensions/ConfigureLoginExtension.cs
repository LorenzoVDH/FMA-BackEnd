using FleetManager.EntityFrameworkDAL.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FleetManager.EntityFrameworkDAL.Context.ModelBuilderExtensions {
    public static class ConfigureLoginExtension {
        public static void ConfigureLogin(this ModelBuilder modelBuilder) {
            modelBuilder.Entity<Login>(entity => { 
                entity.Property(l => l.Role).HasConversion<string>().IsRequired().HasMaxLength(128);
                entity.Property(l => l.Email).HasMaxLength(128).IsRequired();
                entity.Property(l => l.Password).HasMaxLength(128).IsRequired();
            });                
        }
    }
}
