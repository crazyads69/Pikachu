using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoubleFours
{
    public class CollectionImage
    {
        //tao ma tran chia nho hinh png pokemongame.png thanh cac image bitmap rieng biet
        //31 con voi 3 trang thai
        public static Bitmap[,] PokemonImage; //{ get; set; }
        //ma trận hình là 1 biến dùng chung sẽ khởi tạo ngay đầu form1
        public CollectionImage(Bitmap bigbitmap, int PoNumber, int PoAction)
        {
            PokemonImage = CreatePokemon(bigbitmap, PoNumber, PoAction);
        }
        //chia nho image
        public static Bitmap[,] CreatePokemon(Bitmap bigbitmap, int PoNumber, int PoAction)
        {
            Bitmap[,] bm = new Bitmap[PoNumber, PoAction];
            float _Height = (float)bigbitmap.Height / PoAction;//chieu` doc//cac trang thai pokemon
            float _Width = (float)bigbitmap.Width / PoNumber;//chieu ngang//31 con pokemon
            for (int i = 0; i < PoNumber; i++)
                for (int j = 0; j < PoAction; j++)
                {
                    bm[i, j] = bigbitmap.Clone(new Rectangle((int)(i * _Width), (int)(j * _Height)
                        , (int)_Width, (int)_Height), System.Drawing.Imaging.PixelFormat.DontCare);
                }
            return bm;
        }
    }
}
