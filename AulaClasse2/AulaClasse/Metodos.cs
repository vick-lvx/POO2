using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Metodos
    {
        // Metodos

        public int valor1;
        public int valor2;
        public int valor3;
        public double saslario;

        public void Soma(int valor1, int valor2, int valor3)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
            this.valor3 = valor3;
            Console.WriteLine("A soma dos valores é de: " + (valor1 + valor2 + valor3));
        }

        //Void é usado para metodos sem retorno apenas
        public int Multiplicacao(int valor1, int valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
            Console.WriteLine("O resultado da multiplicação é de: " + (valor1 * valor2));
            return valor1 * valor2;


        }
        public string Dividir()
        {
            int resultado = Multiplicacao(valor1, valor2);

            if(resultado % 2 == 0)
            {
                return "Valor par";
            }
            else
            {
                return "Valor impar";
            }
        }

        public double Salario(double salario)
        {
            if (salario >= 2000)
            {
                return salario * 1.2754;
            }
            else
            {
                return salario * 1.1523;
            }
        }
        public int  Somar(int valor1, int valor2)
        {
            this.valor1 = valor1;
            this.valor2 = valor2;
            return valor1 + valor2;
        }
        public void Subtracao(int valor3)
        {

            int soma = Somar(valor1, valor2);
           
            if (valor3 > soma)
            {
                Console.WriteLine("O valor da subtração é maior");
            }
            else
            {
                Console.WriteLine("O valor da soma é maior");
            }
        }
    }
}
