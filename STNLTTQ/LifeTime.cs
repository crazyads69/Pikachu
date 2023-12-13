using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleFours
{
    public class LifeTime
    {
        public PictureBox ptbProgressBar;
        public Label lbPercent;
        public int percent = 100;
        public int maxWidth = 945;
        public bool flyColor = false;
        PictureBox pctbLifeTime;
        private bool count_sound = false;

        public LifeTime(PictureBox ptbProgressBar, Label lbPercent,PictureBox pctbLifeTime)
        {
            this.ptbProgressBar = ptbProgressBar;
            this.lbPercent = lbPercent;
            this.pctbLifeTime = pctbLifeTime;

            NewGame();

        }

        public void NewGame()
        {
            ptbProgressBar.Width = maxWidth;
            percent = 100;
            count_sound = false;
            pctbLifeTime.Image = Image.FromFile
("..\\..\\Resources\\progressbarEch.png");           
            LifeTimePaint();
        }

        public bool Reset()
        {
            if (ptbProgressBar.Width > maxWidth * 0.03)
            {
                ptbProgressBar.Width -= maxWidth * 2 / 100;
                LifeTimePaint();
                return true;
            }
            else return false;

        }

        public bool FlyColor()
        {
            if (ptbProgressBar.Width > maxWidth * 0.04)//update
            {
                ptbProgressBar.Width -= ptbProgressBar.Width / 2;
                LifeTimePaint();
                return true;
            }
            else return false;
        }

        public void Help()
        {
            if (ptbProgressBar.Width > maxWidth * 0.04)
                ptbProgressBar.Width -= maxWidth * 3 / 100;
            LifeTimePaint();
        }

        public void LifeTimePaint()
        {

            if (percent > 80) ptbProgressBar.BackColor = Color.Lime;
            else if (percent > 60) ptbProgressBar.BackColor = Color.GreenYellow;
            else if (percent > 40) ptbProgressBar.BackColor = Color.Yellow;
            else if (percent > 20)
            {
                ptbProgressBar.BackColor = Color.Tomato;
                pctbLifeTime.Image = Image.FromFile
                    ("..\\..\\Resources\\progressbarEchToang.png");
                if (Option.LockSound == false && count_sound == false)
                {
                    DFSoundPlayer.media_reee.Play();
                    count_sound = true;
                }
            }
            else ptbProgressBar.BackColor = Color.Red;
            if (ptbProgressBar.Width > 0)
            {
                percent = ptbProgressBar.Width * 100 / maxWidth;
                if (percent == 0) percent = 1;
            }
            else percent = 0;
            if (percent > 9)
                lbPercent.Text = " " + percent.ToString() + "%";
            else
                lbPercent.Text = "  " + percent.ToString() + "%";

        }

        public void UpdateLifeTime()
        {
            if (ptbProgressBar.Width > 0)
            {
                ptbProgressBar.Width--;
                LifeTimePaint();
            }

        }


    }
}
