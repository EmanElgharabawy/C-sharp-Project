using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Project.YoussifMohamed.Model.Entity
{
    public class Doctor 
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        [StringLength(20)]
        public string? department { get; set; }
        [MinLength(5)]
        [MaxLength(15)]
        [Required]
        public int password { get; set; }
    }
}
