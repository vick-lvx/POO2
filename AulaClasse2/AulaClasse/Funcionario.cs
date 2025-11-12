using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class Funcionario
    {
        public double peso;
        public double altura;
        public double remuneracao;
        public string nome;
        public string cargahoraria;
        public string cargo;
        public int idade;
        public string cpf;
        public string endereco;
        public string telefone;
        public string email;

        public void Trabalhar()
        {
            Console.WriteLine("O funcionario esta trabalhando");
        }
        public void Conversar()
        {
            Console.WriteLine("O funcionario esta conversando");
        }
        public void Lucrar()
        {
            Console.WriteLine("O funcionario esta lucrando");
            if(remuneracao == 0) 
            {
                Console.WriteLine("Você não especificou a remuneração");
            }
            else
            {
                Console.WriteLine("A remuneração com um aumento de 25% é" + remuneracao * 1.25);
            }
        }
        public void Comer()
        {
            Console.WriteLine("O funcionario esta comendo");
        }
        public void Descansar()
        {
            Console.WriteLine("O funcionario esta descansando");
        }
    }
}
