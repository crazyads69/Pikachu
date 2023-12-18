using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using static DoubleFours.Pika2Vn;
using System.Windows.Forms;

namespace DoubleFours
{
    public class LoadDatabase : Database
    {

        public List<point> LoadFromDatabase()
        {
            if (connection.State.ToString() == "Closed")
                connection.Open();
            List<point> curChessboard = new List<point>();
            point temp = new point();
            string user_name = Program.user_name;
            bool check = false;
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT USER_NAME FROM LASTEST_STATE";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["USER_NAME"].ToString() == user_name) check = true;
            }
            reader.Close();
            command = new MySqlCommand();
            command.Connection = connection;
            if (check)
            {
                command.CommandText = "SELECT STATE FROM LASTEST_STATE WHERE USER_NAME = @user_name";
                command.Parameters.AddWithValue("@user_name", user_name);
                reader = command.ExecuteReader();
                reader.Read();
                string json = reader["STATE"].ToString();
                curChessboard = JsonConvert.DeserializeObject<List<point>>(json);
            }
            else
            {
                //xử lý nếu ko tồn tại user_name trong lastest_state
            }
            connection.Close();
            return curChessboard;
        }

        public string loadScore()
        {
            string score = "0";
            if (connection.State.ToString() == "Closed")
                connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            string user_name = Program.user_name;
            command.CommandText = "SELECT USER_NAME, SCORE FROM USER_RANK";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["USER_NAME"].ToString() == user_name)
                {
                    score = reader["SCORE"].ToString();
                }
            }
            connection.Close();
            return score;
        }

        public string loadRank()
        {
            string rank = "EASY";
            if (connection.State.ToString() == "Closed")
                connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            string user_name = Program.user_name;
            command.CommandText = "SELECT USER_NAME, RANK_DIFF FROM USER_RANK";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                if (reader["USER_NAME"].ToString() == user_name)
                {
                    rank = reader["RANK_DIFF"].ToString();
                }
            }
            connection.Close();
            return rank;
        }
    }
}