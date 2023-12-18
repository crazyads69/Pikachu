using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STNLTTQ
{
    public abstract class Database
    {
        private readonly string _connectionString;
        protected MySqlConnection connection;
        public Database()
        {
            _connectionString = "server=sql12.freesqldatabase.com; user=sql12670887; password=cdJ4aaWu7S; database=sql12670887; convert zero datetime=True";
            connection = new MySqlConnection(_connectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}