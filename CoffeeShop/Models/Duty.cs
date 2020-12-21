using System.Collections.Generic;
using MySql.Data.MySqlClient;
namespace CoffeeShop.Models
{
    public class Duty
    {
        public string DutyDescription { get; set; }
        public int Id { get; set; }

        public Duty(string dutyDescription)
        {
            DutyDescription = dutyDescription;
        }

        public Duty(string dutyDescription, int id)
        {
            DutyDescription = dutyDescription;
            Id = id;
        }

        public override bool Equals(System.Object otherDuty)
        {
            if (!(otherDuty is Duty))
            {
                return false;
            }
            else
            {
                Duty newDuty = (Duty)otherDuty;
                bool idEquality = (this.Id == newDuty.Id);
                bool descriptionEquality = (this.DutyDescription == newDuty.DutyDescription);
                return (idEquality && descriptionEquality);
            }
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

        public void Save()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;

            cmd.CommandText = @"INSERT INTO dutys (dutyDescription) VALUES (@DutyDescription);";
            MySqlParameter dutyDescription = new MySqlParameter();
            dutyDescription.ParameterName = "@DutyDescription";
            dutyDescription.Value = this.DutyDescription;
            cmd.Parameters.Add(dutyDescription);
            cmd.ExecuteNonQuery();
            Id = (int)cmd.LastInsertedId;

            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }

        }

        public static void ClearAll()
        {
            MySqlConnection conn = DB.Connection();
            conn.Open();
            MySqlCommand cmd = conn.CreateCommand() as MySqlCommand;
            cmd.CommandText = @"DELETE FROM dutys;";
            cmd.ExecuteNonQuery();
            conn.Close();
            if (conn != null)
            {
                conn.Dispose();
            }

        }
    }
}