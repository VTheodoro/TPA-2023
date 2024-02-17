using System;

namespace aula_28_10posineg
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumeros = 10;
            int numerosPositivos = 0;
            int numerosNegativos = 0;

            Console.WriteLine("Digite 10 números:");

            for (int i = 0; i < totalNumeros; i++)
            {
                Console.Write("Número " + (i + 1) + ": ");
                int numero = int.Parse(Console.ReadLine());

                if (numero > 0)
                {
                    numerosPositivos++;
                }
                else if (numero < 0)
                {
                    numerosNegativos++;
                }
            }

            Console.WriteLine("Quantidade de números positivos: " + numerosPositivos);
            Console.WriteLine("Quantidade de números negativos: " + numerosNegativos);
       
    }
    }
}
