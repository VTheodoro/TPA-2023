using System;

namespace mult4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Os múltiplos de 4 são:\n");

            for (int i = 0; i < 10; i++)
            {
                if (vetor[i] % 4 == 0)
                {
                    Console.WriteLine(vetor[i] + " é um múltiplo de 4.");
                }
            }

        }
    }
}
