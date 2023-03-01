
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
            Console.WriteLine("\nProblema sem POO\n");

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
            Console.WriteLine("\nProblema com POO\n");

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

            double p = (x.A + x.B + x.C) / 2.0;
            double areaX = Math.Sqrt(p * (p - x.A) * (p - x.B) * (p - x.C));

            p = (y.A + y.B + y.C) / 2.0;
            double areaY = Math.Sqrt(p * (p - y.A) * (p - y.B) * (p - y.C));

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
    }



    internal class Triangulo
    {
        public double A;
        public double B;
        public double C;
    }
}
