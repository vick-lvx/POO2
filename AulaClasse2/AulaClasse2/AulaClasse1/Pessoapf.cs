using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Pessoapf : Pessoa
    {
        private string cpf;
        public string patrimonio;
        public string emprego;

        public void Trabalhar ()
        {
            Console.WriteLine("A pessoa fisica esta trabalhando");
        }
        public void EmitirRecibos()
        {
            Console.WriteLine("A pessoa fisica esta emitindo recibos");
        }
        public void PagarIRPF()
        {
            Console.WriteLine("A pessoa fisica esta pagando o Imposto de Renda de Pessoa Fisica");
        }
        public string Cpf
        {
            get
            {
                return cpf;

            }
            set
            {
                cpf = value;
            }
        }
    }
}
