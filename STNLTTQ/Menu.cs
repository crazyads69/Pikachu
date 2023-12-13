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

namespace DoubleFours
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
            
        }


        private void pctbBatDau_Click(object sender, EventArgs e)
        {
            Levels level = new Levels();
            level.Show();
            pctbBatDau.Enabled = false;
            pctbHuongDan.Enabled = false;
            pctbTiepTuc.Enabled = false;
            pctbThoat.Enabled = false;

        }

        private void pctbThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void pctbHuongDan_Click(object sender, EventArgs e)
        {
            pctbHDSD.BackgroundImage = Image.FromFile
("..\\..\\Resources\\huongDanSuDung.jpg");
            pctbHDSD.Visible = true;
            btnBack.Visible = true;
            btnBack.Enabled = true;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            pctbHDSD.Visible = false;
            btnBack.Visible = false;
            btnBack.Enabled = false;
        }

        private void pctbTiepTuc_Click(object sender, EventArgs e)
        {
            Option.pause = true;
            Program.form1.options.Pause();//tiếp tục
            Program.form1.Show();
            Program.menu.Hide();
        }
    }
}
