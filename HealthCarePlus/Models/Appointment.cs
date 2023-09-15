using HealthCarePlus.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus.Models
{
    internal class Appointment
    {
        int appointmentId;
        string appointmentNumber;
        string seatNumber;
        int channelId;
        int patientId;

        public int AppointmentId { get => appointmentId; set => appointmentId = value; }
        public string AppointmentNumber { get => appointmentNumber; set => appointmentNumber = value; }
        public string SeatNumber { get => seatNumber; set => seatNumber = value; }
        public int ChannelId { get => channelId; set => channelId = value; }
        public int PatientId { get => patientId; set => patientId = value; }

        DBConnection databaseConnection = new DBConnection();
        string curruntdate = DateTime.Now.ToString("yyyy-MM-dd");

        public Patient getPatientByNic(string clientNic)
        {
            Patient patient = new Patient();
            MySqlConnection con = DBConnection.getConnection();

            string sql = "SELECT patientId, patientName FROM patient WHERE nic = '"+ clientNic +"'";

            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {

                patient.Patientid = int.Parse(sdr.GetString(0));
                patient.Patientfname = sdr.GetString(1);

                sdr.Close();
                con.Close();

                return patient;

            }
            else
            {
                sdr.Close();
                con.Close();
                return patient;
            }
        }

        public Boolean makeAppointment(Appointment appointment)
        {
            string sql = "INSERT INTO appointment(appoint_number, seat_no, channelId, patientid, appointmentStatus) " +
                "VALUES ('"+ appointment.AppointmentNumber +"', '"+ appointment.SeatNumber +"', "+ appointment.ChannelId +", "+ appointment.PatientId +", 1)";

            return databaseConnection.createData(sql);
        }

        public int getSeatNumberByChannelId(int channelId)
        {
            int seatNumber = 0;

            string sql = "SELECT MAX(seat_no) FROM appointment WHERE appointmentStatus = 1 AND channelId = " + channelId + "";

            MySqlConnection con = DBConnection.getConnection();

            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                if (!sdr.IsDBNull(0))
                    seatNumber = sdr.GetInt32(0);

            }
            sdr.Close();
            con.Close();

            if (seatNumber > 0)
                ++seatNumber;
            
            return ++seatNumber;
        }

        public List<string> getAppointmentByAppointmentNo(string appointNumber)
        {
            MySqlConnection con = DBConnection.getConnection();

            List<string> appointmentdata = new List<string>();

            string sql = "SELECT pt.patientName, cs.channelDate, cs.doctorId, ap.seat_no, ap.appointmentId FROM appointment ap " +
                "LEFT JOIN channel_schedule cs ON cs.channelId = ap.channelId " +
                "LEFT JOIN patient pt ON pt.patientId = ap.patientId " +
                "WHERE appoint_number = '" + appointNumber + "'";

            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {

                appointmentdata.Add(sdr.GetString(0));
                appointmentdata.Add(sdr.GetString(1));
                appointmentdata.Add(sdr.GetString(2));
                appointmentdata.Add(sdr.GetString(3));
                appointmentdata.Add(sdr.GetString(4));
                int docId = int.Parse(sdr.GetString(2));

                sdr.Close();
                con.Close();

                string docsql = "SELECT fullname FROM doctor WHERE doctorId = " + docId + "";

                appointmentdata.Add(databaseConnection.getSingleValuve(docsql));                

                return appointmentdata;
            }
            else
            {
                sdr.Close();
                con.Close();
                return appointmentdata;
            }

        }

        public bool cancelAppointment(int cancelAppointId)
        {
            string sql = "UPDATE appointment SET appointmentStatus = 0 WHERE appointmentId = '" + cancelAppointId + "'";

            if (databaseConnection.updateData(sql))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool rescheduleAppointment(Appointment newAppointment)
        {
            string sql = "UPDATE appointment SET channelId = " + newAppointment.ChannelId + ", seat_no = '" + newAppointment.SeatNumber + "', " +
                "appoint_number = '"+ newAppointment.AppointmentNumber + "' WHERE appointmentId = " + newAppointment.AppointmentId + "";

            if (databaseConnection.updateData(sql))
            {
                return true;
            }
            else 
            { 
                return false; 
            }
        }

        public DataTable searchappointmentByCriterias(string patientnic)
        {
            string sql = "";

            if (patientnic != "" && patientnic != null)
            {
                sql = "SELECT ap.appoint_number as Appointment_Number, pt.patientName as Patient_Name, cs.channelDate as Channel_Date, " +
                    "(SELECT dc.fullname FROM doctor dc WHERE cs.doctorId = dc.doctorId) as doctor_name " +
                    "FROM appointment ap " +
                    "LEFT JOIN channel_schedule cs ON cs.channelId = ap.channelId " +
                    "LEFT JOIN patient pt ON pt.patientId = ap.patientId WHERE pt.nic = '"+ patientnic + "' AND ap.appointmentStatus = 1 " +
                    "ORDER BY appointmentId DESC";
            }
            else
            {
                sql = "SELECT ap.appoint_number as Appointment_Number, pt.patientName as Patient_Name, cs.channelDate as Channel_Date, " +
                    "(SELECT dc.fullname FROM doctor dc WHERE cs.doctorId = dc.doctorId) as doctor_name " +
                    "FROM appointment ap " +
                    "LEFT JOIN channel_schedule cs ON cs.channelId = ap.channelId " +
                    "LEFT JOIN patient pt ON pt.patientId = ap.patientId WHERE ap.appointmentStatus = 1 " +
                    "ORDER BY appointmentId DESC";
            }

            return databaseConnection.searchDataByCritrea(sql);
        }
    }
}
