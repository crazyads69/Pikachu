using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleFours
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        public static Menu menu;
        public static Pika2Vn form1;
        public static string user_name;
        // public static Levels level;
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            menu = new Menu();
            user_name = Microsoft.VisualBasic.Interaction.InputBox("Nhập user_name", "Tên bạn là gì?");
            if (user_name == "")
            {
                Program.menu.Close();
            }
            form1 = new Pika2Vn();
            // level = new Levels();
            Application.Run(menu);
        }
    }
}