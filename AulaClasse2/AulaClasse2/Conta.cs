using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Conta
    {
        public string agencia;
        public string conta;
        public string nomeTitular;
        public virtual void CalcularImpostos(double valor)
        {
            double desconto = valor * 0.04;
            Console.WriteLine("O valor liquido é de: " + (desconto - valor));
        }
    }
}
