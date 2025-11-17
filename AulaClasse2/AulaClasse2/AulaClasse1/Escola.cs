using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class Escola
    {
        public string nome;
        public string cnpj;
        public string funcionarios;
        public string alunos;
        public string salas;
        public string telefone;
        public string endereco;
        public string email;
        public string turmas;
        public string matriculas;


        public void Aprender()
        {
            Console.WriteLine("O aluno esta aprendendo");
        }
        public void Conversar()
        {
            Console.WriteLine("O aluno esta conversando");
        }
        public void Pesquisar()
        {
            Console.WriteLine("O aluno esta pesquisando");
        }
        public void Ler()
        {
            Console.WriteLine("O aluno esta lendo");
        }
        public void Comer()
        {
            Console.WriteLine("O aluno esta comendo");
        }
        public void Beber()
        {
            Console.WriteLine("O aluno esta bebendo");
        }
    }
}
