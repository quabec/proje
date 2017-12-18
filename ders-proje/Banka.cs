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

        public void MusteriSil(int no)
        {
            Musteri toRemove= musteriler.Where(x => x.musteriNo == no).FirstOrDefault();

            musteriler.Remove(toRemove);

        }
        

        public List<Musteri> Listele()
        {
            return musteriler;
        }
    }
}
