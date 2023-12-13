using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace DoubleFours
{
    public class SaveData : Database
    {
        public void Save(int lost)
        {
            if (connection.State.ToString() == "Closed")
                connection.Open();
            MySqlCommand command = new MySqlCommand();
            command.Connection = connection;
            command.CommandText = "UPDATE LASTEST_SCENE SET LOST = @lost WHERE LASTEST_SCENE_ID = @id";
            command.Parameters.AddWithValue("@id", MySqlDbType.VarString).Value = "01";
            command.Parameters.AddWithValue("@lost", lost);
            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}