using HealthCarePlus.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePlus.Models
{
    internal class LabTestCategory
    {
        int labtestId;
        string labtestCode;
        string description;
        string otherDescription;

        public int LabtestId { get => labtestId; set => labtestId = value; }
        public string LabtestCode { get => labtestCode; set => labtestCode = value; }
        public string Description { get => description; set => description = value; }
        public string OtherDescription { get => otherDescription; set => otherDescription = value; }

        DBConnection databaseConnection = new DBConnection();

        public bool saveLabTestCategory(LabTestCategory labTestCategory)
        {
            string sql = "INSERT INTO labtest_category(categorycode, description, otherdescr) " +
                "VALUES ('" + labTestCategory.LabtestCode + "','" + labTestCategory.Description + "','" + labTestCategory.otherDescription + "')";

            return databaseConnection.createData(sql);
        }
    }
}
