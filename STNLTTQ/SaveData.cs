using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Newtonsoft.Json;
using static DoubleFours.Pika2Vn;

namespace DoubleFours
{
    public class SaveData : Database
    {
        public void Save(List<point> curChessboard)
        {
            if (connection.State.ToString() == "Closed")
                connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            // user_name cần đổi
            string user_name = Program.user_name;
            string json = JsonConvert.SerializeObject(curChessboard);
            string rank_diff = "";
            string score = Program.form1.score.Text;
            if (Cons.POKE_NUMBER == 20) rank_diff = "EASY";
            if (Cons.POKE_NUMBER == 25) rank_diff = "NORMAL";
            if (Cons.POKE_NUMBER == 30) rank_diff = "HARD";
            command.CommandText = "SELECT USER_NAME FROM LASTEST_STATE";
            MySqlDataReader reader = command.ExecuteReader();
            bool check = false;
            while (reader.Read())
            {
                if (reader["USER_NAME"].ToString() == user_name) check = true;
            }
            reader.Close();
            command = new MySqlCommand();
            command.Parameters.AddWithValue("@state", json);
            command.Parameters.AddWithValue("@user_name", user_name);
            command.Parameters.AddWithValue("@rank_diff", rank_diff);
            command.Parameters.AddWithValue("@score", score);
            command.Connection = connection;
            if (!check)
            {
                command.CommandText = "INSERT INTO LASTEST_STATE VALUES (NULL,@user_name, @state);\n";
                command.CommandText += "INSERT INTO USER VALUES (NULL, @user_name);\n";
                command.CommandText += "INSERT INTO USER_RANK VALUES (NULL, @user_name, @rank_diff, @score);";
                command.ExecuteNonQuery();
            }
            else
            {
                command.CommandText = "UPDATE LASTEST_STATE SET STATE = @state WHERE USER_NAME = @user_name;\n";
                command.CommandText += "UPDATE USER_RANK SET RANK_DIFF = @rank_diff, SCORE = @score WHERE USER_NAME = @user_name;";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}