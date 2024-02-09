using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_Project.YoussifMohamed.Model.Entity
{
    public class Patient
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        [Required]
        public DateTime DOB { get; set; }
        [ForeignKey("Reciptionist")]
        public int RecipID { get; set; }
        public virtual Reciptionist Reciptionist { get; set; }

    }
}
