using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class Empresario
    {
        public double remuneracao;
        public string nome;
        public string empresa;
        public string cargo;
        public int idade;
        public string cnpj;
        public string endereco;
        public string telefone;
        public string email;
        public string cpf;

        public void Trabalhar()
        {
            Console.WriteLine("O empresario esta trabalhando");
        }
        public void Investir()
        {
            Console.WriteLine("O empresario esta investindo");
        }
        public void Lucrar()
        {
            Console.WriteLine("O empresario esta lucrando");
        }
        public void Pesquisar()
        {
            Console.WriteLine("O empresario esta pesquisando");
        }
    }
}
