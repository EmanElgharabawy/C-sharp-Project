using C_sharp_Project.YoussifMohamed.Model.Database;
using C_sharp_Project.YoussifMohamed.Model.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C_sharp_Project
{
    public partial class PatientPage : Form
    {
        ClinicDB db = new ClinicDB();
        Patient ptn = new Patient();

        public PatientPage()
        {
            InitializeComponent();
        }

        public void GetData()
        {
            var patientData = db.Patient.Select(p => new { Id = p.Id, Name = p.Name, Address = p.Address, DOB = p.DOB, Phone = p.Phone, Gender = p.Gender }).ToList();
            dataGridView1.DataSource = patientData;
        }

        private void PatientPage_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void addbtn_Click(object sender, EventArgs e)
        {
            ptn.Name = textBoxPName.Text;
            ptn.Address = textBoxPAddress.Text;
            ptn.Phone = textBoxPPhone.Text;
            ptn.Gender = comboBoxPGender.Text;
            ptn.DOB = dateTimePickerPDOB.Value;

            db.Patient.Add(ptn);
            db.SaveChanges();
            GetData();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Index != -1)
            {
                ptn.Id = Convert.ToInt32(dataGridView1.CurrentRow.Cells["Id"].Value);
                ptn = db.Patient.Where(a => a.Id == ptn.Id).FirstOrDefault();
                textBoxPName.Text = ptn.Name;
                textBoxPAddress.Text = ptn.Address;
                textBoxPPhone.Text = ptn.Phone;
                comboBoxPGender.Text = ptn.Gender;
                dateTimePickerPDOB.Value = ptn.DOB;
            }
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            ptn.Name = textBoxPName.Text;
            ptn.Address = textBoxPAddress.Text;
            ptn.Phone = textBoxPPhone.Text;
            ptn.Gender = comboBoxPGender.Text;
            ptn.DOB = dateTimePickerPDOB.Value;

            db.Entry(ptn).State = EntityState.Modified;
            db.SaveChanges();
            GetData();
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            var data = db.Entry(ptn);
            if (data.State == EntityState.Detached)
                db.Patient.Attach(ptn);
            db.Patient.Remove(ptn);
            db.SaveChanges();
            GetData();

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            string SearchName = textBoxPName.Text;
            var SearchResult = db.Patient.Where(a => a.Name.Contains(SearchName))
                .Select(p => new { Id = p.Id, Name = p.Name, Address = p.Address, DOB = p.DOB, Phone = p.Phone, Gender = p.Gender })
                .ToList();

            dataGridView1.DataSource = SearchResult;
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            this.Close();

        }


        private void label3_Click(object sender, EventArgs e)
        { }
        private void label10_Click(object sender, EventArgs e)
        { }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        { }

    }
}
