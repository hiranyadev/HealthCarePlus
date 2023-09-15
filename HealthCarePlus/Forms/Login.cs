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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            InterfaceManager.setLogin(this);
            AdminDashboard.userConfigeration = "";
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            userLogin();
        }

        private void btnregister_Click(object sender, EventArgs e)
        {
            InterfaceManager.showStaffMemberRegistration();
        }

        private void btnclose_Click(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                DialogResult result = MessageBox.Show("Do you really want to exit?", "Dialog Title", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Environment.Exit(0);
                }
                else
                {
                    e.Cancel = true;
                }
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "HealthCare Plus", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormHandler.ReleaseCapture();
                FormHandler.SendMessage(Handle, FormHandler.WM_NCLBUTTONDOWN, FormHandler.HT_CAPTION, 0);
            }
        }

        private void userLogin()
        {
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (username == null || username.Equals(""))
            {
                txtusername.Focus();
                return;
            }

            if (password == null || password.Equals(""))
            {
                txtpassword.Focus();
                return;
            }
            if (StaffMember.Authenticate(username, password))
            {
                MessageBox.Show("Login success!!");
                txtpassword.Clear();
                txtusername.Clear();
                AdminDashboard.userConfigeration = DBConnection.setUserConfig(username);
                InterfaceManager.showAdminDashboard();
            }
            else
            {
                MessageBox.Show("Invalid credentials!!");
                txtusername.SelectAll();
                txtusername.Focus();
                txtpassword.Clear();
            }
        }

        private void txtpassword_Enter(object sender, EventArgs e)
        {
            userLogin();
        }
    }
}
