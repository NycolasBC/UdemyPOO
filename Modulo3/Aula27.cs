using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Modulo3
{
    internal class Aula27
    {
        public void ExercicioCondicional01()
        {
            Console.WriteLine("\nCondicional 01\n");

            Console.WriteLine("Digite um número:");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number < 0)
            {
                Console.WriteLine("\nNEGATIVO\n");
            }
            else
            {
                Console.WriteLine("\nNÂO NEGATIVO\n");
            }
        }

        public void ExercicioCondicional02()
        {
            Console.WriteLine("\nCondicional 02\n");

            Console.WriteLine("Digite um número:");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {
                Console.WriteLine("\nPAR\n");
            }
            else
            {
                Console.WriteLine("\nIMPAR\n");
            }
        }

        public void ExercicioCondicional03()
        {
            Console.WriteLine("\nCondicional 03\n");

            Console.WriteLine("Digite 2 valores:");
            string[] array = Console.ReadLine().Split(' ');

            int num1 = Convert.ToInt32(array[0]);
            int num2 = Convert.ToInt32(array[1]);

            if (num1 % num2 == 0.0 || num2 % num1 == 0.0)
            {
                Console.WriteLine("\nSão multiplos");
            }
            else
            {
                Console.WriteLine("\nNão são multiplos");
            }
        }

        public void ExercicioCondicional04()
        {
            Console.WriteLine("\nCondicional 04\n");

            Console.WriteLine("Escreva o horário de início e o de fim respectivamente:");
            string[] array = Console.ReadLine().Split(' ');
            int iniHour = Convert.ToInt32(array[0]);
            int finHour = Convert.ToInt32(array[1]);

            int duration = 0;

            if (iniHour < finHour)
            {
                duration = finHour - iniHour;
            }
            else
            {
                duration = 24 - iniHour + finHour;
            }

            Console.WriteLine($"O JOGO DUROU {duration} HORA(S)");
        }

        public void ExercicioCondicional05()
        {
            Console.WriteLine("\nCondicional 05\n");

            Console.WriteLine("Qual o código e a quantidade do item?" +
                "\n\n1 - Cachorro quente" +
                "\n2 - X-Salada" +
                "\n3 - X-Bacon" +
                "\n4 - Torrada simples" +
                "\n5 - Refrigerante\n");

            string[] product = Console.ReadLine().Split(' ');

            int code = Convert.ToInt32(product[0], CultureInfo.InvariantCulture);
            int amount = Convert.ToInt32(product[1]);
            double bill = 0.0;

            switch (code)
            {
                case 1:
                    {
                        bill = 4.0 * amount;
                        break;
                    }
                case 2:
                    {
                        bill = 4.5 * amount;
                        break;
                    }
                case 3:
                    {
                        bill = 5.0 * amount;
                        break;
                    }
                case 4:
                    {
                        bill = 3.0 * amount;
                        break;
                    }
                case 5:
                    {
                        bill = 1.5 * amount;
                        break;
                    }
            }

            Console.WriteLine($"\nTotal: R${bill.ToString("F2", CultureInfo.InvariantCulture)}\n");
        }

        public void ExercicioCondicional06()
        {
            Console.WriteLine("\nCondicional 06\n");

            double[] array = new double[5];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Digite um número:");
                double number = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                array[i] = number;
            }

            foreach (int i in array)
            {
                if (i >= 0.0 && i <= 25.0)
                {
                    Console.WriteLine("Intervalo [0, 25]");
                }
                else if (i <= 50.0)

                {
                    Console.WriteLine("Intervalo [25, 50]");
                }
                else if (i <= 75.0)
                {
                    Console.WriteLine("Intervalo [50, 75]");
                }
                else if (i <= 100.0)
                {
                    Console.WriteLine("Intervalo [75, 100]");
                }
                else
                {
                    Console.WriteLine("Fora do intevalo");
                }
            }

        }

        public void ExercicioCondicional07()
        {
            Console.WriteLine("\nCondicional 07\n");

            Console.WriteLine("Digite os valores para o eixo x e para o y respectivamente:");
            string[] array = Console.ReadLine().Split(' ');

            decimal x = Convert.ToDecimal(array[0], CultureInfo.InvariantCulture);
            decimal y = Convert.ToDecimal(array[1], CultureInfo.InvariantCulture);

            if (x == 0.0M && y == 0.0M)
            {
                Console.WriteLine("\nOrigem");
            }
            else if (x > 0.0M && y > 0.0M)
            {
                Console.WriteLine("\nQ1");
            }
            else if (x < 0.0M && y > 0.0M)
            {
                Console.WriteLine("\nQ2");
            }
            else if (x < 0.0M && y < 0.0M)
            {
                Console.WriteLine("\nQ3");
            }
            else if (x > 0.0M && y < 0.0M)
            {
                Console.WriteLine("\nQ4");
            }
            else if (x == 0.0M && (y > 0.0M || y < 0.0M))
            {
                Console.WriteLine("\nEixo Y");
            }
            else
            {
                Console.WriteLine("\nEixo X");
            }

        }

        public void ExercicioCondicional08()
        {
            Console.WriteLine("\nCondicional 08\n");
        }

    }
}
