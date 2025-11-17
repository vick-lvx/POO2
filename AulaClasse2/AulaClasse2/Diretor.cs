using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Diretor : Colaborador1
    {
        public override void CalcularSalario(double salario)
        {
            double descSalario = salario * 0.23;
            Console.WriteLine("O valor do seu salario liquido é de: " + (descSalario - salario));
        }
    }
}
