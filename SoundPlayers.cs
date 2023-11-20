using System.Media;
using WMPLib;
namespace Pikachu
{
	internal class SoundPlayers
	{
		public static SoundPlayer mediaClick = new SoundPlayer(global::Pikachu.Properties.Resources.Click);
		public static SoundPlayer media_help = new SoundPlayer(global::Pikachu.Properties.Resources.Help);
		public static SoundPlayer media_flycolor = new SoundPlayer(global::Pikachu.Properties.Resources.FlyColor);
		public static SoundPlayer media_pikachu = new SoundPlayer(global::Pikachu.Properties.Resources.Pikachu);
		public static SoundPlayer media_nope = new SoundPlayer(global::Pikachu.Properties.Resources.Nope);
		public static SoundPlayer media_theme = new SoundPlayer(global::Pikachu.Properties.Resources.Theme);
		public static SoundPlayer media_reee = new SoundPlayer(global::Pikachu.Properties.Resources.reee);
		public static SoundPlayer media_win = new SoundPlayer(global::Pikachu.Properties.Resources.soundWin);
		public static SoundPlayer media_lose = new SoundPlayer(global::Pikachu.Properties.Resources.soundLose);

		public static void BackgroundSound(WindowsMediaPlayer BgMusic)
		{
			BgMusic.URL = "Theme.wav";
			BgMusic.controls.play();
		}

	}
}
