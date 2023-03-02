using System;
using Course.Modulo3;
using Course.Modulo4;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            start:

            Console.WriteLine("Escolha o módulo:");
            Console.WriteLine("" +
                "\n3 - Módulo03" +
                "\n4 - Módulo04"
            );
            int module = Convert.ToInt32(Console.ReadLine());

            switch (module)
            {
                case 3:
                    {
                        Console.WriteLine("\nQual aula deseja escolher?");
                        Console.WriteLine(
                            "\n18 - Aula 18" +
                            "\n22 - Aula 22" +
                            "\n27 - Aula 27" +
                            "\n33 - Aula 33\n"
                        );

                        int typedNumber = Convert.ToInt32(Console.ReadLine());

                        switch (typedNumber)
                        {
                            case 18:
                                {
                                    Aula18 _aula18 = new Aula18();

                                    _aula18.TiposDeSaida();
                                    _aula18.Exercicio();

                                    break;
                                }
                            case 22:
                                {
                                    Aula22 _aula22 = new Aula22();

                                    _aula22.TiposDeEntradaPt1();
                                    _aula22.TiposDeEntradaPt2();
                                    _aula22.Exercicio();

                                    break;
                                }
                            case 27:
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
                            case 33:
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

                case 4:
                    {
                        Console.WriteLine("\nQual aula deseja escolher?");
                        Console.WriteLine(
                            "\n38 - Aula 38 e 39" +
                            "\n42- Aula 42\n"
                        );

                        int typedNumber = Convert.ToInt32(Console.ReadLine());

                        switch (typedNumber)
                        {
                            case 38:
                                {
                                    Aula38_39 _aula38_39 = new Aula38_39();

                                    _aula38_39.ProblemWithoutPOO();
                                    _aula38_39.ProblemWithPOO();
                                    _aula38_39.ExercicoClasse01();
                                    _aula38_39.ExercicoClasse02();

                                    break;
                                }

                            case 42:
                                {
                                    Aula42 _aula42 = new Aula42();

                                    _aula42.Problema01();

                                    break;
                                }
                        }

                        break;
                    }
            }
            

            Console.WriteLine("\n\nDeseja continuar? s/n");
            char typedChar = Convert.ToChar(Console.ReadLine().ToLower());

            if (typedChar == 's')
            {
                goto start;
            }
            else
            {
                Console.WriteLine("Fim do programa!");
            }
            
        }
    }
}