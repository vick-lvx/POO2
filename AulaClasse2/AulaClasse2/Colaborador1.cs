using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Colaborador1
    {
        public virtual void CalcularSalario(double salario)
        {
            double descSalario = salario * 0.14;
            Console.WriteLine("O valor do seu salario liquido é de: " + (descSalario - salario));

        }
        public virtual void CalcularIRRF(double salario)
        {
            double descIrrf = salario * 0.02;
            Console.WriteLine("O valor do desconto do imposto de renda é de:");
        }
    }
}
