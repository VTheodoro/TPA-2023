using System;

class Program
{
    static void Main()
    {
        int[,] matrizSalas = new int[8, 2];

        int numeroSala, numeroAlunos;

        for (int i = 0; i < 8; i++)
        {
            Console.Write("Digite o número da sala " + (i + 1) + ": ");
            numeroSala = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número de alunos na sala " + (i + 1) + ": ");
            numeroAlunos = Convert.ToInt32(Console.ReadLine());

            matrizSalas[i, 0] = numeroSala; 
            matrizSalas[i, 1] = numeroAlunos;

            Console.Write("\n");
        }

        Console.WriteLine("\nNúmero da Sala:\tNúmero de Alunos:");
        for (int i = 0; i < 8; i++)
        {
            Console.WriteLine(matrizSalas[i, 0] + "\t\t" + matrizSalas[i, 1]);
        }
    }
}
