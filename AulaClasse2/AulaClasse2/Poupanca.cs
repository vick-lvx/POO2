using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Poupanca : Conta
    {
        public override void CalcularImpostos(double valor)
        {
            double desconto = valor * 0.06;
            Console.WriteLine("O valor liquido é de: " + (desconto - valor));
        }
    }
}
