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
    internal class TheaterBooking
    {
        DBConnection databaseConnection = new DBConnection();

        int theater_bookId;
        string booking_date;

        public int Theater_bookId { get => theater_bookId; set => theater_bookId = value; }
        public string Booking_date { get => booking_date; set => booking_date = value; }

        public List<int> getBookedTheaterListByDate(string searchdate)
        {
            List<int> theater_booked = new List<int>();

            string sql = "SELECT theaterId FROM theater_book WHERE booking_date = '" + searchdate + "' ";

            MySqlConnection con = DBConnection.getConnection();

            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                theater_booked.Add(sdr.GetInt32(0));
            }

            sdr.Close();
            con.Close();
            return theater_booked;
        }

        public void bookTheater(int teaterno, string appointmentno, string bookingdate)
        {
            string subquery = "(SELECT ap.appointmentId FROM appointment ap WHERE ap.appoint_number = '"+ appointmentno + "')";

            string sql = "INSERT INTO theater_book(booking_date, theaterId, appointmentId) " +
                "VALUES ('" + bookingdate + "', '" + teaterno + "', " + subquery + ")";

            databaseConnection.createData(sql);
        }
    }
}
