using System;

namespace aula_10_somadeN
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            int cont = 0, soma = 0;

            int cro = 0;

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("BEM-VINDO(A) AO SOMADOR! \n-POR VICTOR THEODORO.");
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
                    soma = cont + soma;
                    cont++;
                }
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("O RESULTADO DA SOMA É IGUAL A " + soma+".");
                Console.WriteLine("CÓDIGO ENCERRADO.");
                Console.ResetColor();
            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("------------------------------------------ \n ");
                Console.WriteLine("ERRO NO CÓDIGO!\n"+num+"NÃO É VALÍDO\nDIGITE UM NUMERO VALÍDO.");
                Console.WriteLine("\n\n\n\n\n");
                Console.WriteLine("CÓDIGO ENCERRADO.");

            }

        }
    }
}
