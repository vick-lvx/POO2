using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Caixa
    {
        public double lado;

        public Caixa(double lado)
        {
            lado = 5;
        }
        public double CalcularVolume()
        {
            double volume = lado * lado * lado;

            return volume;
        }
    }
}
