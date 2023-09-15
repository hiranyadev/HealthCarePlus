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
    public partial class StaffMemberAuthorization : Form
    {
        int staffMemberid = 0;

        public StaffMemberAuthorization()
        {
            InitializeComponent();

            cmbRole.Items.Clear();
            cmbRole.Items.Add("ADMIN");
            cmbRole.Items.Add("STAFF");
            cmbRole.Items.Add("CASHIER");

        }

        private void btnAuthorization_Click(object sender, EventArgs e)
        {
            try
            {
                string role = cmbRole.SelectedItem.ToString();

                StaffMember staffMember = new StaffMember();

                if (staffMember.authoriceStaffMember(role, staffMemberid))
                {
                    MessageBox.Show("Successfully Authorization!");
                    clearSearchFields();
                }
                else
                {
                    MessageBox.Show("Error occured while Authorization");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void clearSearchFields()
        {
            throw new NotImplementedException();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            string nic = txtnic.Text.Trim();

            if(nic == null && nic == "")
                txtnic.Focus();

            try
            {
                StaffMember staffMember = new StaffMember();

                staffMember = staffMember.searchByNic(nic);

                txtfname.Text = staffMember.Fname;
                txtaddress.Text = staffMember.Address;
                txtcontact.Text = staffMember.Contact;
                txtemail.Text = staffMember.Email;
                txtjoindate.Text = staffMember.Joindate;
                staffMemberid = staffMember.Memberid;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void StaffMemberAuthorization_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormHandler.ReleaseCapture();
                FormHandler.SendMessage(Handle, FormHandler.WM_NCLBUTTONDOWN, FormHandler.HT_CAPTION, 0);
            }
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
    }
}
