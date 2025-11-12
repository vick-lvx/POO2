using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AulaClasse
{
    public class MetodosSenai
    {
        public string nome;
        public string sobrenome;
        public string endereco;
        public string cidade;
        public string estado;
        public string pais;
        public void Usuario()
        {
            Console.WriteLine("Digite seu nome");
            nome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite seu sobrenome");
            sobrenome = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite seu endereco");
            endereco = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite sua cidade");
            cidade = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite seu estado");
            estado = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite seu País");
            pais = Convert.ToString(Console.ReadLine());


            Console.WriteLine("Seus dados são:\n Nome:" + nome + "\n Sobrenome: " + sobrenome + "\nEndereço: " + endereco + "\n Cidade: " + cidade + "\nEstado:" + estado + "\n País" + pais);


        }
        public string nomeProduto;
        public string marcaProduto;
        public string codigoProduto;

        public void CalcularProduto()
        {
            Console.WriteLine("Digite o nome do produto");
            nomeProduto = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite a marca do produto");
            marcaProduto = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite o codigo do produto");
            codigoProduto = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite quantidade do produto");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Os dados do produto são:\n Nome:" + nomeProduto + "\n Marca: " + marcaProduto + "Codigo: " + codigoProduto);

            if (quantidade < 10)
            {
                Console.WriteLine("O valor é: " + quantidade * 20);
            }
            else if (quantidade < 20)
            {
                Console.WriteLine("O valor é: " + quantidade * 25);
            }
            else
            {
                Console.WriteLine("O valor é: " + quantidade * 5);
            }


        }
        public string nomeAluno;
        public string idadeAluno;
        public string escolaAluno;
        public void Estudar()
        {
            Console.WriteLine("Digite o nome do aluno");
            nomeAluno = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite a idade do aluno");
            idadeAluno = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite a escola do aluno");
            escolaAluno = Convert.ToString(Console.ReadLine().ToLower());
            if (escolaAluno == "senai")
            {
                Console.WriteLine("Parabéns você está cursando em uma excelente escola");
            }
            else
            {
                Console.WriteLine("O aluno não é aluno SENAI;");
            }
        }


        public void AreaRetangulo()
        {
            Console.WriteLine("Digite a base do retângulo");
            double baseRetangulo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura do retângulo");
            double alturaRetangulo = Convert.ToDouble(Console.ReadLine());
            double areaRetangulo = alturaRetangulo * baseRetangulo;
            Console.WriteLine("A área do Retângulo é de " + areaRetangulo);

        }
        public void AreaQuadrado()
        {

            Console.WriteLine("Digite a base do quadrado");
            double baseQuadrado = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Digite a altura do quadrado");
            double alturaQuadrado = Convert.ToDouble(Console.ReadLine());
            double areaQuadrado = alturaQuadrado * baseQuadrado;
            Console.WriteLine("A área do Retângulo é de " + areaQuadrado);

           
        }
        public void AreaCirculo()
        {
            Console.WriteLine("Digite o raio do circulo");
            double raioCirculo = Convert.ToDouble(Console.ReadLine());
            double areaCirculo = 3.14 * (raioCirculo * raioCirculo);
            Console.WriteLine("A área do Retângulo é de " + areaCirculo);
        }
        public string nomeProf;
        public int idadeProf;
        public string materia;
        public string cidadeProf;
        public string escolaProf;

        public void UsuarioProfessor()
        {

            Console.WriteLine("Digite o seu nome");
            nomeProf = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite a sua idade");
            idadeProf = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a matéria que leciona");
            materia = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite a sua cidade");
            cidadeProf = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Digite o nome da escola que trabalha");
            escolaProf = Convert.ToString(Console.ReadLine());

        }

        public double nota1;
        public double nota2;
        public double nota3;
        public double nota4;

        public void MediaAluno(double nota1,  double nota2, double nota3, double nota4)
        {
            this.nota1 = nota1;
            this.nota2 = nota2;
            this.nota3 = nota3;
            this.nota4 = nota4;

            double media = (nota1 + nota2 + nota3 + nota4) / 4;

            Console.WriteLine("Digite o nome do aluno");
            string nomeAluno = Convert.ToString(Console.ReadLine());
            Console.WriteLine("O Aluno: " + nomeAluno + "Tem a media de:" + media);
        }
        public string nomeColab;
        public int idadeColab;
        public string escolaridade;
        public void Colaborador()
        {
            Console.WriteLine("Digite o nome do colaborador: ");
            nomeColab = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Digite a idade do colaborador: ");
            idadeColab = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Digite o nivel de escolaridade do colaborador: ");
            escolaridade = Convert.ToString(Console.ReadLine());

            Console.WriteLine("Nome:" + nomeColab + "\n Idade:" + idadeColab + "\n Nivel de escolaridade:" + escolaridade);
        }

        public void SalarioColaborador()
        {
            Console.WriteLine("Digite o salário do colaborador: ");
            double salarioColaborador = Convert.ToDouble(Console.ReadLine());
            if (salarioColaborador <= 1000)
            {
                Console.WriteLine("Aumento de 25% \n Salário com aumento: R$:" + (salarioColaborador * 1.25));
            }
            else if (salarioColaborador <= 3000)
            {
                Console.WriteLine("Aumento de 10% \n Salário com aumento: R$:" + (salarioColaborador * 1.10));
            }
            else
            {
                Console.WriteLine("Aumento de 5% \n Salário com aumento: R$:" + (salarioColaborador * 1.05));
            }
        }
        

        
    }
}
