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
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus.Forms
{
    public partial class ResourcesManagment : Form
    {
        bool cmdocinst = false;

        public ResourcesManagment()
        {
            InitializeComponent();
            onLoardResources();
            onLoadCategory();
            gidOnLoad();


        }

        private void onLoadCategory()
        {
            List<ResourcesCategory> allResList = new List<ResourcesCategory>();

            string sql = "SELECT resources_categoryid, description FROM resources_category ";

            MySqlConnection con = DBConnection.getConnection();

            if (con.State != ConnectionState.Open)
                con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            try
            {
                while (sdr.Read())
                {
                    ResourcesCategory newres = new ResourcesCategory();
                    newres.ResourcesCategoryId = sdr.GetInt32(0);
                    newres.ResourcesCategoryDescr = sdr.GetString(1);
                    allResList.Add(newres);
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }

            allResList.Insert(0, new ResourcesCategory());

            cmbResCat.DataSource = allResList;
            cmbResCat.ValueMember = "resourcesCategoryId";
            cmbResCat.DisplayMember = "resourcesCategoryDescr";
            cmbResCat.Text = "Select Resource Category";
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

        private void ResourcesManagment_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormHandler.ReleaseCapture();
                FormHandler.SendMessage(Handle, FormHandler.WM_NCLBUTTONDOWN, FormHandler.HT_CAPTION, 0);
            }
        }

        private void btnAddLabTest_Click(object sender, EventArgs e)
        {
            LabTestCategory labTestCategory = new LabTestCategory();
            labTestCategory.LabtestCode = txttestCode.Text.Trim();
            labTestCategory.Description = txtDescr.Text.Trim();
            labTestCategory.OtherDescription = txtOthers.Text.Trim();

            try
            {
                if (labTestCategory.saveLabTestCategory(labTestCategory))
                {
                    MessageBox.Show("Successfully Added Lab Test Category!");
                    labTestClear();
                }
                else
                {
                    MessageBox.Show("Failed to Add Lab Test Category!");
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Error occured while processing!! try again!!");
            }
        }

        private void btnResAdd_Click(object sender, EventArgs e)
        {
            ResourcesCategory resourcesCategory = new ResourcesCategory();
            resourcesCategory.ResourcesCategoryCode = txtresCode.Text.Trim();
            resourcesCategory.ResourcesCategoryDescr = txtResDescr.Text.Trim();
            resourcesCategory.ResourcesCategoryOthers = txtresOthers.Text.Trim();

            try
            {
                if (resourcesCategory.saveResourcesCategory(resourcesCategory))
                {
                    MessageBox.Show("Successfully Added Resources Category!");
                    resCatClear();
                    gidOnLoad();
                }
                else
                {
                    MessageBox.Show("Failed to Add Resources Category!");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while processing!! try again!!");
            }
        }

        private void resCatClear()
        {
            txtresCode.Clear();
            txtResDescr.Clear();
            txtresOthers.Clear();
        }

        private void labTestClear()
        {
            txttestCode.Clear();
            txtDescr.Clear();
            txtOthers.Clear();
        }

        private void btnlabtstClear_Click(object sender, EventArgs e)
        {
            labTestClear();
        }

        private void btnResClear_Click(object sender, EventArgs e)
        {
            resCatClear();
        }

        private void btnresoSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                ResourcesManager resourcesManager = new ResourcesManager();
                resourcesManager.Resources_categoryid = int.Parse(cmbResCat.GetItemText(cmbResCat.SelectedValue));
                resourcesManager.Type = txtType.Text.Trim();
                resourcesManager.Brand = txtBrand.Text.Trim();
                resourcesManager.Userbility = txtUserbility.Text.Trim();
                resourcesManager.Count = int.Parse(txtCount.Text.Trim());
                resourcesManager.Others = txtAdresothers.Text.Trim();

                if (resourcesManager.saveResources(resourcesManager))
                {
                    MessageBox.Show("Successfully Added Resources!");
                    resourceClear();
                    gidOnLoad();
                    onLoardResources();
                }
                else
                {
                    MessageBox.Show("Failed to Add Resources !");
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while processing!! try again!!");
            }
        }

        private void btnresoUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                ResourcesManager resourcesManager = new ResourcesManager();
                resourcesManager.Resources_categoryid = int.Parse(cmbResCat.GetItemText(cmbResCat.SelectedValue));
                resourcesManager.Type = txtType.Text.Trim();
                resourcesManager.Brand = txtBrand.Text.Trim();
                resourcesManager.Userbility = txtUserbility.Text.Trim();
                resourcesManager.Count = int.Parse(txtCount.Text.Trim());
                resourcesManager.Others = txtAdresothers.Text.Trim();
                resourcesManager.Resources_managerId = int.Parse(cmbUpdateres.GetItemText(cmbUpdateres.SelectedValue));


                if (resourcesManager.updateResources(resourcesManager))
                {
                    resourceClear();
                    gidOnLoad();
                    MessageBox.Show("Channel successfully Updated!!");
                }
                else
                {
                    MessageBox.Show("Updating Process Failed !!");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
}

        private void btnresoClear_Click(object sender, EventArgs e)
        {
            resourceClear();
        }

        private void resourceClear()
        {
            txtType.Clear();
            txtBrand.Clear();
            txtUserbility.Clear();
            txtCount.Clear();
            txtAdresothers.Clear();
        }

        private void onLoardResources()
        {
            List<ResourcesManager> allResourcesList = new List<ResourcesManager>();

            string sql = "SELECT rr.resources_managerId, rr.type, rr.brand, " +
                "(SELECT rc.description FROM resources_category rc WHERE rc.resources_categoryid = rr.resources_categoryid) " +
                "FROM resources_manager rr ";

            MySqlConnection con = DBConnection.getConnection();

            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            try
            {
                while (sdr.Read())
                {
                    ResourcesManager newres = new ResourcesManager();
                    newres.Resources_managerId = sdr.GetInt32(0);
                    newres.Others = sdr.GetString(1)+" - "+ sdr.GetString(2)+" - "+ sdr.GetString(3);
                    allResourcesList.Add(newres);
                }

                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }

            allResourcesList.Insert(0, new ResourcesManager());

            cmbUpdateres.DataSource = allResourcesList;
            cmbUpdateres.ValueMember = "resources_managerId";
            cmbUpdateres.DisplayMember = "others";
            cmbUpdateres.Text = "Select Resources only for Update";
        }

        private void gidOnLoad()
        {
            try
            {
                ResourcesManager resourcesManager = new ResourcesManager();

                DataTable resourcesListData = resourcesManager.getAllAvailableDataList();

                dataGridView.DataSource = resourcesListData;

            }
            catch (Exception ex)
            {
                dataGridView.DataSource = null;
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnresoClear_Click_1(object sender, EventArgs e)
        {
            resourceClear();
        }

        private void cmbUpdateres_SelectedValueChanged(object sender, EventArgs e)
        {
            updateDataLoad();
        }

        private void updateDataLoad()
        {
            if (cmdocinst)
            {
                ResourcesManager resourcesManager = new ResourcesManager();

                resourcesManager.Resources_managerId = int.Parse(cmbUpdateres.GetItemText(cmbUpdateres.SelectedValue));

                if (resourcesManager.Resources_managerId > 0)
                {
                    try
                    {
                        resourcesManager = resourcesManager.getResourcesById(resourcesManager);

                        if (resourcesManager != null)
                        {
                            txtType.Text = resourcesManager.Type;
                            txtBrand.Text = resourcesManager.Brand;
                            txtUserbility.Text = resourcesManager.Userbility;

                            string xcount = ""+resourcesManager.Count;
                            txtCount.Text = xcount;
                            txtAdresothers.Text = resourcesManager.Others;
                        }
                        else
                        {
                            MessageBox.Show("This Resources Does not Exist in the system!!");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
                    }
                }
            }
            else
            {
                cmdocinst = true;
            }
        }

    }
}
