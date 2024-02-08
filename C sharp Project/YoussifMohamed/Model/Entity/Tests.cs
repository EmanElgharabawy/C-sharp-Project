using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Project.YoussifMohamed.Model.Entity
{
    public class Tests
    {
        [StringLength(50)]
        [Required]
        public string? Name { get; set; }
        [MaxLength(5)]
        [MinLength(2)]
        public int Price { get; set; }
    }
}
