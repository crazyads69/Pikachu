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
            for (int id = 1; id <= curChessboard.Count(); id++)
            {
                command.Parameters.Clear();
                command.CommandText += "UPDATE CURRENT SET X = @x, Y = @y WHERE ID = @id;";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@x", curChessboard[id - 1].x);
                command.Parameters.AddWithValue("@y", curChessboard[id - 1].y);
                command.ExecuteNonQuery();
            }
            for (int id = curChessboard.Count() + 1; id <= 128; id++)
            {
                command.Parameters.Clear();
                command.CommandText += "UPDATE CURRENT SET X = @x, Y = @y WHERE ID = @id;";
                command.Parameters.AddWithValue("@id", id);
                command.Parameters.AddWithValue("@x", 0);
                command.Parameters.AddWithValue("@y", 0);
                command.ExecuteNonQuery();
            }
            connection.Close();
        }
    }
}