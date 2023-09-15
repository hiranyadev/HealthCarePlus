using HealthCarePlus.Database;
using HealthCarePlus.Helpers;
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
    internal class StaffMember
    {
        int memberid;
        string fname;
        string contact;
        string email;
        string address;
        int age;
        string nic;
        String joindate = DateTime.Now.ToString("yyyy-MM-dd");
        string username;
        string password;
        string role;

        public string Fname { get => fname; set => fname = value; }
        public string Contact { get => contact; set => contact = value; }
        public string Email { get => email; set => email = value; }
        public string Address { get => address; set => address = value; }
        public int Age { get => age; set => age = value; }
        public string Nic { get => nic; set => nic = value; }
        public string Joindate { get => joindate; set => joindate = value; }
        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public int Memberid { get => memberid; set => memberid = value; }

        DBConnection databaseConnection = new DBConnection();

        public static bool Authenticate(string username, string password)
        {
            string sql = "SELECT passwordhash FROM staff WHERE username = '" + username + "'";

            //get the connection from DB class
            MySqlConnection con = DBConnection.getConnection();

            //open the connection
            if (con.State != ConnectionState.Open)
                con.Open();

            //create the SqlCommnd obejct
            MySqlCommand cmd = new MySqlCommand(sql, con);

            //once it is executed, will return a sql data reader with results included
            MySqlDataReader sdr = cmd.ExecuteReader();

            //status variable
            bool isSuccess = false;

            //check whether it has rows
            if (sdr.HasRows)
            {
                //we have a valid entry with a username
                if (sdr.Read())
                {
                    //advance to the first entry
                    //get the first column value
                    string pswHashFromDb = sdr.GetString(0);

                    //generate hash from the given password to compare with the password hash from the database
                    string pswHashFromUser = HashingEncription.getPasswordHash(password);

                    //compare values
                    if (pswHashFromDb.Equals(pswHashFromUser))
                    {
                        isSuccess = true;
                    }
                }
            }
            con.Close();
            sdr.Close();
            return isSuccess;
        }

        public Boolean saveStaffMember(StaffMember staffMember)
        {
            staffMember.role = "";

            string sql = "INSERT INTO staff(name, contact, email, nic, username, passwordhash, role, age, joindate, address) " +
                "VALUES ('"+staffMember.fname+ "','"+staffMember.contact+ "','"+ staffMember.email+ "','"+ staffMember.nic+ "'," +
                "'"+ staffMember.username+ "','"+ staffMember.password+ "','"+ staffMember.role+ "','"+ staffMember.age+ "', " +
                "'"+ staffMember.Joindate +"', '"+ staffMember.Address+"')";

            //get the connection from DB class
            MySqlConnection con = DBConnection.getConnection();

            //open the connection
            if (con.State != ConnectionState.Open)
                con.Open();

            //create the SqlCommnd obejct
            MySqlCommand cmd = new MySqlCommand(sql, con);

            int numOfAffectedRows = cmd.ExecuteNonQuery();
            if (numOfAffectedRows > 0)
            {
                con.Close();
                return true;
            }
            else
            {
                con.Close();
                return false;
            }
        }

        public bool authoriceStaffMember(string role, int staffMemberid)
        {
            string sql = "UPDATE staff SET role = '" + role + "' WHERE memberId = '" + staffMemberid + "'";

            return databaseConnection.updateData(sql);
        }

        public StaffMember searchByNic(string nic)
        {
            StaffMember staffMember = new StaffMember();

            string sql = "SELECT memberId, name, address, contact, email, joindate FROM staff WHERE nic = '" + nic +"'";

            MySqlConnection con = DBConnection.getConnection();

            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {

                staffMember.Memberid = int.Parse(sdr.GetString(0));
                staffMember.Fname = sdr.GetString(1);
                staffMember.Contact = sdr.GetString(3);
                staffMember.Email = sdr.GetString(4);
                staffMember.Address = sdr.GetString(2);
                staffMember.Joindate = sdr.GetString(5);

                sdr.Close();
                con.Close();

                return staffMember;

            }
            else
            {
                sdr.Close();
                con.Close();
                return staffMember;
            }
        }
    }
}
