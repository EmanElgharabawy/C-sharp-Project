using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Project.YoussifMohamed.Model.Entity
{
    public class PatientTests
    {
        [StringLength(50)]
        public string? Results { get; set; }
        public int PatientID { get; set; }
        public int TestsID { get; set; }
        public Patient Patient { get; set; }
        public Tests Tests { get; set; }
    }
}
