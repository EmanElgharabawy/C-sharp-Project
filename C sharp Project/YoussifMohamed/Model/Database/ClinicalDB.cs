using C_sharp_Project.YoussifMohamed.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Project.YoussifMohamed.Model.Database
{
    public class ClinicalDB : DbContext
    {
        public ClinicalDB(DbContextOptions<ClinicalDB> options) : base(options)
        {
        }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Doctorspatient> Doctorspatient { get; set; }
        public DbSet<Tests> Tests { get; set; }
        public DbSet<Receptionist> Receptionist { get; set; }
        public DbSet<PatientTests> PatientTests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-7DE5S9C\\SQLEXPRESS;Database=ClinicalDB;Encrypt=false;Trusted_Connection=True;TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PatientTests>().HasKey(a => new { a.PatientID, a.TestsID });
            modelBuilder.Entity<Doctorspatient>().HasKey(a => new { a.PatientID, a.DoctorID });
        }
    }
}
