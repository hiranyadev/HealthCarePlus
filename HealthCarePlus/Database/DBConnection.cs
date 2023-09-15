using HealthCarePlus.Forms;
using HealthCarePlus.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePlus.Database
{
    internal class DBConnection
    {
        private static string ConString = "server=localhost;uid=root;pwd=root;database=healthcareplus";
        private static MySqlConnection con = null;
        public static MySqlConnection getConnection()
        {
            if (con == null)
            {
                con = new MySqlConnection();
                con.ConnectionString = ConString;
            }
            return con;
        }

        public Boolean createData(string sql)
        {
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

        public Boolean updateData(string sql)
        {
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

        public Boolean deleteData(string sql)
        {
            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            //execute and check the updated number of rows
            if (cmd.ExecuteNonQuery() == 1)
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

        public List<Object[]> searchAllData(string sql)
        {
            List<Object[]> list = new List<Object[]>();

            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {
                while (sdr.Read())
                {
                    Object[] objects = new Object[20];
                    objects[0] = sdr.GetInt32(0);
                    objects[1] = sdr.GetString(1);
                    list.Add(objects);
                }

                sdr.Close();
                con.Close();

                return list;

            }
            else
            {
                sdr.Close();
                con.Close();
                return list;
            }
        }

        public DataTable searchDataByCritrea(string sql)
        {
            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataAdapter sda = new MySqlDataAdapter(cmd);
            DataTable tableViewDta = new DataTable();
            sda.Fill(tableViewDta);

            if (!tableViewDta.Equals(null))
            {
                con.Close();

                return tableViewDta;

            }
            else
            {
                con.Close();
                return tableViewDta;
            }
        }

        public static string setUserConfig(string username)
        {
            if (con.State != ConnectionState.Open)
                con.Open();

            string userConfig = "";

            MySqlCommand cmd = new MySqlCommand("SELECT role, name  FROM staff WHERE username = '" + username + "'" , con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                if (sdr.Read())
                {
                    AdminDashboard.role = sdr.GetString(0);
                    userConfig = sdr.GetString(0) + " - " + sdr.GetString(1);

                    sdr.Close();
                    con.Close();

                    return userConfig;

                }
            }

            sdr.Close();
            con.Close();
            return userConfig;

        }

        public string getSingleValuve(string sql)
        {
            if (con.State != ConnectionState.Open)
                con.Open();

            string resultValue = "";

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                if (sdr.Read())
                {
                    resultValue = sdr.GetString(0);

                    sdr.Close();
                    con.Close();

                    return resultValue;

                }
            }

            sdr.Close();
            con.Close();
            return resultValue;
        }

        public int getSingleAmount(string sql)
        {
            if (con.State != ConnectionState.Open)
                con.Open();

            int resultValue = 0;

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.HasRows)
            {
                if (sdr.Read())
                {
                    resultValue = sdr.GetInt32(0);

                    sdr.Close();
                    con.Close();

                    return resultValue;

                }
            }

            sdr.Close();
            con.Close();
            return resultValue;
        }

    }
}
