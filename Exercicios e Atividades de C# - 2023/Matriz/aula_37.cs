using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[3, 5];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Digite o valor para matriz[{i},{j}]: ");
                matriz[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nValores armazenados na matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine(); 
        }
    }
}
