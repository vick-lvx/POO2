using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Animal
    {
        public string sexo;
        public string raca;
        public string cor;
        public int idade;
        public string habitat;
        public double tamanho;
        public string porte;
        public string especie;

        public void Comer()
        {
            Console.WriteLine("O animal esta comendo");
        }
        public void Correr()
        {
            Console.WriteLine("O animal esta correndo");
        }
        public void Dormir()
        {
            Console.WriteLine("O animal esta dormindo");
        }
    }
}
