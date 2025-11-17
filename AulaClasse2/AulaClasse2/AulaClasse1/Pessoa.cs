using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Pessoa
    {
        public string nome;
        public string endereco;
        public string numeroTel;
        public int idade;
        public string rg;
        public string sexo;
        public double peso;
        public double altura;
        public string cor;

        public void Comer()
        {
            Console.WriteLine("A pessoa esta comendo");
        }
        public void Falar()
        {
            Console.WriteLine("A pessoa esta falando");
        }
        public void Dormir()
        {
            Console.WriteLine("A pessoa esta dormindo");
        }
    }
}
