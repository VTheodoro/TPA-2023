using System;

namespace aula_25_par15
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalNumeros = 15;
            int numerosPares = 0;

            Console.WriteLine("Digite 15 números:");

            for (int i = 0; i < totalNumeros; i++)
            {
                Console.Write("Número " + (i + 1) + ": ");
                int numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0)
                {
                    Console.WriteLine(numero + " é um número par.");
                    numerosPares++;
                }
            }

            Console.WriteLine("Quantidade total de números pares: " + numerosPares);

        }

    }
}
