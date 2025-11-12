using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class Carro
    {

        public string modelo;
        public string placa;
        public string ano;
        public string cor;
        public string marca;

        public void AcenderFarol()
        {
            Console.WriteLine("O carro esta acendendo o farol");
        }
        public void Ligar()
        {
            Console.WriteLine("O carro esta ligando");
        }
        public void Acelerar()
        {
            Console.WriteLine("O carro esta acelerando");
        }
        public void Frear()
        {
            Console.WriteLine("O carro esta freando");
        }
    }
}
