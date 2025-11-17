using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Pessoapj : Pessoa
    {
        private string cnpj;
        public string patrimonio;
        public string empresa;

        public void Gerenciar()
        {
            Console.WriteLine("a pessoa juridica esta gerenciando sua empresa");
        }
        public void EmitirNotasF()
        {
            Console.WriteLine("A pessoa juridica esta emitindo notas fiscais ao seus clientes"); 
        }
        public void PagarIRPJ()
        {
            Console.WriteLine("A pessoa juridica esta pagando o Imposto de Renda de Pessoa Juridica");
        }
        public string Cnpj
        {
            get
            {
                return cnpj;

            }
            set
            {
                cnpj = value;
            }
        }
    }
}
