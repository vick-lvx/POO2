using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Aluno //Sempre trocar o internal para public
    {
        public string nome;
        public string rm;
        public int idade;
        public string email;
        public string cpf;
        public string serie;
        public string responsavel;
        public double peso;
        public double altura;
        public string telefone;
        public string cor;

        public void Estudar()
        {
            Console.WriteLine("O aluno esta estudando");
        }
        public void Escrever()
        {
            Console.WriteLine("O aluno esta escrevendo");
        }
        public void Ler()
        {
            Console.WriteLine("O aluno esta lendo");
        }
        public void Falar()
        {
            Console.WriteLine("O aluno esta falando");
        }
        public void Andar()
        {
            Console.WriteLine("O aluno esta andando");
        }
        public void Aprender()
        {
            Console.WriteLine("O aluno esta aprendendo");
        }
       
    }

}
