using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_proje
{
    class Bireysel : Hesap
    {
        
        public override void hesapNo()
        {
            int sayi = rnd.Next(1000, 9999);
            hesapno = sayi + 50000;
        }
    }
}
