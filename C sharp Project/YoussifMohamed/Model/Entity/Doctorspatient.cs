using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Project.YoussifMohamed.Model.Entity
{
    public class Doctorspatient
    {
        [StringLength(50)]
        public string?  Medicine { get; set; } 
        [StringLength(50)]
        public string?  Diagnosis { get; set; }
        public int DoctorID { get; set; }
        public int PatientID { get; set; }
        public Doctor Doctor { get; set; }
        public Patient Patient { get; set; }
    }
}
