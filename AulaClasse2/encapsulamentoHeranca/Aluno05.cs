using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Aluno05 : Pessoa02
    {
        private string ra;

        public virtual void ApresentarAluno()
        {
            Console.WriteLine("Suas informações são: ");
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(cor);
            Console.WriteLine(altura);
            Console.WriteLine(ra);

            if (ra == "")
            {
                Console.WriteLine("RA não deve estar em branco");
            }
            else
            {

            }
        }
        public virtual string Ra
        {
            get
            {
                return ra;

            }
            set
            {
                ra = value;
            }
        }
    }
}
