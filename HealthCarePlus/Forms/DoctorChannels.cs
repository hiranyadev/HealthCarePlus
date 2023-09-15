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
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus.Forms
{
    public partial class DoctorChannels : Form
    {
        public DoctorChannels()
        {
            InitializeComponent();

            List<Doctor> allDocList = new List<Doctor>();

            string sql = "SELECT doctorId, fullname FROM doctor ";

            MySqlConnection con = DBConnection.getConnection();

            if (con.State != ConnectionState.Open)
                con.Open();
            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            try
            {
                while (sdr.Read())
                {
                    Doctor newdoctor = new Doctor();
                    newdoctor.Doctorid = sdr.GetInt32(0);
                    newdoctor.Doctorfname = sdr.GetString(1);
                    allDocList.Add(newdoctor);
                }
                sdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }

            allDocList.Insert(0, new Doctor());
            
            cmbaddoctor.DataSource = allDocList;
            cmbaddoctor.ValueMember = "doctorid";
            cmbaddoctor.DisplayMember = "doctorfname";
            cmbaddoctor.Text = "Select Doctor";

            cmbredoctor.DataSource = allDocList;
            cmbredoctor.ValueMember = "doctorid";
            cmbredoctor.DisplayMember = "doctorfname";
            cmbredoctor.Text = "Select Doctor";

            cmbcaldoctor.DataSource = allDocList;
            cmbcaldoctor.ValueMember = "doctorid";
            cmbcaldoctor.DisplayMember = "doctorfname";
            cmbcaldoctor.Text = "Select Doctor";

            cmbviewsearch.DataSource = allDocList;
            cmbviewsearch.ValueMember = "doctorid";
            cmbviewsearch.DisplayMember = "doctorfname";
            cmbviewsearch.Text = "Select Doctor";

            for (int i = 1; i <= 10; i++)
            {
                cmbadroom.Items.Add(i.ToString());
                cmbreroom.Items.Add(i.ToString());
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

        private void btnaddcannel_Click(object sender, EventArgs e)
        {
            try
            {
                Channels channel = new Channels();

                channel.Roomnumber = cmbadroom.GetItemText(cmbadroom.Text);
                channel.ChannelDate = dtaddate.Text;
                channel.DoctorId = int.Parse(cmbaddoctor.GetItemText(cmbaddoctor.SelectedValue));
                channel.Channelfee = int.Parse(txtFee.Text.Trim());


                if (channel.addChannel(channel))
                {
                    MessageBox.Show("New Channel successfully Added!!");
                    //clearFields();
                    InterfaceManager.showPatientRegistration();
                }
                else
                {
                    MessageBox.Show("Unable to save the channel! Please Try again", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    clearFields();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }            
        }

        private void btnresearch_Click(object sender, EventArgs e)
        {
            try
            {
                Channels channels = new Channels();
                int searchField = int.Parse(cmbredoctor.GetItemText(cmbredoctor.SelectedValue));

                List<Channels> channelsList = channels.getAllActiveChannelsById(searchField);

                cmbrechannel.DataSource = channelsList;
                cmbrechannel.ValueMember = "channelId";
                cmbrechannel.DisplayMember = "roomnumber";
                cmbrechannel.Text = "Select Channels";

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnviewsearch_Click(object sender, EventArgs e)
        {
            try
            {
                int searchField = int.Parse(cmbviewsearch.GetItemText(cmbviewsearch.SelectedValue));

                Channels channelList = new Channels();

                DataTable channelListData = channelList.searchPatientByCriterias(searchField);

                dataGridView.DataSource = channelListData;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
            
        }

        public void clearFields()
        {
            //cmbaddoctor.Items.Clear();
            cmbadroom.Items.Clear();
            
            cmbrechannel.Items.Clear();
            //cmbredoctor.Items.Clear();
            cmbreroom.Items.Clear();

            cmbcalchannel.Items.Clear();
            cmbcaldoctor.Items.Clear();

            cmbviewsearch.Items.Clear();
        }

        private void btnResChannel_Click(object sender, EventArgs e)
        {
            try
            {
                Channels channels = new Channels();
                int resChannelId = int.Parse(cmbrechannel.GetItemText(cmbrechannel.SelectedValue));
                channels.ChannelId = resChannelId;
                channels.ChannelDate = dtredate.Text;
                channels.Roomnumber = cmbreroom.GetItemText(cmbreroom.Text);

                if (channels.rescheduleChannels(channels) != null)
                {
                    MessageBox.Show("Channel successfully Rescheduled!!");
                }
                else
                {
                    MessageBox.Show("Rescheduling Process Failed !!");
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btncalsearch_Click(object sender, EventArgs e)
        {
            try
            {
                Channels channels = new Channels();
                int searchField = int.Parse(cmbcaldoctor.GetItemText(cmbcaldoctor.SelectedValue));

                List<Channels> channelsList = channels.getAllActiveChannelsById(searchField);

                cmbcalchannel.DataSource = channelsList;
                cmbcalchannel.ValueMember = "channelId";
                cmbcalchannel.DisplayMember = "roomnumber";
                cmbcalchannel.Text = "Select Channels";

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void brnCanChaneel_Click(object sender, EventArgs e)
        {
            try
            {
                Channels channels = new Channels();
                int cancelChannelId = int.Parse(cmbrechannel.GetItemText(cmbrechannel.SelectedValue));
                channels.ChannelId = cancelChannelId;

                if (channels.cancelChannels(channels))
                {
                    MessageBox.Show("Channel successfully Canceled!!");
                }
                else
                {
                    MessageBox.Show("Canceling Process Failed !!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btncalclear_Click(object sender, EventArgs e)
        {

        }

        private void btnreclear_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {

        }

        private void DoctorChannels_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormHandler.ReleaseCapture();
                FormHandler.SendMessage(Handle, FormHandler.WM_NCLBUTTONDOWN, FormHandler.HT_CAPTION, 0);
            }
        }

    }
}
