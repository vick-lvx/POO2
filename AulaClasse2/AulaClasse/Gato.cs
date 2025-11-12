using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class Gato : Animal
    {
        public string castrado;
        public string deficiente;

        public void Miar()
        {
            Console.WriteLine("O gato esta miando");
        }
        public void Lamber()
        {
            Console.WriteLine("O gato esta lambendo");      
        }
    }
}
