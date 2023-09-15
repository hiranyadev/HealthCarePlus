using HealthCarePlus.Database;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePlus.Models
{
    internal class MedicalRecords
    {
        int medicalRecordId;
        string dignosis;
        string symptoms;
        string prescriptions;
        int appointmentid;

        public int MedicalRecordId { get => medicalRecordId; set => medicalRecordId = value; }
        public string Dignosis { get => dignosis; set => dignosis = value; }
        public string Symptoms { get => symptoms; set => symptoms = value; }
        public string Prescriptions { get => prescriptions; set => prescriptions = value; }
        public int Appointmentid { get => appointmentid; set => appointmentid = value; }

        DBConnection databaseConnection = new DBConnection();

        public bool saveMedicalRecords(MedicalRecords medicalRecords)
        {
            string sql = "INSERT INTO medical_records (diagnosis, symptoms, prescription, appointmentId) " +
                "VALUES ('" + medicalRecords.Dignosis + "','" + medicalRecords.Symptoms + "','" + medicalRecords.Prescriptions + "'," + medicalRecords.Appointmentid + ")";

            return databaseConnection.createData(sql);
        }

        public DataTable getMedicalHistoryByPatient(int patientid)
        {
            string sql = "SELECT cs.channelDate as Channel_Date, (SELECT dc.fullname FROM doctor dc WHERE dc.doctorId = cs.doctorId) as Doctor, " +
                "mr.diagnosis as Diagnosis, mr.symptoms as Symptoms, mr.prescription as Prescription, lr.results as Lab_Results " +
                "FROM appointment ap " +
                "LEFT JOIN medical_records mr ON mr.appointmentId = ap.appointmentId " +
                "LEFT JOIN lab_results lr ON lr.appointmentId = ap.appointmentId " +
                "LEFT JOIN channel_schedule cs ON cs.channelId = ap.channelId " +
                "WHERE ap.appointmentStatus = 1 AND ap.patientid = "+ patientid +" " +
                "ORDER BY ap.appointmentId DESC";

            return databaseConnection.searchDataByCritrea(sql);
        }

        public DataTable getMedicalHistoryByAppointment(int appointmentid)
        {
            string sql = "SELECT mr.diagnosis as Diagnosis, mr.symptoms as Symptoms, mr.prescription as Prescription " +
                "FROM medical_records mr WHERE mr.appointmentId = " + appointmentid + " " +
                "ORDER BY mr.appointmentId DESC";

            return databaseConnection.searchDataByCritrea(sql);
        }
    }
}
