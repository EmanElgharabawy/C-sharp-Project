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
    public partial class DoctorPage : Form
    {
        public DoctorPage()
        {
            InitializeComponent();
        }

        private void DoctorPage_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            using (ClinicDB Con = new ClinicDB())
            {
                var DOC = new YoussifMohamed.Model.Entity.Doctor
                {

                    //Id = int.Parse((docid.Text).ToString()),
                    Name = Doctorname.Text,
                    Address = DoctorAddress.Text,
                    Phone = Doctorphone.Text,
                    Specialization = Doctorspecialation.Text,
                    Experience = DoctorExperiance.Text,
                    password = Doctorpassword.Text,
                    Gender = DoctorGender.Text,
                    DOB = DoctorBirthofdate.Value

                };
                Con.Doctor.Add(DOC);
                Con.SaveChanges();

                var Doctor = Con.Doctor.Select(a => new { Name = a.Name, Address = a.Address, Specialization = a.Specialization, Phone = a.Phone, Experience = a.Experience, Gender = a.Gender, DOB = a.DOB }).ToList();
                dataGridView1.DataSource = Doctor;
                Con.SaveChanges();

                MessageBox.Show("Doctor Added successfully!");
            };
        }
    }
}
