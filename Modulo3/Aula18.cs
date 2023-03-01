using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Modulo3
{
    internal class Aula18
    {
        public void TiposDeSaida()
        {
            string nome = "Maria";
            int idade = 27;
            double saldo = 10.35784;

            Console.WriteLine($"\n{nome} tem {idade} anos e tem saldo igual a R${saldo:F2} reais\n\n");

            Console.WriteLine(saldo.ToString("F1"));
            Console.WriteLine(saldo.ToString("F2"));
            Console.WriteLine(saldo.ToString("F3", CultureInfo.InvariantCulture));
        }

        public void Exercicio()
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            Console.WriteLine($"\n\nProdutos:\n{produto1}, cujo preço é $ {preco1:F2}\n{produto2:F2}, cujo preço é $ {preco2}\n");
            Console.WriteLine($"Registro: {idade} anos de idade, código {codigo} e gênero: {genero}\n");
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}\nArrendondado (três casas decimais): {medida:F3}\nSeparador decimal invariant culture: {medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}
