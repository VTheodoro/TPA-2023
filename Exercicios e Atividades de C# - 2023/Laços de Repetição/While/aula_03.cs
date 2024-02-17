using System;

namespace aula_10_somadeN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, soma = 0;
            int cont = 1;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BEM-VINDO(A) AO ALGORITIMO! \n-POR VICTOR THEODORO.");
            Console.WriteLine("\n------------------------------------------\n ");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.ResetColor();

            while (cont <= 5)
            {

                Console.WriteLine("Digite o "+cont+"º número \n");
                num = int.Parse(Console.ReadLine());

                soma = num + soma;

                cont++;

                if (num < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------------------------------ \n ");
                Console.WriteLine("ERRO NO CÓDIGO!\n" + num + " NÃO É VALÍDO\nDIGITE UM NUMERO VALÍDO.");
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("CÓDIGO ENCERRADO.");

            }
        }

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------------------------ \n ");
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("O RESULTADO DA SOMA É IGUAL A " + soma + ".");
            Console.WriteLine("CÓDIGO ENCERRADO.");
            Console.ResetColor();

        }
    }
}

