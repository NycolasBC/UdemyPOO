using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Modulo3
{
    internal class Aula22
    {
        public void TiposDeEntradaPt1()
        {
            string frase = Console.ReadLine();
            string x = Console.ReadLine();
            string y = Console.ReadLine();
            string z = Console.ReadLine();

            string[] vetor = Console.ReadLine().Split(' ');

            string a = vetor[0];
            string b = vetor[1];
            string c = vetor[2];

            Console.WriteLine($"" +
                $"\n{frase}" +
                $"\n{x}" +
                $"\n{y}" +
                $"\n{z}" +
                $"\n{a} {b} {c}"
            );
        }

        public void TiposDeEntradaPt2()
        {
            int n1 = Convert.ToInt32(Console.ReadLine());
            char ch = Convert.ToChar(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            string[] vetor = Console.ReadLine().Split(' ');
            string nome = vetor[0];
            char sexo = Convert.ToChar(vetor[1]);
            int idade = Convert.ToInt32(vetor[2]);
            double altura = Convert.ToDouble(vetor[3], CultureInfo.InvariantCulture);

            Console.WriteLine($"" +
                $"\n{n1}" +
                $"\n{ch}" +
                $"\n{n2}" +
                $"\n{nome} {sexo} {idade} {altura}"
            );
        }

        public void Exercicio()
        {
            Console.WriteLine("\nEntre com seu nome completo:");
            string nome = Console.ReadLine();

            Console.WriteLine("\nQuantos quartos tem sua casa?");
            int qtdQuartos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nEntre com o preço do seu produto:");
            double precoProduto = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("\nEntre seu último nome, idade e altura (mesma linha):");
            string[] vetor = Console.ReadLine().Split(' ');

            string sobrenome = vetor[0];
            int idade = Convert.ToInt32(vetor[1]);
            double altura = Convert.ToDouble(vetor[2], CultureInfo.InvariantCulture);

            Console.WriteLine($"" +
                $"\n\n{nome}" +
                $"\n{qtdQuartos}" +
                $"\n{precoProduto.ToString("F2", CultureInfo.InvariantCulture)}" +
                $"\n{sobrenome} {idade} {altura.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}
