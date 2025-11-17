using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class AlunoSenai
    {
        public string nome;
        public string cidade;
        public string estado;
        public int idade;
        private string rm;
        private string cpf;

        public AlunoSenai(int idade, string nome, string rm) 
        {
            this.idade = idade;
            this.nome = nome;
            this.rm = rm;
        }

        public static void Estudar()
        {
            Console.WriteLine("O aluno do senai esta estudando");
        }
        public static void Conversar()
        {
            Console.WriteLine("O aluno do senai esta conversando");
        }
        public static void Programar()
        {
            Console.WriteLine("O aluno do senai esta programando");
        }

    }
}
