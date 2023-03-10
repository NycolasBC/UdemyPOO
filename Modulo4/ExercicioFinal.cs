using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo4
{
    internal class ExercicioFinal
    {
        public void Exercicio01()
        {
            Console.WriteLine("\nExercício Fixação - Comversor de moedas\n");


            Console.Write($"Qual é a cotação do dólar? ");
            double cotacao = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write($"Quantos dólares você vai comprar? ");
            double valorCompra = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);


            double conversao = Dolar.ConversorDeMoeda(cotacao, valorCompra);

            Console.Write($"Valor a ser pago em reais? {conversao.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }



    class Dolar
    {
        public static double Iof = 6.0;

        public static double ConversorDeMoeda(double cotacao, double valorCompra)
        {
            double total = valorCompra * cotacao;
            return total + total * Iof / 100.0;
        }
    }
}
