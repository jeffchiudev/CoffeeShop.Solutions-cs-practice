using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace CoffeeShop.Models
{
    public class Duty
    {
        public string DutyDescription { get; set; }
        public int Id { get; }

        public Duty(string dutyDescription)
        {
            DutyDescription = dutyDescription;
        }

        public Duty(string dutyDescription, int id)
        {
            DutyDescription = dutyDescription;
            Id = id;
        }

        public static Duty Find(int searchId)
        {
            Duty placeholderDuty = new Duty("placeholder duty");
            return placeholderDuty;
        }


        public static List<Duty> GetAll()
        {
            List<Duty> allDutys = new List<Duty> { };
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"SELECT * FROM dutys;";
            MySqlDataReader rdr = cmd.ExecuteReader() as MySqlDataReader;
            while (rdr.Read())
            {
                int dutyId = rdr.GetInt32(0);
                string dutyDescription = rdr.GetString(1);
                Duty newDuty = new Duty(dutyDescription, dutyId);
                allDutys.Add(newDuty);
            }
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }
            return allDutys;

        }

        public static void ClearAll()
        {

        }
    }
}