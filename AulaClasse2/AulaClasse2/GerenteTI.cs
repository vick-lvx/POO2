using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class GerenteTI : Colaborador02
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a quantidade de horas extras excercidas no mês");
            int horaEx = Convert.ToInt32(Console.ReadLine());
            
            if (horaEx > 100)
            {
                double salario = horaEx / 2 * (200 + 500);

                double diasDesc = horaEx / 8;

                Console.WriteLine("O valor a ser recebido é de: " + salario + "o total de dias de descanço é de:" + diasDesc);
            }
            else
            {
                double salario = horaEx * 400;
                Console.WriteLine("O valor a ser recebido é de: ");
            }

        }
    }
}
