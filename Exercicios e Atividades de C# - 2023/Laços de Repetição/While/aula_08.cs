using System;

namespace aula_03_quadrado
{
    class Program
    {
        static void Main(string[] args)
        {

            double cont = 0;
            double quadrado;
            double num;

            Console.WriteLine("Digite um numero para começar: ");
            num = double.Parse(Console.ReadLine());

            while (cont <= num)
            {
                cont++;
                quadrado = Math.Pow(cont, 2);
                Console.WriteLine(cont+" ao quadrado é " + quadrado + "²");

            }

        }
    }
}
