using HealthCarePlus.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePlus.Models
{
    internal class ResourcesCategory
    {
        int resourcesCategoryId;
        string resourcesCategoryCode;
        string resourcesCategoryDescr;
        string resourcesCategoryOthers;

        public int ResourcesCategoryId { get => resourcesCategoryId; set => resourcesCategoryId = value; }
        public string ResourcesCategoryCode { get => resourcesCategoryCode; set => resourcesCategoryCode = value; }
        public string ResourcesCategoryDescr { get => resourcesCategoryDescr; set => resourcesCategoryDescr = value; }
        public string ResourcesCategoryOthers { get => resourcesCategoryOthers; set => resourcesCategoryOthers = value; }

        DBConnection databaseConnection = new DBConnection();

        public bool saveResourcesCategory(ResourcesCategory resourcesCategory)
        {
            string sql = "INSERT INTO resources_category(resourcescode, description, otherdescr) " +
                "VALUES ('" + resourcesCategory.ResourcesCategoryCode + "','" + resourcesCategory.ResourcesCategoryDescr + "','" + resourcesCategory.ResourcesCategoryOthers + "')";

            return databaseConnection.createData(sql);
        }
    }
}
