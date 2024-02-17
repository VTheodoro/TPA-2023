using System;

namespace SomaMultiplosDeTres
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vetor = new int[50];
            int somaMultiplosDeTres = 0;

            for (int i = 0; i < 50; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 50; i++)
            {
                if (vetor[i] % 3 == 0)
                {
                    somaMultiplosDeTres += vetor[i];
                }
            }

            Console.WriteLine("A soma dos números múltiplos de três é: " + somaMultiplosDeTres);
        }
    }
}
