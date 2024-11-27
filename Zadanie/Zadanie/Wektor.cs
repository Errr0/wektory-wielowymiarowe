using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zadanie
{
    internal class Wektor
    {
        public Punkt a;
        public Punkt b;
        public Wektor(Punkt a, Punkt b)
        {
            this.a = a;
            this.b = b;
        }
        public double Dlugosc()
        {
            return Math.Sqrt(Math.Pow(this.a.x - this.b.x,2) + Math.Pow(this.a.y - this.b.y, 2));
        }
    }
}
