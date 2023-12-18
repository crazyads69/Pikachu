using Org.BouncyCastle.Asn1.Ess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows;

namespace DoubleFours
{
    public partial class Menu : Form
    {

        ChessBoardManager chessBoardManager;

        public Menu()
        {
            InitializeComponent();
        }


        private void pctbBatDau_Click(object sender, EventArgs e)
        {
            Program.form1.firstClick = true;
            Levels level = new Levels();
            level.Show();
            pctbBatDau.Enabled = false;
            pctbTiepTuc.Enabled = false;
            pctbThoat.Enabled = false;
            //SaveData save = new SaveData();
            //save.Save(0);
        }

        private void pctbThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pctbTiepTuc_Click(object sender, EventArgs e)
        {
            if (Program.form1.firstClick == true)
            {
                Option.pause = true;
                Program.form1.options.Pause();//tiếp tục
                Program.form1.Show();
                Program.menu.Hide();
            }
            else
            {
                if (Program.form1.score.Text == "0")
                {
                    MessageBox.Show("Bạn không có dữ liệu nào! Hãy bấm bắt đầu trước khi bấm tiếp tục.");
                }
                else
                {
                    LoadDatabase load = new LoadDatabase();
                    string rank_diff = load.loadRank();
                    if (rank_diff == "EASY") Cons.POKE_NUMBER = 20;
                    if (rank_diff == "NORMAL") Cons.POKE_NUMBER = 25;
                    if (rank_diff == "HARD") Cons.POKE_NUMBER = 30;
                    Program.form1.NewGame();
                    Program.form1.Show();
                    Program.menu.Hide();
                    Program.form1.firstClick = true;
                }
            }
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}