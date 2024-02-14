using C_sharp_Project.EmanMetwallyElgharabawy;
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

namespace C_sharp_Project.RofidaMohamed
{
    public partial class drDash : Form
    {
        ClinicDB db = new ClinicDB();
        int DoctorId = 17;
        public drDash()
        {
            InitializeComponent();
        }

        private void load()
        {
            var list = db.ReciptionAddPatientDoc
               .Where(r => r.Appointment.Date == DateTime.Now.Date && r.DoctorID == DoctorId)
               .OrderBy(r => r.Appointment)
               .Select(
                   res => new
                   {
                       Patient = res.Patient.Name,
                       Time = res.Appointment.ToString("t"),
                       State = res.State == true ? "Done" : res.Appointment > DateTime.Now ? "Waiting" : "Missed"
                   }
               ).ToList();

            dataGridView1.DataSource = list;

            var wait = db.ReciptionAddPatientDoc.Where(r => r.Appointment.Date == DateTime.Now.Date && r.State == false && r.DoctorID == DoctorId).ToList();

            int allNo = list.Count;
            int waitNo = wait.Count;
            int doneNo = list.Count - wait.Count;

            //lable

            allLabel.Text = allNo.ToString();
            waitLabel.Text = waitNo.ToString();
            DoneLabel.Text = doneNo.ToString();

            //progress bar
            progressBar1.Maximum = allNo;
            progressBar1.Value = doneNo;
            perclabel.Text = $"{((double)doneNo / allNo) * 100}%";

            //search part
            searchBox.Focus();
            searchBox.Text = string.Empty;

        }

        private void drDash_Load(object sender, EventArgs e)
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
            var reservations = db.ReciptionAddPatientDoc
                        .OrderBy(res => res.Appointment)
                        .Where(R => R.Patient.Name.StartsWith(str) && R.Appointment.Date == DateTime.Now.Date && R.DoctorID == DoctorId)
                        .Select(
                        res => new
                        {

                            Patient = res.Patient.Name,
                            Doctor = res.Doctor.Name,

                            Time = res.Appointment.ToString("t"),
                            Price = res.Price.ToString() + " $",
                            State = res.State == true ? "Done" : res.Appointment > DateTime.Now ? "Waiting" : "Missed"

                        }
                        ).ToList();

            dataGridView1.DataSource = reservations;
        }

        private void label4_Click(object sender, EventArgs e)
        {
            PatientVisitPagecs f = new PatientVisitPagecs();

            f.Show();
            this.Hide();

        }

        private void label1_Click(object sender, EventArgs e)
        {
            HistoryOfPatient f = new HistoryOfPatient();

            f.Show();
            this.Hide();
        }
    }
}
