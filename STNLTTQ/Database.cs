using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleFours
{
    public abstract class Database
    {
        private readonly string _connectionString;
        protected MySqlConnection connection;
        public Database()
        {
            _connectionString = "server=sql12.freesqldatabase.com; user=sql12668859; password=RhTASwr6ex; database=sql12668859; convert zero datetime=True";
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