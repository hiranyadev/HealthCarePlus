using HealthCarePlus.Database;
using MySql.Data.MySqlClient;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace HealthCarePlus.Models
{
    internal class Channels
    {
        string roomnumber;
        int channelId;
        int doctorId;
        string channelDate;
        int channelStatus;
        int channelfee;

        public string Roomnumber { get => roomnumber; set => roomnumber = value; }
        public int ChannelId { get => channelId; set => channelId = value; }
        public int DoctorId { get => doctorId; set => doctorId = value; }
        public string ChannelDate { get => channelDate; set => channelDate = value; }
        public int ChannelStatus { get => channelStatus; set => channelStatus = value; }
        public int Channelfee { get => channelfee; set => channelfee = value; }

        string curruntdate = DateTime.Now.ToString("yyyy-MM-dd");
        DBConnection databaseConnection = new DBConnection();

        public Boolean addChannel(Channels channels)
        {
            
            channels.ChannelStatus = 1;

            string sql = "INSERT INTO channel_schedule(roomNo, channelDate, doctorId, channelStatus, channelfee) " +
                   "VALUES ('" + channels.Roomnumber + "','" + channels.ChannelDate + "','" + channels.DoctorId + "','" + channels.ChannelStatus + "', "+ channelfee + ")";

           return databaseConnection.createData(sql);
        }

        public Channels rescheduleChannels(Channels channels)
        {
            string sql = "UPDATE channel_schedule SET channelDate = '"+ channels.ChannelDate +"', roomNo = '"+ channels.Roomnumber +"' " +
                "WHERE channelId = '"+ channels.ChannelId +"'";

            if (databaseConnection.updateData(sql))
            {
                return channels;
            }else { return null; }            
        }

        public Boolean cancelChannel(int channelId)
        {
            return false;
        }

        public DataTable searchPatientByCriterias(int searchField)
        {
            
            string sql = "";

            if (searchField != 0 )
            {
                sql = "SELECT dr.fullname, dr.specialization, cs.channelDate, cs.roomNo FROM doctor dr, channel_schedule cs " +
                    "WHERE cs.doctorId = dr.doctorid and cs.doctorId = " + searchField + " and cs.channelDate >= '" + curruntdate  + "' and cs.channelStatus = 1";
            }
            else
            {
                sql = "SELECT dr.fullname, dr.specialization, cs.channelDate, cs.roomNo FROM doctor dr, channel_schedule cs " +
                    "WHERE cs.doctorId = dr.doctorid and cs.channelDate >= '" + curruntdate  + "' and cs.channelStatus = 1";
            }

            return databaseConnection.searchDataByCritrea(sql);
        }

        public List<Channels> getAllActiveChannelsById(int searchField)
        {
            List<Channels> channelslist = new List<Channels>();
            string sql = "SELECT cl.channelId, dc.fullname, cl.channelDate FROM channel_schedule cl LEFT JOIN doctor dc ON cl.doctorId = dc.doctorId " +
                "WHERE dc.doctorId = '"+searchField+ "' AND cl.channelDate >= '"+ curruntdate + "' AND cl.channelStatus = 1";

            MySqlConnection con = DBConnection.getConnection();

            if (con.State != ConnectionState.Open)
                con.Open();

            MySqlCommand cmd = new MySqlCommand(sql, con);
            MySqlDataReader sdr = cmd.ExecuteReader();

            try
            {
                while (sdr.Read())
                {
                    Channels obj = new Channels();
                    obj.ChannelId = sdr.GetInt32(0);
                    obj.Roomnumber = sdr.GetString(1)+" - "+sdr.GetString(2);
                    channelslist.Add(obj);
                }
                sdr.Close();
                con.Close();
                return channelslist;
            }
            catch (Exception ex)
            {
                con.Close();
                return null;
            }
        }

        public Boolean cancelChannels(Channels channels)
        {
            string sql = "UPDATE channel_schedule SET channelStatus = 0 WHERE channelId = '" + channels.ChannelId + "'";

            if (databaseConnection.updateData(sql))
            {
                return true;
            }
            else { 
                return false; 
            }
        }
    }
}
