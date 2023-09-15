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
    public partial class PatientRegistration : Form
    {
        public PatientRegistration()
        {
            InitializeComponent();
            cmbsearch.Items.Clear();
            cmbsearch.Items.Add("NIC");
            cmbsearch.Items.Add("Name");
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

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();

            patient.Contact = txtcontact.Text.Trim();
            patient.Email = txtemail.Text.Trim();
            patient.Nic = txtnic.Text.Trim();
            patient.Age = int.Parse(txtage.Text.Trim());
            patient.Patientfname = txtpatientname.Text.Trim();
            patient.Bloodgroup = txtbloodgrp.Text.Trim();
            patient.Address = txtaddress.Text.Trim();


            if (patient.savePatient(patient))
            {
                MessageBox.Show("Patient Registraion success!!");
                clearFields();
                InterfaceManager.showPatientRegistration();
            }
            else
            {
                MessageBox.Show("Unable to save the patient! Please Try again", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearFields();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string searchField = cmbsearch.Text.Trim();
            string searchValue = txtsearchval.Text.Trim();

            Patient patient = new Patient();

            DataTable patientData = patient.searchPatientByCriterias(searchField, searchValue);

            dataGridView.DataSource = patientData;

        }

        private void clearFields()
        {
            txtaddress.Clear();
            txtcontact.Clear();
            txtemail.Clear();
            txtpatientname.Clear();
            txtnic.Clear();
            txtbloodgrp.Clear();
            txtage.Clear();
            txtsearchval.Clear();
        }

        private void PatientRegistration_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormHandler.ReleaseCapture();
                FormHandler.SendMessage(Handle, FormHandler.WM_NCLBUTTONDOWN, FormHandler.HT_CAPTION, 0);
            }
        }
    }
}
