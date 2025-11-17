using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Retângulo
    {
        public double base1;
        public double altura;

        public Retângulo()
        {
            base1 = 3;
            altura = 5.2;
        }
        public void CalcularArea()
        {
            double result = base1 * altura;
            Console.WriteLine("O valor da area é: " + result);
        }
    }
}
