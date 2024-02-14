using C_sharp_Project.YoussifMohamed.Model.Database;
using C_sharp_Project.YoussifMohamed.Model.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace C_sharp_Project.RofidaMohamed
{
    public partial class RespDash : Form
    {
        ClinicDB db = new ClinicDB();

        public RespDash()
        {
            InitializeComponent();
            SelSearchbox.Items.Add("Doctor");
            SelSearchbox.Items.Add("Patient");
        }

        private void RespDash_Load(object sender, EventArgs e)
        {
            var list = db.ReciptionAddPatientDoc
                .Where(r => r.Appointment.Date == DateTime.Now.Date)
                .OrderBy(r => r.Appointment)
                .Select(
                    res => new
                    {
                        Patient = res.Patient.Name,
                        Doctor = res.Doctor.Name,
                        Time = res.Appointment.ToString("t"),
                        State = res.State == true ? "Done" : res.Appointment > DateTime.Now ? "Waiting" : "Missed"
                    }
                ).ToList();

            dataGridView1.DataSource = list;

            var wait = db.ReciptionAddPatientDoc.Where(r => r.Appointment.Date == DateTime.Now.Date && r.State == false).ToList();

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
            SelSearchbox.SelectedIndex = -1;


        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            string str = searchBox.Text;
            if (SelSearchbox.SelectedIndex == -1)
            {
                MessageBox.Show("Please Selected what Column Wanna to Search ");
            }
            else
            {
                string selectedColumn = SelSearchbox.SelectedItem.ToString();
                if (selectedColumn == "Doctor")
                {
                    var reservations = db.ReciptionAddPatientDoc
                        .OrderBy(res => res.Appointment)
                        .Where(R => R.Doctor.Name.StartsWith(str) && R.Appointment.Date == DateTime.Now.Date)
                        .Select(
                        res => new
                        {

                            Patient = res.Patient.Name,
                            Doctor = res.Doctor.Name,

                            Time = res.Appointment.ToString("t"),

                            State = res.State == true ? "Done" : res.Appointment > DateTime.Now ? "Waiting" : "Missed"

                        }
                        ).ToList();

                    dataGridView1.DataSource = reservations;


                }
                else if (selectedColumn == "Patient")
                {
                    var reservations = db.ReciptionAddPatientDoc
                        .OrderBy(res => res.Appointment)
                        .Where(R => R.Patient.Name.StartsWith(str) && R.Appointment.Date == DateTime.Now.Date)
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
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            ReservationRel f = new ReservationRel();

            f.Show();
            this.Hide();
        }
    }
}