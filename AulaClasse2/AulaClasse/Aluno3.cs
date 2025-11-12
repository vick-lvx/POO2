using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Aluno3
    {
        public string nome;
        public int idade;
        public double peso;
        public double altura;

        //Privados

        private string cpf;
        private string rg;
        private string numero_celular;

        //Propriedade Get(obter) Set(definir)
        //Exclusivo para atributos prividos

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
