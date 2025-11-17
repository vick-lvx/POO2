using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    internal class ContaBancaria
    {
        public string titular;
        public double saldo;
        public double valor1;

        public void Depositar(double valor1)
        {
            this.valor1 = valor1;
            if (valor1 > 0)
            {
                saldo = saldo + valor1;
                Console.WriteLine("Operação feita com sucesso!");
            }
            else
            {
                Console.WriteLine("Valor para deposito invalido!");
            }
        }

        public void Sacar(double valor1)
        {
            this.valor1 = valor1;
            if (valor1 > saldo)
            {
                Console.WriteLine("Saldo insuficiente!");
            }
            else
            {
                saldo = saldo - valor1;
                Console.WriteLine("Operação feita com sucesso!");
            }
        }
        public void ExibirInformacoes()
        {
            Console.WriteLine("O titular " + titular + " tem o saldo atual de: " + saldo);
        }
    }
}
