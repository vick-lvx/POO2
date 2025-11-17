using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    //Polimorfismo com a classe Animal1
    //permite modificsr o metodo de acordo com as caracteristicas propria dos animais
    public class Passaro : Animal1
    {
        public override void EmitirSom()
        {
            Console.WriteLine("O passararo esta cantando");
        }
    }
}
