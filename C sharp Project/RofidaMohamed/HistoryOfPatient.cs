using C_sharp_Project.EmanMetwallyElgharabawy;
using C_sharp_Project.YoussifMohamed.Model.Database;
using C_sharp_Project.YoussifMohamed.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_Project.RofidaMohamed
{
    public partial class HistoryOfPatient : Form
    {
        ClinicDB db = new ClinicDB();
        public HistoryOfPatient()
        {
            InitializeComponent();
        }

        private void load()
        {
            var history = db.Doctorspatient
                .OrderBy(h => h.Patient.Name)
                .Select(
                    h => new
                    {
                        Patient = h.Patient.Name,
                        Doctor = h.Doctor.Name,
                        majoring = h.Doctor.Specialization,
                        Medicine = h.Medicine,
                        Diagons = h.Diagnosis
                    }
                ).ToList();

            dataGridView1.DataSource = history;
        }

        private void HistoryOfPatient_Load(object sender, EventArgs e)
        {
            load();
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string str = searchBox.Text;
            var history = db.Doctorspatient
                .OrderBy(h => h.Patient.Name)
                .Where(h => h.Patient.Name.StartsWith(str))
                .Select(
                    h => new
                    {
                        Patient = h.Patient.Name,
                        Doctor = h.Doctor.Name,
                        majoring = h.Doctor.Specialization,
                        Medicine = h.Medicine,
                        Diagons = h.Diagnosis
                    }
                ).ToList();

            dataGridView1.DataSource = history;

        }

        private void label2_Click(object sender, EventArgs e)
        {
            drDash f = new drDash();

            f.Show();

            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PatientVisitPagecs f = new PatientVisitPagecs();

            f.Show();

            this.Hide();
        }
    }
}
