using HealthCarePlus.Database;
using HealthCarePlus.Helpers;
using HealthCarePlus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus.Forms
{
    public partial class MedicationManagement : Form
    {
        DBConnection databaseConnection = new DBConnection();

        public MedicationManagement()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            InterfaceManager.showAdminDashboard();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "HealthCare Plus", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void MedicationManagement_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormHandler.ReleaseCapture();
                FormHandler.SendMessage(Handle, FormHandler.WM_NCLBUTTONDOWN, FormHandler.HT_CAPTION, 0);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string appointmentnumber = txtappointment.Text.Trim();

            if (appointmentnumber == null && appointmentnumber == "")
            {
                txtappointment.Focus();
            }

            try
            {
                List<string> searchedData = new List<string>();
                Patient patientData = new Patient();

                searchedData = patientData.searchPatientManagemetDataByCriterias("Appointment", appointmentnumber);

                if (searchedData.Count > 0)
                {
                    txtappointno.Text = searchedData[0];
                    txtpatientname.Text = searchedData[1];
                    txtage.Text = searchedData[2];
                    txtbloodgrp.Text = searchedData[3];
                    getLabResults(int.Parse(searchedData[4]));
                    getPrescriptions(int.Parse(searchedData[4]));

                }
                else
                {
                    MessageBox.Show("There are no reletaed records!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }

        }

        private void getLabResults(int appointmentid)
        {
            try
            {
                if (appointmentid > 0)
                {
                    LabResults LabResults = new LabResults();

                    DataTable LabResultsData = LabResults.getMedicalHistoryByAppointment(appointmentid);

                    dataGridView1.DataSource = LabResultsData;

                }
                else
                {
                    dataGridView1.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void getPrescriptions(int appointmentid)
        {
            try
            {
                if (appointmentid > 0)
                {
                    MedicalRecords medicalRecords = new MedicalRecords();

                    DataTable medicalHistoryData = medicalRecords.getMedicalHistoryByAppointment(appointmentid);

                    dataGridView2.DataSource = medicalHistoryData;

                }
                else
                {
                    dataGridView2.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }
    }
}
