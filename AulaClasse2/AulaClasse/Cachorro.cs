using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Cachorro
    {
        public double peso;
        public double altura;
        public string raca;
        public string tipohabitat;
        public int idade;
        public string cor;
        public string nome;
        public string porte;

        public void Latir()
        {
            if (idade <= 3)
            {
                Console.WriteLine("O cachorro não late");
            }
            else
            {
                Console.WriteLine("O cachorro pode latir");
            }
        }
        public void Comer()
        {
            Console.WriteLine("O cachorro esta comendo");
        }
        public void Beber()
        {
            Console.WriteLine("O cachorro esta bebendo");
        }
        public void Morder()
        {
            Console.WriteLine("O cachorro esta mordendo");
        }
        public void Brincar()
        {
            Console.WriteLine("O cachorro esta brincando");
        }
        public void Correr()
        {
            Console.WriteLine("O cachorro esta correndo");
        }
        public void Dormir()
        {
            Console.WriteLine("O cachorro esta dormindo");
        }
    }
}
