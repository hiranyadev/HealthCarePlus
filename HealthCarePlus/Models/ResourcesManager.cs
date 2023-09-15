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
    internal class ResourcesManager
    {
        int resources_managerId;
        string type;
        string brand;
        string userbility;
        int count;
        string others;
        int resources_categoryid;

        public int Resources_managerId { get => resources_managerId; set => resources_managerId = value; }
        public string Type { get => type; set => type = value; }
        public string Brand { get => brand; set => brand = value; }
        public string Userbility { get => userbility; set => userbility = value; }
        public int Count { get => count; set => count = value; }
        public string Others { get => others; set => others = value; }
        public int Resources_categoryid { get => resources_categoryid; set => resources_categoryid = value; }

        DBConnection databaseConnection = new DBConnection();

        public bool saveResources(ResourcesManager resourcesManager)
        {
            string sql = "INSERT INTO resources_manager(type, brand, userbility, count, others, resources_categoryid) " +
                   "VALUES ('" + resourcesManager.Type + "','" + resourcesManager.Brand + "','" + resourcesManager.Userbility + "', "+ resourcesManager.Count + ", " +
                   "'" + resourcesManager.Others + "', "+ resourcesManager.Resources_categoryid + ")";

            return databaseConnection.createData(sql);
        }

        public bool updateResources(ResourcesManager resourcesManager)
        {
            string sql = "UPDATE resources_manager SET type = '" + resourcesManager.Type + "', brand = '" + resourcesManager.Brand + "', " +
                "userbility = '" + resourcesManager.Userbility + "', count = '" + resourcesManager.Count + "', others = '" + resourcesManager.Others + "'  " +
                "WHERE resources_managerId = '" + resourcesManager.Resources_managerId + "'";

            return databaseConnection.updateData(sql);
        }

        public DataTable getAllAvailableDataList()
        {
            string sql = "SELECT (SELECT rc.description FROM resources_category rc WHERE rc.resources_categoryid = rr.resources_categoryid) as Resource_Category, " +
                "rr.type as Type, rr.brand as Brand, rr.userbility as Userbility, rr.count as Available_Count FROM resources_manager rr ";

            return databaseConnection.searchDataByCritrea(sql);
        }

        public ResourcesManager getResourcesById(ResourcesManager resourcesManager)
        {
            ResourcesManager resourcesManagerData = new ResourcesManager();

            MySqlConnection con = DBConnection.getConnection();

            string sql = "SELECT type, brand, userbility, count, others FROM resources_manager WHERE resources_managerId = " + resourcesManager.Resources_managerId + "";

            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            if (sdr.Read())
            {

                resourcesManagerData.Type = sdr.GetString(0);
                resourcesManagerData.Brand = sdr.GetString(1);
                resourcesManagerData.Userbility = sdr.GetString(2);
                resourcesManagerData.Count = sdr.GetInt32(3);
                resourcesManagerData.Others = sdr.GetString(4);

                sdr.Close();
                con.Close();

                return resourcesManagerData;

            }
            else
            {
                sdr.Close();
                con.Close();
                return resourcesManagerData;
            }
        }
    }
}
