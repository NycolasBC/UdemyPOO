using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course.Modulo3
{
    internal class Aula33
    {
        public void ExercicioWhile01()
        {
            Console.WriteLine("\nEstrutura de repetição while 01\n");

            Console.Write("\nDigite a senha: ");
            int password = Convert.ToInt32(Console.ReadLine());

            while (password != 2002)
            {
                Console.WriteLine("\nSenha Inválida\n");
                Console.Write("Digite novamente a senha: ");

                password = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("\nAcesso Permitido");
        }

        public void ExercicioWhile02()
        {
            Console.WriteLine("\nEstrutura de repetição while 02\n");
        }

        public void ExercicioWhile03()
        {
            Console.WriteLine("\nEstrutura de repetição while 03\n");
        }
    }
}
