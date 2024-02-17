using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[4, 2];
        int maiores = 0;

        for (int i = 0; i < 4; i++)
        {
            for(int y = 0; y < 2; y++)
            {
                Console.WriteLine("Digite um valor:");
                matriz[i, y] = int.Parse(Console.ReadLine());

                if (matriz[i, y] > 10)
                {
                    maiores++;
                }
            }   
        }

        for (int i = 0; i < 4; i++)
        {
            for (int y = 0; y < 2; y++)
            {
                Console.WriteLine(matriz[i, y]+"\t");
            }
        }

        Console.WriteLine("Dos Valores Digitados, " + maiores + " São MAIORES que 10.");
    }
}
