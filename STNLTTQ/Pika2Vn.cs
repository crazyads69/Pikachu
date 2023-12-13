using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;
using System.Media;
using System.Threading;
using AxWMPLib;

namespace DoubleFours
{
    public partial class Pika2Vn : Form
    {

        #region Properties
        ChessBoardManager chessBoard;
        LifeTime lifeTime;
        Item items;
        InfinityStones stone;
        public Option options;
        private bool endgame = false;
        #endregion


        public Pika2Vn()
        {

            InitializeComponent();
            Timer.Interval = Cons.LIFETIME_INTERVAL;

            CollectionImage.PokemonImage = CollectionImage.CreatePokemon(DoubleFours.Properties.Resources.pokemongame,
            Cons.POKE_NUMBER_IMAGE, Cons.POKE_STATUS);


            //NewGame();

        }


        #region Methods

        public void NewGame()
        {
            this.SuspendLayout();
            chessBoard = new ChessBoardManager(pnlChessBoard);
            //chessBoard.KhoiTaoStone(ptbstone1, ptbstone2, ptbstone3, ptbstone4, ptbstone5, ptbstone6);
            //chessBoard.resetStone();
            stone = new InfinityStones(ptbstone1, ptbstone2, ptbstone3, ptbstone4, ptbstone5, ptbstone6, chessBoard);
            chessBoard.infinityStone = stone;
            items = new Item(pctbHelp, pctbReset, pctbFlyColor, chessBoard);
            options = new Option(pctbHome, pctbPlay, pctbPause, pctbSoundOff, pctbSoundOn, BgMusic, Timer);

            lifeTime = new LifeTime(progressBar, percent, pctbLifeTime);

            endgame = false;
            Option.pause = false;
            UpdateStatus(endgame, Option.pause);

            Timer.Start();

            this.ResumeLayout();
        }

        //update
        private void Timer_Tick(object sender, EventArgs e)
        {

            lifeTime.UpdateLifeTime();
            if (progressBar.Width == 0)
                LoseGame();

            if (chessBoard.coupleRemain == 0)
                WinGame();

        }

        public void UpdateStatus(bool endgame, bool pause)
        {
            if (endgame == false && pause == false)
            {
                pnlChessBoard.Enabled = true;
                pctbFlyColor.Enabled = true;
                pctbHelp.Enabled = true;
                pctbHome.Enabled = true;
                pctbReset.Enabled = true;
                pctbSoundOn.Enabled = true;
                pctbPause.Enabled = true;
                Option.LockSound = true;
                options.SoundOnOff();
            }
            else if (endgame == false && pause == true)
            {
                pnlChessBoard.Enabled = false;
                pctbFlyColor.Enabled = false;
                pctbHelp.Enabled = false;
                pctbReset.Enabled = false;
                Option.LockSound = false;
                options.SoundOnOff();
            }
            else//endgame=true
            {
                pnlChessBoard.Enabled = false;
                pctbFlyColor.Enabled = false;
                pctbHelp.Enabled = false;
                pctbReset.Enabled = false;
                pctbPause.Enabled = false;
                Option.LockSound = true;
                options.SoundOnOff();
            }



        }
        //update
        void EndGame()
        {
            Timer.Stop();
            endgame = true;
            UpdateStatus(endgame, Option.pause);
            BgMusic.Ctlcontrols.stop();

        }

        void WinGame()
        {
            DFSoundPlayer.media_win.Play();
            EndGame();
            MessageBox.Show("YOU WIN!");


        }

        void LoseGame()
        {
            DFSoundPlayer.media_lose.Play();
            EndGame();
            MessageBox.Show("LOSER!");

        }

        private void pctbPause_Click(object sender, EventArgs e)
        {

            if (endgame == false)
            {
                if (Option.LockSound == false)
                {
                    DFSoundPlayer.media_click.Play();
                }

                options.Pause();
            }
        }

        private void pctbReset_Click(object sender, EventArgs e)
        {
            if (Option.LockSound == false) DFSoundPlayer.media_click.Play();
            if (lifeTime.Reset())
                items.ResetChessBoard();
            this.ResumeLayout();
        }

        private void pctbFlyColor_Click(object sender, EventArgs e)
        {
            if (stone.canSnap() == false)
            {
                MessageBox.Show(
                    "Bạn chưa tìm đủ 6 viên đá để thực hiện BÚNG TAY",
                    "Đọc kĩ hướng dẫn sử dụng trước khi dùng",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if (chessBoard.coupleRemain % 2 != 0)
                {
                    MessageBox.Show(
                        "Số cặp pokemon đang LẺ!\nPhải ăn thêm 1 cặp mới được thực hiện cú BÚNG TAY",
                        "Đọc kĩ hướng dẫn sử dụng trước khi dùng",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                else if(lifeTime.FlyColor())
                {
                    if (Option.LockSound == false) DFSoundPlayer.media_flycolor.Play();
                    items.FlyColor(items.PokeFlyColor(), 0);
                    stone.resetStone();
                    chessBoard.coupleRemain = chessBoard.coupleRemain / 2;//update
                }
            }
        }

        private void pctbHelp_Click(object sender, EventArgs e)
        {
            if (Option.LockSound == false) DFSoundPlayer.media_help.Play();
            lifeTime.Help();

            items.Help();
        }

        private void avt1_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < Cons.CHESS_BOARD_HEIGHT + 1; i++)
            {
                for (int j = 1; j < Cons.CHESS_BOARD_WIDTH + 1; j++)
                {
                    if (chessBoard.matrix[j, i].BackgroundImage != null)
                        chessBoard.matrix[j, i].Cursor = Cursors.PanNW;
                }
            }
        }

        private void avt2_Click(object sender, EventArgs e)
        {
            for (int i = 1; i < Cons.CHESS_BOARD_HEIGHT + 1; i++)
            {
                for (int j = 1; j < Cons.CHESS_BOARD_WIDTH + 1; j++)
                {
                    if (chessBoard.matrix[j, i].BackgroundImage != null)
                        chessBoard.matrix[j, i].Cursor = Cursors.Cross;
                }
            }
        }

        private void BgMusic_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            if (BgMusic.playState == WMPLib.WMPPlayState.wmppsStopped && endgame == false)
            {
                BgMusic.Ctlcontrols.play();
            }
        }

        private void pctbHome_Click(object sender, EventArgs e)
        {

            Option.pause = false;
            options.Pause();
            Program.menu.pctbTiepTuc.Enabled = true;
            Program.form1.Hide();
            Program.menu.Show();
        }

        private void pctbSound_Click(object sender, EventArgs e)
        {
            DFSoundPlayer.media_click.Play();
            options.SoundOnOff();

        }

        private void pctbReset_MouseHover(object sender, EventArgs e)
        {
            ToolTip ttReset = new ToolTip();
            ttReset.IsBalloon = true;

            ttReset.SetToolTip(pctbReset, "Đảo Vị Trí");

        }

        private void pctbHelp_MouseHover(object sender, EventArgs e)
        {
            ToolTip ttHelp = new ToolTip();
            ttHelp.IsBalloon = true;

            ttHelp.SetToolTip(pctbHelp, "Tìm Gợi Ý");
        }

        private void pctbFlyColor_MouseHover(object sender, EventArgs e)
        {
            ToolTip ttFlyColor = new ToolTip();
            ttFlyColor.IsBalloon = true;
            ttFlyColor.SetToolTip
                (pctbFlyColor, "----Thực Hiện Cú Búng Tay----\nChú ý: Chỉ được sử dụng khi số cặp pokemon là lẻ");
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Program.menu.Close();
        }
        #endregion

        private void pnlChessBoard_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
