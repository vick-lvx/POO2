using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Desenvolvedor : Colaborador02
    {
        public override void CalcularHorasExtras()
        {
            Console.WriteLine("Digite a modalidade de trabalho: \n A - Presencial \n B - Híbrido \n C - Remoto");
            string modalidade = Console.ReadLine();

            if (modalidade == "A")
            {
                Console.WriteLine("Digite a quantidade de horas extras excercidas");
                int horaEx = Convert.ToInt32(Console.ReadLine());

                int total = horaEx * 100;

                Console.WriteLine(total);
            }
            else if (modalidade == "B")
            {
                Console.WriteLine("Digite a quantidade de horas extras excercidas");
                int horaEx = Convert.ToInt32(Console.ReadLine());

                int total = horaEx * 50;
            }
            else if (modalidade == "C")
            {
                Console.WriteLine("Seu horario é flexivel não há horas extras excercidas");
            }
            else
            {
                Console.WriteLine("Opção inválida");
            }

        }
    }
}
