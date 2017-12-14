using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_proje
{
    public class Banka
    {
        public List<Musteri> musteriler = new List<Musteri>();

        public void MusteriEkle(Musteri m)
        {
            musteriler.Add(m);
        }

        public void MusteriSil(Musteri m)
        {
            musteriler.Remove(m);
        }

        public List<Musteri> Listele()
        {
            return musteriler;
        }
    }
}
