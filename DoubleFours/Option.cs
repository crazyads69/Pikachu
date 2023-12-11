using AxWMPLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleFours
{
    public class Option
    {
        public static bool pause = false;
        public static bool LockSound = false;
        private bool endgame = false;
        private PictureBox pctbHome;
        private PictureBox pctbPlay;
        private PictureBox pctbPause;
        private PictureBox pctbSoundOff;
        private PictureBox pctbSoundOn;
        AxWindowsMediaPlayer BgMusic;
        Timer Timer;


        public Option(PictureBox pctbHome,PictureBox pctbPlay,PictureBox pctbPause,PictureBox pctbSoundOff,PictureBox pctbSoundOn,AxWindowsMediaPlayer BgMusic,Timer Timer)
        {
            this.pctbHome = pctbHome;
            this.pctbPlay = pctbPlay;
            this.pctbPause = pctbPause;
            this.pctbSoundOff = pctbSoundOff;
            this.pctbSoundOn = pctbSoundOn;
            this.BgMusic = BgMusic;
            this.Timer = Timer;
            pctbPlay.Visible = false;
            pctbSoundOff.Visible = false;
            DFSoundPlayer.BackgroundSound(BgMusic);
        }
        

        public void SoundOnOff()
        {
            if (LockSound == false)
            {
                LockSound = true;
                BgMusic.Ctlcontrols.pause();

                pctbSoundOff.Visible = true;
            }
            else
            {
                if (endgame == false)
                    BgMusic.Ctlcontrols.play();
                LockSound = false;

                pctbSoundOff.Visible = false;
            }
        }

        public void Pause()
        {

            if (pause == false)
            {
                pause = true;
                Program.form1.UpdateStatus(endgame, pause);
                Timer.Stop();

                pctbPlay.Visible = true;
            }
            else
            {
                pause = false;
                Program.form1.UpdateStatus(endgame, pause);
                Timer.Start();

                pctbPlay.Visible = false;
            }

        }
    }
}
