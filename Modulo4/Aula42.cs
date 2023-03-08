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
            //Futuramente terminar de transformar em uma lista
            Console.WriteLine("\nAula 42 - Problema\n");

            List<Produto> listaProdutos = new List<Produto>();
            Produto produto = new Produto();

            Console.WriteLine("\nEntre com os dados do produto:");

            Console.Write("Nome: ");
            produto.Nome = Console.ReadLine();

            Console.Write("Preço: ");
            produto.Preco = Convert.ToDouble(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.Write("Quantidade no estoque: ");
            produto.Quantidade = Convert.ToInt32(Console.ReadLine(), CultureInfo.InvariantCulture);

            listaProdutos.Add(produto);


            Console.WriteLine("\nTodos os Produtos:\n");

            foreach (Produto item in listaProdutos)
            {
                Console.WriteLine($"\nDados do produto: {item}");
            }

            bool loop = true;

            while (loop)
            {

                Console.WriteLine("\nMenu:");
                Console.WriteLine("\n1 - Adicionar Produtos" + "\n2 - Remover" + "\n3 - Sair");
                int opcao = Convert.ToInt32(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        {
                            Console.WriteLine("\nQual a quantidade a ser adicionada?");
                            int quantidade = Convert.ToInt32(Console.ReadLine());

                            produto.AdicionarProdutos(quantidade);

                            foreach (Produto item in listaProdutos)
                            {
                                Console.WriteLine($"\nDados atualizados: {item}");
                            }

                            break;
                        }
                    case 2:
                        {
                            Console.WriteLine("\nQual a quantidade a ser removida?");
                            int quantidade = Convert.ToInt32(Console.ReadLine());

                            produto.RemoverProdutos(quantidade);

                            foreach (Produto item in listaProdutos)
                            {
                                Console.WriteLine($"\nDados atualizados: {item}");
                            }

                            break;
                        }
                    case 3:
                        {
                            loop = false;

                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Digite um valor válido.");

                            break;
                        }
                }
            }
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

        public void AdicionarProdutos(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
