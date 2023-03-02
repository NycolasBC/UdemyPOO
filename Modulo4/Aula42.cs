using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Course.Modulo4
{
    internal class Aula42
    {
        public void Problema01()
        {
            Console.WriteLine("\nAula 48 - Problema");

            Produto produtos = new Produto();

            Console.WriteLine("\nQual a quantidade de produtos que serão informados:");
            int quantidade = Convert.ToInt32(Console.ReadLine());

            List<Produto> produtosLista = produtos.AdicionarProdutos(quantidade);

        }
    }



    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        public List<Produto> AdicionarProdutos(int qtd)
        {
            List<Produto> listaProdutos = new List<Produto>();

            for (int i = 0; i <= qtd; i++)
            {
                Console.WriteLine("Entre com os dados do produto:");

                Console.Write("Preço: ");
                Nome = Console.ReadLine();

                Console.Write("Nome: ");
                Preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

                Console.Write("Quantidade no estoque: ");
                Quantidade = Convert.ToInt32(Console.ReadLine());

                listaProdutos.Add(new Produto { Nome = Nome, Preco = Preco, Quantidade = Quantidade });
            }

            return listaProdutos;
        }

        public void RemoverProdutos(int qtd)
        {

        }
    }
}
