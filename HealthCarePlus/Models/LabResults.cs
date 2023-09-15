using HealthCarePlus.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePlus.Models
{
    internal class LabResults
    {
        int labResultsId;
        int labTestId;
        string symptom;
        string results;
        string reportDate = DateTime.Now.ToString("yyyy-MM-dd");
        int appointmentId;

        public int LabResultsId { get => labResultsId; set => labResultsId = value; }
        public int LabTestId { get => labTestId; set => labTestId = value; }
        public string Symptom { get => symptom; set => symptom = value; }
        public string Results { get => results; set => results = value; }
        public string ReportDate { get => reportDate; set => reportDate = value; }
        public int AppointmentId { get => appointmentId; set => appointmentId = value; }

        DBConnection databaseConnection = new DBConnection();

        public bool saveLabResult(LabResults labResults)
        {
            string sql = "INSERT INTO lab_results (symptom, results, report_date, labtest_categoryId, appointmentId) " +
                "VALUES ('"+ labResults.Symptom +"','"+ labResults.Results +"','"+ labResults.ReportDate +"',"+ labResults.labTestId +","+ labResults.AppointmentId +")";

            return databaseConnection.createData(sql);

        }

        public DataTable getMedicalHistoryByAppointment(int appointmentid)
        {
            string sql = "SELECT lr.symptom as Symptom, (SELECT lc.description FROM labtest_category lc WHERE lc.labtest_categoryId = lr.labtest_categoryId) as Test_Category, " +
                "lr.results as Lab_Results FROM lab_results lr WHERE lr.appointmentId = " + appointmentid + " ORDER BY lr.appointmentId DESC";

            return databaseConnection.searchDataByCritrea(sql);
        }
    }
}
