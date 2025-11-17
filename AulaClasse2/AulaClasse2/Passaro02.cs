using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Passaro02
    {
        public string cor;
        public string especie;
        public string sexo;
        public string habitat;
        public string nome;
        public double altura;

        public Passaro02()
        {
            cor = "Amarela";
            especie = "Sicalis flaveola";
            sexo = "macho";
            habitat = "Campos, zonas mais áridas";
            nome = "Canário-da-terra";
            altura = 13.5;
        }
        public void Voar()
        {
            Console.WriteLine("O pássaro está voando");
        }
        public void Cantar()
        {
            Console.WriteLine("O pássaro está cantando");
        }
    }
}
