using System;

namespace _15num
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] vetor = new int[15];
            int cont = 1;

            for (int i = 0; i < 15; i++)
            {
                Console.Write("Digite o " + (i + 1) + "º número: ");
                vetor[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < 15; i++)
            {
                if (vetor[i] % 2 == 0)
                {
                    cont++;
                }
            }
            Console.Write("A quantidade total de numeros pares é de "+cont);


        }
    }
}
