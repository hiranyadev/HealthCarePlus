using crypto;
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
    public partial class StaffMemberRegistration : Form
    {
        public StaffMemberRegistration()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            string fname = txtfname.Text.Trim();
            string contact = txtcontact.Text.Trim();
            string email = txtemail.Text.Trim();
            string address = txtaddress.Text.Trim();
            string age = txtage.Text.Trim();
            string nic = txttnic.Text.Trim();
            string username = txtusername.Text.Trim();
            string password = txtpassword.Text.Trim();

            if (fname == null || fname.Equals(""))
            {
                txtfname.Focus();
                return;
            }
            if (contact == null || contact.Equals(""))
            {
                txtcontact.Focus();
                return;
            }
            if (email == null || email.Equals(""))
            {
                txtemail.Focus();
                return;
            }
            if (address == null || address.Equals(""))
            {
                txtaddress.Focus();
                return;
            }
            if (age == null || age.Equals(""))
            {
                txtage.Focus();
                return;
            }
            if (nic == null || nic.Equals(""))
            {
                txttnic.Focus();
                return;
            }
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

            string pswHashFromUser = HashingEncription.getPasswordHash(password);

            StaffMember staffMember = new StaffMember();

            staffMember.Fname = txtfname.Text.Trim();
            staffMember.Contact = txtcontact.Text.Trim();
            staffMember.Email = txtemail.Text.Trim();
            staffMember.Address = txtaddress.Text.Trim();
            staffMember.Age = Convert.ToInt32(txtage.Text.Trim());
            staffMember.Nic = txttnic.Text.Trim();
            staffMember.Username = txtusername.Text.Trim();
            staffMember.Password = pswHashFromUser;

            if (staffMember.saveStaffMember(staffMember))
            {
                MessageBox.Show("Member Registraion success!!");
                clearFields();
                InterfaceManager.showLogin();
            }
            else
            {
                MessageBox.Show("Unable to save the memner!", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearFields();
            }

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clearFields();
        }

        private void clearFields()
        {
            txtfname.Clear();
            txtcontact.Clear();
            txtemail.Clear();
            txtaddress.Clear();
            txtpassword.Clear();
            txtusername.Clear();
            txtage.Clear();
            txttnic.Clear();
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

        private void StaffMemberRegistration_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormHandler.ReleaseCapture();
                FormHandler.SendMessage(Handle, FormHandler.WM_NCLBUTTONDOWN, FormHandler.HT_CAPTION, 0);
            }
        }
    }
}
