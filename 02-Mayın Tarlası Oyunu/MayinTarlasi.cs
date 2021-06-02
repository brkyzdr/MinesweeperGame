using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace _02_Mayın_Tarlası_Oyunu
{
    public class MayinTarlasi
    {
        Size buyukluk_;
        List<Mayın> mayinlar;
        int doluMayinSayisi;
        Random rnd = new Random();

        public MayinTarlasi(Size buyukluk, int mayinSayisi)
        {
            mayinlar = new List<Mayın>();
            buyukluk_ = buyukluk;
            doluMayinSayisi = mayinSayisi;

            for (int x = 0; x < buyukluk.Width; x = x + 20)
            {
                for (int y = 0; y < buyukluk.Height; y = y + 20)
                {
                    Mayın m = new Mayın(new Point(x, y));
                    mayinEkle(m);
                }
            }

            mayinlariDoldur();

        }

        public void mayinEkle(Mayın m)
        {
            mayinlar.Add(m);
        }

        private void mayinlariDoldur()
        {
            int say = 0;
            while (say < doluMayinSayisi)
            {
                int i = rnd.Next(0, mayinlar.Count);

                Mayın item = mayinlar[i];
                if (item.mayinVarMi == false)
                {
                    item.mayinVarMi = true;
                    say++;
                }
            }
        }

        public Size buyuklugu
        {
            get { return buyukluk_; }
        }

        public Mayın mayinAlLoc(Point loc)
        {
            foreach (Mayın item in mayinlar)
            {
                if (item.konumAl == loc)
                {
                    return item;
                }
            }
            return null;
        }
        public List<Mayın> GetAllMayin
        {
            get { return mayinlar; }
        }

    }
}
