
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Modulo4
{
    internal class Aula38_39
    {
        public void ProblemWithoutPOO()
        {
            Console.WriteLine("\nProblema sem POO:\n");

            double xA, xB, xC, yA, yB, yC;

            Console.WriteLine("\nEntre com as medidas do triângulo X: ");
            xA = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            xB = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            xC = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntre com as medidas do triângulo Y: ");
            yA = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            yB = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            yC = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double p = (xA + xB + xC) / 2.0;
            double areaX = Math.Sqrt(p * (p - xA) * (p - xB) * (p - xC));

            p = (yA + yB + yC) / 2.0;
            double areaY = Math.Sqrt(p * (p - yA) * (p - yB) * (p - yC));

            Console.WriteLine($"\nÁrea de x: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"\nÁrea de y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("Maior: area X");
            }
            else
            {
                Console.WriteLine("Maior: area Y");
            }
        }

        public void ProblemWithPOO()
        {
            Console.WriteLine("\nProblema com POO:\n");

            Triangulo x, y;
            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("\nEntre com as medidas do triângulo X: ");
            x.A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntre com as medidas do triângulo Y: ");
            y.A = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.AreaTriangulo();
            double areaY = y.AreaTriangulo();

            Console.WriteLine($"\nÁrea de x: {areaX.ToString("F4", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"\nÁrea de y: {areaY.ToString("F4", CultureInfo.InvariantCulture)}");

            if (areaX > areaY)
            {
                Console.WriteLine("\nMaior: area X");
            }
            else
            {
                Console.WriteLine("\nMaior: area Y");
            }
        }

        public void ExercicoClasse01()
        {
            Console.WriteLine("\nExercício de Classes 01:\n");

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa();

            List<Pessoa> listaPessoas = new List<Pessoa>();

            Console.WriteLine("\nQual o nome e a idade da pimeira pessoa?");
            string[] vetorPessoa1 = Console.ReadLine().Split(' ');
            pessoa1.nome = vetorPessoa1[0];
            pessoa1.idade = Convert.ToInt32(vetorPessoa1[1]);
            
            Console.WriteLine("\nQual o nome e a idade da segunda pessoa?");
            string[] vetorPessoa2 = Console.ReadLine().Split(' ');
            pessoa2.nome = vetorPessoa2[0];
            pessoa2.idade = Convert.ToInt32(vetorPessoa2[1]);

            listaPessoas.Add(pessoa1);
            listaPessoas.Add(pessoa2);

            Console.WriteLine("\nDados da primeira pessoa:\n");
            Console.WriteLine($"Nome: {listaPessoas[0].nome}\nIdade: {listaPessoas[0].idade}");

            Console.WriteLine("\nDados da segunda pessoa:\n");
            Console.WriteLine($"Nome: {listaPessoas[1].nome}\nIdade: {listaPessoas[1].idade}");


            if (listaPessoas[0].idade > listaPessoas[1].idade)
            {
                Console.WriteLine($"\nPessoa mais velha: {listaPessoas[0].nome}");
            }
            else
            {
                Console.WriteLine($"\nPessoa mais velha: {listaPessoas[1].nome}");
            }
        }

        public void ExercicoClasse02()
        {
            Console.WriteLine("\nExercício de Classes 02:\n");

            Funcionarios funcionario1 = new Funcionarios();
            Funcionarios funcionario2 = new Funcionarios();

            List<Funcionarios> listaFuncionarios = new List<Funcionarios>();

            Console.WriteLine("\nQual o nome e a idade da pimeira pessoa?");
            string[] vetorFuncionario1 = Console.ReadLine().Split("  ");
            funcionario1.nome = vetorFuncionario1[0];
            funcionario1.salario = Convert.ToDouble(vetorFuncionario1[1], CultureInfo.InvariantCulture);

            Console.WriteLine("\nQual o nome e a idade da segunda pessoa?");
            string[] vetorFuncionario2 = Console.ReadLine().Split("  ");
            funcionario2.nome = vetorFuncionario2[0];
            funcionario2.salario = Convert.ToDouble(vetorFuncionario2[1], CultureInfo.InvariantCulture) ;

            listaFuncionarios.Add(funcionario1);
            listaFuncionarios.Add(funcionario2);

            Console.WriteLine("\nDados do primeiro funcionário:\n");
            Console.WriteLine($"Nome: {listaFuncionarios[0].nome}\nSalário: {listaFuncionarios[0].salario.ToString("F2", CultureInfo.InvariantCulture)}");

            Console.WriteLine("\nDados do segundo funcionário:\n");
            Console.WriteLine($"Nome: {listaFuncionarios[1].nome}\nSalário: {listaFuncionarios[1].salario.ToString("F2", CultureInfo.InvariantCulture)}");

            double mediaSalario = (listaFuncionarios[0].salario + listaFuncionarios[1].salario) / 2.0;

            Console.WriteLine($"\nSalário médio = {mediaSalario.ToString("F2", CultureInfo.InvariantCulture)}\n");
        }
    }



    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double AreaTriangulo()
        {
            double p = (A + B + C) / 2.0;

            double calculoArea = Math.Sqrt(p * (p - A) * (p - B) * (p - C));

            return calculoArea;  // ou return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }

    internal class Pessoa
    {
        public string nome;
        public int idade;
    }

    internal class Funcionarios
    {
        public string nome;
        public double salario;
    }
}
