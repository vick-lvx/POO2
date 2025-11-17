using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Alunos
    {
        public double SomarNotas(double nota1, double nota2, double nota3, double nota4, double nota5)
        {


            double somaNotas = nota1 + nota2 + nota3 + nota4 + nota5;
            return somaNotas;
        }
        public string CalcularMedia()
        {
            double media = SomarNotas(5, 6, 5, 4, 8) / 5;

            if (media >= 7)
            {
                return "Aluno Aprovado";
            }
            else if (media < 7 && media > 5)
            {
                return "Aluno em Recuperação";
            }
            else
            {
                return "Aluno Reprovado";
            }
        }
    }
}
