using Medicaid.Core.Master;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Medicaid.Core
{
    public class MediCaidContext :DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-SF1G3N8\\VIPRAIT; Database= MediCaidDBDev; User Id=sa;Password = vi@pra91");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
        }

        public DbSet<PatientMaster> PatientMasters { get; set; }

    }
}
