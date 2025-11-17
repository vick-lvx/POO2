using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Bancario : Colaborador02
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a quantidade de horas extras excercidas no mês");
            int horaEx = Convert.ToInt32(Console.ReadLine());

            int total = horaEx * 250;
            Console.WriteLine("o valor bruto é de: " +  total);

            if (total > 1000)
            {
                double imp = total * 0.15;
                Console.WriteLine("O novo o valor com imposto é de: " +  imp);
            }
            else if (total > 500)
            {
                double imp = total * 0.10;
                Console.WriteLine("O novo o valor com imposto é de: " + imp);
            }
            else
            {
                Console.WriteLine("Valor bruto" + total);
            }

        }
    }
}
