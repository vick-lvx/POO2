using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class Biblioteca
    {
        public string nome;
        public string cnpj;
        public string funcionario;
        public string livros;
        public string prateleiras;
        public string telefone;
        public string endereco; 
        public string publico;

        public void Emprestar()
        {
            Console.WriteLine("A biblioteca esta emprestando");
        }
        public void Estudar()
        {
            Console.WriteLine("O publico esta estudando");
        }
        public void Pesquisar()
        {
            Console.WriteLine("O publico esta ");
        }
        public void Ler()
        {
            Console.WriteLine("O publico esta lendo");
        }
        public void Descansar()
        {
            Console.WriteLine("O funcionario esta descansando");
        }
        public void Aprender()
        {
            Console.WriteLine("O publico esta aprendendo");
        }
    }
}
