using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleFours
{
    //Quan li 1 o pokemon,dạng picturebox nhung co toa do,ID_Action
    public class Chess:PictureBox
    {
        //tranh nham lan toa do X,Y cua location
        //toa do tren ban co
        public int X { get; set; }
        public int Y { get; set; }
        //toa do trong hinh pokemongame.png
        public int ID_Action { get; set; }
        public int ID_Pokemon { get; set; }
        public override Image BackgroundImage
        {
            get
            {
                return base.BackgroundImage;
            }

            set
            {
                base.BackgroundImage = value;
                if (value == null)
                    this.Cursor = Cursors.Default;
            }
        }
        public Chess(int X,int Y,int ID_Pokemon,int ID_Action)
        {
            this.X = X;
            this.Y = Y;
            this.ID_Pokemon = ID_Pokemon;
            this.ID_Action = ID_Action;
        }

        public void PokeDefault()
        {
            this.BackgroundImage = CollectionImage.PokemonImage[ID_Pokemon, 0];
        }
        public void PokeClicked()
        {
            this.BackgroundImage = CollectionImage.PokemonImage[ID_Pokemon, 1];
        }
        public void PokeHelp()
        {
            this.BackgroundImage = CollectionImage.PokemonImage[ID_Pokemon, 2];
        }
        public void PokeRandom(int numRandom)
        {
            this.BackgroundImage = CollectionImage.PokemonImage[numRandom, 0];
        }
    }
}
