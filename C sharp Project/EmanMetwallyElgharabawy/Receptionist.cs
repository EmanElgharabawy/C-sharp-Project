using C_sharp_Project.YoussifMohamed.Model.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_Project
{
    public partial class Receptionist : Form
    {
        ClinicDB db = new ClinicDB();
        public Receptionist()
        {
            InitializeComponent();
            Display();
        }

        public void Display()
        {
            var model = db.Reciptionist.Select(a => new { ID = a.Id, Name = a.Name, Gender = a.Gender, Address = a.Address, Phone = a.Phone }).ToList();
            listBox1.DataSource = model;
        }

        private void label11_Click(object sender, EventArgs e)
        {}
    }
}
