using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Professor03 : Pessoa02
    {
        private string nif;
        private string cpfProf;

        public virtual void ApresentarProfessor()
        {
            Console.WriteLine("Suas informações são: ");
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(cor);
            Console.WriteLine(altura);
            Console.WriteLine(nif);
            Console.WriteLine(cpfProf);

            if (cpfProf == "")
            {
                Console.WriteLine("Cpf nao pode estar vazio");
            }
            else
            {

            }
            if (nif == "")
            {
                Console.WriteLine("NIF nao pode estar vazio");
            }
            else
            {

            }
        }

        public virtual string Nif
        {
            get
            {
                return nif;

            }
            set
            {
                nif = value;
            }
        }
        public virtual string CpfProf
        {
            get
            {
                return cpfProf;

            }
            set
            {
                cpfProf = value;
            }
        }
    }
}
