using System;

namespace aula_10_somadeN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cont = 0, soma = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BEM-VINDO(A) AO DOBRADOR! \n-POR VICTOR THEODORO.");
            Console.WriteLine("\n------------------------------------------\n ");
            Console.ResetColor();
            Console.WriteLine("Digite um número para iniciar o código: \n");
            num = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n------------------------------------------\n ");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PROCESSANDO... \nPor Favor, Aguarde.");


            if (num > 0)
            {

                while (cont < num)
                {
                    soma = cont * 2;

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n");
                    Console.WriteLine("O RESULTADO DE "+cont+" É "+soma);
                    Console.ResetColor();

                    cont++;
                }

            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------------------------------ \n ");
                Console.WriteLine("ERRO NO CÓDIGO!\n" + num + "NÃO É VALÍDO\nDIGITE UM NUMERO VALÍDO.");
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("CÓDIGO ENCERRADO.");

            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("------------------------------------------ \n ");
            Console.WriteLine("\n\n\n\n\n");
            Console.WriteLine("CÓDIGO ENCERRADO.");
