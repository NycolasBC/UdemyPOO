using System;
using Course.Modulo3;
using Course.Modulo4;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;

            while (loop)
            {
                Console.WriteLine("Escolha o módulo:");
                Console.WriteLine("" +
                    "\n1 - Módulo03" +
                    "\n2 - Módulo04"
                );
                int module = Convert.ToInt32(Console.ReadLine());

                switch (module)
                {
                    case 1:
                        {
                            Console.WriteLine("\nQual aula deseja escolher?");
                            Console.WriteLine(
                                "\n1 - Aula 18" +
                                "\n2 - Aula 22" +
                                "\n3 - Aula 27" +
                                "\n4 - Aula 33\n"
                            );

                            int typedNumber = Convert.ToInt32(Console.ReadLine());

                            switch (typedNumber)
                            {
                                case 1:
                                    {
                                        Aula18 _aula18 = new Aula18();

                                        _aula18.TiposDeSaida();
                                        _aula18.Exercicio();

                                        break;
                                    }
                                case 2:
                                    {
                                        Aula22 _aula22 = new Aula22();

                                        _aula22.TiposDeEntradaPt1();
                                        _aula22.TiposDeEntradaPt2();
                                        _aula22.Exercicio();

                                        break;
                                    }
                                case 3:
                                    {
                                        Aula27 _aula27 = new Aula27();

                                        _aula27.ExercicioCondicional01();
                                        _aula27.ExercicioCondicional02();
                                        _aula27.ExercicioCondicional03();
                                        _aula27.ExercicioCondicional04();
                                        _aula27.ExercicioCondicional05();
                                        _aula27.ExercicioCondicional06();
                                        _aula27.ExercicioCondicional07();

                                        break;
                                    }
                                case 4:
                                    {
                                        Aula33 _aula33 = new Aula33();

                                        _aula33.ExercicioWhile01();
                                        //_aula33.TiposDeEntradaPt2();
                                        //_aula33.Exercicio();

                                        break;
                                    }
                            }

                            break;
                        }

                    case 2:
                        {
                            Console.WriteLine("\nQual aula deseja escolher?");
                            Console.WriteLine(
                                "\n1 - Aula 38 e 39" +
                                "\n2 - Aula 42" +
                                "\n3 - Aula 45" +
                                "\n4 = Aula 46" +
                                "\n5 - Exercício Final"
                            );

                            int typedNumber = Convert.ToInt32(Console.ReadLine());

                            switch (typedNumber)
                            {
                                case 1:
                                    {
                                        Aula38_39 _aula38_39 = new Aula38_39();

                                        _aula38_39.ProblemWithoutPOO();
                                        _aula38_39.ProblemWithPOO();
                                        _aula38_39.ExercicoClasse01();
                                        _aula38_39.ExercicoClasse02();

                                        break;
                                    }

                                case 2:
                                    {
                                        Aula42 _aula42 = new Aula42();

                                        _aula42.Problema01();

                                        break;
                                    }

                                case 3:
                                    {
                                        Aula45 _aula45 = new Aula45();

                                        _aula45.ExercicioClasse01();
                                        _aula45.ExercicioClasse02();
                                        _aula45.ExercicioClasse03();

                                        break;
                                    }

                                case 4:
                                    {
                                        Aula46 _aula46 = new Aula46();

                                        _aula46.CalculadoraComInstância();
                                        _aula46.CalculadoraStatic();

                                        break;
                                    }

                                case 5:
                                    {
                                        ExercicioFinal exercicioClasse = new ExercicioFinal();

                                        exercicioClasse.Exercicio01();

                                        break;
                                    }
                            }

                            break;
                        }
                }

            start:

                Console.WriteLine("\n\nDeseja continuar? s/n");
                char typedChar = Convert.ToChar(Console.ReadLine().ToLower());

                if (typedChar == 'n')
                {
                    loop = false;

                    Console.WriteLine("Fim do programa!");

                }
                else if (typedChar != 'n' && typedChar != 's')
                {
                    Console.WriteLine("Digite um valor válido");

                    goto start;
                }
            }
        }
    }
}