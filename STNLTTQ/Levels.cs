using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleFours
{
    public partial class Levels : Form
    {
        public Levels()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radEasy_CheckedChanged(object sender, EventArgs e)
        {
            Cons.POKE_NUMBER = 20;
        }

        private void radNormal_CheckedChanged(object sender, EventArgs e)
        {
            Cons.POKE_NUMBER = 25;
        }

        private void radHard_CheckedChanged(object sender, EventArgs e)
        {
            Cons.POKE_NUMBER = 30;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            this.Close();
            Program.form1.NewGame();
            Program.form1.Show();

            Program.menu.Hide();
        }

        private void Levels_Load(object sender, EventArgs e)
        {
            
        }

        private void Levels_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.menu.pctbBatDau.Enabled = true;
            Program.menu.pctbHuongDan.Enabled = true;

            if(Option.pause == true)//game đang chơi giữa chừng
            Program.menu.pctbTiepTuc.Enabled = true;

            Program.menu.pctbThoat.Enabled = true;
        }
    }
}
