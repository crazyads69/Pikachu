using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleFours
{
    public class Item
    {
        private PictureBox pctbHelp;
        private PictureBox pctbReset;
        private PictureBox pctbFlyColor;
        private ChessBoardManager chessBoard;
        public Item(PictureBox pctbHelp,PictureBox pctbReset,PictureBox pctbFlyColor,ChessBoardManager chessBoard)
        {
            this.pctbHelp = pctbHelp;
            this.pctbReset = pctbReset;
            this.pctbFlyColor = pctbFlyColor;
            this.chessBoard = chessBoard;
        }

        public void ResetChessBoard()
        {
            Random rd = new Random();
            for (int i = 1; i < Cons.CHESS_BOARD_HEIGHT + 1; i++)
            {
                for (int j = 1; j < Cons.CHESS_BOARD_WIDTH + 1; j++)
                {
                    if (chessBoard.matrix[j, i].BackgroundImage != null)
                    {
                        int numRandom;
                        int max = chessBoard.coupleRemain / 2;
                        if (max >= Cons.POKE_NUMBER)//đảm bảo ko xuất hiện pokemon lạ và ko Exception Index
                            max = Cons.POKE_NUMBER;
                        numRandom = rd.Next(0, max);//update
                        //coupleRemain cặp -> 1 nửa cặp xuất hiện->xác suất win cao hơn
                        //và phải <= POKE_NUMBER
                        chessBoard.matrix[j, i].ID_Pokemon = numRandom;
                        chessBoard.matrix[j, i].PokeRandom(numRandom);
                    }
                }
            }
        }

        public void Help()
        {

            // Add not-null chess into chessArray
            ArrayList chessArray = new ArrayList();
            for (int i = 1; i < Cons.CHESS_BOARD_HEIGHT + 1; i++)
            {
                for (int j = 1; j < Cons.CHESS_BOARD_WIDTH + 1; j++)
                {
                    if (chessBoard.matrix[j, i].BackgroundImage != null)
                        chessArray.Add(chessBoard.matrix[j, i]);
                }
            }
            // Fingding couple
            Chess pokeFound1 = null;
            Chess pokeFound2 = null;
            bool found = false;
            for (int i = 0; i < chessArray.Count; i++)
            {
                Chess poke1 = (Chess)chessArray[i];
                for (int j = i + 1; j < chessArray.Count; j++)
                {
                    Chess poke2 = (Chess)chessArray[j];
                    if (chessBoard.checkPokemon(poke1, poke2) == true && poke1.ID_Pokemon == poke2.ID_Pokemon)
                    {
                        pokeFound1 = poke1;
                        pokeFound2 = poke2;
                        found = true;
                        break;
                    }
                    if (found == true)
                        break;
                }
            }
            // If found, change color
            if (found == true)
            {
                pokeFound1.PokeHelp();
                pokeFound2.PokeHelp();
            }
            else
            {
                MessageBox.Show("Couple not found !! Please roll !");
            }

        }

        public int PokeFlyColor()
        {
            int num = 0;
            for (int i = 1; i < Cons.CHESS_BOARD_HEIGHT + 1; i++)
            {
                for (int j = 1; j < Cons.CHESS_BOARD_WIDTH + 1; j++)
                {
                    if (chessBoard.matrix[j, i].BackgroundImage != null)
                    {
                        num++;
                    }
                }
            }
            num = num / 2;
            return num;
        }

        private bool FlyColor(int PokeFlyColor, int x, Random rd)
        {
            if (PokeFlyColor != x)
            {
                int i;


                int j;
                i = rd.Next(1, Cons.CHESS_BOARD_HEIGHT + 1);//update
                j = rd.Next(1, Cons.CHESS_BOARD_WIDTH + 1);
                if (chessBoard.matrix[j, i].BackgroundImage != null)
                {
                    chessBoard.matrix[j, i].BackgroundImage = null;
                    x++;
                    return FlyColor(PokeFlyColor, x, rd);

                }
                else return FlyColor(PokeFlyColor, x, rd);
            }
            else return true;

        }


        public void FlyColor(int PokeFlyColor, int x)
        {

            Random rd = new Random();
            FlyColor(PokeFlyColor, x, rd);
        }
    }
}
