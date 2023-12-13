using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleFours
{
    public class ChessBoardManager
    {
        #region Properties
        private Panel pnlChessBoard;
        public Chess[,] matrix;
        public int coupleRemain = Cons.CHESS_BOARD_HEIGHT * Cons.CHESS_BOARD_WIDTH / 2;
        Queue chosePokemons = new Queue();
        public InfinityStones infinityStone { get; set; }
        #endregion

        #region Initialize
        public ChessBoardManager(Panel pnlChessBoard)
        {
            this.pnlChessBoard = pnlChessBoard;

            DrawChessBoard();
        }
        #endregion

        #region Method
        //tao ban co
        public void DrawChessBoard()
        {
            pnlChessBoard.Controls.Clear();//xóa bàn cờ để vẽ lại
            matrix = new Chess[Cons.CHESS_BOARD_WIDTH + 2, Cons.CHESS_BOARD_HEIGHT + 2];
            //+2 để tạo 1 đường viền null xung quanh để thuật toán chữ U

            Chess old_pokemon = new Chess(-1, -1, -1, 0)
            {
                Width = 0,
                Height = 0,
                Location = new Point(0, 0),
            };

            Random rd = new Random();
            for (int i = 0; i < Cons.CHESS_BOARD_HEIGHT + 2; i++)//update
            {

                for (int j = 0; j < Cons.CHESS_BOARD_WIDTH + 2; j++)
                {
                    int randomID;

                    randomID = rd.Next(0, Cons.POKE_NUMBER);
                    Chess pokemon = new Chess(j, i, randomID, 0)
                    {
                        Width = Cons.CHESS_WIDTH,
                        Height = Cons.CHESS_HEIGHT,
                        Location = new Point(old_pokemon.Location.X + old_pokemon.Width, old_pokemon.Location.Y),
                    };

                    //đường viền bằng null
                    if (i != 0 && i != Cons.CHESS_BOARD_HEIGHT + 1 && j != 0 && j != Cons.CHESS_BOARD_WIDTH + 1)
                    {
                        pokemon.PokeRandom(randomID);
                        pokemon.Cursor = Cursors.PanNW;//chỉnh avatar con trỏ
                    }



                    pokemon.Click += Pokemon_Click;


                    pnlChessBoard.Controls.Add(pokemon);
                    old_pokemon = pokemon;
                    matrix[j, i] = pokemon;
                }

                old_pokemon.Location = new Point(0, old_pokemon.Location.Y + Cons.CHESS_HEIGHT);
                old_pokemon.Width = 0;
                old_pokemon.Height = 0;
            }
        }

 
        private void Pokemon_Click(object sender, EventArgs e)
        {
            Chess pokemon = (Chess)sender;
            if (pokemon.BackgroundImage == null)
                return;
            pokemon.PokeClicked();//pokemon hóa vàng
            chosePokemons.Enqueue(pokemon);

            if (chosePokemons.Count == 2)
            {
                Chess pokemon1 = (Chess)chosePokemons.Dequeue();
                Chess pokemon2 = (Chess)chosePokemons.Dequeue();

                if (pokemon1.ID_Pokemon != pokemon2.ID_Pokemon)
                {
                    pokemon1.PokeDefault();
                    pokemon2.PokeDefault();
                    DFSoundPlayer.media_nope.Play();
                }
                else if (pokemon1.X == pokemon2.X && pokemon1.Y == pokemon2.Y)
                {
                    pokemon1.PokeDefault();
                    pokemon2.PokeDefault();

                }
                else
                {
                    // delete without checking
                    //pokemon1.BackgroundImage = null;
                    //pokemon2.BackgroundImage = null;
                    // delete if true conditions

                    bool check = checkPokemon(pokemon1, pokemon2);
                    if (check)
                    {
                        pokemon1.BackgroundImage = null;
                        pokemon2.BackgroundImage = null;
                        DFSoundPlayer.media_pikachu.Play();
                        infinityStone.CheckStone(pokemon1);
                        infinityStone.CheckStone(pokemon2);
                        coupleRemain -= 1;

                    }
                    else
                    {
                        pokemon1.PokeDefault();
                        pokemon2.PokeDefault();
                        DFSoundPlayer.media_nope.Play();
                    }

                }


            }
        }

        // checking
        public bool checkPokemon(Chess poke1, Chess poke2)
        {
            if (poke1.X == poke2.X)
                if (checkLineX(poke1.Y, poke2.Y, poke1.X))
                    return true;

            if (poke1.Y == poke2.Y)
                if (checkLineY(poke1.X, poke2.X, poke1.Y))
                    return true;

            if (checkRectX(poke1, poke2) != -1)
                return true;
            if (checkRectY(poke1, poke2) != -1)
                return true;

            //right
            if (checkMoreLineX(poke1, poke2, 1) != -1)
                return true;
            //left
            if (checkMoreLineX(poke1, poke2, -1) != -1)
                return true;

            if (checkMoreLineY(poke1, poke2, 1) != -1)
                return true;
            if (checkMoreLineY(poke1, poke2, -1) != -1)
                return true;

            return false;
        }

        private bool checkLineX(int y1, int y2, int x)
        {
            // find point have column max and min
            int min = Math.Min(y1, y2);
            int max = Math.Max(y1, y2);
            // run column
            for (int y = min + 1; y < max; y++)
            {
                if (matrix[x, y].BackgroundImage != null)
                { // if see barrier then die
                    return false;
                }
            }
            // not die -> success
            return true;
        }

        private bool checkLineY(int x1, int x2, int y)
        {
            int min = Math.Min(x1, x2);
            int max = Math.Max(x1, x2);
            for (int x = min + 1; x < max; x++)
            {
                if (matrix[x, y].BackgroundImage != null)
                {
                    return false;
                }
            }
            return true;
        }

        // check in rectangle
        private int checkRectX(Chess p1, Chess p2)
        {
            // find point have y min and max
            Chess pMinY, pMaxY;
            if (p1.Y > p2.Y)
            {
                pMinY = p2;
                pMaxY = p1;
            }
            else
            {
                pMinY = p1;
                pMaxY = p2;
            }
            for (int y = pMinY.Y; y <= pMaxY.Y; y++)
            {
                if (y > pMinY.Y && matrix[pMinY.X, y].BackgroundImage != null)
                {
                    return -1;
                }
                // check two line
                if ((matrix[pMaxY.X, y].BackgroundImage == null || y == pMaxY.Y)
                        && checkLineY(pMinY.X, pMaxY.X, y)
                        && checkLineX(y, pMaxY.Y, pMaxY.Y))
                {
                    // if three line is true return column y
                    return y;
                }
            }
            // have a line in three line not true then return -1
            return -1;
        }

        private int checkRectY(Chess p1, Chess p2)
        {
            // find point have y min
            Chess pMinX, pMaxX;
            if (p1.X > p2.X)
            {
                pMinX = p2;
                pMaxX = p1;
            }
            else
            {
                pMinX = p1;
                pMaxX = p2;
            }
            // find line and y begin
            for (int x = pMinX.X; x <= pMaxX.X; x++)
            {
                if (x > pMinX.X && matrix[x, pMinX.Y].BackgroundImage != null)
                {
                    return -1;
                }
                if ((matrix[x, pMaxX.Y].BackgroundImage == null || x == pMaxX.X)
                        && checkLineX(pMinX.Y, pMaxX.Y, x)
                        && checkLineY(x, pMaxX.X, pMaxX.Y))
                {

                    return x;
                }
            }
            return -1;
        }

        private int checkMoreLineX(Chess p1, Chess p2, int type)
        {
            // find point have y min
            Chess pMinY, pMaxY;
            if (p1.Y > p2.Y)
            {
                pMinY = p2;
                pMaxY = p1;
            }
            else
            {
                pMinY = p1;
                pMaxY = p2;
            }
            // find line and y begin
            int y = pMaxY.Y + type;
            int row = pMinY.X;
            int colFinish = pMaxY.Y;
            if (type == -1)
            {
                colFinish = pMinY.Y;
                y = pMinY.Y + type;
                row = pMaxY.X;
            }

            // find column finish of line

            // check more
            if ((matrix[row, colFinish].BackgroundImage == null || pMinY.Y == pMaxY.Y)
                    && checkLineX(pMinY.Y, pMaxY.Y, row))
            {
                while (matrix[pMinY.X, y].BackgroundImage == null
                        && matrix[pMaxY.X, y].BackgroundImage == null)
                {
                    if (checkLineY(pMinY.X, pMaxY.X, y))
                    {
                        return y;
                    }
                    y += type;
                }
            }
            return -1;
        }

        private int checkMoreLineY(Chess p1, Chess p2, int type)
        {
            Chess pMinX, pMaxX;
            if (p1.X > p2.X)
            {
                pMinX = p2;
                pMaxX = p1;
            }
            else
            {
                pMinX = p1;
                pMaxX = p2;
            }
            int x = pMaxX.X + type;
            int col = pMinX.Y;
            int rowFinish = pMaxX.X;
            if (type == -1)
            {
                rowFinish = pMinX.X;
                x = pMinX.X + type;
                col = pMaxX.Y;
            }
            if ((matrix[rowFinish, col].BackgroundImage == null || pMinX.X == pMaxX.X)
                    && checkLineY(pMinX.X, pMaxX.X, col))
            {
                while (matrix[x, pMinX.Y].BackgroundImage == null
                        && matrix[x, pMaxX.Y].BackgroundImage == null)
                {
                    if (checkLineX(pMinX.Y, pMaxX.Y, x))
                    {
                        return x;
                    }
                    x += type;
                }
            }
            return -1;
        }
        #endregion
    }
}
