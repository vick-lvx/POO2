using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Pessoa02
    {
        public string nome;
        public int idade;
        public string cor;
        public double altura;

        private string rg;
        private string cpf;
        private string cidade;
        private string estado;

        public virtual void ApresentarPessoa()
        {
            Console.WriteLine("Suas informações são: ");
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(cor);
            Console.WriteLine(altura);
            Console.WriteLine(rg);
            Console.WriteLine(cpf);
            Console.WriteLine(cidade);
            Console.WriteLine(estado);
            
            if (idade <= 0)
            {
                Console.WriteLine("Sua idade deve ser maior que 0");
      
            }
            else 
            {
            
            }
            if (altura <= 0)
            {
                Console.WriteLine("Sua altura deve ser maior que 0");

            }
            else
            {
              
            }
            if (rg == "")
            {
                Console.WriteLine("RG não pode estar vazio");
            }
            else
            {

            }
            if (cpf == "")
            {
                Console.WriteLine("Cpf nao pode estar vazio");
            }
            else
            {

            }

        }
        
        public virtual string Cpf
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
        public virtual string Rg
        {
            get
            {
                return rg;

            }
            set
            {
                rg = value;
            }
        }
        public virtual string Cidade
        {
            get
            {
                return cidade;

            }
            set
            {
                cidade = value;
            }
        }
        public virtual string Estado
        {
            get
            {
                return estado;

            }
            set
            {
                estado = value;
            }
        }
    }
}
