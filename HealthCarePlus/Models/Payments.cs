using HealthCarePlus.Database;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthCarePlus.Models
{
    internal class Payments
    {
        int hospitalChargesPerDay = 2000;
        int roomChargesPerDay = 10000;
        int theaterChargesPerDay = 25000;
        int daysStay = 0;

        int paymentId;
        int doctorCharges;
        int roomCharges;
        int thearterCharges;
        int hospitalCharges;
        int otherCharges;
        int totalAmount;
        int appointmentId;

        public int PaymentId { get => paymentId; set => paymentId = value; }
        public int DoctorCharges { get => doctorCharges; set => doctorCharges = value; }
        public int RoomCharges { get => roomCharges; set => roomCharges = value; }
        public int ThearterCharges { get => thearterCharges; set => thearterCharges = value; }
        public int HospitalCharges { get => hospitalCharges; set => hospitalCharges = value; }
        public int OtherCharges { get => otherCharges; set => otherCharges = value; }
        public int TotalAmount { get => totalAmount; set => totalAmount = value; }
        public int AppointmentId { get => appointmentId; set => appointmentId = value; }

        DBConnection databaseConnection = new DBConnection();
        string curruntdate = DateTime.Now.ToString("yyyy-MM-dd");

        public Payments getInvoiceDataByAppointmentId(string appointmentno)
        {
            string apointsql = "SELECT appointmentId FROM appointment WHERE appoint_number = '"+ appointmentno + "'";
            int appointmentid = databaseConnection.getSingleAmount(apointsql);

            Payments payments = new Payments();
            
            payments.RoomCharges = getRoomCharges(appointmentid);
            payments.ThearterCharges = getThearterCharges(appointmentid);
            payments.HospitalCharges= getHospitalCharges(appointmentid);
            payments.DoctorCharges = getDoctorCharges(appointmentid);
            payments.AppointmentId = appointmentid;
            return payments;
        }

        private int getHospitalCharges(int appointmentid)
        {
            if (daysStay > 0)
            {
                return hospitalChargesPerDay * daysStay;
            }

            return hospitalChargesPerDay;            
        }

        private int getThearterCharges(int appointmentid)
        {
            int charges = 0;
            string sql = "SELECT COUNT(theater_bookId) FROM theater_book WHERE appointmentId = "+appointmentid+"";
            int theatercount = databaseConnection.getSingleAmount(sql);

            if(theatercount > 0)
            {
                charges = theaterChargesPerDay * theatercount;
            }
            else
            {
                charges = 0;
            }
            
            daysStay += theatercount;

            return charges;
        }

        private int getRoomCharges(int appointmentid)
        {
            int charges = 0;
            string sql = "SELECT COUNT(room_bookId) FROM room_book WHERE appointmentId = " + appointmentid + "";
            int roomcount = databaseConnection.getSingleAmount(sql);

            if(roomcount > 0)
            {
                charges = roomChargesPerDay * roomcount;
            }
            else
            {
                charges = 0;
            }            
            daysStay += roomcount;

            return charges;
        }

        private int getDoctorCharges(int appointmentid)
        {
            int holeDocCharge = 0;

            string sql = "SELECT channelId FROM appointment WHERE appointmentId = " + appointmentid + "";
            int channelid = databaseConnection.getSingleAmount(sql);

            string sqldoc = "SELECT channelfee FROM channel_schedule WHERE channelId = " + channelid + "";

            int docCharges = databaseConnection.getSingleAmount(sqldoc);

            if(daysStay > 0)
            {
                holeDocCharge = daysStay * docCharges;
            }
            else
            {
                holeDocCharge = docCharges;
            }

            return holeDocCharge;
        }

        public void savePayments(Payments payments)
        {
            string sql = "INSERT INTO payments( doctorCharges, roomCharges, thearterCharges, hospitalCharges, otherCharges, totalAmount, appointmentId, printdate) " +
               "VALUES (" + payments.DoctorCharges + ", " + payments.RoomCharges + ", " + payments.ThearterCharges + ", " + payments.HospitalCharges + "," +
               "" + payments.OtherCharges + ", " + payments.TotalAmount + ", " + payments.AppointmentId + ", '"+ curruntdate + "')";

            databaseConnection.createData(sql);
        }
    }
}
