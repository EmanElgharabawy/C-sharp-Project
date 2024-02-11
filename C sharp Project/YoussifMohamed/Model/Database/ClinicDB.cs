using C_sharp_Project.YoussifMohamed.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Project.YoussifMohamed.Model.Database
{
    public class ClinicDB : DbContext
    {
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Reciptionist> Reciptionist { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=. ;Database=DBClinicalManagement;Encrypt=false;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientTests>().HasKey(a => new { a.PatientID, a.TestsID });
            modelBuilder.Entity<Doctorspatient>().HasKey(a => new { a.PatientID, a.DoctorID });



            modelBuilder.Entity<Doctor>().HasData(new Doctor { Id=1 , Phone="012345698715" , Name = "Eman" , Address="Cairo" , department="Surgery Department" , password="Doctor123" });
          
        }


       
    }

}
