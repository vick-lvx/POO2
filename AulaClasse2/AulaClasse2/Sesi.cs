using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Sesi : Escola
    {
        public override void CalcularMedia()
        {
            Console.WriteLine("Digie sua primeira nota");
            double nota1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digie sua segunda nota");
            double nota2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Digie sua terceira nota");
            double nota3 = Convert.ToDouble(Console.ReadLine());

            double media = (nota1 + nota2 + nota3) / 3;

            if (media >= 7)
            {
                Console.WriteLine("Aluno Aprovado \n Sua media é: " + media);
            }
            else if (media >= 4) 
            {
                Console.WriteLine("Aluno em recuperação \n Sua media é: " + media);
            }
            else
            {
                Console.WriteLine("Aluno reprovado \n Sua media é: " + media);
            }
        }
    }
}
