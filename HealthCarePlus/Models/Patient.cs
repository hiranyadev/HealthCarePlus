using HealthCarePlus.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePlus.Models
{
    internal class Patient
    {
        int patientid;
        string patientfname;
        string contact;
        string email;
        string address;
        string nic;
        int age;
        string bloodgroup;

        public int Patientid { get => patientid; set => patientid = value; }
        public string Patientfname { get => patientfname; set => patientfname = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Nic { get => nic; set => nic = value; }
        public int Age { get => age; set => age = value; }
        public string Bloodgroup { get => bloodgroup; set => bloodgroup = value; }

        DBConnection databaseConnection = new DBConnection();

        public Boolean savePatient(Patient patient)
        {
            string sql = "INSERT INTO patient (patientName, contact, email, age, nic, address, bloodgroup) " +
                "VALUES ('" + patient.patientfname + "','" + patient.contact + "','" + patient.email + "','" + patient.age + "'," +
                "'" + patient.nic + "','" + patient.address + "','" + patient.bloodgroup + "')";

            return databaseConnection.createData(sql);
        }

        public DataTable searchPatientByCriterias(string searchCriteria, string searchField)
        {
            Patient newpatient = new Patient();

            string sql = "";

            if (searchCriteria != null && searchCriteria.Equals("NIC"))
            {
                sql = "SELECT patientId, patientName, contact, email, age, nic, address, bloodgroup FROM patient WHERE nic = '" + searchField + "'";
            }
            else if (searchField != null && searchCriteria.Equals("Name"))
            {
                sql = "SELECT patientId, patientName, contact, email, age, nic, address, bloodgroup FROM patient WHERE patientName like '" + searchField + "%'";
            }
            else
            {
                sql = "SELECT patientId, patientName, contact, email, age, nic, address, bloodgroup FROM patient";
            }



            MySqlConnection con = DBConnection.getConnection();

            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable patientData = new DataTable();
            

            if (!patientData.Equals(null))
            {
                sda.Fill(patientData);
                con.Close();
                return patientData;

            }
            else
            {
                con.Close();
                return patientData;
            }
        }

        public List<string> searchPatientManagemetDataByCriterias(string searchCriteria, string searchValue)
        {
            List<string> searchedData = new List<string>();

            MySqlConnection con = DBConnection.getConnection();

            string sql = "";

            if (searchCriteria.Equals("NIC"))
            {
                sql = "SELECT ap.appoint_number, pt.patientName, pt.age, pt.bloodgroup, ap.appointmentId, ap.patientId " +
                    "FROM appointment ap LEFT JOIN patient pt ON pt.patientId = ap.patientId " +
                    "WHERE pt.nic = '" + searchValue + "' AND ap.appointmentId = (SELECT MAX(app.appointmentId) " +
                    "FROM appointment app WHERE app.patientId = pt.patientId);";
            }
            else if (searchCriteria.Equals("Appointment"))
            {
                sql = "SELECT ap.appoint_number, pt.patientName, pt.age, pt.bloodgroup, ap.appointmentId, ap.patientId " +
                    "FROM appointment ap LEFT JOIN patient pt ON pt.patientId = ap.patientId " +
                    "WHERE ap.appoint_number = '" + searchValue + "'";
            }

            
            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {

                searchedData.Add(sdr.GetString(0));
                searchedData.Add(sdr.GetString(1));
                searchedData.Add(sdr.GetString(2));
                searchedData.Add(sdr.GetString(3));
                searchedData.Add(sdr.GetString(4));
                searchedData.Add(sdr.GetString(5));

                sdr.Close();
                con.Close();

                return searchedData;
            }
            else
            {
                sdr.Close();
                con.Close();
                return searchedData;
            }
        }
    }
}
