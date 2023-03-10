using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo4
{
    internal class Aula46
    {
        public void CalculadoraComInstância()
        {
            Calculadora calculadora = new Calculadora();

            Console.WriteLine("\nAula 46 - Calculadora com instância\n");


            Console.WriteLine("Entre o valor do raio: ");
            double raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circuderencia = calculadora.Circunferencia(raio);
            double volume = calculadora.Volume(raio);

            Console.WriteLine($"Circunferência: {circuderencia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {calculadora.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }

        public void CalculadoraStatic()
        {
            Console.WriteLine("\nAula 46 - Calculadora utilizando static\n");


            Console.WriteLine("Entre o valor do raio: ");
            double raio = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            double circuderencia = Calculadora2.Circunferencia(raio);
            double volume = Calculadora2.Volume(raio);

            Console.WriteLine($"Circunferência: {circuderencia.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Volume: {volume.ToString("F2", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"Valor de PI: {Calculadora2.Pi.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }


    class Calculadora
    {
        public double Pi = 3.14;

        public double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public double Volume(double r)
        {
            return ((4.0 / 3.0) * Pi) * Math.Pow(r, 3);
        }
    }


    class Calculadora2
    {
        public static double Pi = 3.14;

        public static double Circunferencia(double r)
        {
            return 2.0 * Pi * r;
        }

        public static double Volume(double r)
        {
            return ((4.0 / 3.0) * Pi) * Math.Pow(r, 3);
        }
    }
}
