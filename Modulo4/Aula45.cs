using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Modulo4
{
    internal class Aula45
    {
        public void ExercicioClasse01()
        {
            Console.WriteLine("\nAula 45 - Exercício de Classe 01");


            Retangulo retangulo = new Retangulo();

            Console.WriteLine("Entre a largura e a altura do retângulo?");
            retangulo.Largura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            retangulo.Altura = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            retangulo.Area();
            retangulo.Perimetro();
            retangulo.Diagonal();

            Console.WriteLine(retangulo);
        }

        public void ExercicioClasse02()
        {
            Console.WriteLine("\nAula 45 - Exercício de Classe 02\n");


            Funcionario funcionario = new Funcionario();

            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();

            Console.Write("Salário bruto: ");
            funcionario.SalarioBruto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Imposto: ");
            funcionario.Imposto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine($"\nFuncionário: {funcionario}");


            Console.WriteLine("\nDigite a porcentagem para aumentar o salário: ");
            double porcentagem = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            funcionario.AumentarSalario(porcentagem);

            Console.WriteLine($"\nDados atualizadas: {funcionario}");

        }

        public void ExercicioClasse03()
        {
            Console.WriteLine("\nAula 45 - Exercício de Classe 03\n");

            Aluno aluno = new Aluno();

            Console.Write("Nome do aluno: ");
            aluno.Nome = Console.ReadLine();

            Console.WriteLine("Digite as três notas do aluno: ");
            aluno.Nota1 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            aluno.Nota3 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            aluno.CalculoNotaFinal();
            

            Console.WriteLine($"NOTA FINAL {aluno.NotaFinal}");

            aluno.ResultadoFinal();
        }
    } 


    internal class Retangulo
    {
        public double Largura;
        public double Altura;


        public double Area()
        {
            return Largura * Altura;
        }

        public double Perimetro()
        {
            return 2.0 * (Largura + Altura);
        }

        public double Diagonal()
        {
            return Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
        }

        public override string ToString()
        {
            return $"AREA = {Area().ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nPERÍMETRO = {Perimetro().ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\nDIAGONAL = {Diagonal().ToString("F2", CultureInfo.InvariantCulture)}" ;
        }
    }


    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentarSalario(double porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * porcentagem / 100.0);
        }

        public override string ToString()
        {
            return Nome
            + ", R$ "
            + SalarioLiquido().ToString("F2", CultureInfo.InvariantCulture);
        }
    }


    internal class Aluno
    {
        public string Nome;
        public double Nota1;
        public double Nota2;
        public double Nota3;
        public double NotaFinal;


        public double CalculoNotaFinal()
        {
            return NotaFinal = Nota1 + Nota2 + Nota3;
        }

        public void ResultadoFinal()
        {
            if (NotaFinal >= 0.0 && NotaFinal < 60.0)
            {
                Console.WriteLine("REPROVADO");

                double pontosFaltantes = 60.0 - NotaFinal; 

                Console.WriteLine($"FALTARAM {pontosFaltantes.ToString("F2", CultureInfo.InvariantCulture)} PONTOS");
            }
            else
            {
                Console.WriteLine("APROVADO");
            }
        }
    }
}
