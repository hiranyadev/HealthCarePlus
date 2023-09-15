using HealthCarePlus.Database;
using HealthCarePlus.Helpers;
using HealthCarePlus.Models;
using MySql.Data.MySqlClient;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus.Forms
{
    public partial class PatientAppoinments : Form
    {
        private static int patientId = 0;
        string curruntdate = DateTime.Now.ToString("yyyy-MM-dd");
        private Boolean cmdocinst = false;
        private Boolean chaninst = false;
        private Boolean resChannel = false;
        private int cancelAppointId = 0;
        private int resAppointId = 0;

        public PatientAppoinments()
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
                con.Close();
            }
            catch (Exception ex)
            {
                sdr.Close();
                con.Close();
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }

            allDocList.Insert(0, new Doctor());

            cmbDoctor.DataSource = allDocList;
            cmbDoctor.ValueMember = "doctorid";
            cmbDoctor.DisplayMember = "doctorfname";
            cmbDoctor.Text = "Select Doctor";


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

        private void btnClientSearch_Click(object sender, EventArgs e)
        {
            string clientNic = txtnicNo.Text.Trim();

            Appointment appointment = new Appointment();

            try
            {
                Patient patient = appointment.getPatientByNic(clientNic);

                if (patient.Patientfname != null && patient.Patientfname != "")
                {
                    txtclient.Text = patient.Patientfname;
                    patientId = patient.Patientid;
                }
                else
                {
                    MessageBox.Show("This Patient Does not Exist in the system!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while processing!! try again!!");
            }
        }

        private void cmbDoctor_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cmdocinst)
            {
                string docid = cmbDoctor.GetItemText(cmbDoctor.SelectedValue);

                if (docid != null && docid != "")
                {
                    try
                    {
                        int doctorId = int.Parse(docid);

                        List<Channels> channelsList = new List<Channels>();

                        string sql = "SELECT channelId, channelDate FROM channel_schedule WHERE channelStatus = 1 AND doctorId = " + doctorId + " " +
                            "AND channelDate >= '" + curruntdate + "'";

                        MySqlConnection con = DBConnection.getConnection();

                        if (con.State != ConnectionState.Open)
                            con.Open();

                        MySqlCommand cmd = new MySqlCommand(sql, con);
                        MySqlDataReader sdr = cmd.ExecuteReader();

                        while (sdr.Read())
                        {
                            Channels channels = new Channels();
                            channels.ChannelId = sdr.GetInt32(0);
                            channels.ChannelDate = sdr.GetString(1);
                            channelsList.Add(channels);
                        }

                        sdr.Close();
                        con.Close();

                        if (channelsList.Count()>0)
                        {
                            channelsList.Insert(0, new Channels());

                            cmbChannel.DataSource = channelsList;
                            cmbChannel.ValueMember = "channelId";
                            cmbChannel.DisplayMember = "channelDate";
                            cmbChannel.Text = "Select Channel";

                            chaninst = true;
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();
            appointment.AppointmentNumber = txtAppointNo.Text.Trim();
            appointment.SeatNumber = txtSeat.Text.Trim();
            appointment.ChannelId = int.Parse(cmbChannel.GetItemText(cmbChannel.SelectedValue));
            appointment.PatientId = patientId;

            try
            {
                if (appointment.makeAppointment(appointment))
                {
                    MessageBox.Show("New Appointment successfully Created!!");
                    addingPaneClear();
                    InterfaceManager.showPatientAppointments();
                }
                else
                {
                    MessageBox.Show("Unable to make appointment! Please Try again", "Error!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }

        }

        private string generateAppointmentNumber(int seat, int channel)
        {
            string newAppointmentNo = "00000";
            if(seat>9)
                newAppointmentNo = "0000";
            newAppointmentNo = string.Concat(newAppointmentNo, channel, seat);
            return newAppointmentNo;
        }

        private void cmbChannel_SelectedValueChanged(object sender, EventArgs e)
        {
            if (chaninst)
            {
                Appointment appointment = new Appointment();

                string channelid = cmbChannel.GetItemText(cmbChannel.SelectedValue);
                int channelId = int.Parse(channelid);

                if (channelid != null && channelid != "")
                {
                    try
                    {
                        int seat = appointment.getSeatNumberByChannelId(channelId);
                        txtSeat.Text = seat.ToString();
                        txtAppointNo.Text = generateAppointmentNumber(seat, channelId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
                    }
                }
            }
        }

        private void btnAddclear_Click(object sender, EventArgs e)
        {
            addingPaneClear();
        }

        private void addingPaneClear()
        {
            txtAppointNo.Clear();
            txtSeat.Clear();
            patientId = 0;
        }

        private void btnResAppoint_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();

            string appointNumber = txtenterAppointNo.Text.Trim();

            if (appointNumber == null || appointNumber.Equals(""))
            {
                txtenterAppointNo.Focus();
                return;
            }

            try
            {
                List<string> resValues = appointment.getAppointmentByAppointmentNo(appointNumber);

                txtresClient.Text = resValues[0];
                txtResDoctor.Text = resValues[5];
                txtOldChannel.Text = resValues[1];
                rescheduleDoctorChannels(resValues[2]);
                resAppointId = int.Parse(resValues[4]);

            }
            catch (Exception ex )
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void rescheduleDoctorChannels(string docid)
        {
            if (docid != null && docid != "")
            {
                try
                {
                    int doctorId = int.Parse(docid);

                    List<Channels> channelsList = new List<Channels>();

                    string sql = "SELECT channelId, channelDate FROM channel_schedule WHERE channelStatus = 1 AND doctorId = " + doctorId + " " +
                        "AND channelDate >= '" + curruntdate + "'";

                    MySqlConnection con = DBConnection.getConnection();

                    if (con.State != ConnectionState.Open)
                        con.Open();

                    MySqlCommand cmd = new MySqlCommand(sql, con);
                    MySqlDataReader sdr = cmd.ExecuteReader();

                    while (sdr.Read())
                    {
                        Channels channels = new Channels();
                        channels.ChannelId = sdr.GetInt32(0);
                        channels.ChannelDate = sdr.GetString(1);
                        channelsList.Add(channels);
                    }

                    sdr.Close();
                    con.Close();

                    if (channelsList.Count() > 0)
                    {
                        channelsList.Insert(0, new Channels());

                        cmbresChannel.DataSource = channelsList;
                        cmbresChannel.ValueMember = "channelId";
                        cmbresChannel.DisplayMember = "channelDate";
                        cmbresChannel.Text = "Select Channel";

                        resChannel = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
                }
            }
        }

        private void cmbresChannel_SelectedValueChanged(object sender, EventArgs e)
        {
            if (resChannel)
            {
                Appointment appointment = new Appointment();

                string channelid = cmbresChannel.GetItemText(cmbresChannel.SelectedValue);
                int channelId = int.Parse(channelid);

                if (channelid != null && channelid != "")
                {
                    try
                    {
                        int seat = appointment.getSeatNumberByChannelId(channelId);
                        txtResSeatNo.Text = seat.ToString();
                        txtresAppopint.Text = generateAppointmentNumber(seat, channelId);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
                    }
                }
            }

        }

        private void btnReschedule_Click(object sender, EventArgs e)
        {
            string newChannel = cmbresChannel.GetItemText(cmbresChannel.SelectedValue);
            int channelId = int.Parse(newChannel);

            if (newChannel != null && newChannel != "")
            {
                try
                {
                    Appointment newAppointment = new Appointment();

                    newAppointment.AppointmentId = resAppointId;
                    newAppointment.ChannelId = channelId;
                    newAppointment.SeatNumber = txtResSeatNo.Text.Trim();
                    newAppointment.AppointmentNumber = txtresAppopint.Text.Trim();

                    if (newAppointment.rescheduleAppointment(newAppointment))
                    {
                        MessageBox.Show("Appointment successfully Rescheduled!!");
                        resPanelClear();
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

            resPanelClear();
        }

        private void btnresclear_Click(object sender, EventArgs e)
        {
            resPanelClear();
        }

        private void btnCanAppoint_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();

            string appointNumber = txtCanAppointNo.Text.Trim();

            if (appointNumber == null || appointNumber.Equals(""))
            {
                txtCanAppointNo.Focus();
                return;
            }

            try
            {
                List<string> resValues = appointment.getAppointmentByAppointmentNo(appointNumber);

                txtcanClient.Text = resValues[0];
                txtcanDoc.Text = resValues[5];
                txtChannelDate.Text = resValues[1];
                txtSeatNo.Text= resValues[3];
                cancelAppointId = int.Parse(resValues[4]);

            }
            catch (Exception ex)
            {
                MessageBox.Show("The Appointment Number does not Exist!!");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Appointment appointment = new Appointment();

            try
            {
                if (appointment.cancelAppointment(cancelAppointId))
                {
                    MessageBox.Show("Appointment successfully Canceled!!");
                    cancelPanelClear();
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

        private void btnViewAppoint_Click(object sender, EventArgs e)
        {
            string patientnic = txtpatientnic.Text.Trim();

            try
            {

                Appointment appointList = new Appointment();

                DataTable AppointmentListData = appointList.searchappointmentByCriterias(patientnic);

                dataGridView.DataSource = AppointmentListData;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnCanClear_Click(object sender, EventArgs e)
        {
            cancelPanelClear();
        }

        private void cancelPanelClear()
        {
            txtcanClient.Clear();
            txtcanDoc.Clear();
            txtChannelDate.Clear();
            txtSeatNo.Clear();
            txtCanAppointNo.Clear();
            cancelAppointId = 0;
        }

        private void resPanelClear()
        {
            txtresClient.Clear();
            txtResDoctor.Clear();
            txtOldChannel.Clear();
            txtResSeatNo.Clear();
            txtresAppopint.Clear();
            txtenterAppointNo.Clear();
            resAppointId = 0;
        }

        private void PatientAppoinments_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormHandler.ReleaseCapture();
                FormHandler.SendMessage(Handle, FormHandler.WM_NCLBUTTONDOWN, FormHandler.HT_CAPTION, 0);
            }
        }

    }
}
