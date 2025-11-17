using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Aluno06
    {
        public string nome;
        public int idade;

        private string rg;
        private string cpf;

        public string Rg
        {
            get { return rg; }
            set { rg = value; }
        }
        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }
    }
}
