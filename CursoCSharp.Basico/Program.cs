using System;

namespace CursoCSharp.Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            string nomeUsuario = "";
            int operacaoMatematica = 0;

            float numero1 = 0;
            float numero2 = 0;
            float resultado = 0;

            while (true)
            {
                Console.Write("Por favor, insira seu nome: ");
                nomeUsuario = Console.ReadLine();

                Console.WriteLine($"Olá {nomeUsuario}, escolha uma das operações:");

                Console.WriteLine("1 - Adição");
                Console.WriteLine("2 - Subtração");
                Console.WriteLine("3 - Divisão");
                Console.WriteLine("4 - Multiplicação");
                Console.WriteLine("5 - Módulo");

                Console.Write("Insira a opção desejada: ");

                try
                {
                    operacaoMatematica = int.Parse(Console.ReadLine());
                }
                catch (Exception ex)
                {
                    //Console.WriteLine(ex.Message);
                    operacaoMatematica = 0;
                }

                Console.Write("Operação selecionada: ");

                switch (operacaoMatematica)
                {
                    case 1: // Adição
                        Console.WriteLine("Adição!");
                        break;
                    case 2: // Subtração
                        Console.WriteLine("Subtração");
                        break;
                    case 3: // Divisão
                        Console.WriteLine("Divisão");
                        break;
                    case 4: // Multiplicação
                        Console.WriteLine("Multiplicação");
                        break;
                    case 5: // Módulo
                        Console.WriteLine("Módulo!");
                        break;
                    default:
                        operacaoMatematica = 0;
                        Console.WriteLine("Operação inválida :(");
                        break;
                }

                if (operacaoMatematica != 0)
                //if (operacaoMatematica > 0)
                {
                    bool converteuCorretamenta = false;

                    while (!converteuCorretamenta)
                    {
                        Console.Write("Insira o 1º número: ");
                        converteuCorretamenta = float.TryParse(Console.ReadLine(), out numero1);

                        if (!converteuCorretamenta)
                            Console.WriteLine("Número inválido, tente novamente!");
                    }

                    do
                    {
                        Console.Write("Insira o 2º número: ");
                        converteuCorretamenta = float.TryParse(Console.ReadLine(), out numero2);

                        if (!converteuCorretamenta)
                            Console.WriteLine("Número inválido, tente novamente!");
                    } while (!converteuCorretamenta);

                    if (operacaoMatematica == 1) // Adição
                        resultado = numero1 + numero2;
                    else if (operacaoMatematica == 2) // Subtração
                        resultado = numero1 - numero2;
                    else if (operacaoMatematica == 3) // Divisão
                        resultado = numero1 / numero2;
                    else if (operacaoMatematica == 4) // Multiplicação
                        resultado = numero1 * numero2;
                    else if (operacaoMatematica == 5) // Módulo
                        resultado = numero1 % numero2;

                    Console.WriteLine($"{nomeUsuario} o resultado da operação matemática é {resultado}");
                }

                Console.WriteLine();
            }

            //Console.ReadKey();
        }
    }
}
