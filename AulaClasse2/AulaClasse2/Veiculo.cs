using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Veiculo
    {
        public string modelo;
        public string placa;

        public virtual void ValorCombustivel()
        {
            Console.WriteLine("Selecione qual combustível deseja abastecer: \n Álcool(A) R$ 3,99 por L; \n Gasolina(G) R$ 5,99 por L; \n Disel(D) R$ 6,99 por L;");
            string combustivel = Console.ReadLine();

            Console.WriteLine("Informe quantos litros você deseja por:(Apenas numeros) ");
            double litros = Convert.ToDouble(Console.ReadLine());

            if (combustivel == "A" || combustivel == "Alcool")
            {
                double valor = litros * 3.99;
                Console.WriteLine("O valor a pagar é de: " +  valor);
            }
            else if (combustivel == "G" ||  combustivel == "Gasolina")
            {
                double valor = litros * 5.99;
                Console.WriteLine("O valor a pagar é de: " + valor);
            }
            else if (combustivel == "D" ||  combustivel == "Disel")
            {
                double valor = litros * 6.99;
                Console.WriteLine("O valor a pagar é de: " + valor);
            }
        }
        public virtual void CalcularTotal()
        {
            Console.WriteLine("Informe a quantidade de pessoas na viagem: ");
            int pessoas = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Informe a quantidade de km a percorrer");
            double km = Convert.ToDouble(Console.ReadLine());

            if (pessoas == 2 && km > 50)
            {
                double total = km * 25;
                Console.WriteLine("O total é de: " + total);
            }
            else if (pessoas == 2 && km <= 50)
            {
                double total = km * 18;
                Console.WriteLine("O total é de: " + total);
            }
            else
            {
                double total = km * 15;
                Console.WriteLine("O total é de: " + total);
            }
        }

    }
}
