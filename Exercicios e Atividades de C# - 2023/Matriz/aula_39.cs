using System;

class Program
{
    static void Main()
    {
        string[,] matriz = new string[6, 2];

        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write($"Digite o nome para matriz[{i},{j}]: ");
                matriz[i, j] = Console.ReadLine();
            }
        }

        Console.WriteLine("\nValores armazenados na matriz:");
        for (int i = 0; i < 6; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine(); 
        }
    }
}
