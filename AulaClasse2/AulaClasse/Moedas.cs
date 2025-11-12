using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Moedas
    {
        public double real;
        public double dolar;
        public double euro;
        public void ConvertRealDolar(double real)
        {
            this.real = real;

            dolar = 5.40;
            double convert = real / dolar;

            Console.WriteLine("O valor em R$: " + real + "Em dolar (US$) é: " + convert);
        }
        public void ConvertDolarReal(double dolar)
        {
            this.dolar = dolar;

            real = 0.19;
            double convert = real * dolar;

            Console.WriteLine("O valor em US$: " + dolar + "Em real (R$) é: " + convert);
        }

        public void ConvertRealEuro(double real)
        {
            this.real = real;

            euro = 0.16;
            double convert = real * euro;

            Console.WriteLine("O valor em R$: " + real + "Em euro (€) é: " + convert);

        }
    }
}
