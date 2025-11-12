using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Colaborador
    {
        public string nome;

        public virtual void ValeAlimentacao(double salario)
        {
            double novoSalario = salario * 1.25;

            Console.WriteLine("O novo salario é de:" + novoSalario);
        }
        public virtual void CalcularImposto(double salario)
        {
            double imposto = salario * 0.15;
            double salarioLiquido = salario - imposto;

            Console.WriteLine("O salario liquido é de: " + salarioLiquido);
        }

    }
}
