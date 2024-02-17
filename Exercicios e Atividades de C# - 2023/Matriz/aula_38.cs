using System;

class Program
{
    static void Main()
    {
        double[,] matriz = new double[2, 5];

        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Digite o valor para matriz[{i},{j}]: ");
                matriz[i, j] = double.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nValores armazenados na matriz:");
        for (int i = 0; i < 2; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine(); 
        }
    }
}
