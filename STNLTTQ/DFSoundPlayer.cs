using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using AxWMPLib;

namespace DoubleFours
{
    class DFSoundPlayer
    {
        public static SoundPlayer media_click = new SoundPlayer(global::DoubleFours.Properties.Resources.Click);
        public static SoundPlayer media_help = new SoundPlayer(global::DoubleFours.Properties.Resources.Help1);
        public static SoundPlayer media_flycolor = new SoundPlayer(global::DoubleFours.Properties.Resources.FlyColor);
        public static SoundPlayer media_pikachu = new SoundPlayer(global::DoubleFours.Properties.Resources.Pikachu);
        public static SoundPlayer media_nope = new SoundPlayer(global::DoubleFours.Properties.Resources.Nope);
        public static SoundPlayer media_theme = new SoundPlayer(global::DoubleFours.Properties.Resources.Theme);
        public static SoundPlayer media_reee = new SoundPlayer(global::DoubleFours.Properties.Resources.reee);
        public static SoundPlayer media_win = new SoundPlayer(global::DoubleFours.Properties.Resources.soundWin);
        public static SoundPlayer media_lose = new SoundPlayer(global::DoubleFours.Properties.Resources.soundLose);
        public static SoundPlayer media_foundstone = new SoundPlayer(global::DoubleFours.Properties.Resources.foundstone);

        public static void BackgroundSound(AxWindowsMediaPlayer BgMusic)
        {
            BgMusic.URL = "Theme.wav";
            BgMusic.Ctlcontrols.play();
        }


    }
}
