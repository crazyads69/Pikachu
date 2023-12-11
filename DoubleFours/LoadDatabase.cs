using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleFours
{
    public class LoadDatabase : Database
    {

        public int LoadLostFromDatabase()
        {
            int lost = 0;
            if (connection.State.ToString() == "Closed")
                connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT LOST FROM LASTEST_SCENE WHERE LASTEST_SCENE_ID = @id";
            string id = "01";
            command.Parameters.AddWithValue("@id", id);
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
                lost = int.Parse(reader["LOST"].ToString());
            connection.Close();
            return lost * 2;
        }
    }
}
