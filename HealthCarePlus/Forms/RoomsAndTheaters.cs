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
    public partial class RoomsAndTheaters : Form
    {
        string curruntdate = DateTime.Now.ToString("yyyy-MM-dd");

        public RoomsAndTheaters()
        {
            InitializeComponent();
            clearBooking();
            roomAvailability(curruntdate);
            theaterAvailablity(curruntdate);
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

        private void RoomsAndTheaters_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                FormHandler.ReleaseCapture();
                FormHandler.SendMessage(Handle, FormHandler.WM_NCLBUTTONDOWN, FormHandler.HT_CAPTION, 0);
            }
        }

        private void btnBed01_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(1, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed02_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(2, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed03_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(3, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed04_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(4, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed05_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(5, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed06_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(6, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed07_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(7, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed08_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(8, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed09_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(9, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed10_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(10, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed11_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(11, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed12_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(12, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed13_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(13, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed14_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(14, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed15_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(15, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnBed16_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                TheaterBooking theaterBooking = new TheaterBooking();
                theaterBooking.bookTheater(16, appointmentno, bookingdate);

                MessageBox.Show("Theater Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R1_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(1, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R2_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(2, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R3_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(3, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R4_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(4, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R5_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(5, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R6_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(6, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R7_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(7, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R8_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(8, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R9_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(9, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R10_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(10, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R11_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(11, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R12_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(12, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R13_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(13, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R14_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(14, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R15_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(15, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F1R16_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(16, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R1_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(17, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R2_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(18, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R3_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(19, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R4_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(20, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R5_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(21, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R6_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(22, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R7_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(23, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R8_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(24, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R9_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(25, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R10_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(26, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R11_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(27, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R12_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(28, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R13_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(29, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R14_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(30, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R15_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(31, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F2R16_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(32, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R1_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(33, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R2_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(34, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R3_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(35, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R4_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(36, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R5_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(37, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R6_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(38, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R7_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(39, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R8_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(40, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R9_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(41, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R10_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(42, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R11_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(43, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R12_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(44, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R13_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(45, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R14_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(46, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R15_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(47, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void F3R16_Click(object sender, EventArgs e)
        {
            string appointmentno = txtappointment.Text.Trim();
            string bookingdate = dateTimePicker.Text;

            try
            {
                RoomBooking roomBooking = new RoomBooking();
                roomBooking.bookRoom(48, appointmentno, bookingdate);

                MessageBox.Show("Room Successfully Booked!!");
                roomAvailability(bookingdate);
                theaterAvailablity(bookingdate);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {           
            string searchdate = dateTimePicker.Text;

            try
            {
                clearBooking();
                roomAvailability(searchdate);
                theaterAvailablity(searchdate); 
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Occured While Processing!! Please Try Again!!");
            }
        }

        private void roomAvailability(string searchdate)
        {
            List<int> roomlist = new List<int>();

            RoomBooking roomBooking = new RoomBooking();
            roomlist = roomBooking.getBookedRoomListByDate(searchdate);

            if(roomlist.Count > 0)
            {
                foreach (int room in roomlist)
                {
                    switch (room)
                    {
                        case 1: { F1R1.BackColor = System.Drawing.Color.Red; F1R1.Enabled = false; break; }
                        case 2: { F1R2.BackColor = System.Drawing.Color.Red; F1R2.Enabled = false; break; }
                        case 3: { F1R3.BackColor = System.Drawing.Color.Red; F1R3.Enabled = false; break; }
                        case 4: { F1R4.BackColor = System.Drawing.Color.Red; F1R4.Enabled = false; break; }
                        case 5: { F1R5.BackColor = System.Drawing.Color.Red; F1R5.Enabled = false; break; }
                        case 6: { F1R6.BackColor = System.Drawing.Color.Red; F1R6.Enabled = false; break; }
                        case 7: { F1R7.BackColor = System.Drawing.Color.Red; F1R7.Enabled = false; break; }
                        case 8: { F1R8.BackColor = System.Drawing.Color.Red; F1R8.Enabled = false; break; }
                        case 9: { F1R9.BackColor = System.Drawing.Color.Red; F1R9.Enabled = false; break; }
                        case 10: { F1R10.BackColor = System.Drawing.Color.Red; F1R10.Enabled = false; break; }
                        case 11: { F1R11.BackColor = System.Drawing.Color.Red; F1R11.Enabled = false; break; }
                        case 12: { F1R12.BackColor = System.Drawing.Color.Red; F1R12.Enabled = false; break; }
                        case 13: { F1R13.BackColor = System.Drawing.Color.Red; F1R13.Enabled = false; break; }
                        case 14: { F1R14.BackColor = System.Drawing.Color.Red; F1R14.Enabled = false; break; }
                        case 15: { F1R15.BackColor = System.Drawing.Color.Red; F1R15.Enabled = false; break; }
                        case 16: { F1R16.BackColor = System.Drawing.Color.Red; F1R16.Enabled = false; break; }
                        case 17: { F2R1.BackColor = System.Drawing.Color.Red; F2R1.Enabled = false; break; }
                        case 18: { F2R2.BackColor = System.Drawing.Color.Red; F2R2.Enabled = false; break; }
                        case 19: { F2R3.BackColor = System.Drawing.Color.Red; F2R3.Enabled = false; break; }
                        case 20: { F2R4.BackColor = System.Drawing.Color.Red; F2R4.Enabled = false; break; }
                        case 21: { F2R5.BackColor = System.Drawing.Color.Red; F2R5.Enabled = false; break; }
                        case 22: { F2R6.BackColor = System.Drawing.Color.Red; F2R6.Enabled = false; break; }
                        case 23: { F2R7.BackColor = System.Drawing.Color.Red; F2R7.Enabled = false; break; }
                        case 24: { F2R8.BackColor = System.Drawing.Color.Red; F2R8.Enabled = false; break; }
                        case 25: { F2R9.BackColor = System.Drawing.Color.Red; F2R9.Enabled = false; break; }
                        case 26: { F2R10.BackColor = System.Drawing.Color.Red; F2R10.Enabled = false; break; }
                        case 27: { F2R11.BackColor = System.Drawing.Color.Red; F2R11.Enabled = false; break; }
                        case 28: { F2R12.BackColor = System.Drawing.Color.Red; F2R12.Enabled = false; break; }
                        case 29: { F2R13.BackColor = System.Drawing.Color.Red; F2R13.Enabled = false; break; }
                        case 30: { F2R14.BackColor = System.Drawing.Color.Red; F2R14.Enabled = false; break; }
                        case 31: { F2R15.BackColor = System.Drawing.Color.Red; F2R15.Enabled = false; break; }
                        case 32: { F2R16.BackColor = System.Drawing.Color.Red; F2R16.Enabled = false; break; }
                        case 33: { F3R1.BackColor = System.Drawing.Color.Red; F3R1.Enabled = false; break; }
                        case 34: { F3R2.BackColor = System.Drawing.Color.Red; F3R2.Enabled = false; break; }
                        case 35: { F3R3.BackColor = System.Drawing.Color.Red; F3R3.Enabled = false; break; }
                        case 36: { F3R4.BackColor = System.Drawing.Color.Red; F3R4.Enabled = false; break; }
                        case 37: { F3R5.BackColor = System.Drawing.Color.Red; F3R5.Enabled = false; break; }
                        case 38: { F3R6.BackColor = System.Drawing.Color.Red; F3R6.Enabled = false; break; }
                        case 39: { F3R7.BackColor = System.Drawing.Color.Red; F3R7.Enabled = false; break; }
                        case 40: { F3R8.BackColor = System.Drawing.Color.Red; F3R8.Enabled = false; break; }
                        case 41: { F3R9.BackColor = System.Drawing.Color.Red; F3R9.Enabled = false; break; }
                        case 42: { F3R10.BackColor = System.Drawing.Color.Red; F3R10.Enabled = false; break; }
                        case 43: { F3R11.BackColor = System.Drawing.Color.Red; F3R11.Enabled = false; break; }
                        case 44: { F3R12.BackColor = System.Drawing.Color.Red; F3R12.Enabled = false; break; }
                        case 45: { F3R13.BackColor = System.Drawing.Color.Red; F3R13.Enabled = false; break; }
                        case 46: { F3R14.BackColor = System.Drawing.Color.Red; F3R14.Enabled = false; break; }
                        case 47: { F3R15.BackColor = System.Drawing.Color.Red; F3R15.Enabled = false; break; }
                        case 48: { F3R16.BackColor = System.Drawing.Color.Red; F3R16.Enabled = false; break; }

                    }
                }
            }           

        }

        private void theaterAvailablity(string searchdate)
        {
            List<int> theaterlist = new List<int>();

            TheaterBooking theaterBooking = new TheaterBooking();
            theaterlist = theaterBooking.getBookedTheaterListByDate(searchdate);

            if(theaterlist.Count > 0)
            {
                foreach (int theater in theaterlist)
                {
                    switch (theater)
                    {
                        case 1: { btnBed01.BackColor = System.Drawing.Color.Red; btnBed01.Enabled = false; break; }
                        case 2: { btnBed02.BackColor = System.Drawing.Color.Red; btnBed02.Enabled = false; break; }
                        case 3: { btnBed03.BackColor = System.Drawing.Color.Red; btnBed03.Enabled = false; break; }
                        case 4: { btnBed04.BackColor = System.Drawing.Color.Red; btnBed04.Enabled = false; break; }
                        case 5: { btnBed05.BackColor = System.Drawing.Color.Red; btnBed05.Enabled = false; break; }
                        case 6: { btnBed06.BackColor = System.Drawing.Color.Red; btnBed06.Enabled = false; break; }
                        case 7: { btnBed07.BackColor = System.Drawing.Color.Red; btnBed07.Enabled = false; break; }
                        case 8: { btnBed08.BackColor = System.Drawing.Color.Red; btnBed08.Enabled = false; break; }
                        case 9: { btnBed09.BackColor = System.Drawing.Color.Red; btnBed09.Enabled = false; break; }
                        case 10: { btnBed10.BackColor = System.Drawing.Color.Red; btnBed10.Enabled = false; break; }
                        case 11: { btnBed11.BackColor = System.Drawing.Color.Red; btnBed11.Enabled = false; break; }
                        case 12: { btnBed12.BackColor = System.Drawing.Color.Red; btnBed12.Enabled = false; break; }
                        case 13: { btnBed13.BackColor = System.Drawing.Color.Red; btnBed13.Enabled = false; break; }
                        case 14: { btnBed14.BackColor = System.Drawing.Color.Red; btnBed14.Enabled = false; break; }
                        case 15: { btnBed15.BackColor = System.Drawing.Color.Red; btnBed15.Enabled = false; break; }
                        case 16: { btnBed16.BackColor = System.Drawing.Color.Red; btnBed16.Enabled = false; break; }

                    }
                }
            }

        }

        public void clearBooking()
        {
            btnBed01.BackColor = System.Drawing.Color.White;
            btnBed02.BackColor = System.Drawing.Color.White;
            btnBed03.BackColor = System.Drawing.Color.White;
            btnBed04.BackColor = System.Drawing.Color.White;
            btnBed05.BackColor = System.Drawing.Color.White;
            btnBed06.BackColor = System.Drawing.Color.White;
            btnBed07.BackColor = System.Drawing.Color.White;
            btnBed08.BackColor = System.Drawing.Color.White;
            btnBed09.BackColor = System.Drawing.Color.White;
            btnBed10.BackColor = System.Drawing.Color.White;
            btnBed11.BackColor = System.Drawing.Color.White;
            btnBed12.BackColor = System.Drawing.Color.White;
            btnBed13.BackColor = System.Drawing.Color.White;
            btnBed14.BackColor = System.Drawing.Color.White;
            btnBed15.BackColor = System.Drawing.Color.White;
            btnBed16.BackColor = System.Drawing.Color.White;
            F1R1.BackColor = System.Drawing.Color.White;
            F1R2.BackColor = System.Drawing.Color.White;
            F1R3.BackColor = System.Drawing.Color.White;
            F1R4.BackColor = System.Drawing.Color.White;
            F1R5.BackColor = System.Drawing.Color.White;
            F1R6.BackColor = System.Drawing.Color.White;
            F1R7.BackColor = System.Drawing.Color.White;
            F1R8.BackColor = System.Drawing.Color.White;
            F1R9.BackColor = System.Drawing.Color.White;
            F1R10.BackColor = System.Drawing.Color.White;
            F1R11.BackColor = System.Drawing.Color.White;
            F1R12.BackColor = System.Drawing.Color.White;
            F1R13.BackColor = System.Drawing.Color.White;
            F1R14.BackColor = System.Drawing.Color.White;
            F1R15.BackColor = System.Drawing.Color.White;
            F1R16.BackColor = System.Drawing.Color.White;
            F2R1.BackColor = System.Drawing.Color.White;
            F2R2.BackColor = System.Drawing.Color.White;
            F2R3.BackColor = System.Drawing.Color.White;
            F2R4.BackColor = System.Drawing.Color.White;
            F2R5.BackColor = System.Drawing.Color.White;
            F2R6.BackColor = System.Drawing.Color.White;
            F2R7.BackColor = System.Drawing.Color.White;
            F2R8.BackColor = System.Drawing.Color.White;
            F2R9.BackColor = System.Drawing.Color.White;
            F2R10.BackColor = System.Drawing.Color.White;
            F2R11.BackColor = System.Drawing.Color.White;
            F2R12.BackColor = System.Drawing.Color.White;
            F2R13.BackColor = System.Drawing.Color.White;
            F2R14.BackColor = System.Drawing.Color.White;
            F2R15.BackColor = System.Drawing.Color.White;
            F2R16.BackColor = System.Drawing.Color.White;
            F3R1.BackColor = System.Drawing.Color.White;
            F3R2.BackColor = System.Drawing.Color.White;
            F3R3.BackColor = System.Drawing.Color.White;
            F3R4.BackColor = System.Drawing.Color.White;
            F3R5.BackColor = System.Drawing.Color.White;
            F3R6.BackColor = System.Drawing.Color.White;
            F3R7.BackColor = System.Drawing.Color.White;
            F3R8.BackColor = System.Drawing.Color.White;
            F3R9.BackColor = System.Drawing.Color.White;
            F3R10.BackColor = System.Drawing.Color.White;
            F3R11.BackColor = System.Drawing.Color.White;
            F3R12.BackColor = System.Drawing.Color.White;
            F3R13.BackColor = System.Drawing.Color.White;
            F3R14.BackColor = System.Drawing.Color.White;
            F3R15.BackColor = System.Drawing.Color.White;
            F3R16.BackColor = System.Drawing.Color.White;

            btnBed01.Enabled = true;
            btnBed02.Enabled = true;
            btnBed03.Enabled = true;
            btnBed04.Enabled = true;
            btnBed05.Enabled = true;
            btnBed06.Enabled = true;
            btnBed07.Enabled = true;
            btnBed08.Enabled = true;
            btnBed09.Enabled = true;
            btnBed10.Enabled = true;
            btnBed11.Enabled = true;
            btnBed12.Enabled = true;
            btnBed13.Enabled = true;
            btnBed14.Enabled = true;
            btnBed15.Enabled = true;
            btnBed16.Enabled = true;
            F1R1.Enabled = true;
            F1R2.Enabled = true;
            F1R3.Enabled = true;
            F1R4.Enabled = true;
            F1R5.Enabled = true;
            F1R6.Enabled = true;
            F1R7.Enabled = true;
            F1R8.Enabled = true;
            F1R9.Enabled = true;
            F1R10.Enabled = true;
            F1R11.Enabled = true;
            F1R12.Enabled = true;
            F1R13.Enabled = true;
            F1R14.Enabled = true;
            F1R15.Enabled = true;
            F1R16.Enabled = true;
            F2R1.Enabled = true;
            F2R2.Enabled = true;
            F2R3.Enabled = true;
            F2R4.Enabled = true;
            F2R5.Enabled = true;
            F2R6.Enabled = true;
            F2R7.Enabled = true;
            F2R8.Enabled = true;
            F2R9.Enabled = true;
            F2R10.Enabled = true;
            F2R11.Enabled = true;
            F2R12.Enabled = true;
            F2R13.Enabled = true;
            F2R14.Enabled = true;
            F2R15.Enabled = true;
            F2R16.Enabled = true;
            F3R1.Enabled = true;
            F3R2.Enabled = true;
            F3R3.Enabled = true;
            F3R4.Enabled = true;
            F3R5.Enabled = true;
            F3R6.Enabled = true;
            F3R7.Enabled = true;
            F3R8.Enabled = true;
            F3R9.Enabled = true;
            F3R10.Enabled = true;
            F3R11.Enabled = true;
            F3R12.Enabled = true;
            F3R13.Enabled = true;
            F3R14.Enabled = true;
            F3R15.Enabled = true;
            F3R16.Enabled = true;


        }

    }
}
