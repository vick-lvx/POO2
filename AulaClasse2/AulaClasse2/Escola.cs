using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public abstract class Escola
    {
        public abstract void CalcularMedia();

        public void DescobrirNome()
        {
            Console.WriteLine("Digite o nome da escola que você estuda");
            string nomeEscola = Console.ReadLine();

            Console.WriteLine("Digite o nome da sua cidade");
            string cidade = Console.ReadLine();

            Console.WriteLine("Digite o nome do seu estado");
            string estado = Console.ReadLine();

            Console.WriteLine("Digite sua serie");
            string serie = Console.ReadLine();

            if (nomeEscola == "SesiSenai" && cidade == "Garça")
            {
                Console.WriteLine("Aluno Sesi/Senai");
            }
            else
            {
                Console.WriteLine("Aluno da escola" +  nomeEscola + "e da cidade" + cidade);
            }

        }
    }
}
