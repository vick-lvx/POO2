using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Moto : Veiculo
    {
        public override void ValorCombustivel()
        {
            Console.WriteLine("Selecione qual combustível deseja abastecer: \n Álcool(A); \n Gasolina(G); \n Ambos 4,99 por L");
            string combustivel = Console.ReadLine();

            Console.WriteLine("Informe quantos litros você deseja por:(Apenas numeros) ");
            double litros = Convert.ToDouble(Console.ReadLine());

            double valor = litros * 4.99;

            Console.WriteLine("O valor a pagar é de: " +  valor);
        }
        public override void CalcularTotal()
        {
            Console.WriteLine("Informe a quantidade de km a percorrer");
            double km = Convert.ToDouble(Console.ReadLine());

            if (km > 100 && km < 150)
            {
                double total = km * 20;
                Console.WriteLine("O total é de: " + total);
            }
            else if (km > 50)
            {
                double total = km * 10;
                Console.WriteLine("O total é de: " + total);
            }
            else
            {
                double total = km * 5;
                Console.WriteLine("O total é de: " + total);
            }
        }
    }
}
