using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Senai : Escola
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("Digie sua primeira nota (0 a 10)");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digie sua segunda nota (0 a 10)");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digie sua terceira nota (0 a 10)");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digie sua quarta nota (0 a 10)");
            double nota4 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digite sua Frequencia (%)");
            int frequencia = Convert.ToInt32(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            if (frequencia >= 90 && media >= 7 )
            {
                Console.WriteLine("Parabéns, você foi aprovado no curso técnico do Senai!");
            }
            else if (frequencia >= 90 && media < 7)
            {
                Console.WriteLine("Você precisa fazer trabalho de recuperação");
            }
            else if (frequencia < 90  && media >= 7)
            {
                Console.WriteLine("Você foi reprovado por falta");
            }
            else
            {
                Console.WriteLine("Aluno reprovado");
            }
        }
    }
}
