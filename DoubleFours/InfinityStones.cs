using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleFours
{
    public class InfinityStones
    {
        private PictureBox ptbstone2;
        private PictureBox ptbstone3;
        private PictureBox ptbstone4;
        private PictureBox ptbstone5;
        private PictureBox ptbstone6;
        private PictureBox ptbstone1;
        private int numstone;
        private int[,] stone = new int[6, 2];
        ChessBoardManager chessBoard;
        public InfinityStones(PictureBox ptbstone1, PictureBox ptbstone2, PictureBox ptbstone3, PictureBox ptbstone4, PictureBox ptbstone5, PictureBox ptbstone6,ChessBoardManager chessBoard)
        {
            this.ptbstone1 = ptbstone1;
            this.ptbstone2 = ptbstone2;
            this.ptbstone3 = ptbstone3;
            this.ptbstone4 = ptbstone4;
            this.ptbstone5 = ptbstone5;
            this.ptbstone6 = ptbstone6;
            this.chessBoard = chessBoard;
            resetStone();
        }
        public void resetStone()
        {
            numstone = 0;
            stoneLocation();

            ptbstone1.Visible = false;

            ptbstone2.Visible = false;

            ptbstone3.Visible = false;

            ptbstone4.Visible = false;

            ptbstone5.Visible = false;

            ptbstone6.Visible = false;
        }
        private void stoneLocation()
        {
            Random rd = new Random();
            if (chessBoard.coupleRemain*2 > 30)//búng tay 1 lần xong mà trên 30 pokemon vẫn tiếp tục tìm đá
            {
                for (int i = 0; i < 6; i++)
                {
                    int x;
                    int y;
                    y = rd.Next(1, Cons.CHESS_BOARD_HEIGHT + 1);//update
                    x = rd.Next(1, Cons.CHESS_BOARD_WIDTH + 1);
                    if (chessBoard.matrix[x, y].BackgroundImage != null)
                    {
                        stone[i, 0] = x;
                        stone[i, 1] = y;
                    }
                }
            }
            else
            {
                stone = null;
            }
        }
        public void CheckStone(Chess poke)
        {
            int kindofstone;
            if (stone != null)
                for (int i = 0; i < 6; i++)
                {
                    if (poke.X == stone[i, 0] && poke.Y == stone[i, 1])
                    {
                        numstone++;
                        kindofstone = i;
                        UpdateStone(kindofstone);
                        DFSoundPlayer.media_foundstone.Play();
                        break;
                    }
                }

        }
        private void UpdateStone(int kindofstone)
        {
            switch (kindofstone)
            {
                case 0:
                    ptbstone1.Visible = true;
                    break;
                case 1:
                    ptbstone2.Visible = true;
                    break;
                case 2:
                    ptbstone3.Visible = true;
                    break;
                case 3:
                    ptbstone4.Visible = true;
                    break;
                case 4:
                    ptbstone5.Visible = true;
                    break;
                case 5:
                    ptbstone6.Visible = true;
                    break;
            }
        }
        public bool canSnap()
        {
            if (numstone == 6) return true;
            else return false;
        }
    }
}
