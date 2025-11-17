using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    abstract class Forma
    {
        public abstract void CalcularArea();
        
        public void DefinirTipo()
        {
            Console.WriteLine("Digite qual forma geométrica você irá calcular");
        }
    }
}
