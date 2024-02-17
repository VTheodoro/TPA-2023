using System;

namespace aula_16_subtracao
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BEM-VINDO(A) AO 'SUBTRADOR'! \n-POR VICTOR THEODORO.");
            Console.WriteLine("\n------------------------------------------\n ");
            Console.ResetColor();
            Console.WriteLine("Digite um número para iniciar o código: \n");
            cont = int.Parse(Console.ReadLine());

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\n------------------------------------------\n ");
            Console.ResetColor();


            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("PROCESSANDO... \nPor Favor, Aguarde.");
if (cont > 0)
            {

                while (cont > 0)
                {
                   
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\n");
                    Console.WriteLine(cont);
                    Console.ResetColor();
                    cont--;
                }

                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("CÓDIGO ENCERRADO.");

            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------------------------------ \n ");
                Console.WriteLine("ERRO NO CÓDIGO!\n" + cont + "NÃO É VALÍDO\nDIGITE UM NUMERO VALÍDO.");
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("CÓDIGO ENCERRADO.");

            }

        }
    }
}
