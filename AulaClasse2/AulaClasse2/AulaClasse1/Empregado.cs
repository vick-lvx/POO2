using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Empregado
    {
        public string nome;
        public int idade;

        private double salario;
        private string departamento;

        public virtual void CalcularSalario(double salario)
        {
            if (salario > 3500)
            {
                double novoSalario = salario * 1.08;
                Console.WriteLine("O seu novo salario é no valor de: " + novoSalario);
            }
            else if (salario > 2500)
            {
                double novoSalario = salario * 1.10;
                Console.WriteLine("O seu novo salario é no valor de: " + novoSalario);
            }
            else
            {
                double novoSalario = salario * 1.12;
            }
        }
        public virtual void CalcularAlimentacao()
        {
            Console.WriteLine("Digite o valor do seu vale alimentação");
            double valeAlim = Convert.ToDouble(Console.ReadLine());

            if (valeAlim > 250)
            {
                double valeDesc = valeAlim * 0.05;
                Console.WriteLine("O valor do desconto do seu vale é de:" + valeDesc);
            }
            else if (valeAlim > 100)
            {
                double valeDesc = valeAlim * 0.02;
                Console.WriteLine("O valor do desconto do seu vale é de:" + valeDesc);
            }
            else
            {
                double valeDesc = valeAlim * 0.01;
                Console.WriteLine("O valor do desconto do seu vale é de:" + valeDesc);
            }
        }

        public virtual double Salario
        {
            get
            {
                return salario;

            }
            set
            {
                salario = value;
            }
        }
        public virtual string Departamento
        {
            get
            {
                return departamento;

            }
            set
            {
                departamento = value;
            }
        }
    }
}


