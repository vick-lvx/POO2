using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Estagiario1 : Colaborador
    {
        public override void ValeAlimentacao(double salario)
        {
            Console.WriteLine("O valordo vale é de: " +  salario * 1.30);
        }
        public override void CalcularImposto(double salario)
        {
           Console.WriteLine("O valor do salário líquido é de: " + salario);
        }
    }
}
