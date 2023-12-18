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
using DevExpress.XtraPrinting.Native.WebClientUIControl;

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
            command.Connection = connection;
            if (!check)
            {
                command.CommandText = "INSERT INTO LASTEST_STATE VALUES (NULL,@user_name, @state);\n";
                command.CommandText += "INSERT INTO USER VALUES (NULL, @user_name);";
                command.ExecuteNonQuery();
            }
            else
            {
                command.CommandText = "UPDATE LASTEST_STATE SET STATE = @state WHERE USER_NAME = @user_name";
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}