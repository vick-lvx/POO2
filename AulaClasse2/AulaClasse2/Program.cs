using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse2
{
    internal class Program
    {
        public void Main(string[] args)
        {
            Colaborador1 colaborador1 = new Colaborador1();
            colaborador1.CalcularSalario(1400.03);
            colaborador1.CalcularIRRF(1400.03);

            Professor4 professor4 = new Professor4();
            professor4.CalcularSalario(1750.03);
            professor4.CalcularIRRF(1750.03);

            Diretor diretor = new Diretor();
            diretor.CalcularSalario(2300.76);
            diretor.CalcularIRRF(2300.76);

            Coordenador coordenador = new Coordenador();
            coordenador.CalcularSalario(1940.80);
            coordenador.CalcularIRRF(1940.80);

            //
            //Atividade02
            //

            Poupanca poupanca = new Poupanca();
            poupanca.nomeTitular = "Vitória";
            poupanca.conta = "Poupanca";
            poupanca.agencia = "002";
            poupanca.CalcularImpostos(12300.43);

            Corrente corrente = new Corrente();
            corrente.nomeTitular = "Victor";
            corrente.conta = "Corrente";
            corrente.agencia = "330";
            corrente.CalcularImpostos(3500.77);

            //
            //Atividade 03
            //
            Veiculo veiculo = new Veiculo();
            veiculo.ValorCombustivel();
            veiculo.CalcularTotal();

            Moto moto = new Moto(); 
            moto.ValorCombustivel();
            moto.CalcularTotal();

            //
            //Aluno senai
            AlunoSenai alunosenai =  new AlunoSenai(17, "4022", "Vitória");
            Console.WriteLine(alunosenai.idade);

            BancoDeDados bancoDeDados = new BancoDeDados("computador", 3306, "Vitória", "1234");    
            
            //
            // Atividade abstração1
            //

            Sesi sesi = new Sesi();
            sesi.DescobrirNome();
            sesi.CalcularMedia();

            Senai senai = new Senai();
            senai.DescobrirNome();
            senai.CalcularMedia();

            //
            //Atividade absttacao2
            //

            Desenvolvedor desenvolvedor = new Desenvolvedor();
            desenvolvedor.CalcularHorasExtras();

            Bancario bancario = new Bancario();
            bancario.CalcularHorasExtras();

            GerenteTI gerenteTI = new GerenteTI();
            gerenteTI.CalcularHorasExtras();
        }

    }
}
