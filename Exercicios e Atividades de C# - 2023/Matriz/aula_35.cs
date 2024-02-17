using System;

class Program
{
    static void Main()
    {
        string[,] matrizPesos = new string[12, 2];
        string nome, peso;


        for (int i = 0; i < 12; i++)
        {
            Console.Write("Digite o nome da pessoa número " + (i + 1) + ": ");
            nome = Console.ReadLine();

            Console.Write("Digite o peso de " + nome + ": ");
            peso = Console.ReadLine();

            matrizPesos[i, 0] = nome;
            matrizPesos[i, 1] = peso;

            Console.Write("\n");
        }

        Console.WriteLine("\nNome:\t\t\tPeso:");
        for (int i = 0; i < 12; i++)
        {
            Console.WriteLine(matrizPesos[i, 0] + "\t\t\t" + matrizPesos[i, 1] + " KG");
        }
    }
}
