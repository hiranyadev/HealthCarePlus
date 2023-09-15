using HealthCarePlus.Database;
using HealthCarePlus.Helpers;
using HealthCarePlus.Models;
using MySql.Data.MySqlClient;
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
    public partial class PatientManagement : Form
    {
        private int appointmentid = 0;
        private int patientId = 0;

        public PatientManagement()
        {
            InitializeComponent();

            cmbsearchby.Items.Clear();
            cmbsearchby.Items.Add(string.Empty);
            cmbsearchby.Items.Add("NIC");
            cmbsearchby.Items.Add("Appointment");

            List<LabTestCategory> allDocList = new List<LabTestCategory>();

            string sql = "SELECT labtest_categoryId, description FROM labtest_category ";

            MySqlConnection con = DBConnection.getConnection();

            if (con.State != ConnectionState.Open)
                con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            try
            {
                while (sdr.Read())
                {
                    LabTestCategory newtest = new LabTestCategory();
                    newtest.LabtestId = sdr.GetInt32(0);
                    newtest.Description = sdr.GetString(1);
                    allDocList.Add(newtest);
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }

            allDocList.Insert(0, new LabTestCategory());

            cmblabtests.DataSource = allDocList;
            cmblabtests.ValueMember = "labtestId";
            cmblabtests.DisplayMember = "description";
            cmblabtests.Text = "Select Lab Test";
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

        private void PatientManagement_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormHandler.ReleaseCapture();
                FormHandler.SendMessage(Handle, FormHandler.WM_NCLBUTTONDOWN, FormHandler.HT_CAPTION, 0);
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchCriteria = cmbsearchby.Text.Trim();
            string searchValue = txtappointment.Text.Trim();
            List<string> searchedData = new List<string>();
            Patient patientData = new Patient(); 

            try
            {
                if(searchCriteria!=null && searchCriteria!="" && searchValue != null && searchValue != "")
                {
                    searchedData = patientData.searchPatientManagemetDataByCriterias(searchCriteria, searchValue);

                    if(searchedData.Count > 0)
                    {
                        txtappointno.Text = searchedData[0];
                        txtpatientname.Text = searchedData[1];
                        txtage.Text = searchedData[2];
                        txtbloodgrp.Text = searchedData[3];
                        appointmentid = int.Parse(searchedData[4]);
                        patientId = int.Parse(searchedData[5]);
                        getGridData(int.Parse(searchedData[5]));
                    }
                    else
                    {
                        MessageBox.Show("There are no reletaed records!!");
                    }

                }
                else
                {
                    txtappointment.Focus();
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnlabtest_Click(object sender, EventArgs e)
        {
            string labtestCat = cmblabtests.GetItemText(cmblabtests.SelectedValue);

            if (labtestCat == null && labtestCat == "")
                cmblabtests.Focus();

            try
            {
                LabResults labResults = new LabResults();

                labResults.LabTestId = int.Parse(labtestCat);
                labResults.Symptom = txtsymp.Text.Trim();
                labResults.Results = txtresult.Text.Trim();
                labResults.AppointmentId = appointmentid;

                if (labResults.saveLabResult(labResults))
                {
                    MessageBox.Show("Lab Results successfully Added!!");
                    clearlabTest();
                    getGridData(patientId);
                }
                else
                {
                    MessageBox.Show("Unable to Add the Lab Results! Please Try again!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnaddpatientmed_Click(object sender, EventArgs e)
        {
            try
            {
                MedicalRecords medicalRecords = new MedicalRecords();

                medicalRecords.Dignosis = txtdiagnosis.Text.Trim();
                medicalRecords.Symptoms = txtpatientsymp.Text.Trim();
                medicalRecords.Prescriptions = txtprescription.Text.Trim();
                medicalRecords.Appointmentid = appointmentid;

                if (medicalRecords.saveMedicalRecords(medicalRecords))
                {
                    MessageBox.Show("Medical Record successfully Added!!");
                    clearDiagnosis();
                    getGridData(patientId);
                }
                else
                {
                    MessageBox.Show("Unable to Add the Medical Record! Please Try again!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnlabclear_Click(object sender, EventArgs e)
        {
            clearlabTest();
        }

        private void btnpatientclear_Click(object sender, EventArgs e)
        {
            clearDiagnosis();
        }

        private void getGridData(int patientid)
        {
            try
            {
                if(appointmentid > 0 && patientid > 0)
                {
                    MedicalRecords medicalHistory = new MedicalRecords();

                    DataTable medicalHistoryData = medicalHistory.getMedicalHistoryByPatient(patientid);

                    dataGridView.DataSource = medicalHistoryData;

                }
                else
                {
                    dataGridView.DataSource = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void clearlabTest()
        {
            cmblabtests.Text = "Select Lab Test";
            txtsymp.Clear();
            txtresult.Clear();
        }

        private void clearDiagnosis()
        {
            txtdiagnosis.Clear();
            txtpatientsymp.Clear();
            txtprescription.Clear();
        }
    }
}
