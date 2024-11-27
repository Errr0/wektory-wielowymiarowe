using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    internal class WektorWieloWymiarowy
    {
        public PunktWieloWymiarowy a;
        public PunktWieloWymiarowy b;
        public WektorWieloWymiarowy(PunktWieloWymiarowy a, PunktWieloWymiarowy b)
        {
            this.a = a;
            this.b = b;
        }
        public double Dlugosc()
        {
            double sum = 0;
            for(int i = 0 ; i < a.wspolrzedne.Count() ; i++)
            {
                sum += Math.Pow(this.a.wspolrzedne[i] - this.b.wspolrzedne[i], 2);
            }
            return Math.Sqrt(sum);
        }
    }
}
