using C_sharp_Project.YoussifMohamed.Model.Database;
using C_sharp_Project.YoussifMohamed.Model.Entity;
using Microsoft.EntityFrameworkCore;
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
        ClinicDB db = new ClinicDB();
        Doctor Doctor1 = new Doctor();
        public DoctorPage()
        {
            InitializeComponent();
            display();
        }

        private void DoctorPage_Load(object sender, EventArgs e)
        {

        }

        public void display()
        {
            var Doctor = db.Doctor.Select(a => new { id = a.Id, Name = a.Name, Address = a.Address, Specialization = a.Specialization, Phone = a.Phone, Experience = a.Experience, Gender = a.Gender, DOB = a.DOB, password = a.password }).ToList();
            dataGridView1.DataSource = Doctor;
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

        private void searchbtn_Click(object sender, EventArgs e)
        {
            var searchByName = Doctorname.Text.Trim();
            var search = db.Doctor.Where(s => s.Name == searchByName).Select(a => new { ID = a.Id, Name = a.Name, Gender = a.Gender, Address = a.Address, Phone = a.Phone, Password = a.password }).ToList();
            dataGridView1.DataSource = search;
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var Del = db.Entry(Doctor1);
            if (Del.State == EntityState.Detached)
                db.Doctor.Attach(Doctor1);
            db.Doctor.Remove(Doctor1);
            db.SaveChanges();
            display();
        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {

            if (dataGridView1.CurrentRow.Index != -1)
            {
                Doctor1.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                Doctor1 = db.Doctor.Where(a => a.Id == Doctor1.Id).FirstOrDefault();

                Doctorname.Text = Doctor1.Name;
                DoctorGender.Text = Doctor1.Gender;
                DoctorAddress.Text = Doctor1.Address;
                Doctorphone.Text = Doctor1.Phone;
                Doctorpassword.Text = Doctor1.password;
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {

            Doctor1.Name = Doctorname.Text;
            Doctor1.Address = DoctorAddress.Text;
            Doctor1.Phone = Doctorphone.Text;
            Doctor1.Specialization = Doctorspecialation.Text;
            Doctor1.Experience = DoctorExperiance.Text;
            Doctor1.password = Doctorpassword.Text;
            Doctor1.Gender = DoctorGender.Text;
            Doctor1.DOB = DoctorBirthofdate.Value;

            db.Entry(Doctor1).State = EntityState.Modified;
            db.SaveChanges();
            display();
        }
    }
}
