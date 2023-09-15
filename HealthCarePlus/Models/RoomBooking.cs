using HealthCarePlus.Database;
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
    internal class RoomBooking
    {
        DBConnection databaseConnection = new DBConnection();

        int room_bookId;
        string booking_date;

        public int Room_bookId { get => room_bookId; set => room_bookId = value; }
        public string Booking_date { get => booking_date; set => booking_date = value; }

        public List<int> getBookedRoomListByDate(string searchdate)
        {
            List<int> room_booked = new List<int>();

            string sql = "SELECT roomId FROM room_book WHERE booking_date = '"+ searchdate + "' ";

            MySqlConnection con = DBConnection.getConnection();

            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            while (sdr.Read())
            {
                room_booked.Add(sdr.GetInt32(0));
            }

            sdr.Close();
            con.Close();
            return room_booked;
        }

        public void bookRoom(int roomno, string appointmentno, string bookingdate)
        {
            string subquery = "(SELECT ap.appointmentId FROM appointment ap WHERE ap.appoint_number = '" + appointmentno + "')";

            string sql = "INSERT INTO room_book(booking_date, roomId, appointmentId) " +
                "VALUES ('" + bookingdate + "', '" + roomno + "', " + subquery + ")";

            databaseConnection.createData(sql);
        }
    }
}
