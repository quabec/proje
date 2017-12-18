using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ders_proje
{
    public abstract class Hesap
    {
        public long hesapno { get; set; }
        public abstract void hesapNo();

        public Random rnd = new Random();

    }
}
