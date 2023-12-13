using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DoubleFours.Pika2Vn;

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
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "SELECT X, Y FROM CURRENT";
            MySqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                temp.x = int.Parse(reader["X"].ToString());
                temp.y = int.Parse(reader["Y"].ToString());
                if (temp.x > 0 && temp.y > 0)
                    curChessboard.Add(temp);
            }
            connection.Close();
            return curChessboard;
        }
    }
}