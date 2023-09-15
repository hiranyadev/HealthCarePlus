using HealthCarePlus.Database;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthCarePlus.Models
{
    internal class Doctor
    {
        private int doctorid;
        private string doctorfname;
        private string contact;
        private string email;
        private string address;
        private string nic;
        private string qualification;
        private string expertice;
        private string specialization;
        private string location;

        public string Doctorfname { get => doctorfname; set => doctorfname = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public string Nic { get => nic; set => nic = value; }
        public string Qualification { get => qualification; set => qualification = value; }
        public string Expertice { get => expertice; set => expertice = value; }
        public string Specialization { get => specialization; set => specialization = value; }
        public string Location { get => location; set => location = value; }
        public int Doctorid { get => doctorid; set => doctorid = value; }

        DBConnection databaseConnection = new DBConnection();

        public Boolean saveDoctor(Doctor doctor)
        {
            string sql = "INSERT INTO doctor(fullname, contact, email, address, nic, qualification, expertise, specialization, location) " +
                "VALUES ('" + doctor.doctorfname + "','" + doctor.contact + "','" + doctor.email + "','" + doctor.address + "'," +
                "'" + doctor.nic + "','" + doctor.qualification + "','" + doctor.expertice + "','" + doctor.specialization + "','" + doctor.location +"')";

            return databaseConnection.createData(sql);
        }

        public Doctor searchDoctor(int doctorId)
        {
            Doctor newdoctor = new Doctor();            

            string sql = "SELECT doctorId, fullname, contact, email, address, nic, qualification, expertise, specialization, location " +
                "FROM doctor WHERE doctorId = " + doctorId + "";

            MySqlConnection con = DBConnection.getConnection();

            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                
                newdoctor.doctorid = doctorId;
                newdoctor.doctorfname = sdr.GetString(1);
                newdoctor.contact = sdr.GetString(2);
                newdoctor.email = sdr.GetString(3);
                newdoctor.address = sdr.GetString(4);
                newdoctor.nic = sdr.GetString(5);
                newdoctor.qualification = sdr.GetString(6);
                newdoctor.expertice = sdr.GetString(7);
                newdoctor.specialization = sdr.GetString(8);
                newdoctor.location = sdr.GetString(9);

                sdr.Close();
                con.Close();

                return newdoctor;

            }
            else
            {
                sdr.Close();
                con.Close();
                return newdoctor;
            }
        }

        public DataTable searchDoctorByCriterias(string searchCriteria, string searchField)
        {
            string sql = "";

            if (searchCriteria != null && searchCriteria.Equals("NIC"))
            {
                sql = "SELECT doctorId, fullname, contact, email, address, nic, specialization FROM doctor WHERE nic = '" + searchField + "'";
            }
            else if(searchField != null && searchCriteria.Equals("Name"))
            {
                sql = "SELECT doctorId, fullname, contact, email, address, nic, specialization FROM doctor WHERE fullname like '" + searchField + "%'";
            }
            else if(searchCriteria != null && searchCriteria.Equals("Specialization"))
            {
                sql = "SELECT doctorId, fullname, contact, email, address, nic, specialization FROM doctor WHERE specialization = '" + searchField + "'";
            }
            else
            {
                sql = "SELECT doctorId, fullname, contact, email, address, nic, specialization FROM doctor";
            }

            return databaseConnection.searchDataByCritrea(sql);
        }

        public Boolean updateDoctor(Doctor doctor)
        {
            string sql = "UPDATE doctor SET fullname = '" + doctor.doctorfname + "' , contact = '" + doctor.contact + "'," +
                " email = '" + doctor.email + "', address = '" + doctor.address + "', " +
                "qualification = '" + doctor.qualification + "', expertise = '" + doctor.expertice + "', " +
                "specialization = '" + doctor.specialization + "', location = '" + doctor.location + "' " +
                "WHERE doctorId = '"+doctor.doctorid + "'";

            return databaseConnection.updateData(sql);
        }

        public Boolean deleteDoctor(int doctorId)
        {
            string sql = "DELETE FROM doctor WHERE doctorId = " + doctorId + "";

            return databaseConnection.deleteData(sql);
        }

        public List<Doctor> getAllDoctor()
        {
            
            List<Doctor> newdoctorList = new List<Doctor>();

            string sql = "SELECT doctorId, fullname FROM doctor ";

            MySqlConnection con = DBConnection.getConnection();

            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                while (sdr.Read())
                {
                    Doctor newdoctor = new Doctor();
                    newdoctor.doctorid = sdr.GetInt32(0);
                    newdoctor.doctorfname = sdr.GetString(1);
                    newdoctorList.Add(newdoctor);
                }               

                sdr.Close();
                con.Close();

                return newdoctorList;

            }
            else
            {
                sdr.Close();
                con.Close();
                return newdoctorList;
            }
        }
    }
}
