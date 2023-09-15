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
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus.Forms
{
    public partial class AdminDashboard : Form
    {
        public static string role = "";
        public static string userConfigeration = "";

        public AdminDashboard()
        {
            InitializeComponent();

            lblAuthonticate.Text = userConfigeration;

        }

        private void btndocChannel_Click(object sender, EventArgs e)
        {
            if(role.Equals("ADMIN") || role.Equals("STAFF"))
                InterfaceManager.showDoctorChannels();
        }

        private void btnDocReg_Click(object sender, EventArgs e)
        {
            if (role.Equals("ADMIN") || role.Equals("STAFF"))
                InterfaceManager.showDoctorRegistration();
        }

        private void btnMediManage_Click(object sender, EventArgs e)
        {
            if (role.Equals("ADMIN") || role.Equals("STAFF"))
                InterfaceManager.showMedicalManagement();
        }

        private void btnptnManage_Click(object sender, EventArgs e)
        {
            if (role.Equals("ADMIN") || role.Equals("STAFF"))
                InterfaceManager.showPatientManagement();
        }

        private void btnptnAppoint_Click(object sender, EventArgs e)
        {
            if (role.Equals("ADMIN") || role.Equals("STAFF"))
                InterfaceManager.showPatientAppointments();
        }

        private void btnptnReg_Click(object sender, EventArgs e)
        {
            if (role.Equals("ADMIN") || role.Equals("STAFF"))
                InterfaceManager.showPatientRegistration();
        }

        private void btnresmanage_Click(object sender, EventArgs e)
        {
            if (role.Equals("ADMIN") || role.Equals("STAFF"))
                InterfaceManager.showResourcesManager();
        }

        private void btnRARbook_Click(object sender, EventArgs e)
        {
            if (role.Equals("ADMIN") || role.Equals("STAFF"))
                InterfaceManager.showRoomAndTheaters();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            if (role.Equals("ADMIN"))
                InterfaceManager.showReportsManagement();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            lblAuthonticate.Text = "";
            userConfigeration = "";
            InterfaceManager.showLogin();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "HealthCare Plus", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (role.Equals("ADMIN") || role.Equals("CASHIER"))
                InterfaceManager.showInvoice();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (role.Equals("ADMIN"))
                InterfaceManager.showStaffMemberRegistration();
        }

        private void AdminDashboard_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormHandler.ReleaseCapture();
                FormHandler.SendMessage(Handle, FormHandler.WM_NCLBUTTONDOWN, FormHandler.HT_CAPTION, 0);
            }
        }

        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            if (role.Equals("ADMIN"))
                InterfaceManager.showStaffMemberAuthorization();
        }

    }
}
