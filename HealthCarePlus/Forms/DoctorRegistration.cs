using HealthCarePlus.Database;
using HealthCarePlus.Helpers;
using HealthCarePlus.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus.Forms
{
    public partial class DoctorRegistration : Form
    {
        public DoctorRegistration()
        {
            InitializeComponent();
            cmbSearch.Items.Clear();
            cmbSearch.Items.Add("NIC");
            cmbSearch.Items.Add("Name");
            cmbSearch.Items.Add("Specialization");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you really want to exit?", "HealthCare Plus", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            InterfaceManager.showAdminDashboard();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            Doctor doctor = new Doctor();
            doctor.Contact=txtdoccontact.Text.Trim();
            doctor.Email=txtdocemail.Text.Trim();
            doctor.Nic=txtdocnic.Text.Trim();
            doctor.Qualification=txtqualification.Text.Trim();
            doctor.Location=txtlocation.Text.Trim();
            doctor.Address=txtdocaddress.Text.Trim();
            doctor.Specialization=txtspecialz.Text.Trim();
            doctor.Doctorfname=txtdocname.Text.Trim();
            doctor.Expertice=txtexpertice.Text.Trim();


            if (doctor.saveDoctor(doctor))
            {
                MessageBox.Show("Doctor Registraion success!!");
                clearFields();
                InterfaceManager.showDoctorRegistration();
            }
            else
            {
                MessageBox.Show("Unable to save the doctror! Please Try again" , "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearFields();
            }

        }

        private void clearFields()
        {
            txtdocaddress.Clear();
            txtdoccontact.Clear();
            txtdocemail.Clear();
            txtdocname.Clear();
            txtdocnic.Clear();
            txtexpertice.Clear();
            txtlocation.Clear();
            txtqualification.Clear();
            txtspecialz.Clear();
            txtdoctorid.Clear();
        }

        private void btnmodifysearch_Click(object sender, EventArgs e)
        {
            int doctorid = 0;

            //validate id
            if (txtdoctorid.Text.Trim().Equals(""))
            {
                txtdoctorid.Focus();
                return;
            }

            //try to convert in to integer
            if (!int.TryParse(txtdoctorid.Text.Trim(), out doctorid))
            {   //if the conversion is not successfull
                txtdoctorid.Focus();
                txtdoctorid.SelectAll();
                return;
            }
            

            Doctor doctor = new Doctor();
            doctor = doctor.searchDoctor(doctorid);

            if (doctor != null && doctor.Doctorid!=0)
            {
                txtdoccontactu.Text = doctor.Contact;
                txtdocemailu.Text = doctor.Email;
                txtqualificationu.Text = doctor.Qualification;
                txtlocationu.Text = doctor.Location;
                txtdocaddressu.Text = doctor.Address;
                txtspecialzu.Text = doctor.Specialization;
                txtdocnameu.Text = doctor.Doctorfname;
                txtexperticeu.Text = doctor.Expertice;
            }
            else
            {
                MessageBox.Show("Unable find the doctror! Please Try again", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                clearFields();
                clearSearchFields();
            }          
        }

        private void clearSearchFields()
        {
            txtdocaddressu.Clear();
            txtdoccontactu.Clear();
            txtdocemailu.Clear();
            txtdocnameu.Clear();
            txtexperticeu.Clear();
            txtlocationu.Clear();
            txtqualificationu.Clear();
            txtspecialzu.Clear();
            txtdoctorid.Clear();
            txtGridSearch.Clear();
        }

        private void btnGridSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string searchCriteria = cmbSearch.Text.Trim();
                string searchField = txtGridSearch.Text.Trim();

                Doctor doctor = new Doctor();

                DataTable doctorData = doctor.searchDoctorByCriterias(searchCriteria, searchField);

                dataGridView.DataSource = doctorData;

            }catch (Exception ex)
            {
                MessageBox.Show("Error occured while processing!! try again!!");
            }
        }

        private void btnschclear_Click(object sender, EventArgs e)
        {
            clearSearchFields();
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            int doctorid = 0;

            //validate id
            if (txtdoctorid.Text.Equals(""))
            {
                txtdoctorid.Focus();
                return;
            }

            //try to convert in to integer
            if (!int.TryParse(txtdoctorid.Text.Trim(), out doctorid))
            {   //if the conversion is not successfull
                txtdoctorid.Focus();
                txtdoctorid.SelectAll();
                return;
            }

            Doctor doctor = new Doctor();
            doctor.Doctorid = doctorid;
            doctor.Contact = txtdoccontactu.Text.Trim();
            doctor.Email = txtdocemailu.Text.Trim();
            doctor.Qualification = txtqualificationu.Text.Trim();
            doctor.Location = txtlocationu.Text.Trim();
            doctor.Address = txtdocaddressu.Text.Trim();
            doctor.Specialization = txtspecialzu.Text.Trim();
            doctor.Doctorfname = txtdocnameu.Text.Trim();
            doctor.Expertice = txtexperticeu.Text.Trim();

            try
            {
                if (doctor.updateDoctor(doctor))
                {
                    MessageBox.Show("Successfully Updated!");
                    clearSearchFields();
                }
                else
                {
                    MessageBox.Show("Error occured while updating the records");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while processing!! try again!!");
            }

        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try 
            {
                Doctor doctor = new Doctor();
                int doctorid = 0;

                //validate id
                if (txtdoctorid.Text.Equals(""))
                {
                    txtdoctorid.Focus();
                    return;
                }

                //try to convert in to integer
                if (!int.TryParse(txtdoctorid.Text.Trim(), out doctorid))
                {   //if the conversion is not successfull
                    txtdoctorid.Focus();
                    txtdoctorid.SelectAll();
                    return;
                }

                DialogResult x = MessageBox.Show("Do you wnat to delete the user?", "Confirm!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (x == DialogResult.Yes)
                {
                    if (doctor.deleteDoctor(doctorid))
                    {
                        MessageBox.Show("Successfully deleted!");
                        clearSearchFields();
                    }
                    else
                    {
                        MessageBox.Show("Error occured while deleting the records");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while processing!! try again!!");
            }

        }

        private void DoctorRegistration_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormHandler.ReleaseCapture();
                FormHandler.SendMessage(Handle, FormHandler.WM_NCLBUTTONDOWN, FormHandler.HT_CAPTION, 0);
            }
        }
    }
}
