using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    public class Filme
    {
        public string titulo;
        public string classificacao;
        public string lancamento;
        public string produtora;
        public string atorPrinc;

        public Filme(string titulo, string classificacao, string lancamento, string produtora, string atorPrinc) 
        {
            this.titulo = titulo;
            this.classificacao = classificacao;
            this.lancamento = lancamento;
            this.produtora = produtora;
            this.atorPrinc = atorPrinc;
        }
    }
}
