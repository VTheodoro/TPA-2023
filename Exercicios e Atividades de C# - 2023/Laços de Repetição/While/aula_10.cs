using System;

namespace aula_09_numeroN
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont = 10;
            double cont2;
            double num;
            double div;

            Console.WriteLine("Digite um numero para a contagem e divisão por 3: ");
            num = int.Parse(Console.ReadLine());

            if (num > 10)
            {
                while (cont <= num)
                {
cont2 = cont;
                    div = cont2 / 3;
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write(cont);

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" Dividido por ");

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("3");

                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write(" é ");

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(div);


                    Console.ResetColor();

                    Console.WriteLine("----------------------------------------------------------");
                    cont++;

                }
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine(" ");

                Console.WriteLine("Fim da Contagem...");

            }

            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Não é possivel realizar a contagem com um numero menor que 10! \n Tente novamente.");
                Console.ResetColor();

            }

        }
    }
}
