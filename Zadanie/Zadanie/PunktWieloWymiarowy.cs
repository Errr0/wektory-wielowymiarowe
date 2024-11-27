using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    internal class PunktWieloWymiarowy
    {
        public List<double> wspolrzedne = new List<double>();
        public PunktWieloWymiarowy(List<double> wspolrzedne) {
            foreach (var w in wspolrzedne) {
                this.wspolrzedne.Add(w);
            }
        }
    }
}
